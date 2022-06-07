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
                lblTodayCalender.Text.Contains("جمعه")) lblTodayCalender.Text += "امروز 8 تا 13 شیفتیم (صبح)!";

            else if (lblTodayCalender.Text.Contains("یکشنبه") || lblTodayCalender.Text.Contains("دوشنبه") ||
                     lblTodayCalender.Text.Contains("چهارشنبه")) lblTodayCalender.Text += "امروز 18 تا 23 شیفتیم (شب)!";

            else lblTodayCalender.Text += "امروز رو تعطیلیم!";
        }

        public void lblLine_Click(object sender, EventArgs e)
        {
            //txtNote.Text += "\r\n---------------------------------------------------------\r\n";
            //txtNote.Select(txtNote.Text.Length, 0);
            //txtNote.Focus();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            //lblLength.Text = txtNote.Text.Length + "/2000";
        }

        private void btnQuickAccessAddress_Click(object sender, EventArgs e)
        {
        }

        private void btnQuickAccessName_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessSave.Visible == false)
            {
                btnQuickAccessSave.Visible = true;
                btnEditQuickAccess.Visible = false;
                btnAddressQuickAccess.Visible = false;
                lblQuickAccess.Text = "نام دکمه ها را انتخاب کنید";

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnQuickAccessSave.Visible == false)
            {
                btnQuickAccessSave.Visible = true;
                btnEditQuickAccess.Visible = false;
                btnAddressQuickAccess.Visible = false;
                lblQuickAccess.Text = "مسیر دکمه ها را انتخاب کنید";
            }
        }

        #region QuickAccess
        private void btnQuickAccess1_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress1 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress1);
            }
        }

        private void btnQuickAccess2_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress2 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress2);
            }
        }

        private void btnQuickAccess3_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress3 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress3);
            }
        }

        private void btnQuickAccess4_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress4 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress4);
            }
        }

        private void btnQuickAccess5_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress5 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress5);
            }
        }

        private void btnQuickAccess6_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress6 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress6);
            }
        }

        private void btnQuickAccess7_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "مسیر دکمه ها را انتخاب کنید")
            {
                if (_fdb.ShowDialog() == DialogResult.OK) Properties.Settings.Default.QuickAccessAddress7 = _fdb.SelectedPath;
            }
            else
            {
                _ = System.Diagnostics.Process.Start(Properties.Settings.Default.QuickAccessAddress7);
            }
        }
        #endregion

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) label1.Font = new Font(label1.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked) label3.Font = new Font(label3.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked) label4.Font = new Font(label4.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked) label5.Font = new Font(label5.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked) label6.Font = new Font(label6.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label6.Font = new Font(label6.Font, FontStyle.Bold);
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked) label7.Font = new Font(label7.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label7.Font = new Font(label7.Font, FontStyle.Bold);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked) label8.Font = new Font(label8.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label8.Font = new Font(label8.Font, FontStyle.Bold);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked) label9.Font = new Font(label9.Font, FontStyle.Strikeout | FontStyle.Bold);
            else label9.Font = new Font(label9.Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font, FontStyle.Bold);
                checkBox1.Checked = false;
            }
            else if (!checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox1.Checked = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label3.Font = new Font(label3.Font, FontStyle.Bold);
                checkBox2.Checked = false;
            }
            else if (!checkBox2.Checked)
            {
                label3.Font = new Font(label3.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox2.Checked = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label4.Font = new Font(label4.Font, FontStyle.Bold);
                checkBox3.Checked = false;
            }
            else if (!checkBox3.Checked)
            {
                label4.Font = new Font(label4.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox3.Checked = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label5.Font = new Font(label5.Font, FontStyle.Bold);
                checkBox4.Checked = false;
            }
            else if (!checkBox4.Checked)
            {
                label5.Font = new Font(label5.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox4.Checked = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                label6.Font = new Font(label6.Font, FontStyle.Bold);
                checkBox5.Checked = false;
            }
            else if (!checkBox5.Checked)
            {
                label6.Font = new Font(label6.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox5.Checked = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                label7.Font = new Font(label7.Font, FontStyle.Bold);
                checkBox6.Checked = false;
            }
            else if (!checkBox6.Checked)
            {
                label7.Font = new Font(label7.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox6.Checked = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                label8.Font = new Font(label8.Font, FontStyle.Bold);
                checkBox7.Checked = false;
            }
            else if (!checkBox7.Checked)
            {
                label8.Font = new Font(label8.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox7.Checked = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                label9.Font = new Font(label9.Font, FontStyle.Bold);
                checkBox8.Checked = false;
            }
            else if (!checkBox8.Checked)
            {
                label9.Font = new Font(label9.Font, FontStyle.Strikeout | FontStyle.Bold);
                checkBox8.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblQuickAccess.Text == "نام دکمه ها را انتخاب کنید")
            {
                btnQuickAccessSave.Visible = false;
                btnEditQuickAccess.Visible = true;
                btnAddressQuickAccess.Visible = true;
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
            else
            {
                btnQuickAccessSave.Visible = false;
                btnEditQuickAccess.Visible = true;
                btnAddressQuickAccess.Visible = true;
                lblQuickAccess.Text = "دسترسی سریع";

                txtQuickAccessName1.Visible = false;
                btnQuickAccess1.Visible = true;
                btnQuickAccess1.Text = Properties.Settings.Default.QuickAccessName1;

                txtQuickAccessName2.Visible = false;
                btnQuickAccess2.Visible = true;
                btnQuickAccess2.Text = Properties.Settings.Default.QuickAccessName2;

                txtQuickAccessName3.Visible = false;
                btnQuickAccess3.Visible = true;
                btnQuickAccess3.Text = Properties.Settings.Default.QuickAccessName3;

                txtQuickAccessName4.Visible = false;
                btnQuickAccess4.Visible = true;
                btnQuickAccess4.Text = Properties.Settings.Default.QuickAccessName4;

                txtQuickAccessName5.Visible = false;
                btnQuickAccess5.Visible = true;
                btnQuickAccess5.Text = Properties.Settings.Default.QuickAccessName5;

                txtQuickAccessName6.Visible = false;
                btnQuickAccess6.Visible = true;
                btnQuickAccess6.Text = Properties.Settings.Default.QuickAccessName6;

                txtQuickAccessName7.Visible = false;
                btnQuickAccess7.Visible = true;
                btnQuickAccess7.Text = Properties.Settings.Default.QuickAccessName7;
            }
        }

        private void btnReminderSave_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            btnReminderSave.Visible = false;
            btnEditReminder.Visible = true;

            label1.Text = textBox1.Text;
            label3.Text = textBox2.Text;
            label4.Text = textBox3.Text;
            label5.Text = textBox4.Text;
            label6.Text = textBox5.Text;
            label7.Text = textBox6.Text;
            label8.Text = textBox7.Text;
            label9.Text = textBox8.Text;
        }

        private void btnEditReminder_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            btnReminderSave.Visible = true;
            btnEditReminder.Visible = false;

            textBox1.Text = label1.Text;
            textBox2.Text = label3.Text;
            textBox3.Text = label4.Text;
            textBox4.Text = label5.Text;
            textBox5.Text = label6.Text;
            textBox6.Text = label7.Text;
            textBox7.Text = label8.Text;
            textBox8.Text = label9.Text;
        }
    }
}
