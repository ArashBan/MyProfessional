using System;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogic;
using BusinessEntity.Utilities;

namespace MyProfessional
{
    public partial class ucMillion : UserControl
    {
        public ucMillion()
        {
            InitializeComponent();
        }

        public readonly BLLMillion bllMillion = new BLLMillion();
        private int _selectedId;
        private int _selectedRowNumber;
        private double _total;
        private string _moneyWithoutCommas;

        private void _clearControllers()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case ComboBox combobox:
                        combobox.Text = null;
                        break;
                }
                txtTitle.Text = null;
                txtMoney.Text = null;
            }
        }

        public void refreshMoney()
        {
            if (dgvMillion.CurrentRow != null)
            {
                if (Convert.ToDouble(txtDefaultMoney.Text) < bllMillion.SumMoney())
                {
                    _total = 0;
                }
                else
                {
                    _total = Convert.ToDouble(txtDefaultMoney.Text.Replace(",", "")) - bllMillion.SumMoney();
                }
                lblDefaultMoney.Text = "درآمد: " +
                                       string.Format("{0:N0}",
                                           double.Parse(bllMillion.SumMoney().ToString().Replace(",", ""))) +
                                       " تومان | باقیمانده: " + string.Format("{0:N0}",
                                           double.Parse(_total.ToString().Replace(",", ""))) + " تومان!";
            }
        }

        private void _loadDGV()
        {
            dgvMillion.DataSource = bllMillion.ReadAll();
            if (dgvMillion.CurrentRow != null)
            {
                dgvMillion.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void ucMillion_Load(object sender, EventArgs e)
        {
            dgvMillion.AutoGenerateColumns = false;
            dgvMillion.Columns[3].Width = 100;
            dgvMillion.Columns[4].Width = 100;
            _loadDGV();
            refreshMoney();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            _moneyWithoutCommas = txtMoney.Text.Replace(",", "");

            if (btnRegist.Text == "ذخیره سازی")
            {
                if (txtTitle.Text.Trim().Length == 0 || txtMoney.Text.Trim().Length == 0 ||
                    cmbDay.Text.Trim().Length == 0 || cmbMonth.Text.Trim().Length == 0 ||
                    cmbYear.Text.Trim().Length == 0)
                {
                    CustomMessageBox.ShowMessageBox("!هیچ فیلدی نباید خالی باشه", CustomMessageBox.Conditions.Error);
                }
                else
                {
                    var million = new Million(txtTitle.Text, Convert.ToInt32(_moneyWithoutCommas),
                        cmbDay.Text, cmbMonth.Text, cmbYear.Text);
                    bllMillion.Create(million);
                    CustomMessageBox.ShowMessageBox("!مبلغ جدید با موفقیت ثبت شد",
                        CustomMessageBox.Conditions.Information);
                    _clearControllers();
                    _loadDGV();
                    refreshMoney();
                }
            }
            else
            {
                if (txtTitle.Text.Trim().Length == 0 || txtMoney.Text.Trim().Length == 0 ||
                    cmbDay.Text.Trim().Length == 0 || cmbMonth.Text.Trim().Length == 0 ||
                    cmbYear.Text.Trim().Length == 0)
                {
                    CustomMessageBox.ShowMessageBox("!هیچ فیلدی نباید خالی باشه", CustomMessageBox.Conditions.Error);
                }
                else
                {
                    var million = new Million(txtTitle.Text, Convert.ToInt32(_moneyWithoutCommas),
                        cmbDay.Text, cmbMonth.Text, cmbYear.Text);
                    bllMillion.Edit(million, _selectedId);
                    CustomMessageBox.ShowMessageBox($@"!سطر {_selectedRowNumber} با موفقیت ویرایش شد",
                        CustomMessageBox.Conditions.Information);
                    _clearControllers();
                    _loadDGV();
                    refreshMoney();
                    btnRegist.Text = "ذخیره سازی";
                }
            }
        }

        private void txtDefault_TextChanged(object sender, EventArgs e)
        {
            if (txtDefaultMoney.Text != string.Empty)
            {
                txtDefaultMoney.Text = string.Format("{0:N0}", double.Parse(txtDefaultMoney.Text.Replace(",", "")));
                txtDefaultMoney.Select(txtDefaultMoney.TextLength, 0);
            }

            if (txtDefaultMoney.Text == "")
            {
                txtDefaultMoney.Text = "0";
            }

            refreshMoney();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text != string.Empty)
            {
                txtMoney.Text = string.Format("{0:N0}", double.Parse(txtMoney.Text.Replace(",", "")));
                txtMoney.Select(txtMoney.TextLength, 0);
            }
        }

        private void dgvMillion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedId = int.Parse(dgvMillion.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception) { /*ignore*/ }
        }

        private void cmbMonth_TextChanged(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "مهر" || cmbMonth.Text == "آبان" || cmbMonth.Text == "آذر" ||
                cmbMonth.Text == "دی" || cmbMonth.Text == "بهمن" || cmbMonth.Text == "اسفند")
            {
                cmbDay.Items.Remove("31");
            }
            else if (cmbDay.Items.Count == 30)
            {
                cmbDay.Items.Add("31");
            }
        }

        #region ContextMenueStrip
        private void ویرایشسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var million = bllMillion.GetById(_selectedId);
            txtTitle.Text = million.Title;
            txtMoney.Text = million.Money.ToString();
            cmbDay.Text = million.Day;
            cmbMonth.Text = million.Month;
            cmbYear.Text = million.Year;
            btnRegist.Text = "ویرایش سطر";
            _selectedRowNumber = dgvMillion.CurrentRow.Index + 1;
        }

        private void حذفسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedRowNumber = dgvMillion.CurrentRow.Index + 1;
            if (CustomMessageBox.ShowMessageBox($@"آیا سطر {_selectedRowNumber} حذف بشه؟",
                CustomMessageBox.Conditions.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllMillion.Delete(_selectedId);
                _loadDGV();
                refreshMoney();
                CustomMessageBox.ShowMessageBox($@"!سطر {_selectedRowNumber} با موفقیت حذف شد",
                    CustomMessageBox.Conditions.Information);
            }

            if (dgvMillion.CurrentRow == null)
            {
                dgvMillion.ContextMenuStrip = null;
            }
        }
        #endregion

        #region TextBoxFilters
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDefaultMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}