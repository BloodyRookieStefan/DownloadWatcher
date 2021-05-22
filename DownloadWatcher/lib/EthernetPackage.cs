using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadWatcher
{
    class EthernetPackage
    {
        public double KBit_s { get; private set; }
        public double MBit_s { get; private set; }
        public double KByte_s { get; private set; }
        public double MByte_s { get; private set; }

        public double MBit_s_average { get; private set; }
        public double MByte_s_average { get; private set; }

        public EthernetPackage(double bytes)
        {
            KBit_s = Math.Round((bytes * Math.Pow(10, -3)), 2) * 8;
            MBit_s = Math.Round((bytes * Math.Pow(10, -6)), 2) * 8;
            KByte_s = Math.Round(ConvertLib.ConvertBitToByte(KBit_s), 2);
            MByte_s = Math.Round(ConvertLib.ConvertBitToByte(MBit_s), 2);

            MBit_s_average = -1;
            MByte_s_average = -1;
        }

        public void UpdateAverage(List<EthernetPackage> packages)
        {
            foreach (var value in packages)
            {
                MBit_s_average += value.MBit_s;
            }
            MBit_s_average /= packages.Count;
            MBit_s_average = Math.Round(ConvertLib.ConvertBitToByte(MBit_s_average), 2);
            MByte_s_average = Math.Round(ConvertLib.ConvertBitToByte(MBit_s_average), 2);
        }
    }
}
