using System;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogic;
using BusinessEntity.Utilities;

namespace MyProfessional
{
    public partial class ucPassword : UserControl
    {
        public ucPassword()
        {
            InitializeComponent();
        }

        public readonly BLLPassword bllPassword = new BLLPassword();
        private int _selectedId;
        private int _selectedRowNumber;

        private void _clearControllers()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox textbox:
                        textbox.Clear();
                        break;
                }
                rdbSpecialAlgorithm.Checked = true;
            }
        }

        private void _makeSpecialPassword()
        {
            try
            {
                // @Di-64#%41-La!
                // =Di-64#%49-la!
                // 13 - 17 = *

                var ShapeSample = "=#%@";
                var WordSample = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

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

                #region Shape

                var firstShape = _randomString(ShapeSample, 1);
                txtPassword.Text = firstShape;
                ShapeSample = ShapeSample.Replace(firstShape, "");

                #endregion

                #region FirstTwoChar

                txtPassword.Text += _randomString(firstOneCharLower + firstOneCharUpper, 1);
                txtPassword.Text += _randomString(firstTwoCharLower + firstTwoCharUpper, 1) + "-";

                #endregion

                #region Number

                txtPassword.Text += txtSiteName.Text.Length * txtSiteName.Text.Length;

                //txtPassword.Text += _randomString("0123456789", 4);

                //var number = _randomString("1234567890", 1);
                //txtPassword.Text += number;
                //NumberSample = NumberSample.Replace(number, "");

                //for (var i = 0; i <= 2; i++)
                //{
                //    number = _randomString(NumberSample, 1);
                //    txtPassword.Text += number;
                //    NumberSample = NumberSample.Replace(number, "");
                //}

                #endregion

                #region Shape

                var shape2 = _randomString(ShapeSample, 1);
                txtPassword.Text += shape2;
                ShapeSample = ShapeSample.Replace(shape2, "");

                var shape3 = _randomString(ShapeSample, 1);
                txtPassword.Text += shape3;
                ShapeSample = ShapeSample.Replace(shape3, "");

                //var word = _randomString(WordSample, 1);
                //WordSample = WordSample.Replace(word, "");

                //var word2 = _randomString(WordSample, 1);

                //var shape = _randomString(ShapeSample, 1);
                //ShapeSample = ShapeSample.Replace(shape, "");

                //var shape2 = _randomString(ShapeSample, 1);
                //ShapeSample = ShapeSample.Replace(shape2, "");

                //var allThings = word + word2 + shape + shape2;
                //var all = _randomString(allThings, 1);
                //txtPassword.Text += all;
                //allThings = allThings.Replace(all, "");

                //for (var i = 0; i <= 2; i++)
                //{
                //    all = _randomString(allThings, 1);
                //    txtPassword.Text += all;
                //    allThings = allThings.Replace(all, "");
                //}

                //var shape2 = _randomString(ShapeSample, 1);
                //txtPassword.Text += shape2;
                //ShapeSample = ShapeSample.Replace(shape2, "");

                //var shape3 = _randomString(ShapeSample, 1);
                //txtPassword.Text += shape3;
                //ShapeSample = ShapeSample.Replace(shape3, "");

                #endregion

                #region Number

                var WordSample1 = "abcdefghijklmnopqrstuvwxyz";

                for (int i = 1; i <= 26; i++)
                {
                    var WordSample2 = WordSample1.Substring(0, 1);

                    if (firstOneCharLower == WordSample2)
                    {
                        txtPassword.Text += i.ToString();
                        break;
                    }
                    else
                    {
                        WordSample1 = WordSample1.Replace(WordSample2, "");
                    }
                }

                WordSample1 = "abcdefghijklmnopqrstuvwxyz";

                for (int i = 1; i <= 26; i++)
                {
                    var WordSample2 = WordSample1.Substring(0, 1);

                    if (lastOneCharLower == WordSample2)
                    {
                        txtPassword.Text += i.ToString() + "-";
                        break;
                    }
                    else
                    {
                        WordSample1 = WordSample1.Replace(WordSample2, "");
                    }
                }

                //txtPassword.Text += txtSiteName.Text.Length * txtSiteName.Text.Length;

                //txtPassword.Text += _randomString("0123456789", 4);

                //var number2 = _randomString(NumberSample, 1);
                //txtPassword.Text += number2;
                //NumberSample = NumberSample.Replace(number2, "");

                //for (var i = 0; i <= 2; i++)
                //{
                //    number2 = _randomString(NumberSample, 1);
                //    txtPassword.Text += number2;
                //    NumberSample = NumberSample.Replace(number2, "");
                //}

                #endregion

                #region LastTwoChar

                txtPassword.Text += _randomString(lastOneCharLower + lastOneCharUpper, 1);
                txtPassword.Text += _randomString(lastTwoCharLower + lastTwoCharUpper, 1) + "!";

                #endregion

                #region Shape

                //var lastShape = _randomString(ShapeSample, 1);
                //txtPassword.Text += lastShape;

                #endregion

            }
            catch (Exception) { txtPassword.Text = null; }
        }

        private void _makeRandomPassword()
        {
            txtPassword.Text = _randomString("=#%@!0123456789AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz", 18);
        }

        private void _makeFixedPassword()
        {
            txtPassword.Text = "AR-ash194376!";
        }

        private string _randomString(string chars, int length)
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

        private void _loadDGV()
        {
            dgvPassword.DataSource = bllPassword.ReadAll();
            if (dgvPassword.CurrentRow != null)
            {
                dgvPassword.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void ucPassword_Load(object sender, EventArgs e)
        {
            dgvPassword.AutoGenerateColumns = false;
            _loadDGV();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (btnRegist.Text == "ذخیره سازی")
            {
                if (txtPassword.Text.Trim().Length == 0)
                {
                    CustomMessageBox.ShowMessageBox("!فیلد پسوورد نباید خالی باشه", CustomMessageBox.Conditions.Error);
                }
                else
                {
                    var password = new Password(txtSiteName.Text, txtUsername.Text,
                        txtEmail.Text, txtPassword.Text);
                    bllPassword.Create(password);
                    CustomMessageBox.ShowMessageBox("!پسوورد جدید با موفقیت ثبت شد",
                        CustomMessageBox.Conditions.Information);
                    _clearControllers();
                    _loadDGV();
                }
            }
            else
            {
                if (txtPassword.Text.Trim().Length == 0)
                {
                    CustomMessageBox.ShowMessageBox("!فیلد پسوورد نباید خالی باشه", CustomMessageBox.Conditions.Error);
                }
                else
                {
                    var password = new Password(txtSiteName.Text, txtUsername.Text,
                        txtEmail.Text, txtPassword.Text);
                    bllPassword.Edit(password, _selectedId);
                    CustomMessageBox.ShowMessageBox($@"!سطر {_selectedRowNumber} با موفقیت ویرایش شد",
                        CustomMessageBox.Conditions.Information);
                    _clearControllers();
                    _loadDGV();
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
            if (rdbSpecialAlgorithm.Checked)
            {
                _makeSpecialPassword();
            }
            else if (rdbRandomAlgorithm.Checked)
            {
                _makeRandomPassword();
            }
            else if (rdbFixedAlgorithm.Checked)
            {
                _makeFixedPassword();
            }
        }

        private void txtSiteName_TextChanged(object sender, EventArgs e)
        {
            if (rdbSpecialAlgorithm.Checked)
            {
                _makeSpecialPassword();
            }
        }

        private void rdbSpecialAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            _makeSpecialPassword();
        }

        private void rdbRandomAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            _makeRandomPassword();
        }

        private void rdbFixedAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            _makeFixedPassword();
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
                var password = bllPassword.GetById(_selectedId);
                Clipboard.SetText(password.TextPassword);
            }
            catch (Exception) { /*ignore*/ }
        }

        #region ContextMenueStrip
        private void ویرایشسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbSpecialAlgorithm.Checked = false;
            rdbRandomAlgorithm.Checked = false;
            rdbFixedAlgorithm.Checked = false;
            var password = bllPassword.GetById(_selectedId);
            txtSiteName.Text = password.SiteName;
            txtUsername.Text = password.Username;
            txtEmail.Text = password.Email;
            txtPassword.Text = password.TextPassword;
            btnRegist.Text = "ویرایش سطر";
            _selectedRowNumber = dgvPassword.CurrentRow.Index + 1;
        }

        private void حذفسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedRowNumber = dgvPassword.CurrentRow.Index + 1;
            if (CustomMessageBox.ShowMessageBox($@"آیا سطر {_selectedRowNumber} حذف بشه؟",
                CustomMessageBox.Conditions.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllPassword.Delete(_selectedId);
                _loadDGV();
                CustomMessageBox.ShowMessageBox($@"!سطر {_selectedRowNumber} با موفقیت حذف شد",
                    CustomMessageBox.Conditions.Information);
            }

            if (dgvPassword.CurrentRow == null)
            {
                dgvPassword.ContextMenuStrip = null;
            }
        }

        private void کپیکردنسطرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var passwordList = bllPassword.CopyRows();
            var result = new StringBuilder();
            foreach (var password in passwordList)
            {
                result.AppendLine(password);
            }
            Clipboard.SetText("(شکل رندوم)(2 حرف اول)-(تعداد حروف ضربدر خودش)(2 شکل رندوم)(عدد حرف اول در انگلیسی)(عدد حرف دوم در انگلیسی)-(2 حرف آخر)!\r\n \r\n" + result.ToString());
        }
        #endregion
    }
}
