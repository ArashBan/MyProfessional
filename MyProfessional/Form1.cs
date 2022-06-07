using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyProfessional
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool EnableWindow(IntPtr hwnd, bool bEnable);

        public Form1()
        {
            InitializeComponent();
        }

        private readonly UcHome _ucHome = new UcHome();
        private readonly UcPassword _ucPassword = new UcPassword();
        private readonly UcMillion _ucMillion = new UcMillion();
        private readonly UcTimer _ucTimer = new UcTimer();
        private readonly UcSettings _ucSettings = new UcSettings();
        public string securityStatus = "Off";

        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void LoadButtons(UserControl us)
        {
            foreach (var item in panel1.Controls)
            {
                if (item is Button)
                {
                    var button = item as Button;
                    if (button.BackColor == Color.FromArgb(45, 55, 90)) button.BackColor = Color.Transparent;
                }
            }
            panel3.Controls.Clear();
            panel3.Controls.Add(us);
            if (us == _ucHome)
            {
                panel4.Location = new Point(194, 74);
                btnHome.BackColor = Color.FromArgb(45, 55, 90);
            }
            else if (us == _ucPassword)
            {
                panel4.Location = new Point(194, 144);
                btnPassword.BackColor = Color.FromArgb(45, 55, 90);
            }
            else if (us == _ucMillion)
            {
                panel4.Location = new Point(194, 214);
                btnMillion.BackColor = Color.FromArgb(45, 55, 90);
            }
            else if (us == _ucTimer)
            {
                panel4.Location = new Point(194, 284);
                btnTimer.BackColor = Color.FromArgb(45, 55, 90);
            }
            else if (us == _ucSettings)
            {
                panel4.Location = new Point(194, 480);
                btnSettings.BackColor = Color.FromArgb(45, 55, 90);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPassword_Click(this, new EventArgs());
            btnMillion_Click(this, new EventArgs());
            btnHome_Click(this, new EventArgs());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadButtons(_ucHome);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            LoadButtons(_ucPassword);
        }

        private void btnMillion_Click(object sender, EventArgs e)
        {
            LoadButtons(_ucMillion);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            LoadButtons(_ucTimer);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadButtons(_ucSettings);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            //WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            if (securityStatus == "Off")
            {
                btnSecurity.Image = Properties.Resources.SecurityOn;
                securityStatus = "On";
                _ucMillion.securityStatusMillion = securityStatus;
                _ucPassword.securityStatusPassword = securityStatus;

                //_ucHome.txtNote.Enabled = false;
                //_ucHome.txtNote.ForeColor = Color.FromArgb(240, 240, 240);

                _ucPassword.dgvPassword.DataSource = null;
                _ucMillion.dgvMillion.DataSource = null;

                _ucPassword.ویرایشسطرToolStripMenuItem.Visible = false;
                _ucPassword.حذفسطرToolStripMenuItem.Visible = false;
                _ucPassword.کپیکردنسطرهاToolStripMenuItem.Visible = false;

                _ucMillion.ویرایشسطرToolStripMenuItem.Visible = false;
                _ucMillion.حذفسطرToolStripMenuItem.Visible = false;

                _ucMillion.lblDefaultMoney.Text = "مجموع درآمد!";
            }
            else
            {
                btnSecurity.Image = Properties.Resources.SecurityOff;
                securityStatus = "Off";
                _ucMillion.securityStatusMillion = securityStatus;
                _ucPassword.securityStatusPassword = securityStatus;

                //_ucHome.txtNote.Enabled = true;
                //_ucHome.txtNote.ForeColor = Color.Black;

                _ucPassword.dgvPassword.DataSource = _ucPassword.BllPassword.ReadAll();
                _ucMillion.dgvMillion.DataSource = _ucMillion.BllMillion.ReadAll();

                _ucPassword.ویرایشسطرToolStripMenuItem.Visible = true;
                _ucPassword.حذفسطرToolStripMenuItem.Visible = true;
                _ucPassword.کپیکردنسطرهاToolStripMenuItem.Visible = true;

                _ucMillion.ویرایشسطرToolStripMenuItem.Visible = true;
                _ucMillion.حذفسطرToolStripMenuItem.Visible = true;

                _ucMillion.RefreshMoney();
            }
        }

        public void btnLock_Click(object sender, EventArgs e)
        {
            if (TopMost == false)
            {
                btnLock.Image = Properties.Resources.Lock;
                TopMost = true;
            }
            else
            {
                btnLock.Image = Properties.Resources.UnLock;
                TopMost = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .10;
            if (Opacity == 100) timer1.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Timer = Convert.ToInt32(_ucTimer.nudTimer.Text);
            Properties.Settings.Default.WarningTimer = Convert.ToInt32(_ucTimer.nudWarningTimer.Text);
            Properties.Settings.Default.Title = _ucTimer.txtTitle.Text;

            Properties.Settings.Default.DefaultMoney = _ucMillion.txtDefaultMoney.Text;

            //Properties.Settings.Default.Note = _ucHome.txtNote.Text;

            Properties.Settings.Default.Save();
        }

        private void btnQuickAccessName_Click(object sender, EventArgs e)
        {

        }
    }
}
