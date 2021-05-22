namespace DownloadWatcher
{
    partial class DownloadWatcherForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadWatcherForm));
            this.button_enable = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.comboBox_networks = new System.Windows.Forms.ComboBox();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_datarate_send = new System.Windows.Forms.Label();
            this.label_datarate_recive = new System.Windows.Forms.Label();
            this.dateTimePicker_latestShutdown = new System.Windows.Forms.DateTimePicker();
            this.textBox_datarate_threshold = new System.Windows.Forms.TextBox();
            this.textBox_datarate_time = new System.Windows.Forms.TextBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_info = new System.Windows.Forms.TableLayoutPanel();
            this.label_datarate_recive_average_bit = new System.Windows.Forms.Label();
            this.label_fix_ip = new System.Windows.Forms.Label();
            this.label_fix_datarate_send = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_datarate_send_average_bit = new System.Windows.Forms.Label();
            this.label_fix_average = new System.Windows.Forms.Label();
            this.label_datarate_send_average_byte = new System.Windows.Forms.Label();
            this.label_datarate_recive_average_byte = new System.Windows.Forms.Label();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_settings = new System.Windows.Forms.TableLayoutPanel();
            this.label_fix__latestShutdown = new System.Windows.Forms.Label();
            this.label_fix_datarate_time = new System.Windows.Forms.Label();
            this.label_fix_datarate_threshold = new System.Windows.Forms.Label();
            this.label_fix_networks = new System.Windows.Forms.Label();
            this.label_fix_MBits_threshold = new System.Windows.Forms.Label();
            this.label_fix_time_threshold = new System.Windows.Forms.Label();
            this.label_fix_MBytes_threshold = new System.Windows.Forms.Label();
            this.label_datarate_threshold_bytes = new System.Windows.Forms.Label();
            this.button_about = new System.Windows.Forms.Button();
            this.button_logs = new System.Windows.Forms.Button();
            this.label_Drive_Busy = new System.Windows.Forms.Label();
            this.groupBox_info.SuspendLayout();
            this.tableLayoutPanel_info.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.tableLayoutPanel_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_enable
            // 
            this.button_enable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_enable.Location = new System.Drawing.Point(523, 173);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(75, 23);
            this.button_enable.TabIndex = 0;
            this.button_enable.Text = "Enable";
            this.button_enable.UseVisualStyleBackColor = true;
            this.button_enable.Click += new System.EventHandler(this.Button_enable_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // comboBox_networks
            // 
            this.tableLayoutPanel_settings.SetColumnSpan(this.comboBox_networks, 4);
            this.comboBox_networks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_networks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_networks.FormattingEnabled = true;
            this.comboBox_networks.Location = new System.Drawing.Point(207, 3);
            this.comboBox_networks.Name = "comboBox_networks";
            this.comboBox_networks.Size = new System.Drawing.Size(373, 21);
            this.comboBox_networks.TabIndex = 1;
            this.comboBox_networks.SelectedIndexChanged += new System.EventHandler(this.ComboBox_networks_SelectedIndexChanged);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ip.Location = new System.Drawing.Point(127, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(118, 38);
            this.label_ip.TabIndex = 2;
            this.label_ip.Text = "ip";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_datarate_send
            // 
            this.label_datarate_send.AutoSize = true;
            this.label_datarate_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_send.Location = new System.Drawing.Point(127, 38);
            this.label_datarate_send.Name = "label_datarate_send";
            this.label_datarate_send.Size = new System.Drawing.Size(118, 38);
            this.label_datarate_send.TabIndex = 3;
            this.label_datarate_send.Text = "Send";
            this.label_datarate_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_datarate_recive
            // 
            this.label_datarate_recive.AutoSize = true;
            this.label_datarate_recive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_recive.Location = new System.Drawing.Point(127, 76);
            this.label_datarate_recive.Name = "label_datarate_recive";
            this.label_datarate_recive.Size = new System.Drawing.Size(118, 39);
            this.label_datarate_recive.TabIndex = 4;
            this.label_datarate_recive.Text = "Recive";
            this.label_datarate_recive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_latestShutdown
            // 
            this.tableLayoutPanel_settings.SetColumnSpan(this.dateTimePicker_latestShutdown, 4);
            this.dateTimePicker_latestShutdown.CustomFormat = "dd/MM/yyyy  HH:mm:ss tt";
            this.dateTimePicker_latestShutdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_latestShutdown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_latestShutdown.Location = new System.Drawing.Point(207, 105);
            this.dateTimePicker_latestShutdown.Name = "dateTimePicker_latestShutdown";
            this.dateTimePicker_latestShutdown.ShowCheckBox = true;
            this.dateTimePicker_latestShutdown.Size = new System.Drawing.Size(373, 20);
            this.dateTimePicker_latestShutdown.TabIndex = 5;
            // 
            // textBox_datarate_threshold
            // 
            this.textBox_datarate_threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_datarate_threshold.Location = new System.Drawing.Point(207, 37);
            this.textBox_datarate_threshold.Multiline = true;
            this.textBox_datarate_threshold.Name = "textBox_datarate_threshold";
            this.textBox_datarate_threshold.Size = new System.Drawing.Size(198, 28);
            this.textBox_datarate_threshold.TabIndex = 1;
            this.textBox_datarate_threshold.Text = "1";
            this.textBox_datarate_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_datarate_threshold.TextChanged += new System.EventHandler(this.TextBox_datarate_threshold_TextChanged);
            // 
            // textBox_datarate_time
            // 
            this.textBox_datarate_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_datarate_time.Location = new System.Drawing.Point(207, 71);
            this.textBox_datarate_time.Multiline = true;
            this.textBox_datarate_time.Name = "textBox_datarate_time";
            this.textBox_datarate_time.Size = new System.Drawing.Size(198, 28);
            this.textBox_datarate_time.TabIndex = 7;
            this.textBox_datarate_time.Text = "10";
            this.textBox_datarate_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_datarate_time.TextChanged += new System.EventHandler(this.TextBox_datarate_time_TextChanged);
            // 
            // groupBox_info
            // 
            this.groupBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_info.Controls.Add(this.tableLayoutPanel_info);
            this.groupBox_info.Location = new System.Drawing.Point(15, 173);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(502, 134);
            this.groupBox_info.TabIndex = 8;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // tableLayoutPanel_info
            // 
            this.tableLayoutPanel_info.ColumnCount = 4;
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_recive_average_bit, 2, 2);
            this.tableLayoutPanel_info.Controls.Add(this.label_ip, 1, 0);
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_send, 1, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_recive, 1, 2);
            this.tableLayoutPanel_info.Controls.Add(this.label_fix_ip, 0, 0);
            this.tableLayoutPanel_info.Controls.Add(this.label_fix_datarate_send, 0, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_send_average_bit, 2, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label_fix_average, 2, 0);
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_send_average_byte, 3, 1);
            this.tableLayoutPanel_info.Controls.Add(this.label_datarate_recive_average_byte, 3, 2);
            this.tableLayoutPanel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_info.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_info.Name = "tableLayoutPanel_info";
            this.tableLayoutPanel_info.RowCount = 3;
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_info.Size = new System.Drawing.Size(496, 115);
            this.tableLayoutPanel_info.TabIndex = 0;
            // 
            // label_datarate_recive_average_bit
            // 
            this.label_datarate_recive_average_bit.AutoSize = true;
            this.label_datarate_recive_average_bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_recive_average_bit.Location = new System.Drawing.Point(251, 76);
            this.label_datarate_recive_average_bit.Name = "label_datarate_recive_average_bit";
            this.label_datarate_recive_average_bit.Size = new System.Drawing.Size(118, 39);
            this.label_datarate_recive_average_bit.TabIndex = 9;
            this.label_datarate_recive_average_bit.Text = "Average Recive Bit";
            this.label_datarate_recive_average_bit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fix_ip
            // 
            this.label_fix_ip.AutoSize = true;
            this.label_fix_ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_ip.Location = new System.Drawing.Point(3, 0);
            this.label_fix_ip.Name = "label_fix_ip";
            this.label_fix_ip.Size = new System.Drawing.Size(118, 38);
            this.label_fix_ip.TabIndex = 5;
            this.label_fix_ip.Text = "IP Adress";
            this.label_fix_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_datarate_send
            // 
            this.label_fix_datarate_send.AutoSize = true;
            this.label_fix_datarate_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_datarate_send.Location = new System.Drawing.Point(3, 38);
            this.label_fix_datarate_send.Name = "label_fix_datarate_send";
            this.label_fix_datarate_send.Size = new System.Drawing.Size(118, 38);
            this.label_fix_datarate_send.TabIndex = 6;
            this.label_fix_datarate_send.Text = "Send";
            this.label_fix_datarate_send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recive";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_datarate_send_average_bit
            // 
            this.label_datarate_send_average_bit.AutoSize = true;
            this.label_datarate_send_average_bit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_send_average_bit.Location = new System.Drawing.Point(251, 38);
            this.label_datarate_send_average_bit.Name = "label_datarate_send_average_bit";
            this.label_datarate_send_average_bit.Size = new System.Drawing.Size(118, 38);
            this.label_datarate_send_average_bit.TabIndex = 8;
            this.label_datarate_send_average_bit.Text = "Average Send Bit";
            this.label_datarate_send_average_bit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fix_average
            // 
            this.label_fix_average.AutoSize = true;
            this.tableLayoutPanel_info.SetColumnSpan(this.label_fix_average, 2);
            this.label_fix_average.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_average.Location = new System.Drawing.Point(251, 0);
            this.label_fix_average.Name = "label_fix_average";
            this.label_fix_average.Size = new System.Drawing.Size(242, 38);
            this.label_fix_average.TabIndex = 10;
            this.label_fix_average.Text = "Average network load";
            this.label_fix_average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_datarate_send_average_byte
            // 
            this.label_datarate_send_average_byte.AutoSize = true;
            this.label_datarate_send_average_byte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_send_average_byte.Location = new System.Drawing.Point(375, 38);
            this.label_datarate_send_average_byte.Name = "label_datarate_send_average_byte";
            this.label_datarate_send_average_byte.Size = new System.Drawing.Size(118, 38);
            this.label_datarate_send_average_byte.TabIndex = 11;
            this.label_datarate_send_average_byte.Text = "Average Send Byte";
            this.label_datarate_send_average_byte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_datarate_recive_average_byte
            // 
            this.label_datarate_recive_average_byte.AutoSize = true;
            this.label_datarate_recive_average_byte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_recive_average_byte.Location = new System.Drawing.Point(375, 76);
            this.label_datarate_recive_average_byte.Name = "label_datarate_recive_average_byte";
            this.label_datarate_recive_average_byte.Size = new System.Drawing.Size(118, 39);
            this.label_datarate_recive_average_byte.TabIndex = 12;
            this.label_datarate_recive_average_byte.Text = "Average Recive Byte";
            this.label_datarate_recive_average_byte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_settings.Controls.Add(this.tableLayoutPanel_settings);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(589, 155);
            this.groupBox_settings.TabIndex = 9;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // tableLayoutPanel_settings
            // 
            this.tableLayoutPanel_settings.ColumnCount = 5;
            this.tableLayoutPanel_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix__latestShutdown, 0, 3);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_datarate_time, 0, 2);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_datarate_threshold, 0, 1);
            this.tableLayoutPanel_settings.Controls.Add(this.textBox_datarate_threshold, 1, 1);
            this.tableLayoutPanel_settings.Controls.Add(this.textBox_datarate_time, 1, 2);
            this.tableLayoutPanel_settings.Controls.Add(this.comboBox_networks, 1, 0);
            this.tableLayoutPanel_settings.Controls.Add(this.dateTimePicker_latestShutdown, 1, 3);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_networks, 0, 0);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_MBits_threshold, 2, 1);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_time_threshold, 2, 2);
            this.tableLayoutPanel_settings.Controls.Add(this.label_fix_MBytes_threshold, 4, 1);
            this.tableLayoutPanel_settings.Controls.Add(this.label_datarate_threshold_bytes, 3, 1);
            this.tableLayoutPanel_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_settings.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_settings.Name = "tableLayoutPanel_settings";
            this.tableLayoutPanel_settings.RowCount = 4;
            this.tableLayoutPanel_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_settings.Size = new System.Drawing.Size(583, 136);
            this.tableLayoutPanel_settings.TabIndex = 0;
            // 
            // label_fix__latestShutdown
            // 
            this.label_fix__latestShutdown.AutoSize = true;
            this.label_fix__latestShutdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix__latestShutdown.Location = new System.Drawing.Point(3, 102);
            this.label_fix__latestShutdown.Name = "label_fix__latestShutdown";
            this.label_fix__latestShutdown.Size = new System.Drawing.Size(198, 34);
            this.label_fix__latestShutdown.TabIndex = 11;
            this.label_fix__latestShutdown.Text = "Latest shutdown";
            this.label_fix__latestShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_datarate_time
            // 
            this.label_fix_datarate_time.AutoSize = true;
            this.label_fix_datarate_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_datarate_time.Location = new System.Drawing.Point(3, 68);
            this.label_fix_datarate_time.Name = "label_fix_datarate_time";
            this.label_fix_datarate_time.Size = new System.Drawing.Size(198, 34);
            this.label_fix_datarate_time.TabIndex = 10;
            this.label_fix_datarate_time.Text = "Time treshold must be lower";
            this.label_fix_datarate_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_datarate_threshold
            // 
            this.label_fix_datarate_threshold.AutoSize = true;
            this.label_fix_datarate_threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_datarate_threshold.Location = new System.Drawing.Point(3, 34);
            this.label_fix_datarate_threshold.Name = "label_fix_datarate_threshold";
            this.label_fix_datarate_threshold.Size = new System.Drawing.Size(198, 34);
            this.label_fix_datarate_threshold.TabIndex = 9;
            this.label_fix_datarate_threshold.Text = "MBit/s average treshold";
            this.label_fix_datarate_threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_networks
            // 
            this.label_fix_networks.AutoSize = true;
            this.label_fix_networks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_networks.Location = new System.Drawing.Point(3, 0);
            this.label_fix_networks.Name = "label_fix_networks";
            this.label_fix_networks.Size = new System.Drawing.Size(198, 34);
            this.label_fix_networks.TabIndex = 8;
            this.label_fix_networks.Text = "Network card";
            this.label_fix_networks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_MBits_threshold
            // 
            this.label_fix_MBits_threshold.AutoSize = true;
            this.label_fix_MBits_threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_MBits_threshold.Location = new System.Drawing.Point(411, 34);
            this.label_fix_MBits_threshold.Name = "label_fix_MBits_threshold";
            this.label_fix_MBits_threshold.Size = new System.Drawing.Size(52, 34);
            this.label_fix_MBits_threshold.TabIndex = 12;
            this.label_fix_MBits_threshold.Text = "MBit/s";
            this.label_fix_MBits_threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_time_threshold
            // 
            this.label_fix_time_threshold.AutoSize = true;
            this.label_fix_time_threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_time_threshold.Location = new System.Drawing.Point(411, 68);
            this.label_fix_time_threshold.Name = "label_fix_time_threshold";
            this.label_fix_time_threshold.Size = new System.Drawing.Size(52, 34);
            this.label_fix_time_threshold.TabIndex = 13;
            this.label_fix_time_threshold.Text = "Min";
            this.label_fix_time_threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fix_MBytes_threshold
            // 
            this.label_fix_MBytes_threshold.AutoSize = true;
            this.label_fix_MBytes_threshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fix_MBytes_threshold.Location = new System.Drawing.Point(527, 34);
            this.label_fix_MBytes_threshold.Name = "label_fix_MBytes_threshold";
            this.label_fix_MBytes_threshold.Size = new System.Drawing.Size(53, 34);
            this.label_fix_MBytes_threshold.TabIndex = 14;
            this.label_fix_MBytes_threshold.Text = "MByte/s";
            this.label_fix_MBytes_threshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_datarate_threshold_bytes
            // 
            this.label_datarate_threshold_bytes.AutoSize = true;
            this.label_datarate_threshold_bytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_datarate_threshold_bytes.Location = new System.Drawing.Point(469, 34);
            this.label_datarate_threshold_bytes.Name = "label_datarate_threshold_bytes";
            this.label_datarate_threshold_bytes.Size = new System.Drawing.Size(52, 34);
            this.label_datarate_threshold_bytes.TabIndex = 15;
            this.label_datarate_threshold_bytes.Text = "0,12";
            this.label_datarate_threshold_bytes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.Location = new System.Drawing.Point(523, 235);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 10;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.Button_about_Click);
            // 
            // button_logs
            // 
            this.button_logs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logs.Location = new System.Drawing.Point(523, 204);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(75, 23);
            this.button_logs.TabIndex = 11;
            this.button_logs.Text = "Logs";
            this.button_logs.UseVisualStyleBackColor = true;
            this.button_logs.Click += new System.EventHandler(this.Button_logs_Click);
            // 
            // label_Drive_Busy
            // 
            this.label_Drive_Busy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Drive_Busy.AutoSize = true;
            this.label_Drive_Busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Drive_Busy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Drive_Busy.Location = new System.Drawing.Point(527, 278);
            this.label_Drive_Busy.Name = "label_Drive_Busy";
            this.label_Drive_Busy.Size = new System.Drawing.Size(80, 13);
            this.label_Drive_Busy.TabIndex = 12;
            this.label_Drive_Busy.Text = "Drive is busy";
            this.label_Drive_Busy.Visible = false;
            // 
            // DownloadWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 321);
            this.Controls.Add(this.label_Drive_Busy);
            this.Controls.Add(this.button_logs);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_enable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadWatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Watcher";
            this.Load += new System.EventHandler(this.DownloadWatcherForm_Load);
            this.groupBox_info.ResumeLayout(false);
            this.tableLayoutPanel_info.ResumeLayout(false);
            this.tableLayoutPanel_info.PerformLayout();
            this.groupBox_settings.ResumeLayout(false);
            this.tableLayoutPanel_settings.ResumeLayout(false);
            this.tableLayoutPanel_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enable;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox_networks;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_datarate_send;
        private System.Windows.Forms.Label label_datarate_recive;
        private System.Windows.Forms.DateTimePicker dateTimePicker_latestShutdown;
        private System.Windows.Forms.TextBox textBox_datarate_threshold;
        private System.Windows.Forms.TextBox textBox_datarate_time;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_info;
        private System.Windows.Forms.Label label_fix_ip;
        private System.Windows.Forms.Label label_fix_datarate_send;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_settings;
        private System.Windows.Forms.Label label_fix__latestShutdown;
        private System.Windows.Forms.Label label_fix_datarate_time;
        private System.Windows.Forms.Label label_fix_datarate_threshold;
        private System.Windows.Forms.Label label_fix_networks;
        private System.Windows.Forms.Label label_datarate_recive_average_bit;
        private System.Windows.Forms.Label label_datarate_send_average_bit;
        private System.Windows.Forms.Label label_fix_average;
        private System.Windows.Forms.Label label_fix_MBits_threshold;
        private System.Windows.Forms.Label label_fix_time_threshold;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Label label_datarate_send_average_byte;
        private System.Windows.Forms.Label label_datarate_recive_average_byte;
        private System.Windows.Forms.Label label_fix_MBytes_threshold;
        private System.Windows.Forms.Label label_datarate_threshold_bytes;
        private System.Windows.Forms.Button button_logs;
        private System.Windows.Forms.Label label_Drive_Busy;
    }
}

