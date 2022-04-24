using System;
using System.Windows.Forms;
using BusinessEntity;
using BusinessLogic;
using BusinessEntity.Utilities;

namespace MyProfessional
{
    public partial class UcMillion : UserControl
    {
        public UcMillion()
        {
            InitializeComponent();
        }

        public readonly BLLMillion BllMillion = new BLLMillion();
        private int _selectedId;
        private int _selectedRowNumber;
        private double _total;
        private string _moneyWithoutCommas;
        public string securityStatusMillion = "Off";

        private void ClearControllers()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case ComboBox comboBox:
                        comboBox.Text = null;
                        break;
                }
            }
            txtTitle.Text = null;
            txtMoney.Text = null;
        }

        public void RefreshMoney()
        {
            if (dgvMillion.CurrentRow != null)
            {
                if (Convert.ToDouble(txtDefaultMoney.Text) < BllMillion.SumMoney()) _total = 0;

                else _total = Convert.ToDouble(txtDefaultMoney.Text.Replace(",", "")) - BllMillion.SumMoney();

                lblDefaultMoney.Text = $@"درآمد: {string.Format("{0:N0}", double.Parse(BllMillion.SumMoney().ToString().Replace(",", "")))} تومان | باقی مانده: {string.Format("{0:N0}", double.Parse(_total.ToString().Replace(",", "")))} تومان!";
            }
        }

        private void LoadDgv()
        {
            dgvMillion.DataSource = BllMillion.ReadAll();
            if (dgvMillion.CurrentRow != null) dgvMillion.ContextMenuStrip = contextMenuStrip1;
        }

        private void UcMillion_Load(object sender, EventArgs e)
        {
            dgvMillion.AutoGenerateColumns = false;
            dgvMillion.Columns[3].Width = 100;
            dgvMillion.Columns[4].Width = 100;
            LoadDgv();
            RefreshMoney();
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
                    _ = CustomMessageBox.ShowMessageBox("!هیچ فیلدی نباید خالی باشه", CustomMessageBox.Status.Error);
                }
                else
                {
                    var million = new Million(txtTitle.Text, Convert.ToInt32(_moneyWithoutCommas),
                        cmbDay.Text, cmbMonth.Text, cmbYear.Text);
                    BllMillion.Create(million);
                    _ = CustomMessageBox.ShowMessageBox("!مبلغ جدید با موفقیت ثبت شد",
                        CustomMessageBox.Status.Information);
                    ClearControllers();
                    RefreshMoney();
                    if (securityStatusMillion == "Off") LoadDgv();
                }
            }
            else
            {
                if (txtTitle.Text.Trim().Length == 0 || txtMoney.Text.Trim().Length == 0 ||
                    cmbDay.Text.Trim().Length == 0 || cmbMonth.Text.Trim().Length == 0 ||
                    cmbYear.Text.Trim().Length == 0)
                {
                    _ = CustomMessageBox.ShowMessageBox("!هیچ فیلدی نباید خالی باشه", CustomMessageBox.Status.Error);
                }
                else
                {
                    var million = new Million(txtTitle.Text, Convert.ToInt32(_moneyWithoutCommas),
                        cmbDay.Text, cmbMonth.Text, cmbYear.Text);
                    BllMillion.Edit(million, _selectedId);
                    _ = CustomMessageBox.ShowMessageBox($"!سطر {_selectedRowNumber} با موفقیت ویرایش شد",
                        CustomMessageBox.Status.Information);
                    ClearControllers();
                    RefreshMoney();
                    if (securityStatusMillion == "Off") LoadDgv();
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

            if (txtDefaultMoney.Text == "") txtDefaultMoney.Text = "0";

            RefreshMoney();
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
                cmbMonth.Text == "دی" || cmbMonth.Text == "بهمن" || cmbMonth.Text == "اسفند") cmbDay.Items.Remove("31");

            else if (cmbDay.Items.Count == 30) cmbDay.Items.Add("31");
        }

        #region ContextMenueStrip
        private void ویرایشسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var million = BllMillion.FindBy(_selectedId);
            txtTitle.Text = million.Title;
            txtMoney.Text = million.Money.ToString();
            cmbDay.Text = million.Day;
            cmbMonth.Text = million.Month;
            cmbYear.Text = million.Year;
            btnRegist.Text = "ذخیره سازی ویرایش";
            _selectedRowNumber = dgvMillion.CurrentRow.Index + 1;
        }

        private void حذفسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _selectedRowNumber = dgvMillion.CurrentRow.Index + 1;
            if (CustomMessageBox.ShowMessageBox($"آیا سطر {_selectedRowNumber} حذف شود؟",
                CustomMessageBox.Status.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BllMillion.Delete(_selectedId);
                LoadDgv();
                RefreshMoney();
                _ = CustomMessageBox.ShowMessageBox($"!سطر {_selectedRowNumber} با موفقیت حذف شد",
                    CustomMessageBox.Status.Information);
            }

            if (dgvMillion.CurrentRow == null) dgvMillion.ContextMenuStrip = null;
        }
        #endregion

        #region TextBoxFilters
        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void txtDefaultMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        #endregion
    }
}
