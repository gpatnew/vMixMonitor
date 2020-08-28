using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace vMixMonitor
{
    public partial class MainForm : Form
    {
        string countDown;
        Font countDownFont;
        SolidBrush countDownBrush;
        DateTime endTime;
        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer countDownTimer;
        vMixHelper vmixhelper = new vMixHelper();
        bool online = false;
        bool streaming = false;
        public MainForm()
        {
            InitializeComponent();
            this.groupBox1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

                countDownTimer = new System.Windows.Forms.Timer();
                timer = new System.Windows.Forms.Timer();

                countDownFont = new Font(new FontFamily("Arial"), 80, FontStyle.Bold);
                countDownBrush = new SolidBrush(Color.Green);

                timer.Tick += Timer_Tick;
                timer.Interval = 500;
                countDownTimer.Tick += CountDownTimer_Tick;
                this.Paint += new PaintEventHandler(MainForm_Paint);

                this.DoubleBuffered = true;
                this.ResizeRedraw = true;
                countDownTimer.Interval = 5;

                timer.Start();
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            vmixhelper.RefreshDoc();
            endTime = vmixhelper.endTime;
            online = vmixhelper.onLine;
            streaming = vmixhelper.streaming;
            SetLabels();
            if (online && streaming)
            {                
                this.labelOnlineStatus.Text = "STREAMING ON";
                this.labelOnlineStatus.BackColor = Color.Black;
                this.labelOnlineStatus.ForeColor = Color.Red;
            }
            else if(online)
            {
                this.labelOnlineStatus.Text = "OFFLINE";
                this.labelOnlineStatus.BackColor = Color.AliceBlue;
                this.labelOnlineStatus.ForeColor = Color.Gray;
                countDown = "";
                Refresh();
            }
            else
            {
                this.labelOnlineStatus.Text = "Not connected";
                this.labelOnlineStatus.BackColor = Color.AliceBlue;
                this.labelOnlineStatus.ForeColor = Color.Gray;
            }

            if (vmixhelper.timerState == Data.@enum.InputState.Running && !countDownTimer.Enabled)
            {
                countDownTimer.Start();
            }
            else if(vmixhelper.timerState != Data.@enum.InputState.Running)
            {
                countDownTimer.Stop();
            }

        }

        private void SetLabels()
        {
            if (vmixhelper.audioVolume > 0 && streaming)
            {
                lblMicStatus.Text = "MIC LIVE";
                lblMicStatus.ForeColor = Color.OrangeRed;
                lblMicStatus.BackColor = Color.Black;
            }
            else if(vmixhelper.audioVolume >= 0 && !streaming)
            {
                lblMicStatus.Text = "MIC OFF";
                lblMicStatus.ForeColor = Color.AliceBlue;
                lblMicStatus.BackColor = Color.Black;
            }
            else if(vmixhelper.audioVolume < 0)
            {
                lblMicStatus.Text = "DISCONNECTED";
                lblMicStatus.ForeColor = Color.AliceBlue;
                lblMicStatus.BackColor = Color.Black;
            }
            lblActiveInput.Text = vmixhelper.activeInput != null ? vmixhelper.activeInput.shortTitle : "CAMERA INPUT";
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Size size = Size.Ceiling(e.Graphics.MeasureString(countDown, countDownFont));
            e.Graphics.DrawString(countDown, countDownFont, countDownBrush, ((this.Width - 4) / 2) - (size.Width / 2), ((this.Height - 32) / 2) - (size.Height / 2));
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = DateTime.Now.Subtract(endTime);
            if(leftTime.TotalMinutes <= 1 &&leftTime.TotalSeconds < 1 && streaming)
            {
                countDown = "LIVE";
                countDownBrush.Color = Color.Red;
                countDownTimer.Stop();
            }
            else if (online && streaming)
            {
                countDown = leftTime.Minutes.ToString("00") + ":" + leftTime.Seconds.ToString("00") + ":" + (leftTime.Milliseconds / 10).ToString("00");
                countDownBrush.Color = Color.Black;
            }
            else if (online)
            {
                countDown = leftTime.Minutes.ToString("00") + ":" + leftTime.Seconds.ToString("00") + ":" + (leftTime.Milliseconds / 10).ToString("00")  + " Testing ";
                countDownBrush.Color = Color.Green;
            }
            else
            {
                countDown = " off ";
                countDownBrush.Color = Color.Green;
            }
            Refresh();
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = !groupBox1.Visible;
            this.tbUrl.Text = Properties.Settings.Default.vMixUrl;
            this.tbTimerInput.Text = Properties.Settings.Default.TimerKeyword;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.vMixUrl = this.tbUrl.Text;
            Properties.Settings.Default.TimerKeyword = this.tbTimerInput.Text;
            Properties.Settings.Default.IsMasterOutput = this.cbAudioIsMaster.Checked;
            Properties.Settings.Default.isTestStream = this.cbUseTestStream.Checked;
            Properties.Settings.Default.OutroInput = this.tbOutroInpu.Text;
            Properties.Settings.Default.Save();

            this.groupBox1.Visible = false;
        }

    }
}
