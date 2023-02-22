namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tabSetup = new System.Windows.Forms.TabControl();
            this.tabWave = new System.Windows.Forms.TabPage();
            this.lblDCOffset = new System.Windows.Forms.Label();
            this.lblDutyCycle = new System.Windows.Forms.Label();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.updDCOffset = new System.Windows.Forms.NumericUpDown();
            this.updDutyCycle = new System.Windows.Forms.NumericUpDown();
            this.updAmplitude = new System.Windows.Forms.NumericUpDown();
            this.grpWaveType = new System.Windows.Forms.GroupBox();
            this.optTTL = new System.Windows.Forms.RadioButton();
            this.optTriangle = new System.Windows.Forms.RadioButton();
            this.optSawtooth = new System.Windows.Forms.RadioButton();
            this.optSquare = new System.Windows.Forms.RadioButton();
            this.optSine = new System.Windows.Forms.RadioButton();
            this.tabFrequency = new System.Windows.Forms.TabPage();
            this.lblActFreq = new System.Windows.Forms.Label();
            this.txtActFreq = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.updFrequency = new System.Windows.Forms.NumericUpDown();
            this.grpFrequency = new System.Windows.Forms.GroupBox();
            this.opt10kHz = new System.Windows.Forms.RadioButton();
            this.opt1kHz = new System.Windows.Forms.RadioButton();
            this.opt100Hz = new System.Windows.Forms.RadioButton();
            this.opt10Hz = new System.Windows.Forms.RadioButton();
            this.opt1Hz = new System.Windows.Forms.RadioButton();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cmdOnOff = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSetup.SuspendLayout();
            this.tabWave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updDCOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDutyCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmplitude)).BeginInit();
            this.grpWaveType.SuspendLayout();
            this.tabFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFrequency)).BeginInit();
            this.grpFrequency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(267, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(266, 31);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Function Generator";
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.tabWave);
            this.tabSetup.Controls.Add(this.tabFrequency);
            this.tabSetup.Location = new System.Drawing.Point(22, 43);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.SelectedIndex = 0;
            this.tabSetup.Size = new System.Drawing.Size(246, 326);
            this.tabSetup.TabIndex = 1;
            // 
            // tabWave
            // 
            this.tabWave.Controls.Add(this.lblDCOffset);
            this.tabWave.Controls.Add(this.lblDutyCycle);
            this.tabWave.Controls.Add(this.lblAmplitude);
            this.tabWave.Controls.Add(this.updDCOffset);
            this.tabWave.Controls.Add(this.updDutyCycle);
            this.tabWave.Controls.Add(this.updAmplitude);
            this.tabWave.Controls.Add(this.grpWaveType);
            this.tabWave.Location = new System.Drawing.Point(4, 22);
            this.tabWave.Name = "tabWave";
            this.tabWave.Padding = new System.Windows.Forms.Padding(3);
            this.tabWave.Size = new System.Drawing.Size(238, 300);
            this.tabWave.TabIndex = 0;
            this.tabWave.Text = "Wave";
            this.tabWave.UseVisualStyleBackColor = true;
            // 
            // lblDCOffset
            // 
            this.lblDCOffset.AutoSize = true;
            this.lblDCOffset.Location = new System.Drawing.Point(40, 252);
            this.lblDCOffset.Name = "lblDCOffset";
            this.lblDCOffset.Size = new System.Drawing.Size(72, 13);
            this.lblDCOffset.TabIndex = 2;
            this.lblDCOffset.Text = "DC Offset (V):";
            // 
            // lblDutyCycle
            // 
            this.lblDutyCycle.AutoSize = true;
            this.lblDutyCycle.Location = new System.Drawing.Point(34, 196);
            this.lblDutyCycle.Name = "lblDutyCycle";
            this.lblDutyCycle.Size = new System.Drawing.Size(78, 13);
            this.lblDutyCycle.TabIndex = 2;
            this.lblDutyCycle.Text = "Duty Cycle (%):";
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(40, 140);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(72, 13);
            this.lblAmplitude.TabIndex = 2;
            this.lblAmplitude.Text = "Amplitude (V):";
            // 
            // updDCOffset
            // 
            this.updDCOffset.Location = new System.Drawing.Point(114, 248);
            this.updDCOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updDCOffset.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.updDCOffset.Name = "updDCOffset";
            this.updDCOffset.Size = new System.Drawing.Size(88, 20);
            this.updDCOffset.TabIndex = 1;
            this.updDCOffset.ValueChanged += new System.EventHandler(this.updDCOffset_ValueChanged);
            // 
            // updDutyCycle
            // 
            this.updDutyCycle.Enabled = false;
            this.updDutyCycle.Location = new System.Drawing.Point(114, 192);
            this.updDutyCycle.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.updDutyCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updDutyCycle.Name = "updDutyCycle";
            this.updDutyCycle.Size = new System.Drawing.Size(88, 20);
            this.updDutyCycle.TabIndex = 1;
            this.updDutyCycle.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.updDutyCycle.ValueChanged += new System.EventHandler(this.updDutyCycle_ValueChanged);
            // 
            // updAmplitude
            // 
            this.updAmplitude.Location = new System.Drawing.Point(114, 136);
            this.updAmplitude.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updAmplitude.Name = "updAmplitude";
            this.updAmplitude.Size = new System.Drawing.Size(88, 20);
            this.updAmplitude.TabIndex = 1;
            this.updAmplitude.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.updAmplitude.ValueChanged += new System.EventHandler(this.updAmplitude_ValueChanged);
            // 
            // grpWaveType
            // 
            this.grpWaveType.Controls.Add(this.optTTL);
            this.grpWaveType.Controls.Add(this.optTriangle);
            this.grpWaveType.Controls.Add(this.optSawtooth);
            this.grpWaveType.Controls.Add(this.optSquare);
            this.grpWaveType.Controls.Add(this.optSine);
            this.grpWaveType.Location = new System.Drawing.Point(21, 6);
            this.grpWaveType.Name = "grpWaveType";
            this.grpWaveType.Size = new System.Drawing.Size(195, 94);
            this.grpWaveType.TabIndex = 0;
            this.grpWaveType.TabStop = false;
            this.grpWaveType.Text = "Wave Type";
            // 
            // optTTL
            // 
            this.optTTL.AutoSize = true;
            this.optTTL.Location = new System.Drawing.Point(107, 55);
            this.optTTL.Name = "optTTL";
            this.optTTL.Size = new System.Drawing.Size(45, 17);
            this.optTTL.TabIndex = 0;
            this.optTTL.Text = "TTL";
            this.optTTL.UseVisualStyleBackColor = true;
            this.optTTL.CheckedChanged += new System.EventHandler(this.WaveType_CheckedChanged);
            // 
            // optTriangle
            // 
            this.optTriangle.AutoSize = true;
            this.optTriangle.Location = new System.Drawing.Point(107, 32);
            this.optTriangle.Name = "optTriangle";
            this.optTriangle.Size = new System.Drawing.Size(63, 17);
            this.optTriangle.TabIndex = 0;
            this.optTriangle.Text = "Triangle";
            this.optTriangle.UseVisualStyleBackColor = true;
            this.optTriangle.CheckedChanged += new System.EventHandler(this.WaveType_CheckedChanged);
            // 
            // optSawtooth
            // 
            this.optSawtooth.AutoSize = true;
            this.optSawtooth.Location = new System.Drawing.Point(18, 66);
            this.optSawtooth.Name = "optSawtooth";
            this.optSawtooth.Size = new System.Drawing.Size(70, 17);
            this.optSawtooth.TabIndex = 0;
            this.optSawtooth.Text = "Sawtooth";
            this.optSawtooth.UseVisualStyleBackColor = true;
            this.optSawtooth.CheckedChanged += new System.EventHandler(this.WaveType_CheckedChanged);
            // 
            // optSquare
            // 
            this.optSquare.AutoSize = true;
            this.optSquare.Location = new System.Drawing.Point(18, 43);
            this.optSquare.Name = "optSquare";
            this.optSquare.Size = new System.Drawing.Size(59, 17);
            this.optSquare.TabIndex = 0;
            this.optSquare.Text = "Square";
            this.optSquare.UseVisualStyleBackColor = true;
            this.optSquare.CheckedChanged += new System.EventHandler(this.WaveType_CheckedChanged);
            // 
            // optSine
            // 
            this.optSine.AutoSize = true;
            this.optSine.Checked = true;
            this.optSine.Location = new System.Drawing.Point(18, 20);
            this.optSine.Name = "optSine";
            this.optSine.Size = new System.Drawing.Size(46, 17);
            this.optSine.TabIndex = 0;
            this.optSine.TabStop = true;
            this.optSine.Text = "Sine";
            this.optSine.UseVisualStyleBackColor = true;
            this.optSine.CheckedChanged += new System.EventHandler(this.WaveType_CheckedChanged);
            // 
            // tabFrequency
            // 
            this.tabFrequency.Controls.Add(this.lblActFreq);
            this.tabFrequency.Controls.Add(this.txtActFreq);
            this.tabFrequency.Controls.Add(this.lblFrequency);
            this.tabFrequency.Controls.Add(this.updFrequency);
            this.tabFrequency.Controls.Add(this.grpFrequency);
            this.tabFrequency.Location = new System.Drawing.Point(4, 22);
            this.tabFrequency.Name = "tabFrequency";
            this.tabFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequency.Size = new System.Drawing.Size(238, 300);
            this.tabFrequency.TabIndex = 1;
            this.tabFrequency.Text = "Frequency";
            this.tabFrequency.UseVisualStyleBackColor = true;
            // 
            // lblActFreq
            // 
            this.lblActFreq.AutoSize = true;
            this.lblActFreq.Location = new System.Drawing.Point(60, 223);
            this.lblActFreq.Name = "lblActFreq";
            this.lblActFreq.Size = new System.Drawing.Size(112, 13);
            this.lblActFreq.TabIndex = 6;
            this.lblActFreq.Text = "Actual Frequency (Hz)";
            // 
            // txtActFreq
            // 
            this.txtActFreq.Location = new System.Drawing.Point(66, 242);
            this.txtActFreq.Name = "txtActFreq";
            this.txtActFreq.ReadOnly = true;
            this.txtActFreq.Size = new System.Drawing.Size(100, 20);
            this.txtActFreq.TabIndex = 5;
            this.txtActFreq.Text = "5";
            this.txtActFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(46, 44);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(60, 13);
            this.lblFrequency.TabIndex = 4;
            this.lblFrequency.Text = "Frequency:";
            // 
            // updFrequency
            // 
            this.updFrequency.DecimalPlaces = 1;
            this.updFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updFrequency.Location = new System.Drawing.Point(112, 42);
            this.updFrequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updFrequency.Name = "updFrequency";
            this.updFrequency.Size = new System.Drawing.Size(88, 20);
            this.updFrequency.TabIndex = 3;
            this.updFrequency.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            this.updFrequency.ValueChanged += new System.EventHandler(this.updFrequency_ValueChanged);
            // 
            // grpFrequency
            // 
            this.grpFrequency.Controls.Add(this.opt10kHz);
            this.grpFrequency.Controls.Add(this.opt1kHz);
            this.grpFrequency.Controls.Add(this.opt100Hz);
            this.grpFrequency.Controls.Add(this.opt10Hz);
            this.grpFrequency.Controls.Add(this.opt1Hz);
            this.grpFrequency.Location = new System.Drawing.Point(21, 98);
            this.grpFrequency.Name = "grpFrequency";
            this.grpFrequency.Size = new System.Drawing.Size(195, 94);
            this.grpFrequency.TabIndex = 1;
            this.grpFrequency.TabStop = false;
            this.grpFrequency.Text = "Frequency Range";
            // 
            // opt10kHz
            // 
            this.opt10kHz.AutoSize = true;
            this.opt10kHz.Location = new System.Drawing.Point(107, 55);
            this.opt10kHz.Name = "opt10kHz";
            this.opt10kHz.Size = new System.Drawing.Size(64, 17);
            this.opt10kHz.TabIndex = 0;
            this.opt10kHz.Text = "x10 kHz";
            this.opt10kHz.UseVisualStyleBackColor = true;
            this.opt10kHz.CheckedChanged += new System.EventHandler(this.FreqRange_CheckedChanged);
            // 
            // opt1kHz
            // 
            this.opt1kHz.AutoSize = true;
            this.opt1kHz.Location = new System.Drawing.Point(107, 32);
            this.opt1kHz.Name = "opt1kHz";
            this.opt1kHz.Size = new System.Drawing.Size(58, 17);
            this.opt1kHz.TabIndex = 0;
            this.opt1kHz.Text = "x1 kHz";
            this.opt1kHz.UseVisualStyleBackColor = true;
            this.opt1kHz.CheckedChanged += new System.EventHandler(this.FreqRange_CheckedChanged);
            // 
            // opt100Hz
            // 
            this.opt100Hz.AutoSize = true;
            this.opt100Hz.Location = new System.Drawing.Point(18, 66);
            this.opt100Hz.Name = "opt100Hz";
            this.opt100Hz.Size = new System.Drawing.Size(64, 17);
            this.opt100Hz.TabIndex = 0;
            this.opt100Hz.Text = "x100 Hz";
            this.opt100Hz.UseVisualStyleBackColor = true;
            this.opt100Hz.CheckedChanged += new System.EventHandler(this.FreqRange_CheckedChanged);
            // 
            // opt10Hz
            // 
            this.opt10Hz.AutoSize = true;
            this.opt10Hz.Location = new System.Drawing.Point(18, 43);
            this.opt10Hz.Name = "opt10Hz";
            this.opt10Hz.Size = new System.Drawing.Size(58, 17);
            this.opt10Hz.TabIndex = 0;
            this.opt10Hz.Text = "x10 Hz";
            this.opt10Hz.UseVisualStyleBackColor = true;
            this.opt10Hz.CheckedChanged += new System.EventHandler(this.FreqRange_CheckedChanged);
            // 
            // opt1Hz
            // 
            this.opt1Hz.AutoSize = true;
            this.opt1Hz.Checked = true;
            this.opt1Hz.Location = new System.Drawing.Point(18, 20);
            this.opt1Hz.Name = "opt1Hz";
            this.opt1Hz.Size = new System.Drawing.Size(52, 17);
            this.opt1Hz.TabIndex = 0;
            this.opt1Hz.TabStop = true;
            this.opt1Hz.Text = "x1 Hz";
            this.opt1Hz.UseVisualStyleBackColor = true;
            this.opt1Hz.CheckedChanged += new System.EventHandler(this.FreqRange_CheckedChanged);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(4, 8);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(68, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Device/Port:";
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(73, 4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(98, 21);
            this.cboPort.TabIndex = 0;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // cmdOnOff
            // 
            this.cmdOnOff.BackColor = System.Drawing.Color.Red;
            this.cmdOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOnOff.Location = new System.Drawing.Point(47, 375);
            this.cmdOnOff.Name = "cmdOnOff";
            this.cmdOnOff.Size = new System.Drawing.Size(85, 64);
            this.cmdOnOff.TabIndex = 2;
            this.cmdOnOff.Text = "OFF";
            this.cmdOnOff.UseVisualStyleBackColor = false;
            this.cmdOnOff.Click += new System.EventHandler(this.cmdOnOff_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuit.Location = new System.Drawing.Point(154, 377);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(85, 64);
            this.cmdQuit.TabIndex = 3;
            this.cmdQuit.Text = "QUIT";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // chtData
            // 
            chartArea5.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtData.Legends.Add(legend5);
            this.chtData.Location = new System.Drawing.Point(274, 65);
            this.chtData.Name = "chtData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chtData.Series.Add(series5);
            this.chtData.Size = new System.Drawing.Size(514, 372);
            this.chtData.TabIndex = 4;
            this.chtData.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.chtData);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdOnOff);
            this.Controls.Add(this.tabSetup);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "Form1";
            this.Text = "Function Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSetup.ResumeLayout(false);
            this.tabWave.ResumeLayout(false);
            this.tabWave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updDCOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDutyCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAmplitude)).EndInit();
            this.grpWaveType.ResumeLayout(false);
            this.grpWaveType.PerformLayout();
            this.tabFrequency.ResumeLayout(false);
            this.tabFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFrequency)).EndInit();
            this.grpFrequency.ResumeLayout(false);
            this.grpFrequency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TabControl tabSetup;
        private System.Windows.Forms.TabPage tabWave;
        private System.Windows.Forms.GroupBox grpWaveType;
        private System.Windows.Forms.RadioButton optTTL;
        private System.Windows.Forms.RadioButton optTriangle;
        private System.Windows.Forms.RadioButton optSawtooth;
        private System.Windows.Forms.RadioButton optSquare;
        private System.Windows.Forms.RadioButton optSine;
        private System.Windows.Forms.TabPage tabFrequency;
        private System.Windows.Forms.Label lblDCOffset;
        private System.Windows.Forms.Label lblDutyCycle;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.NumericUpDown updDCOffset;
        private System.Windows.Forms.NumericUpDown updDutyCycle;
        private System.Windows.Forms.NumericUpDown updAmplitude;
        private System.Windows.Forms.GroupBox grpFrequency;
        private System.Windows.Forms.RadioButton opt10kHz;
        private System.Windows.Forms.RadioButton opt1kHz;
        private System.Windows.Forms.RadioButton opt100Hz;
        private System.Windows.Forms.RadioButton opt10Hz;
        private System.Windows.Forms.RadioButton opt1Hz;
        private System.Windows.Forms.Button cmdOnOff;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Label lblActFreq;
        private System.Windows.Forms.TextBox txtActFreq;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.NumericUpDown updFrequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cboPort;
    }
}

