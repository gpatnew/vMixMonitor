namespace vMixMonitor
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
            this.labelOnlineStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActiveInput = new System.Windows.Forms.Label();
            this.lblMicStatus = new System.Windows.Forms.Label();
            this.tbOutroInpu = new System.Windows.Forms.TextBox();
            this.cbUseTestStream = new System.Windows.Forms.CheckBox();
            this.cbAudioIsMaster = new System.Windows.Forms.CheckBox();
            this.tbAudioInpu = new System.Windows.Forms.TextBox();
            this.tbTimerInput = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOnlineStatus
            // 
            this.labelOnlineStatus.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelOnlineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnlineStatus.Location = new System.Drawing.Point(12, 9);
            this.labelOnlineStatus.Name = "labelOnlineStatus";
            this.labelOnlineStatus.Size = new System.Drawing.Size(1857, 294);
            this.labelOnlineStatus.TabIndex = 0;
            this.labelOnlineStatus.Text = "OFF LINE";
            this.labelOnlineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOutroInpu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbUseTestStream);
            this.groupBox1.Controls.Add(this.cbAudioIsMaster);
            this.groupBox1.Controls.Add(this.tbAudioInpu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.tbTimerInput);
            this.groupBox1.Controls.Add(this.tbUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(476, 743);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(117, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Outro Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(113, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Audio Input";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonOk.Location = new System.Drawing.Point(719, 172);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(113, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(134, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "vMix URL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(62, 894);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SETUP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // lblActiveInput
            // 
            this.lblActiveInput.AutoSize = true;
            this.lblActiveInput.BackColor = System.Drawing.Color.Black;
            this.lblActiveInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveInput.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblActiveInput.Location = new System.Drawing.Point(295, 346);
            this.lblActiveInput.MinimumSize = new System.Drawing.Size(600, 80);
            this.lblActiveInput.Name = "lblActiveInput";
            this.lblActiveInput.Size = new System.Drawing.Size(600, 80);
            this.lblActiveInput.TabIndex = 3;
            this.lblActiveInput.Text = "Active Camera";
            this.lblActiveInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMicStatus
            // 
            this.lblMicStatus.AutoSize = true;
            this.lblMicStatus.BackColor = System.Drawing.Color.Black;
            this.lblMicStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMicStatus.Location = new System.Drawing.Point(1065, 346);
            this.lblMicStatus.MinimumSize = new System.Drawing.Size(600, 80);
            this.lblMicStatus.Name = "lblMicStatus";
            this.lblMicStatus.Size = new System.Drawing.Size(600, 80);
            this.lblMicStatus.TabIndex = 4;
            this.lblMicStatus.Text = "MIC Status";
            this.lblMicStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOutroInpu
            // 
            this.tbOutroInpu.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vMixMonitor.Properties.Settings.Default, "OutroInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbOutroInpu.Location = new System.Drawing.Point(233, 153);
            this.tbOutroInpu.Name = "tbOutroInpu";
            this.tbOutroInpu.Size = new System.Drawing.Size(233, 20);
            this.tbOutroInpu.TabIndex = 10;
            this.tbOutroInpu.Text = global::vMixMonitor.Properties.Settings.Default.OutroInput;
            // 
            // cbUseTestStream
            // 
            this.cbUseTestStream.AutoSize = true;
            this.cbUseTestStream.Checked = global::vMixMonitor.Properties.Settings.Default.isTestStream;
            this.cbUseTestStream.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::vMixMonitor.Properties.Settings.Default, "isTestStream", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbUseTestStream.ForeColor = System.Drawing.Color.Blue;
            this.cbUseTestStream.Location = new System.Drawing.Point(563, 116);
            this.cbUseTestStream.Name = "cbUseTestStream";
            this.cbUseTestStream.Size = new System.Drawing.Size(105, 17);
            this.cbUseTestStream.TabIndex = 8;
            this.cbUseTestStream.Text = "Use Test Stream";
            this.cbUseTestStream.UseVisualStyleBackColor = true;
            // 
            // cbAudioIsMaster
            // 
            this.cbAudioIsMaster.AutoSize = true;
            this.cbAudioIsMaster.Checked = global::vMixMonitor.Properties.Settings.Default.IsMasterOutput;
            this.cbAudioIsMaster.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::vMixMonitor.Properties.Settings.Default, "IsMasterOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbAudioIsMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAudioIsMaster.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cbAudioIsMaster.Location = new System.Drawing.Point(563, 79);
            this.cbAudioIsMaster.Name = "cbAudioIsMaster";
            this.cbAudioIsMaster.Size = new System.Drawing.Size(231, 24);
            this.cbAudioIsMaster.TabIndex = 7;
            this.cbAudioIsMaster.Text = "Audio Input is Master Output";
            this.cbAudioIsMaster.UseVisualStyleBackColor = true;
            // 
            // tbAudioInpu
            // 
            this.tbAudioInpu.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vMixMonitor.Properties.Settings.Default, "AudiouInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAudioInpu.Location = new System.Drawing.Point(233, 116);
            this.tbAudioInpu.Name = "tbAudioInpu";
            this.tbAudioInpu.Size = new System.Drawing.Size(233, 20);
            this.tbAudioInpu.TabIndex = 6;
            this.tbAudioInpu.Text = global::vMixMonitor.Properties.Settings.Default.AudiouInput;
            // 
            // tbTimerInput
            // 
            this.tbTimerInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vMixMonitor.Properties.Settings.Default, "TimerKeyword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbTimerInput.Location = new System.Drawing.Point(233, 83);
            this.tbTimerInput.Name = "tbTimerInput";
            this.tbTimerInput.Size = new System.Drawing.Size(233, 20);
            this.tbTimerInput.TabIndex = 3;
            this.tbTimerInput.Text = global::vMixMonitor.Properties.Settings.Default.TimerKeyword;
            // 
            // tbUrl
            // 
            this.tbUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::vMixMonitor.Properties.Settings.Default, "vMixUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbUrl.Location = new System.Drawing.Point(233, 48);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(233, 20);
            this.tbUrl.TabIndex = 2;
            this.tbUrl.Text = global::vMixMonitor.Properties.Settings.Default.vMixUrl;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 956);
            this.Controls.Add(this.lblMicStatus);
            this.Controls.Add(this.lblActiveInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelOnlineStatus);
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Name = "MainForm";
            this.Text = "vMIX MONITOR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOnlineStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTimerInput;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAudioInpu;
        private System.Windows.Forms.CheckBox cbAudioIsMaster;
        private System.Windows.Forms.Label lblActiveInput;
        private System.Windows.Forms.Label lblMicStatus;
        private System.Windows.Forms.TextBox tbOutroInpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbUseTestStream;
    }
}

