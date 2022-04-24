using System;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogic;
using BusinessEntity.Utilities;
using System.Drawing;

namespace MyProfessional
{
    public partial class UcPassword : UserControl
    {
        public UcPassword()
        {
            InitializeComponent();
        }

        public readonly BLLPassword BllPassword = new BLLPassword();
        private int _selectedId;
        private int _selectedRowNumber;
        public string securityStatusPassword = "Off";

        private void ClearControllers()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox textbox:
                        textbox.Clear();
                        break;
                }
            }
            rdbNoneAlgorithm.Checked = true;
        }

        private void MakeSpecialPassword()
        {
            try
            {
                // ¶∆∆-€€¶¶€€-∆∆!
                // =Di-64#%49-la!
                // 13 - 17 = *

                var shapeSample = "=#%@";
                //var wordSample = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

                var firstOneCharLower = txtSiteName.Text.Substring(0, 1).ToLower();
                var firstOneCharUpper = txtSiteName.Text.Substring(0, 1).ToUpper();

                var firstTwoCharLower = txtSiteName.Text.Substring(1, 1).ToLower();
                var firstTwoCharUpper = txtSiteName.Text.Substring(1, 1).ToUpper();

                var lastOneCharLower = txtSiteName.Text.Substring(Math.Max(0, txtSiteName.Text.Length - 2)).ToLower();
                lastOneCharLower = lastOneCharLower.Substring(0, 1);
                var lastOneCharUpper = txtSiteName.Text.Substring(Math.Max(0, txtSiteName.Text.Length - 2)).ToUpper();
                lastOneCharUpper = lastOneCharUpper.Substring(0, 1);

                var lastTwoCharLower = txtSiteName.Text.Substring(Math.Max(0, txtSiteName.Text.Length - 2)).ToLower();
                lastTwoCharLower = lastTwoCharLower.Substring(1, 1);
                var lastTwoCharUpper = txtSiteName.Text.Substring(Math.Max(0, txtSiteName.Text.Length - 2)).ToUpper();
                lastTwoCharUpper = lastTwoCharUpper.Substring(1, 1);


                // ( ¶ ) ∆∆-€€¶¶€€-∆∆!
                var firstShape = RandomString(shapeSample, 1);
                txtPassword.Text = firstShape;
                shapeSample = shapeSample.Replace(firstShape, "");


                // ¶ ( ∆∆- ) €€¶¶€€-∆∆!
                txtPassword.Text += RandomString(firstOneCharLower + firstOneCharUpper, 1);
                txtPassword.Text += RandomString(firstTwoCharLower + firstTwoCharUpper, 1) + "-";


                // ¶∆∆- ( €€ ) ¶¶€€-∆∆!
                txtPassword.Text += txtSiteName.Text.Length * txtSiteName.Text.Length;


                // ¶∆∆-€€ ( ¶¶ ) €€-∆∆!
                var shape2 = RandomString(shapeSample, 1);
                txtPassword.Text += shape2;
                shapeSample = shapeSample.Replace(shape2, "");

                var shape3 = RandomString(shapeSample, 1);
                txtPassword.Text += shape3;
                shapeSample = shapeSample.Replace(shape3, "");
                var wordSample1 = "abcdefghijklmnopqrstuvwxyz";


                // ¶∆∆-€€¶¶ ( €€- ) ∆∆!
                for (int i = 1; i <= 26; i++)
                {
                    var wordSample2 = wordSample1.Substring(0, 1);

                    if (firstOneCharLower == wordSample2)
                    {
                        txtPassword.Text += i.ToString();
                        break;
                    }
                    wordSample1 = wordSample1.Replace(wordSample2, "");
                }

                wordSample1 = "abcdefghijklmnopqrstuvwxyz";

                for (int i = 1; i <= 26; i++)
                {
                    var wordSample2 = wordSample1.Substring(0, 1);

                    if (lastOneCharLower == wordSample2)
                    {
                        txtPassword.Text += i + "-";
                        break;
                    }
                    wordSample1 = wordSample1.Replace(wordSample2, "");
                }


                // ¶∆∆-€€¶¶€€- ( ∆∆! )
                txtPassword.Text += RandomString(lastOneCharLower + lastOneCharUpper, 1);
                txtPassword.Text += RandomString(lastTwoCharLower + lastTwoCharUpper, 1) + "!";

            }
            catch (Exception) { txtPassword.Text = null; }
        }

        private void MakeRandomPassword()
        {
            if (txtSiteName.Text.Trim().Length >= 1) txtPassword.Text = RandomString("=#%@!0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz", 18);
            else txtPassword.Text = null;
        }

        private string RandomString(string chars, int length)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                var randomChar = chars[random.Next(0, chars.Length)];
                sb.Append(randomChar);
            }
            return sb.ToString();
        }

        private void LoadDgv()
        {
            dgvPassword.DataSource = BllPassword.ReadAll();
            if (dgvPassword.CurrentRow != null) dgvPassword.ContextMenuStrip = contextMenuStrip1;
        }

        private void UcPassword_Load(object sender, EventArgs e)
        {
            btnChangePassword.ForeColor = Color.FromArgb(0, 80, 180);
            dgvPassword.AutoGenerateColumns = false;
            LoadDgv();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (btnRegist.Text == "ذخیره سازی")
            {
                if (txtPassword.Text.Trim().Length == 0)
                {
                    _ = CustomMessageBox.ShowMessageBox("!فیلد پسوورد نباید خالی باشه", CustomMessageBox.Status.Error);
                }
                else
                {
                    var password = new Password(txtSiteName.Text, txtUsername.Text,
                        txtEmail.Text, txtPassword.Text);
                    BllPassword.Create(password);
                    _ = CustomMessageBox.ShowMessageBox("!پسوورد جدید با موفقیت ثبت شد",
                        CustomMessageBox.Status.Information);
                    ClearControllers();
                    if (securityStatusPassword == "Off") LoadDgv();
                }
            }
            else
            {
                if (txtPassword.Text.Trim().Length == 0)
                {
                    _ = CustomMessageBox.ShowMessageBox("!فیلد پسوورد نباید خالی باشه", CustomMessageBox.Status.Error);
                }
                else
                {
                    var password = new Password(txtSiteName.Text, txtUsername.Text,
                        txtEmail.Text, txtPassword.Text);
                    BllPassword.Edit(password, _selectedId);
                    _ = CustomMessageBox.ShowMessageBox($"!سطر {_selectedRowNumber} با موفقیت ویرایش شد",
                        CustomMessageBox.Status.Information);
                    ClearControllers();
                    if (securityStatusPassword == "Off") LoadDgv();
                    btnRegist.Text = "ذخیره سازی";
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
            txtPassword.Copy();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (rdbSpecialAlgorithm.Checked) MakeSpecialPassword();
            else if (rdbRandomAlgorithm.Checked) MakeRandomPassword();
        }

        private void txtSiteName_TextChanged(object sender, EventArgs e)
        {
            if (rdbSpecialAlgorithm.Checked) MakeSpecialPassword();
            else if (rdbRandomAlgorithm.Checked) MakeRandomPassword();
        }

        private void rdbSpecialAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            MakeSpecialPassword();
            btnChangePassword.Enabled = true;
            btnChangePassword.ForeColor = Color.FromArgb(0, 126, 249);
        }

        private void rdbRandomAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            MakeRandomPassword();
            btnChangePassword.Enabled = true;
            btnChangePassword.ForeColor = Color.FromArgb(0, 126, 249);
        }

        private void rdbNoneAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            btnChangePassword.ForeColor = Color.FromArgb(0, 80, 180);
            txtPassword.Text = null;
            btnChangePassword.Enabled = false;
        }

        private void dgvPassword_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedId = int.Parse(dgvPassword.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception) { /*ignore*/ }
        }

        private void dgvPassword_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var password = BllPassword.FindBy(_selectedId);
                Clipboard.SetText(password.TextPassword);
            }
            catch (Exception) { /*ignore*/ }
        }

        #region ContextMenueStrip
        private void ویرایشسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbNoneAlgorithm.Checked = true;
            var password = BllPassword.FindBy(_selectedId);
            txtSiteName.Text = password.SiteName;
            txtUsername.Text = password.Username;
            txtEmail.Text = password.Email;
            txtPassword.Text = password.TextPassword;
            btnRegist.Text = "ذخیره سازی ویرایش";
            _selectedRowNumber = dgvPassword.CurrentRow.Index + 1;
        }

        private void حذفسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedRowNumber = dgvPassword.CurrentRow.Index + 1;
            if (CustomMessageBox.ShowMessageBox($"آیا سطر {_selectedRowNumber} حذف شود؟",
                CustomMessageBox.Status.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BllPassword.Delete(_selectedId);
                LoadDgv();
                _ = CustomMessageBox.ShowMessageBox($"!سطر {_selectedRowNumber} با موفقیت حذف شد",
                    CustomMessageBox.Status.Information);
            }
            if (dgvPassword.CurrentRow == null) dgvPassword.ContextMenuStrip = null;
        }

        private void کپیکردنسطرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var passwordList = BllPassword.CopyRows();
            var result = new StringBuilder();
            foreach (var password in passwordList)
            {
                result.AppendLine(password);
            }
            Clipboard.SetText($"(شکل رندوم)(2 حرف اول)-(تعداد حروف ضربدر خودش)(2 شکل رندوم)(عدد حرف اول در انگلیسی)(عدد حرف دوم در انگلیسی)-(2 حرف آخر)!\r\n \r\n{result}");
        }
        #endregion
    }
}
