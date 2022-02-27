
namespace MyProfessional
{
    partial class ucPassword
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvPassword = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفسطرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کپیکردنسطرهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.rdbSpecialAlgorithm = new System.Windows.Forms.RadioButton();
            this.rdbRandomAlgorithm = new System.Windows.Forms.RadioButton();
            this.rdbFixedAlgorithm = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassword)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 2;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCopy.Location = new System.Drawing.Point(370, 166);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(67, 40);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "کپی";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblPassword.Location = new System.Drawing.Point(634, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 31);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "پسوورد:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(370, 121);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(250, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPassword
            // 
            this.dgvPassword.AllowUserToAddRows = false;
            this.dgvPassword.AllowUserToDeleteRows = false;
            this.dgvPassword.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sahel SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPassword.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPassword.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPassword.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPassword.ColumnHeadersHeight = 50;
            this.dgvPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPassword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.SiteName,
            this.Username,
            this.Email,
            this.TextPassword});
            this.dgvPassword.Location = new System.Drawing.Point(12, 236);
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            this.dgvPassword.RowHeadersVisible = false;
            this.dgvPassword.RowHeadersWidth = 51;
            this.dgvPassword.RowTemplate.Height = 24;
            this.dgvPassword.Size = new System.Drawing.Size(702, 300);
            this.dgvPassword.TabIndex = 7;
            this.dgvPassword.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassword_CellClick);
            this.dgvPassword.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassword_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // SiteName
            // 
            this.SiteName.DataPropertyName = "SiteName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SiteName.DefaultCellStyle = dataGridViewCellStyle9;
            this.SiteName.HeaderText = " نام سایت";
            this.SiteName.MinimumWidth = 140;
            this.SiteName.Name = "SiteName";
            this.SiteName.ReadOnly = true;
            this.SiteName.Width = 140;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Username.DefaultCellStyle = dataGridViewCellStyle10;
            this.Username.HeaderText = "  یوزرنیم";
            this.Username.MinimumWidth = 139;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 139;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Email.DefaultCellStyle = dataGridViewCellStyle11;
            this.Email.HeaderText = "  ایمیل";
            this.Email.MinimumWidth = 240;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 240;
            // 
            // TextPassword
            // 
            this.TextPassword.DataPropertyName = "TextPassword";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TextPassword.DefaultCellStyle = dataGridViewCellStyle12;
            this.TextPassword.HeaderText = "   پسوورد";
            this.TextPassword.MinimumWidth = 180;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.ReadOnly = true;
            this.TextPassword.Width = 180;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشسطرToolStripMenuItem,
            this.حذفسطرToolStripMenuItem,
            this.کپیکردنسطرهاToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 112);
            // 
            // ویرایشسطرToolStripMenuItem
            // 
            this.ویرایشسطرToolStripMenuItem.Name = "ویرایشسطرToolStripMenuItem";
            this.ویرایشسطرToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.ویرایشسطرToolStripMenuItem.Text = "ویرایش سطر";
            this.ویرایشسطرToolStripMenuItem.Click += new System.EventHandler(this.ویرایشسطرToolStripMenuItem_Click);
            // 
            // حذفسطرToolStripMenuItem
            // 
            this.حذفسطرToolStripMenuItem.Name = "حذفسطرToolStripMenuItem";
            this.حذفسطرToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.حذفسطرToolStripMenuItem.Text = "حذف سطر";
            this.حذفسطرToolStripMenuItem.Click += new System.EventHandler(this.حذفسطرToolStripMenuItem_Click);
            // 
            // کپیکردنسطرهاToolStripMenuItem
            // 
            this.کپیکردنسطرهاToolStripMenuItem.Name = "کپیکردنسطرهاToolStripMenuItem";
            this.کپیکردنسطرهاToolStripMenuItem.Size = new System.Drawing.Size(220, 36);
            this.کپیکردنسطرهاToolStripMenuItem.Text = "کپی کردن سطرها";
            this.کپیکردنسطرهاToolStripMenuItem.Click += new System.EventHandler(this.کپیکردنسطرهاToolStripMenuItem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 121);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(250, 39);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEmail.Location = new System.Drawing.Point(289, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 31);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "ایمیل:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUsername.Location = new System.Drawing.Point(284, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 31);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "یوزرنیم:";
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSiteName.Location = new System.Drawing.Point(626, 75);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(91, 31);
            this.lblSiteName.TabIndex = 8;
            this.lblSiteName.Text = "نام سایت:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 76);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(250, 39);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(370, 75);
            this.txtSiteName.MaxLength = 30;
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSiteName.Size = new System.Drawing.Size(250, 39);
            this.txtSiteName.TabIndex = 0;
            this.txtSiteName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSiteName.TextChanged += new System.EventHandler(this.txtSiteName_TextChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatAppearance.BorderSize = 2;
            this.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnChangePassword.Location = new System.Drawing.Point(443, 166);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(177, 40);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "تغییر پسوورد";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.FlatAppearance.BorderSize = 2;
            this.btnRegist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnRegist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRegist.Location = new System.Drawing.Point(28, 166);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(250, 40);
            this.btnRegist.TabIndex = 6;
            this.btnRegist.Text = "ذخیره سازی";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // rdbSpecialAlgorithm
            // 
            this.rdbSpecialAlgorithm.Checked = true;
            this.rdbSpecialAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rdbSpecialAlgorithm.Location = new System.Drawing.Point(480, 18);
            this.rdbSpecialAlgorithm.Name = "rdbSpecialAlgorithm";
            this.rdbSpecialAlgorithm.Size = new System.Drawing.Size(144, 35);
            this.rdbSpecialAlgorithm.TabIndex = 0;
            this.rdbSpecialAlgorithm.TabStop = true;
            this.rdbSpecialAlgorithm.Text = "الگوریتم خاص";
            this.rdbSpecialAlgorithm.UseVisualStyleBackColor = true;
            this.rdbSpecialAlgorithm.CheckedChanged += new System.EventHandler(this.rdbSpecialAlgorithm_CheckedChanged);
            // 
            // rdbRandomAlgorithm
            // 
            this.rdbRandomAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rdbRandomAlgorithm.Location = new System.Drawing.Point(290, 18);
            this.rdbRandomAlgorithm.Name = "rdbRandomAlgorithm";
            this.rdbRandomAlgorithm.Size = new System.Drawing.Size(144, 35);
            this.rdbRandomAlgorithm.TabIndex = 0;
            this.rdbRandomAlgorithm.Text = "الگوریتم رندوم";
            this.rdbRandomAlgorithm.UseVisualStyleBackColor = true;
            this.rdbRandomAlgorithm.CheckedChanged += new System.EventHandler(this.rdbRandomAlgorithm_CheckedChanged);
            // 
            // rdbFixedAlgorithm
            // 
            this.rdbFixedAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.rdbFixedAlgorithm.Location = new System.Drawing.Point(98, 18);
            this.rdbFixedAlgorithm.Name = "rdbFixedAlgorithm";
            this.rdbFixedAlgorithm.Size = new System.Drawing.Size(136, 35);
            this.rdbFixedAlgorithm.TabIndex = 0;
            this.rdbFixedAlgorithm.Text = "الگوریتم ثابت";
            this.rdbFixedAlgorithm.UseVisualStyleBackColor = true;
            this.rdbFixedAlgorithm.CheckedChanged += new System.EventHandler(this.rdbFixedAlgorithm_CheckedChanged);
            // 
            // ucPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.rdbFixedAlgorithm);
            this.Controls.Add(this.rdbRandomAlgorithm);
            this.Controls.Add(this.rdbSpecialAlgorithm);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.dgvPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSiteName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnRegist);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(728, 549);
            this.Load += new System.EventHandler(this.ucPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassword)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextPassword;
        private System.Windows.Forms.RadioButton rdbSpecialAlgorithm;
        private System.Windows.Forms.RadioButton rdbRandomAlgorithm;
        private System.Windows.Forms.RadioButton rdbFixedAlgorithm;
        public System.Windows.Forms.DataGridView dgvPassword;
        public System.Windows.Forms.ToolStripMenuItem ویرایشسطرToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem حذفسطرToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem کپیکردنسطرهاToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
