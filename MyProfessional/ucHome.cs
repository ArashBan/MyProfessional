using System;
using System.Windows.Forms;

namespace MyProfessional
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            lblTodayCalender.Text = DateTime.Now.ToString("" + "\r\n" + "dddd، dd MMMM ماه yyyy" + "\r\n");

            if (lblTodayCalender.Text.Contains("یکشنبه") || lblTodayCalender.Text.Contains("سه شنبه") ||
                lblTodayCalender.Text.Contains("پنجشنبه"))
            {
                lblTodayCalender.Text += "امروز رو شیفت صبحیم!";
            }
            else if (lblTodayCalender.Text.Contains("دوشنبه") || lblTodayCalender.Text.Contains("چهارشنبه") ||
                     lblTodayCalender.Text.Contains("جمعه"))
            {
                lblTodayCalender.Text += "امروز رو شیفت شبیم!";
            }
            else
            {
                lblTodayCalender.Text += "امروز رو تعطیلیم!";
            }
        }

        private void lblLine_Click(object sender, EventArgs e)
        {
            txtNote.Select(10, 11);
            txtNote.Text += @"" + "\r\n" + "---------------------------------------------------------" + "\r\n";
            txtNote.Focus();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = txtNote.Text.Length.ToString() + "/2000";
        }

        #region QuickAccess
        private void btnVisualProjectPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Arash\source\repos");
        }

        private void btnAtriya_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Programming\Education\Coding\Atria\ASP.NET");
        }

        private void btnVikings_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Film\Vikings");
        }

        private void btnThe100_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Film\The 100");
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Programming\برنامه هفتگی.pdf");
        }

        private void btnProgramming_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Programming");
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Film");
        }
        #endregion
    }
}