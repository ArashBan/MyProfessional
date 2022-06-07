using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace MyProfessional
{
    public partial class UcTimer : UserControl
    {
        public UcTimer()
        {
            InitializeComponent();
        }

        private int _timerMinute;
        private int _timerSecond;
        private int _cronometerMinute;
        private int _cronometerSecond;
        private int _cronometerMiniSecond;

        private void UcTimer_Load(object sender, EventArgs e)
        {
            btnTimerPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnTimerStop.ForeColor = Color.FromArgb(0, 80, 180);

            btnCronometerPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnCronometerStop.ForeColor = Color.FromArgb(0, 80, 180);
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            if (btnTimerStart.Text == "شروع")
            {
                btnTimerStart.Enabled = false;
                btnTimerPause.Enabled = true;
                btnTimerStop.Enabled = true;

                btnTimerStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnTimerPause.ForeColor = Color.FromArgb(0, 126, 249);
                btnTimerStop.ForeColor = Color.FromArgb(0, 126, 249);

                _timerMinute = (int)nudTimer.Value;
                lblTimerMinute.Text = _timerMinute.ToString("00");

                timer1.Interval = (int)nudTimer.Value * 1000 * 60;
                lblTimerSecond.Text = "00";
                btnTimerStart.Text = "ادامه";
            }
            else if (btnTimerStart.Text == "ادامه")
            {
                btnTimerStart.Enabled = false;
                btnTimerPause.Enabled = true;

                btnTimerStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnTimerPause.ForeColor = Color.FromArgb(0, 126, 249);
            }
        }

        private void btnTimerPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            btnTimerStart.Enabled = true;
            btnTimerPause.Enabled = false;

            btnTimerStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnTimerPause.ForeColor = Color.FromArgb(0, 80, 180);
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            lblTimerMinute.Text = "00";
            lblTimerSecond.Text = "00";
            _timerSecond = 0;

            btnTimerStart.Enabled = true;
            btnTimerPause.Enabled = false;
            btnTimerStop.Enabled = false;
            btnTimerStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnTimerPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnTimerStop.ForeColor = Color.FromArgb(0, 80, 180);
            btnTimerStart.Text = "شروع";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = $"تایمر {nudTimer.Text} دقیقه تمام شده است!";
            notifyIcon1.BalloonTipText = txtTitle.Text;
            notifyIcon1.Icon = SystemIcons.Information;

            notifyIcon1.ShowBalloonTip(1);

            timer1.Interval = (int)nudWarningTimer.Value * 1000;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _timerSecond--;
            lblTimerSecond.Text = _timerSecond.ToString("00");

            if (_timerSecond < 0)
            {
                _timerSecond = 59;
                lblTimerSecond.Text = _timerSecond.ToString("00");
                _timerMinute--;
                lblTimerMinute.Text = _timerMinute.ToString("00");
            }

            if (_timerMinute == 0 && _timerSecond == 0)
            {
                lblTimerMinute.Text = "00";
                lblTimerSecond.Text = "00";
                _timerSecond = 0;
                btnTimerPause.Enabled = false;
                btnTimerPause.ForeColor = Color.FromArgb(0, 80, 180);
                timer1.Start();
                timer2.Stop();



                Form1 _form1 = new Form1();
                _form1.WindowState = FormWindowState.Normal;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            _cronometerMiniSecond++;
            lblCronometerMiniSecond.Text = _cronometerMiniSecond.ToString("00");

            if (_cronometerMiniSecond > 59)
            {
                _cronometerSecond++;
                lblCronometerSecond.Text = _cronometerSecond.ToString("00");
                _cronometerMiniSecond = 0;
                lblCronometerMiniSecond.Text = _cronometerMiniSecond.ToString("00");
            }

            if (_cronometerSecond > 59)
            {
                _cronometerMinute++;
                lblCronometerMinute.Text = _cronometerMinute.ToString("00");
                _cronometerSecond = 0;
                lblCronometerSecond.Text = _cronometerSecond.ToString("00");
            }
        }

        private void btnCronometerStart_Click(object sender, EventArgs e)
        {
            timer3.Start();
            if (btnCronometerStart.Text == "شروع")
            {
                btnCronometerStart.Enabled = false;
                btnCronometerPause.Enabled = true;
                btnCronometerStop.Enabled = true;
                btnCronometerMark.Enabled = true;

                btnCronometerStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnCronometerPause.ForeColor = Color.FromArgb(0, 126, 249);
                btnCronometerStop.ForeColor = Color.FromArgb(0, 126, 249);
                btnCronometerMark.ForeColor = Color.FromArgb(0, 126, 249);

                btnCronometerStart.Text = "ادامه";
                btnCronometerMark.Text = "مارک";
            }
            else if (btnCronometerStart.Text == "ادامه")
            {
                btnCronometerStart.Enabled = false;
                btnCronometerPause.Enabled = true;

                btnCronometerStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnCronometerPause.ForeColor = Color.FromArgb(0, 126, 249);

                btnCronometerMark.Text = "مارک";
            }
        }

        private void btnCronometerPause_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            btnCronometerMark.Text = "حذف مارک ها";

            btnCronometerStart.Enabled = true;
            btnCronometerPause.Enabled = false;

            btnCronometerStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnCronometerPause.ForeColor = Color.FromArgb(0, 80, 180);
        }

        private void btnCronometerStop_Click(object sender, EventArgs e)
        {
            timer3.Stop();

            lblCronometerMinute.Text = "00";
            lblCronometerSecond.Text = "00";
            lblCronometerMiniSecond.Text = "00";
            _cronometerMiniSecond = 0;
            _cronometerSecond = 0;
            _cronometerMinute = 0;

            btnCronometerStart.Enabled = true;
            btnCronometerPause.Enabled = false;
            btnCronometerStop.Enabled = false;

            btnCronometerStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnCronometerPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnCronometerStop.ForeColor = Color.FromArgb(0, 80, 180);
            btnCronometerMark.ForeColor = Color.FromArgb(0, 126, 249);

            btnCronometerStart.Text = "شروع";
            btnCronometerMark.Text = "حذف مارک ها";
        }

        private void btnCronometerMark_Click(object sender, EventArgs e)
        {
            if (btnCronometerMark.Text == "حذف مارک ها") listBox1.Items.Clear();
            else listBox1.Items.Add($"+ {lblCronometerMinute.Text}:{lblCronometerSecond.Text}:{lblCronometerMiniSecond.Text}");
        }
    }
}
