using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyProfessional
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        [DllImport("user32.dll")]
        public static extern bool EnableWindow(IntPtr hwnd, bool bEnable);

        public Form1()
        {
            InitializeComponent();
        }

        private readonly ucHome _ucHome = new ucHome();
        private readonly ucPassword _ucPassword = new ucPassword();
        private readonly ucMillion _ucMillion = new ucMillion();
        private readonly ucTimer _ucTimer = new ucTimer();
        private readonly ucSettings _ucSettings = new ucSettings();
        private string _note;

        private void _moveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void _buttonsColor()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is Button)
                {
                    var button = item as Button;
                    if (button.BackColor == Color.FromArgb(45, 55, 90))
                    {
                        button.BackColor = Color.Transparent;
                    }
                }
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
            panel3.Controls.Clear();
            panel3.Controls.Add(_ucHome);
            panel4.Location = new Point(195, 74);
            _buttonsColor();
            btnHome.BackColor = Color.FromArgb(45, 55, 90);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(_ucPassword);
            panel4.Location = new Point(195, 139);
            _buttonsColor();
            btnPassword.BackColor = Color.FromArgb(45, 55, 90);
        }

        private void btnMillion_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(_ucMillion);
            panel4.Location = new Point(195, 204);
            _buttonsColor();
            btnMillion.BackColor = Color.FromArgb(45, 55, 90);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(_ucTimer);
            panel4.Location = new Point(195, 269);
            _buttonsColor();
            btnTimer.BackColor = Color.FromArgb(45, 55, 90);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(_ucSettings);
            panel4.Location = new Point(195, 485);
            _buttonsColor();
            btnBackup.BackColor = Color.FromArgb(45, 55, 90);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            if (btnSecurity.Text == " ")
            {
                btnSecurity.Image = Properties.Resources.SecurityOn;
                btnSecurity.Text = "  ";

                _note = _ucHome.txtNote.Text;
                _ucHome.txtNote.Text = null;

                _ucPassword.dgvPassword.DataSource = null;
                _ucMillion.dgvMillion.DataSource = null;

                _ucPassword.ویرایشسطرToolStripMenuItem.Visible = false;
                _ucPassword.حذفسطرToolStripMenuItem.Visible = false;
                _ucPassword.کپیکردنسطرهاToolStripMenuItem.Visible = false;

                _ucMillion.ویرایشسطرToolStripMenuItem.Visible = false;
                _ucMillion.حذفسطرToolStripMenuItem.Visible = false;

                _ucMillion.lblDefaultMoney.Text = "مجموع درآمدها";
            }
            else
            {
                btnSecurity.Image = Properties.Resources.SecurityOff;
                btnSecurity.Text = " ";

                _ucHome.txtNote.Text = _note;

                _ucPassword.dgvPassword.DataSource = _ucPassword.bllPassword.ReadAll();
                _ucMillion.dgvMillion.DataSource = _ucMillion.bllMillion.ReadAll();

                _ucPassword.ویرایشسطرToolStripMenuItem.Visible = true;
                _ucPassword.حذفسطرToolStripMenuItem.Visible = true;
                _ucPassword.کپیکردنسطرهاToolStripMenuItem.Visible = true;

                _ucMillion.ویرایشسطرToolStripMenuItem.Visible = true;
                _ucMillion.حذفسطرToolStripMenuItem.Visible = true;

                _ucMillion.refreshMoney();
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
            _moveForm();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _moveForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .10;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Timer = Convert.ToInt32(_ucTimer.nudTimer.Text);
            Properties.Settings.Default.WarningTimer = Convert.ToInt32(_ucTimer.nudWarningTimer.Text);
            Properties.Settings.Default.Title = _ucTimer.txtTitle.Text;

            Properties.Settings.Default.DefaultMoney = _ucMillion.txtDefaultMoney.Text;

            if (_ucHome.txtNote.Text == "")
            {
                Properties.Settings.Default.Note = _note;
            }
            else
            {
                Properties.Settings.Default.Note = _ucHome.txtNote.Text;
            }

            Properties.Settings.Default.Save();
        }
    }
}
