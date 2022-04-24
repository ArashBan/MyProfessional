using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProfessional
{
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
        }

        private readonly FolderBrowserDialog _fdb = new FolderBrowserDialog();

        private void UcHome_Load(object sender, EventArgs e)
        {
            lblTodayCalender.Text = DateTime.Now.ToString("\r\ndddd، dd MMMM ماه yyyy\r\n");

            if (lblTodayCalender.Text.Contains("سه شنبه") || lblTodayCalender.Text.Contains("پنجشنبه") ||
                lblTodayCalender.Text.Contains("جمعه")) lblTodayCalender.Text += "امروز رو شیفت صبحیم!";

            else if (lblTodayCalender.Text.Contains("یکشنبه") || lblTodayCalender.Text.Contains("دوشنبه") ||
                     lblTodayCalender.Text.Contains("چهارشنبه")) lblTodayCalender.Text += "امروز رو شیفت شبیم!";

            else lblTodayCalender.Text += "امروز رو تعطیلیم!";
        }

        private void lblLine_Click(object sender, EventArgs e)
        {
            txtNote.Text += "\r\n---------------------------------------------------------\r\n";
            txtNote.Select(txtNote.Text.Length, 0);
            txtNote.Focus();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = txtNote.Text.Length + "/2000";
        }

        private void btnQuickAccessAddress_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                btnQuickAccessAddress.Text = "ذخیره";
                btnQuickAccessAddress.Width = 163;
                btnQuickAccessAddress.BringToFront();
                lblQuickAccess.Text = "انتخاب کنید...";
            }
            else
            {
                btnQuickAccessAddress.Text = "مسیر";
                btnQuickAccessAddress.Width = 80;
                lblQuickAccess.Text = "دسترسی سریع";
            }
        }

        private void btnQuickAccessName_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessName.Text == "نام")
            {
                btnQuickAccessName.Text = "ذخیره";
                btnQuickAccessName.Width = 163;
                btnQuickAccessName.BringToFront();
                btnQuickAccessName.Location = new Point(3, 6);
                lblQuickAccess.Text = "انتخاب کنید...";

                txtQuickAccessName1.Visible = true;
                btnQuickAccess1.Visible = false;
                txtQuickAccessName1.Text = Properties.Settings.Default.QuickAccessName1;

                txtQuickAccessName2.Visible = true;
                btnQuickAccess2.Visible = false;
                txtQuickAccessName2.Text = Properties.Settings.Default.QuickAccessName2;

                txtQuickAccessName3.Visible = true;
                btnQuickAccess3.Visible = false;
                txtQuickAccessName3.Text = Properties.Settings.Default.QuickAccessName3;

                txtQuickAccessName4.Visible = true;
                btnQuickAccess4.Visible = false;
                txtQuickAccessName4.Text = Properties.Settings.Default.QuickAccessName4;

                txtQuickAccessName5.Visible = true;
                btnQuickAccess5.Visible = false;
                txtQuickAccessName5.Text = Properties.Settings.Default.QuickAccessName5;

                txtQuickAccessName6.Visible = true;
                btnQuickAccess6.Visible = false;
                txtQuickAccessName6.Text = Properties.Settings.Default.QuickAccessName6;

                txtQuickAccessName7.Visible = true;
                btnQuickAccess7.Visible = false;
                txtQuickAccessName7.Text = Properties.Settings.Default.QuickAccessName7;
            }
            else
            {
                btnQuickAccessName.Text = "نام";
                btnQuickAccessName.Width = 80;
                btnQuickAccessName.Location = new Point(86, 6);
                lblQuickAccess.Text = "دسترسی سریع";

                txtQuickAccessName1.Visible = false;
                btnQuickAccess1.Visible = true;
                btnQuickAccess1.Text = txtQuickAccessName1.Text;
                Properties.Settings.Default.QuickAccessName1 = txtQuickAccessName1.Text;

                txtQuickAccessName2.Visible = false;
                btnQuickAccess2.Visible = true;
                btnQuickAccess2.Text = txtQuickAccessName2.Text;
                Properties.Settings.Default.QuickAccessName2 = txtQuickAccessName2.Text;

                txtQuickAccessName3.Visible = false;
                btnQuickAccess3.Visible = true;
                btnQuickAccess3.Text = txtQuickAccessName3.Text;
                Properties.Settings.Default.QuickAccessName3 = txtQuickAccessName3.Text;

                txtQuickAccessName4.Visible = false;
                btnQuickAccess4.Visible = true;
                btnQuickAccess4.Text = txtQuickAccessName4.Text;
                Properties.Settings.Default.QuickAccessName4 = txtQuickAccessName4.Text;

                txtQuickAccessName5.Visible = false;
                btnQuickAccess5.Visible = true;
                btnQuickAccess5.Text = txtQuickAccessName5.Text;
                Properties.Settings.Default.QuickAccessName5 = txtQuickAccessName5.Text;

                txtQuickAccessName6.Visible = false;
                btnQuickAccess6.Visible = true;
                btnQuickAccess6.Text = txtQuickAccessName6.Text;
                Properties.Settings.Default.QuickAccessName6 = txtQuickAccessName6.Text;

                txtQuickAccessName7.Visible = false;
                btnQuickAccess7.Visible = true;
                btnQuickAccess7.Text = txtQuickAccessName7.Text;
                Properties.Settings.Default.QuickAccessName7 = txtQuickAccessName7.Text;
            }
        }

        #region QuickAccess
        private void btnQuickAccess1_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress1);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress1 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess2_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress2);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress2 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess3_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress3);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress3 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess4_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress4);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress4 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess5_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress5);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress5 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess6_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress6);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress6 = _fdb.SelectedPath;
            }
        }

        private void btnQuickAccess7_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessAddress.Text == "مسیر")
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress7);
            }
            else
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress7 = _fdb.SelectedPath;
            }
        }
        #endregion
    }
}
