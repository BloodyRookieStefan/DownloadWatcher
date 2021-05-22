using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWatcher
{
    public partial class DownloadWatcherForm : Form
    {
        readonly NetworkWatcher Watcher;
        bool WatcherEnabled;
        DateTime UnderThresholdTime;
        // User inputs
        double DatarateThreshold;
        int DatarateTime;
        bool InputError_datarateThreshold, InputError_datarateTime;

        public DownloadWatcherForm()
        {
            InitializeComponent();

            // Build new watcher
            Watcher = new NetworkWatcher();
            // Enable timer
            timer.Enabled = true;

            WatcherEnabled = false;
            UnderThresholdTime = DateTime.MinValue;

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void DownloadWatcherForm_Load(object sender, EventArgs e)
        {
            SetDefaultText();
            SetNetworkInterfaces();
            dateTimePicker_latestShutdown.Value = DateTime.Now.AddHours(6);
            Log.CreateLogFolder();
        }

        private void SetNetworkInterfaces()
        {
            comboBox_networks.Items.Clear();

            foreach (NetworkInterface netInterface in Watcher.Interfaces)
            {
                comboBox_networks.Items.Add(netInterface.Name);
            }

            comboBox_networks.SelectedIndex = 0;
        }

        private void ComboBox_networks_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (UnicastIPAddressInformation ip in Watcher.Interfaces[comboBox_networks.SelectedIndex].GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    label_ip.Text = ip.Address.ToString();
                }
            }

            Watcher.ResetWatcher();
            UpdateByteLabel();
        }

        private void UpdateByteLabel()
        {
            // At least one packed need to be calculated
            if (Watcher.EthPackage_Send != null && Watcher.EthPackage_Send != null)
            {
                label_datarate_send.Text = Watcher.EthPackage_Send.MBit_s.ToString() + " MBit/s";
                label_datarate_recive.Text = Watcher.EthPackage_Recive.MBit_s.ToString() + " MBit/s";

                // Check if average was calculated for send
                if (Watcher.EthPackage_Send.MBit_s_average > -1)
                {
                    label_datarate_send_average_bit.Text = Watcher.EthPackage_Send.MBit_s_average.ToString() + " MBit/s";
                    label_datarate_send_average_byte.Text = Watcher.EthPackage_Send.MByte_s_average.ToString() + " MByte/s";
                }
                else
                {
                    SetDefaultText();
                }

                // Check if average was calculated for recive
                if (Watcher.EthPackage_Recive.MBit_s_average > -1)
                {
                    label_datarate_recive_average_bit.Text = Watcher.EthPackage_Recive.MBit_s_average.ToString() + " MBit/s";
                    label_datarate_recive_average_byte.Text = Watcher.EthPackage_Recive.MByte_s_average.ToString() + " MByte/s";

                    // Color label if below threshold
                    if (Watcher.EthPackage_Recive.MBit_s_average < DatarateThreshold)
                    {
                        label_datarate_recive_average_bit.ForeColor = Color.Red;
                        label_datarate_recive_average_byte.ForeColor = Color.Red;
                    }
                    else // Default color
                    {
                        label_datarate_recive_average_bit.ForeColor = Color.Black;
                        label_datarate_recive_average_byte.ForeColor = Color.Black;
                    }

                    // Check for drive
                    if (Watcher.DriveBusy)
                    {
                        label_Drive_Busy.Visible = true;
                    }
                    else
                    {
                        label_Drive_Busy.Visible = false;
                    }

                }
                else // Average was not calculated yet
                {
                    SetDefaultText();
                }
            }
            else // No package was calculated yet
            {
                SetDefaultText();
            }
        }

        private void SetDefaultText()
        {
            const string initText = "1 Minute init ...";

            label_datarate_recive_average_bit.ForeColor = Color.Black;
            label_datarate_recive_average_bit.Text = initText;
            label_datarate_recive_average_byte.Text = initText;
            label_datarate_send_average_bit.Text = initText;
            label_datarate_send_average_byte.Text = initText;
            label_Drive_Busy.Visible = false;
        }

        private void Shutdown()
        {
            // Shutdown in 120 Seconds
            Process.Start("shutdown", "/s /t 120");
            Log.Write("CMD command send to Windows. 2 Minutes to shutdown.");
            Log.Write("Exit program");
            timer.Enabled = false;
            WatcherEnabled = false;
            Environment.Exit(0);
        }

        private void CheckDownloadStatus()
        {
            if (Watcher.EthPackage_Recive.MBit_s_average <= DatarateThreshold && UnderThresholdTime == DateTime.MinValue && !Watcher.DriveBusy)
            {
                UnderThresholdTime = DateTime.Now;
                Log.Write("Datarate below threshold detected: " + Watcher.EthPackage_Recive.MBit_s_average.ToString() + " MBit/s. Threshold: " + DatarateThreshold.ToString() + " MBit/s");
            }
            else if (UnderThresholdTime != DateTime.MinValue && (Watcher.EthPackage_Recive.MBit_s_average > DatarateThreshold || Watcher.DriveBusy))
            {
                UnderThresholdTime = DateTime.MinValue;
                if (Watcher.DriveBusy)
                {
                    Log.Write("Drive is busy");
                }
                else
                {
                    Log.Write("Datarate above threshold detected: " + Watcher.EthPackage_Recive.MBit_s_average.ToString() + " MBit/s. Threshold: " + DatarateThreshold.ToString() + " MBit/s");
                }
                Log.Write("Timer was reset");
            }

            // Only perform shutdown when drive is not busy 
            if (UnderThresholdTime != DateTime.MinValue && (DateTime.Now - UnderThresholdTime).TotalMinutes >= DatarateTime)
            {
                Log.Write("Timer was reached. Performing shutdown...");
                Shutdown();
            }

            // Check if time run out
            if (dateTimePicker_latestShutdown.Checked && DateTime.Compare(DateTime.Now, dateTimePicker_latestShutdown.Value) > 0)
            {
                Log.Write("Min average was not reached in time. Performing shutdown...");
                Shutdown();
            }

        }

        private void InputCheck()
        {
            if (InputError_datarateThreshold || InputError_datarateTime)
            {
                button_enable.Enabled = false;
            }
            else
            {
                button_enable.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Watcher.Tick(comboBox_networks.SelectedIndex, timer.Interval);
            UpdateByteLabel();
            if (WatcherEnabled && Watcher.EthPackage_Recive.MBit_s_average > -1)
            {
                CheckDownloadStatus();
            }
        }

        private void TextBox_datarate_threshold_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_datarate_threshold.Text, @"^[0-9]{1,3}(\,[0-9]{1,2})?$"))
            {
                textBox_datarate_threshold.BackColor = Color.OrangeRed;
                InputError_datarateThreshold = true;
                label_datarate_threshold_bytes.Text = String.Empty;
            }
            else
            {
                textBox_datarate_threshold.BackColor = SystemColors.Window;
                InputError_datarateThreshold = false;
                label_datarate_threshold_bytes.Text = Math.Round(ConvertLib.ConvertBitToByte(Convert.ToDouble(textBox_datarate_threshold.Text)), 2).ToString();
            }
            InputCheck();
        }

        private void TextBox_datarate_time_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_datarate_time.Text, "^[0-9]{1,3}$"))
            {
                textBox_datarate_time.BackColor = Color.OrangeRed;
                InputError_datarateTime = true;
            }
            else
            {
                textBox_datarate_time.BackColor = SystemColors.Window;
                InputError_datarateTime = false;
            }
            InputCheck();
        }

        private void Button_enable_Click(object sender, EventArgs e)
        {
            // Check if date is in past
            if (dateTimePicker_latestShutdown.Value < DateTime.Now)
            {
                MessageBox.Show("Date for latest shutdown is in the past!\nPlease select another date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            WatcherEnabled = !WatcherEnabled;

            if (WatcherEnabled)
            {
                button_enable.Text = "Disable";
                Log.Write("Status Enable");

                groupBox_settings.Enabled = false;
                // TextBoxstuff to data
                DatarateThreshold = Convert.ToDouble(textBox_datarate_threshold.Text);
                DatarateTime = Convert.ToInt32(textBox_datarate_time.Text);

                Log.Write("Settings used:");
                Log.Write("------------------------------------------------------------------------------------------------------------------");
                Log.Write("Network: " + comboBox_networks.Text);
                Log.Write("Threshold: " + textBox_datarate_threshold.Text + " MBit/s");
                Log.Write("Time threshold: " + textBox_datarate_time.Text + " Minutes");
                Log.Write("Latest shutdown used: " + dateTimePicker_latestShutdown.Checked.ToString());
                Log.Write("Latest shutdown value: " + dateTimePicker_latestShutdown.Value.ToString());
                Log.Write("------------------------------------------------------------------------------------------------------------------");
            }
            else
            {
                button_enable.Text = "Enable";
                Log.Write("Status Disable");

                groupBox_settings.Enabled = true;
            }
        }

        private void Button_logs_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Path.GetDirectoryName(Log.FolderPath)))
            {
                MessageBox.Show("Something went wrong.\nExpected log folder does not exist!", "Folder missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LogForm log = new LogForm(Log.FolderPath);
            log.ShowDialog(this);
            log.Dispose();
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
            about.Dispose();
        }
    }
}
