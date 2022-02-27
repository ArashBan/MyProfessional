using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProfessional
{
    public partial class ucTimer : UserControl
    {
        public ucTimer()
        {
            InitializeComponent();
        }

        private int _minute;
        private int _second;

        private void UCTimer_Load(object sender, EventArgs e)
        {
            btnPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnStop.ForeColor = Color.FromArgb(0, 80, 180);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "شروع")
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnStop.Enabled = true;

                btnStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnPause.ForeColor = Color.FromArgb(0, 126, 249);
                btnStop.ForeColor = Color.FromArgb(0, 126, 249);

                _minute = (int)nudTimer.Value;
                if (_minute <= 9)
                {
                    lblMinute.Text = "0";
                    lblMinute.Text += _minute.ToString();
                }
                else
                {
                    lblMinute.Text = _minute.ToString();
                }
                timer1.Interval = (int)nudTimer.Value * 1000 * 60;
                lblSecond.Text = "00";
                timer1.Start();
                timer2.Start();
                btnStart.Text = "ادامه";
            }
            else if (btnStart.Text == "ادامه")
            {
                timer1.Start();
                timer2.Start();

                btnStart.Enabled = false;
                btnPause.Enabled = true;

                btnStart.ForeColor = Color.FromArgb(0, 80, 180);
                btnPause.ForeColor = Color.FromArgb(0, 126, 249);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            btnStart.Enabled = true;
            btnPause.Enabled = false;

            btnStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnPause.ForeColor = Color.FromArgb(0, 80, 180);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            lblMinute.Text = "00";
            lblSecond.Text = "00";
            _second = 0;

            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnStart.ForeColor = Color.FromArgb(0, 126, 249);
            btnPause.ForeColor = Color.FromArgb(0, 80, 180);
            btnStop.ForeColor = Color.FromArgb(0, 80, 180);
            btnStart.Text = "شروع";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = nudTimer.Text + " دقیقه تمام شده است!";
            notifyIcon1.BalloonTipText = txtTitle.Text;
            notifyIcon1.Icon = SystemIcons.Information;

            notifyIcon1.ShowBalloonTip(1);

            timer1.Interval = (int)nudWarningTimer.Value * 1000;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_minute <= 10)
            {
                if (_second <= 59 && _second >= 11)
                {
                    _second -= 1;
                    lblSecond.Text = _second.ToString();
                }
                else
                {
                    lblSecond.Text = "0";
                    _second -= 1;
                    lblSecond.Text += _second.ToString();
                }

                if (_second < 0)
                {
                    lblMinute.Text = "0";
                    _minute -= 1;
                    lblMinute.Text += _minute.ToString();
                    _second = 59;
                    lblSecond.Text = _second.ToString();
                }
            }

            else
            {
                if (_second <= 59 && _second >= 11)
                {
                    _second -= 1;
                    lblSecond.Text = _second.ToString();
                }
                else
                {
                    lblSecond.Text = "0";
                    _second -= 1;
                    lblSecond.Text += _second.ToString();
                }

                if (_second < 0)
                {
                    _minute -= 1;
                    lblMinute.Text = _minute.ToString();
                    _second = 59;
                    lblSecond.Text = _second.ToString();
                }
            }

            if (_minute == 0 && _second == 0)
            {
                lblMinute.Text = "00";
                lblSecond.Text = "00";
                _second = 0;
                btnPause.Enabled = false;
                btnPause.ForeColor = Color.FromArgb(0, 80, 180);
                timer1_Tick(this, new EventArgs());
                timer2.Stop();
            }
        }
    }
}
