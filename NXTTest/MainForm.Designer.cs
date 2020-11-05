namespace NXTTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.batteryLevelBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.freeUserFlashBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSignalStrengthBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.protocolBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firmwareBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rotationCountBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.blockTachoCountBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tachoCountBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.runStateCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.regulationModeCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.modeRegulatedBox = new System.Windows.Forms.CheckBox();
            this.modeBrakeCheck = new System.Windows.Forms.CheckBox();
            this.modeOnCheck = new System.Windows.Forms.CheckBox();
            this.tachoLimitBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.turnRatioUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.powerUpDown = new System.Windows.Forms.NumericUpDown();
            this.getMotorStateButton = new System.Windows.Forms.Button();
            this.setMotorStateButton = new System.Windows.Forms.Button();
            this.resetMotorButton = new System.Windows.Forms.Button();
            this.motorCombo = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.setInputModeButton = new System.Windows.Forms.Button();
            this.sensorModeCombo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.sensorTypeCombo = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.calibratedInputBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.scaledInputBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.normalizedInputBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.rawInputBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.sensorModeBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sensorTypeBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.calibratedCheck = new System.Windows.Forms.CheckBox();
            this.validCheck = new System.Windows.Forms.CheckBox();
            this.getInputButton = new System.Windows.Forms.Button();
            this.inputPortCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnRatioUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerUpDown)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(267, 30);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(93, 28);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "&Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(167, 30);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(93, 31);
            this.portBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(63, 22);
            this.portBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.batteryLevelBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.freeUserFlashBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btSignalStrengthBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btAddressBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.deviceNameBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.protocolBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.firmwareBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(373, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device info";
            // 
            // batteryLevelBox
            // 
            this.batteryLevelBox.Location = new System.Drawing.Point(147, 215);
            this.batteryLevelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batteryLevelBox.Name = "batteryLevelBox";
            this.batteryLevelBox.ReadOnly = true;
            this.batteryLevelBox.Size = new System.Drawing.Size(132, 22);
            this.batteryLevelBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Battery level:";
            // 
            // freeUserFlashBox
            // 
            this.freeUserFlashBox.Location = new System.Drawing.Point(147, 178);
            this.freeUserFlashBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freeUserFlashBox.Name = "freeUserFlashBox";
            this.freeUserFlashBox.ReadOnly = true;
            this.freeUserFlashBox.Size = new System.Drawing.Size(132, 22);
            this.freeUserFlashBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Free user Flash:";
            // 
            // btSignalStrengthBox
            // 
            this.btSignalStrengthBox.Location = new System.Drawing.Point(147, 142);
            this.btSignalStrengthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSignalStrengthBox.Name = "btSignalStrengthBox";
            this.btSignalStrengthBox.ReadOnly = true;
            this.btSignalStrengthBox.Size = new System.Drawing.Size(132, 22);
            this.btSignalStrengthBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Signal strength:";
            // 
            // btAddressBox
            // 
            this.btAddressBox.Location = new System.Drawing.Point(147, 105);
            this.btAddressBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddressBox.Name = "btAddressBox";
            this.btAddressBox.ReadOnly = true;
            this.btAddressBox.Size = new System.Drawing.Size(212, 22);
            this.btAddressBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bluetooth address:";
            // 
            // deviceNameBox
            // 
            this.deviceNameBox.Location = new System.Drawing.Point(147, 68);
            this.deviceNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deviceNameBox.Name = "deviceNameBox";
            this.deviceNameBox.ReadOnly = true;
            this.deviceNameBox.Size = new System.Drawing.Size(212, 22);
            this.deviceNameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Device name:";
            // 
            // protocolBox
            // 
            this.protocolBox.Location = new System.Drawing.Point(280, 31);
            this.protocolBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.protocolBox.Name = "protocolBox";
            this.protocolBox.ReadOnly = true;
            this.protocolBox.Size = new System.Drawing.Size(79, 22);
            this.protocolBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protocol:";
            // 
            // firmwareBox
            // 
            this.firmwareBox.Location = new System.Drawing.Point(93, 31);
            this.firmwareBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmwareBox.Name = "firmwareBox";
            this.firmwareBox.ReadOnly = true;
            this.firmwareBox.Size = new System.Drawing.Size(79, 22);
            this.firmwareBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firmware:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rotationCountBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.blockTachoCountBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tachoCountBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.getMotorStateButton);
            this.groupBox3.Controls.Add(this.setMotorStateButton);
            this.groupBox3.Controls.Add(this.resetMotorButton);
            this.groupBox3.Controls.Add(this.motorCombo);
            this.groupBox3.Location = new System.Drawing.Point(400, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(367, 382);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor control";
            // 
            // rotationCountBox
            // 
            this.rotationCountBox.Location = new System.Drawing.Point(147, 345);
            this.rotationCountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rotationCountBox.Name = "rotationCountBox";
            this.rotationCountBox.ReadOnly = true;
            this.rotationCountBox.Size = new System.Drawing.Size(132, 22);
            this.rotationCountBox.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 348);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Rotation count:";
            this.toolTip.SetToolTip(this.label16, "Current position relative to last reset of motor\'s rotation sensor");
            // 
            // blockTachoCountBox
            // 
            this.blockTachoCountBox.Location = new System.Drawing.Point(147, 314);
            this.blockTachoCountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blockTachoCountBox.Name = "blockTachoCountBox";
            this.blockTachoCountBox.ReadOnly = true;
            this.blockTachoCountBox.Size = new System.Drawing.Size(132, 22);
            this.blockTachoCountBox.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 318);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Block tacho count:";
            this.toolTip.SetToolTip(this.label15, "Current position relative to last programmed movement");
            // 
            // tachoCountBox
            // 
            this.tachoCountBox.Location = new System.Drawing.Point(147, 283);
            this.tachoCountBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tachoCountBox.Name = "tachoCountBox";
            this.tachoCountBox.ReadOnly = true;
            this.tachoCountBox.Size = new System.Drawing.Size(132, 22);
            this.tachoCountBox.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 287);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tacho count:";
            this.toolTip.SetToolTip(this.label14, "Number of counts since last reset of motor counter");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.runStateCombo);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.regulationModeCombo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tachoLimitBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.turnRatioUpDown);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.powerUpDown);
            this.groupBox4.Location = new System.Drawing.Point(7, 55);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(353, 222);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor state";
            // 
            // runStateCombo
            // 
            this.runStateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runStateCombo.FormattingEnabled = true;
            this.runStateCombo.Items.AddRange(new object[] {
            "Idle",
            "Rump-Up",
            "Running",
            "Rump-Down"});
            this.runStateCombo.Location = new System.Drawing.Point(133, 185);
            this.runStateCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runStateCombo.Name = "runStateCombo";
            this.runStateCombo.Size = new System.Drawing.Size(185, 24);
            this.runStateCombo.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Run state:";
            // 
            // regulationModeCombo
            // 
            this.regulationModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regulationModeCombo.FormattingEnabled = true;
            this.regulationModeCombo.Items.AddRange(new object[] {
            "Idle",
            "Speed",
            "Sync"});
            this.regulationModeCombo.Location = new System.Drawing.Point(133, 154);
            this.regulationModeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regulationModeCombo.Name = "regulationModeCombo";
            this.regulationModeCombo.Size = new System.Drawing.Size(185, 24);
            this.regulationModeCombo.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Regulation mode:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.modeRegulatedBox);
            this.groupBox5.Controls.Add(this.modeBrakeCheck);
            this.groupBox5.Controls.Add(this.modeOnCheck);
            this.groupBox5.Location = new System.Drawing.Point(7, 86);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(340, 55);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // modeRegulatedBox
            // 
            this.modeRegulatedBox.AutoSize = true;
            this.modeRegulatedBox.Location = new System.Drawing.Point(227, 25);
            this.modeRegulatedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeRegulatedBox.Name = "modeRegulatedBox";
            this.modeRegulatedBox.Size = new System.Drawing.Size(95, 21);
            this.modeRegulatedBox.TabIndex = 2;
            this.modeRegulatedBox.Text = "Regulated";
            this.modeRegulatedBox.UseVisualStyleBackColor = true;
            // 
            // modeBrakeCheck
            // 
            this.modeBrakeCheck.AutoSize = true;
            this.modeBrakeCheck.Location = new System.Drawing.Point(120, 25);
            this.modeBrakeCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeBrakeCheck.Name = "modeBrakeCheck";
            this.modeBrakeCheck.Size = new System.Drawing.Size(67, 21);
            this.modeBrakeCheck.TabIndex = 1;
            this.modeBrakeCheck.Text = "Brake";
            this.modeBrakeCheck.UseVisualStyleBackColor = true;
            // 
            // modeOnCheck
            // 
            this.modeOnCheck.AutoSize = true;
            this.modeOnCheck.Checked = true;
            this.modeOnCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modeOnCheck.Location = new System.Drawing.Point(13, 25);
            this.modeOnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modeOnCheck.Name = "modeOnCheck";
            this.modeOnCheck.Size = new System.Drawing.Size(49, 21);
            this.modeOnCheck.TabIndex = 0;
            this.modeOnCheck.Text = "On";
            this.modeOnCheck.UseVisualStyleBackColor = true;
            // 
            // tachoLimitBox
            // 
            this.tachoLimitBox.Location = new System.Drawing.Point(187, 55);
            this.tachoLimitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tachoLimitBox.Name = "tachoLimitBox";
            this.tachoLimitBox.Size = new System.Drawing.Size(132, 22);
            this.tachoLimitBox.TabIndex = 9;
            this.tachoLimitBox.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tacho limit (0 run forever):";
            // 
            // turnRatioUpDown
            // 
            this.turnRatioUpDown.Location = new System.Drawing.Point(240, 25);
            this.turnRatioUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.turnRatioUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.turnRatioUpDown.Name = "turnRatioUpDown";
            this.turnRatioUpDown.Size = new System.Drawing.Size(80, 22);
            this.turnRatioUpDown.TabIndex = 7;
            this.turnRatioUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Turn ratio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Power:";
            // 
            // powerUpDown
            // 
            this.powerUpDown.Location = new System.Drawing.Point(67, 25);
            this.powerUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powerUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.powerUpDown.Name = "powerUpDown";
            this.powerUpDown.Size = new System.Drawing.Size(80, 22);
            this.powerUpDown.TabIndex = 5;
            this.powerUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // getMotorStateButton
            // 
            this.getMotorStateButton.Enabled = false;
            this.getMotorStateButton.Location = new System.Drawing.Point(280, 23);
            this.getMotorStateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getMotorStateButton.Name = "getMotorStateButton";
            this.getMotorStateButton.Size = new System.Drawing.Size(80, 28);
            this.getMotorStateButton.TabIndex = 3;
            this.getMotorStateButton.Text = "&Get state";
            this.getMotorStateButton.UseVisualStyleBackColor = true;
            this.getMotorStateButton.Click += new System.EventHandler(this.getMotorStateButton_Click);
            // 
            // setMotorStateButton
            // 
            this.setMotorStateButton.Enabled = false;
            this.setMotorStateButton.Location = new System.Drawing.Point(193, 23);
            this.setMotorStateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setMotorStateButton.Name = "setMotorStateButton";
            this.setMotorStateButton.Size = new System.Drawing.Size(80, 28);
            this.setMotorStateButton.TabIndex = 2;
            this.setMotorStateButton.Text = "&Set state";
            this.setMotorStateButton.UseVisualStyleBackColor = true;
            this.setMotorStateButton.Click += new System.EventHandler(this.setMotorStateButton_Click);
            // 
            // resetMotorButton
            // 
            this.resetMotorButton.Enabled = false;
            this.resetMotorButton.Location = new System.Drawing.Point(107, 23);
            this.resetMotorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetMotorButton.Name = "resetMotorButton";
            this.resetMotorButton.Size = new System.Drawing.Size(80, 28);
            this.resetMotorButton.TabIndex = 1;
            this.resetMotorButton.Text = "&Reset";
            this.resetMotorButton.UseVisualStyleBackColor = true;
            this.resetMotorButton.Click += new System.EventHandler(this.resetMotorButton_Click);
            // 
            // motorCombo
            // 
            this.motorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motorCombo.FormattingEnabled = true;
            this.motorCombo.Items.AddRange(new object[] {
            "Motor A",
            "Motor B",
            "Motor C"});
            this.motorCombo.Location = new System.Drawing.Point(13, 25);
            this.motorCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motorCombo.Name = "motorCombo";
            this.motorCombo.Size = new System.Drawing.Size(85, 24);
            this.motorCombo.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.setInputModeButton);
            this.groupBox6.Controls.Add(this.sensorModeCombo);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.sensorTypeCombo);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.calibratedInputBox);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.scaledInputBox);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.normalizedInputBox);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.rawInputBox);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.sensorModeBox);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.sensorTypeBox);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.calibratedCheck);
            this.groupBox6.Controls.Add(this.validCheck);
            this.groupBox6.Controls.Add(this.getInputButton);
            this.groupBox6.Controls.Add(this.inputPortCombo);
            this.groupBox6.Location = new System.Drawing.Point(780, 12);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(227, 382);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input ports";
            // 
            // setInputModeButton
            // 
            this.setInputModeButton.Enabled = false;
            this.setInputModeButton.Location = new System.Drawing.Point(107, 348);
            this.setInputModeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setInputModeButton.Name = "setInputModeButton";
            this.setInputModeButton.Size = new System.Drawing.Size(107, 28);
            this.setInputModeButton.TabIndex = 21;
            this.setInputModeButton.Text = "Set &mode";
            this.setInputModeButton.UseVisualStyleBackColor = true;
            this.setInputModeButton.Click += new System.EventHandler(this.setInputModeButton_Click);
            // 
            // sensorModeCombo
            // 
            this.sensorModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorModeCombo.FormattingEnabled = true;
            this.sensorModeCombo.Items.AddRange(new object[] {
            "Raw",
            "Boolean",
            "Transition Counter",
            "Periodic Counter",
            "PCT Full Scale",
            "Celsius",
            "Fahrenheit",
            "Angle Steps"});
            this.sensorModeCombo.Location = new System.Drawing.Point(107, 320);
            this.sensorModeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorModeCombo.Name = "sensorModeCombo";
            this.sensorModeCombo.Size = new System.Drawing.Size(105, 24);
            this.sensorModeCombo.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(13, 279);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(200, 2);
            this.label25.TabIndex = 19;
            // 
            // sensorTypeCombo
            // 
            this.sensorTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorTypeCombo.FormattingEnabled = true;
            this.sensorTypeCombo.Items.AddRange(new object[] {
            "No Sensor",
            "Switch",
            "Temperature",
            "Reflection",
            "Angle",
            "Light Active",
            "Light Inactive",
            "Sound (dB)",
            "Sound (dBA)",
            "Custom",
            "Lowspeed",
            "Lowspeed 9V"});
            this.sensorTypeCombo.Location = new System.Drawing.Point(107, 289);
            this.sensorTypeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorTypeCombo.Name = "sensorTypeCombo";
            this.sensorTypeCombo.Size = new System.Drawing.Size(105, 24);
            this.sensorTypeCombo.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 324);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "Sensor mode:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 293);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 17);
            this.label24.TabIndex = 16;
            this.label24.Text = "Sensor type:";
            // 
            // calibratedInputBox
            // 
            this.calibratedInputBox.Location = new System.Drawing.Point(107, 246);
            this.calibratedInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calibratedInputBox.Name = "calibratedInputBox";
            this.calibratedInputBox.ReadOnly = true;
            this.calibratedInputBox.Size = new System.Drawing.Size(105, 22);
            this.calibratedInputBox.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 250);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "Calibrated:";
            // 
            // scaledInputBox
            // 
            this.scaledInputBox.Location = new System.Drawing.Point(107, 215);
            this.scaledInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scaledInputBox.Name = "scaledInputBox";
            this.scaledInputBox.ReadOnly = true;
            this.scaledInputBox.Size = new System.Drawing.Size(105, 22);
            this.scaledInputBox.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 219);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 17);
            this.label21.TabIndex = 12;
            this.label21.Text = "Scaled:";
            // 
            // normalizedInputBox
            // 
            this.normalizedInputBox.Location = new System.Drawing.Point(107, 185);
            this.normalizedInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.normalizedInputBox.Name = "normalizedInputBox";
            this.normalizedInputBox.ReadOnly = true;
            this.normalizedInputBox.Size = new System.Drawing.Size(105, 22);
            this.normalizedInputBox.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 188);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "Normalized:";
            // 
            // rawInputBox
            // 
            this.rawInputBox.Location = new System.Drawing.Point(107, 154);
            this.rawInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rawInputBox.Name = "rawInputBox";
            this.rawInputBox.ReadOnly = true;
            this.rawInputBox.Size = new System.Drawing.Size(105, 22);
            this.rawInputBox.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 158);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "Row:";
            // 
            // sensorModeBox
            // 
            this.sensorModeBox.Location = new System.Drawing.Point(107, 123);
            this.sensorModeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorModeBox.Name = "sensorModeBox";
            this.sensorModeBox.ReadOnly = true;
            this.sensorModeBox.Size = new System.Drawing.Size(105, 22);
            this.sensorModeBox.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 127);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Sensor mode:";
            // 
            // sensorTypeBox
            // 
            this.sensorTypeBox.Location = new System.Drawing.Point(107, 92);
            this.sensorTypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorTypeBox.Name = "sensorTypeBox";
            this.sensorTypeBox.ReadOnly = true;
            this.sensorTypeBox.Size = new System.Drawing.Size(105, 22);
            this.sensorTypeBox.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 96);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Sensor type:";
            // 
            // calibratedCheck
            // 
            this.calibratedCheck.AutoSize = true;
            this.calibratedCheck.Enabled = false;
            this.calibratedCheck.Location = new System.Drawing.Point(107, 62);
            this.calibratedCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calibratedCheck.Name = "calibratedCheck";
            this.calibratedCheck.Size = new System.Drawing.Size(108, 21);
            this.calibratedCheck.TabIndex = 3;
            this.calibratedCheck.Text = "Is Calibrated";
            this.calibratedCheck.UseVisualStyleBackColor = true;
            // 
            // validCheck
            // 
            this.validCheck.AutoSize = true;
            this.validCheck.Enabled = false;
            this.validCheck.Location = new System.Drawing.Point(13, 62);
            this.validCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validCheck.Name = "validCheck";
            this.validCheck.Size = new System.Drawing.Size(75, 21);
            this.validCheck.TabIndex = 2;
            this.validCheck.Text = "Is Valid";
            this.validCheck.UseVisualStyleBackColor = true;
            // 
            // getInputButton
            // 
            this.getInputButton.Enabled = false;
            this.getInputButton.Location = new System.Drawing.Point(127, 23);
            this.getInputButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getInputButton.Name = "getInputButton";
            this.getInputButton.Size = new System.Drawing.Size(87, 28);
            this.getInputButton.TabIndex = 1;
            this.getInputButton.Text = "Get &input";
            this.getInputButton.UseVisualStyleBackColor = true;
            this.getInputButton.Click += new System.EventHandler(this.getInputButton_Click);
            // 
            // inputPortCombo
            // 
            this.inputPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputPortCombo.FormattingEnabled = true;
            this.inputPortCombo.Items.AddRange(new object[] {
            "Port 1",
            "Port 2",
            "Port 3",
            "Port 4"});
            this.inputPortCombo.Location = new System.Drawing.Point(13, 25);
            this.inputPortCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPortCombo.Name = "inputPortCombo";
            this.inputPortCombo.Size = new System.Drawing.Size(99, 24);
            this.inputPortCombo.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 405);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Lego NXT Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnRatioUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerUpDown)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox protocolBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firmwareBox;
        private System.Windows.Forms.TextBox deviceNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox freeUserFlashBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox btSignalStrengthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btAddressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox batteryLevelBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox motorCombo;
        private System.Windows.Forms.Button getMotorStateButton;
        private System.Windows.Forms.Button setMotorStateButton;
        private System.Windows.Forms.Button resetMotorButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown powerUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown turnRatioUpDown;
        private System.Windows.Forms.TextBox tachoLimitBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox modeOnCheck;
        private System.Windows.Forms.CheckBox modeRegulatedBox;
        private System.Windows.Forms.CheckBox modeBrakeCheck;
        private System.Windows.Forms.ComboBox regulationModeCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox runStateCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tachoCountBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox blockTachoCountBox;
        private System.Windows.Forms.TextBox rotationCountBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox inputPortCombo;
        private System.Windows.Forms.Button getInputButton;
        private System.Windows.Forms.CheckBox calibratedCheck;
        private System.Windows.Forms.CheckBox validCheck;
        private System.Windows.Forms.TextBox sensorModeBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox sensorTypeBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox rawInputBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox normalizedInputBox;
        private System.Windows.Forms.TextBox calibratedInputBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox scaledInputBox;
        private System.Windows.Forms.ComboBox sensorTypeCombo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox sensorModeCombo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button setInputModeButton;
    }
}

