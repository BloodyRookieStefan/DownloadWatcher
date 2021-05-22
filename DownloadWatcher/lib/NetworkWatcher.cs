using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DownloadWatcher
{
    class NetworkWatcher
    {
        public NetworkInterface[] Interfaces { get; private set; }
        public EthernetPackage EthPackage_Send { get; private set; }
        public EthernetPackage EthPackage_Recive { get; private set; }
        public bool DriveBusy { get; private set; }

        private long LastTickSend;
        private long LastTickRecived;
        private long[] StartBytesSend;
        private long[] StartBytesRecived;
        private List<EthernetPackage> MBit_s_send_average_storage;
        private List<EthernetPackage> MBit_s_recive_average_storage;
        
        private readonly UInt64[] AllDriveStorage;

        public NetworkWatcher()
        {
            ResetWatcher();
            AllDriveStorage = new UInt64[DriveInfo.GetDrives().Length];
            for(int i=0; i< AllDriveStorage.Length; i++)
            {
                AllDriveStorage[i] = 0;
            }
        }

        public void ResetWatcher()
        {
            LastTickSend = 0;
            LastTickRecived = 0;

            MBit_s_send_average_storage = new List<EthernetPackage>();
            MBit_s_recive_average_storage = new List<EthernetPackage>();

            GetNetworkInterfaces();
        }

        public void Tick(int index, int tickRate)
        {
            ClacDatarate(index, tickRate);
            CheckDriveActivity();
        }

        private void CheckDriveActivity()
        {
            const int thresholdDriveMB = 5;
            DriveBusy = false;

            //create a management scope object
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2");

            //create object query
            //ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfDisk_PhysicalDisk Where Name=\"0 C:\"");
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfDisk_PhysicalDisk");

            //create object searcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            //get a collection of WMI objects
            ManagementObjectCollection queryCollection = searcher.Get();

            //enumerate the collection.
            int i = 0;
            foreach (ManagementObject m in queryCollection)
            {
                // access properties of the WMI object
                string name = m["Name"].ToString();

                // Skip total
                if(name.Contains(' '))
                {
                    name = name.Split(' ')[1];
                }
                else
                {
                    continue;
                }

                
                UInt64 avgDiskWrite = Convert.ToUInt64(m["DiskWriteBytesPerSec"]);
                Int64 res = Math.Abs((Int64)(AllDriveStorage[i] - avgDiskWrite));

#if DEBUG
                Console.WriteLine("DiskWriteBytesPerSec {0}: {1}KBytes", name, res/1024);
#endif

                AllDriveStorage[i] = avgDiskWrite;

                // If res[MByte] > Threshold
                if(res/1000/1000 > thresholdDriveMB)
                {
                    DriveBusy = true;
                }

                i++;
            }

            searcher.Dispose();
        }

        private void ClacDatarate(int index, int tickRate)
        {
            // Calc needed storage based on timer tick rate (1 Minute init)
            int itemsInStorage = 60000 / tickRate;

            // Get current bytes
            long currentTickSend = Interfaces[index].GetIPv4Statistics().BytesSent - StartBytesSend[index];
            long currentTuckRecived = Interfaces[index].GetIPv4Statistics().BytesReceived - StartBytesRecived[index];

            // Get diff between current bytes and last bytes
            double bytesSend = Math.Abs(currentTickSend - LastTickSend);
            double bytesRecived = Math.Abs(currentTuckRecived - LastTickRecived);

            // Create Ethernet Package
            EthPackage_Send = new EthernetPackage(bytesSend);
            EthPackage_Recive = new EthernetPackage(bytesRecived);

            // Have at least 60 values to calculate average MBit/s
            if(MBit_s_send_average_storage.Count >= itemsInStorage && MBit_s_recive_average_storage.Count >= itemsInStorage)
            {
                // Remove first entry (Oldest)
                MBit_s_send_average_storage.RemoveAt(0);
                MBit_s_recive_average_storage.RemoveAt(0);

                // Add new entry
                MBit_s_send_average_storage.Add(EthPackage_Send);
                MBit_s_recive_average_storage.Add(EthPackage_Recive);

                // Calc mean
                EthPackage_Send.UpdateAverage(MBit_s_send_average_storage);
                EthPackage_Recive.UpdateAverage(MBit_s_recive_average_storage);
            }
            else
            {
                MBit_s_send_average_storage.Add(EthPackage_Send);
                MBit_s_recive_average_storage.Add(EthPackage_Recive);
            }

            LastTickSend = currentTickSend;
            LastTickRecived = currentTuckRecived;
        }

        private void GetNetworkInterfaces()
        {
            Interfaces = null;

            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            Interfaces = NetworkInterface.GetAllNetworkInterfaces();

            StartBytesSend = new long[Interfaces.Length];
            StartBytesRecived = new long[Interfaces.Length];

            for (int i = 0; i < Interfaces.Length - 1; i++)
            {
                StartBytesSend[i] = Interfaces[i].GetIPv4Statistics().BytesSent;
                StartBytesRecived[i] = Interfaces[i].GetIPv4Statistics().BytesReceived;
            }
        }
    }
}
