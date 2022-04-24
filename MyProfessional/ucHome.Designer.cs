
namespace MyProfessional
{
    partial class UcHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTodayCalender = new System.Windows.Forms.Label();
            this.lblQuickAccess = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtQuickAccessName3 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName7 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName6 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName5 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName4 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName2 = new System.Windows.Forms.TextBox();
            this.txtQuickAccessName1 = new System.Windows.Forms.TextBox();
            this.btnQuickAccessAddress = new System.Windows.Forms.Button();
            this.btnQuickAccessName = new System.Windows.Forms.Button();
            this.btnQuickAccess4 = new System.Windows.Forms.Button();
            this.btnQuickAccess5 = new System.Windows.Forms.Button();
            this.btnQuickAccess3 = new System.Windows.Forms.Button();
            this.btnQuickAccess7 = new System.Windows.Forms.Button();
            this.btnQuickAccess6 = new System.Windows.Forms.Button();
            this.btnQuickAccess2 = new System.Windows.Forms.Button();
            this.btnQuickAccess1 = new System.Windows.Forms.Button();
            this.lblCalender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblLength);
            this.panel2.Controls.Add(this.lblLine);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Location = new System.Drawing.Point(377, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 492);
            this.panel2.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblLength.Location = new System.Drawing.Point(139, 14);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(48, 31);
            this.lblLength.TabIndex = 9;
            this.lblLength.Text = "طول";
            // 
            // lblLine
            // 
            this.lblLine.FlatAppearance.BorderSize = 2;
            this.lblLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.lblLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLine.Font = new System.Drawing.Font("Sahel SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblLine.Location = new System.Drawing.Point(5, 5);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(120, 42);
            this.lblLine.TabIndex = 3;
            this.lblLine.Text = "خط فاصله";
            this.lblLine.UseVisualStyleBackColor = true;
            this.lblLine.Click += new System.EventHandler(this.lblLine_Click);
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "Note", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNote.Location = new System.Drawing.Point(5, 52);
            this.txtNote.MaxLength = 2000;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(309, 435);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = global::MyProfessional.Properties.Settings.Default.Note;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(231, 11);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(94, 36);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "یادداشت";
            // 
            // lblTodayCalender
            // 
            this.lblTodayCalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTodayCalender.Font = new System.Drawing.Font("Sahel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayCalender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTodayCalender.Location = new System.Drawing.Point(0, 0);
            this.lblTodayCalender.Name = "lblTodayCalender";
            this.lblTodayCalender.Size = new System.Drawing.Size(319, 145);
            this.lblTodayCalender.TabIndex = 1;
            this.lblTodayCalender.Text = "متن امروز!";
            this.lblTodayCalender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuickAccess
            // 
            this.lblQuickAccess.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickAccess.ForeColor = System.Drawing.Color.White;
            this.lblQuickAccess.Location = new System.Drawing.Point(161, 11);
            this.lblQuickAccess.Name = "lblQuickAccess";
            this.lblQuickAccess.Size = new System.Drawing.Size(147, 36);
            this.lblQuickAccess.TabIndex = 0;
            this.lblQuickAccess.Text = "دسترسی سریع";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.txtQuickAccessName3);
            this.panel4.Controls.Add(this.txtQuickAccessName7);
            this.panel4.Controls.Add(this.txtQuickAccessName6);
            this.panel4.Controls.Add(this.txtQuickAccessName5);
            this.panel4.Controls.Add(this.txtQuickAccessName4);
            this.panel4.Controls.Add(this.txtQuickAccessName2);
            this.panel4.Controls.Add(this.txtQuickAccessName1);
            this.panel4.Controls.Add(this.btnQuickAccessAddress);
            this.panel4.Controls.Add(this.btnQuickAccessName);
            this.panel4.Controls.Add(this.btnQuickAccess4);
            this.panel4.Controls.Add(this.btnQuickAccess5);
            this.panel4.Controls.Add(this.btnQuickAccess3);
            this.panel4.Controls.Add(this.btnQuickAccess7);
            this.panel4.Controls.Add(this.btnQuickAccess6);
            this.panel4.Controls.Add(this.btnQuickAccess2);
            this.panel4.Controls.Add(this.btnQuickAccess1);
            this.panel4.Controls.Add(this.lblQuickAccess);
            this.panel4.Location = new System.Drawing.Point(29, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 319);
            this.panel4.TabIndex = 18;
            // 
            // txtQuickAccessName3
            // 
            this.txtQuickAccessName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName3.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName3.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName3.Location = new System.Drawing.Point(3, 127);
            this.txtQuickAccessName3.MaxLength = 15;
            this.txtQuickAccessName3.Name = "txtQuickAccessName3";
            this.txtQuickAccessName3.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName3.TabIndex = 19;
            this.txtQuickAccessName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName3.Visible = false;
            // 
            // txtQuickAccessName7
            // 
            this.txtQuickAccessName7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName7.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName7.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName7.Location = new System.Drawing.Point(3, 261);
            this.txtQuickAccessName7.MaxLength = 15;
            this.txtQuickAccessName7.Name = "txtQuickAccessName7";
            this.txtQuickAccessName7.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName7.TabIndex = 19;
            this.txtQuickAccessName7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName7.Visible = false;
            // 
            // txtQuickAccessName6
            // 
            this.txtQuickAccessName6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName6.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName6.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName6.Location = new System.Drawing.Point(163, 261);
            this.txtQuickAccessName6.MaxLength = 15;
            this.txtQuickAccessName6.Name = "txtQuickAccessName6";
            this.txtQuickAccessName6.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName6.TabIndex = 19;
            this.txtQuickAccessName6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName6.Visible = false;
            // 
            // txtQuickAccessName5
            // 
            this.txtQuickAccessName5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName5.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName5.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName5.Location = new System.Drawing.Point(3, 194);
            this.txtQuickAccessName5.MaxLength = 15;
            this.txtQuickAccessName5.Name = "txtQuickAccessName5";
            this.txtQuickAccessName5.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName5.TabIndex = 19;
            this.txtQuickAccessName5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName5.Visible = false;
            // 
            // txtQuickAccessName4
            // 
            this.txtQuickAccessName4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName4.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName4.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName4.Location = new System.Drawing.Point(162, 194);
            this.txtQuickAccessName4.MaxLength = 15;
            this.txtQuickAccessName4.Name = "txtQuickAccessName4";
            this.txtQuickAccessName4.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName4.TabIndex = 19;
            this.txtQuickAccessName4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName4.Visible = false;
            // 
            // txtQuickAccessName2
            // 
            this.txtQuickAccessName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName2.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName2.Location = new System.Drawing.Point(163, 127);
            this.txtQuickAccessName2.MaxLength = 15;
            this.txtQuickAccessName2.Name = "txtQuickAccessName2";
            this.txtQuickAccessName2.Size = new System.Drawing.Size(154, 49);
            this.txtQuickAccessName2.TabIndex = 19;
            this.txtQuickAccessName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName2.Visible = false;
            // 
            // txtQuickAccessName1
            // 
            this.txtQuickAccessName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtQuickAccessName1.Font = new System.Drawing.Font("Sahel SemiBold", 16F, System.Drawing.FontStyle.Bold);
            this.txtQuickAccessName1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuickAccessName1.Location = new System.Drawing.Point(3, 60);
            this.txtQuickAccessName1.MaxLength = 30;
            this.txtQuickAccessName1.Name = "txtQuickAccessName1";
            this.txtQuickAccessName1.Size = new System.Drawing.Size(313, 49);
            this.txtQuickAccessName1.TabIndex = 19;
            this.txtQuickAccessName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuickAccessName1.Visible = false;
            // 
            // btnQuickAccessAddress
            // 
            this.btnQuickAccessAddress.FlatAppearance.BorderSize = 2;
            this.btnQuickAccessAddress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccessAddress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccessAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccessAddress.Font = new System.Drawing.Font("Sahel SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuickAccessAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccessAddress.Location = new System.Drawing.Point(3, 6);
            this.btnQuickAccessAddress.Name = "btnQuickAccessAddress";
            this.btnQuickAccessAddress.Size = new System.Drawing.Size(80, 42);
            this.btnQuickAccessAddress.TabIndex = 3;
            this.btnQuickAccessAddress.Text = "مسیر";
            this.btnQuickAccessAddress.UseVisualStyleBackColor = true;
            this.btnQuickAccessAddress.Click += new System.EventHandler(this.btnQuickAccessAddress_Click);
            // 
            // btnQuickAccessName
            // 
            this.btnQuickAccessName.FlatAppearance.BorderSize = 2;
            this.btnQuickAccessName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccessName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccessName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccessName.Font = new System.Drawing.Font("Sahel SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuickAccessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccessName.Location = new System.Drawing.Point(86, 6);
            this.btnQuickAccessName.Name = "btnQuickAccessName";
            this.btnQuickAccessName.Size = new System.Drawing.Size(80, 42);
            this.btnQuickAccessName.TabIndex = 3;
            this.btnQuickAccessName.Text = "نام";
            this.btnQuickAccessName.UseVisualStyleBackColor = true;
            this.btnQuickAccessName.Click += new System.EventHandler(this.btnQuickAccessName_Click);
            // 
            // btnQuickAccess4
            // 
            this.btnQuickAccess4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess4.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess4.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess4.Location = new System.Drawing.Point(162, 187);
            this.btnQuickAccess4.Name = "btnQuickAccess4";
            this.btnQuickAccess4.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess4.TabIndex = 3;
            this.btnQuickAccess4.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName4;
            this.btnQuickAccess4.UseVisualStyleBackColor = true;
            this.btnQuickAccess4.Click += new System.EventHandler(this.btnQuickAccess4_Click);
            // 
            // btnQuickAccess5
            // 
            this.btnQuickAccess5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess5.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess5.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess5.Location = new System.Drawing.Point(3, 187);
            this.btnQuickAccess5.Name = "btnQuickAccess5";
            this.btnQuickAccess5.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess5.TabIndex = 3;
            this.btnQuickAccess5.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName5;
            this.btnQuickAccess5.UseVisualStyleBackColor = true;
            this.btnQuickAccess5.Click += new System.EventHandler(this.btnQuickAccess5_Click);
            // 
            // btnQuickAccess3
            // 
            this.btnQuickAccess3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess3.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess3.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess3.Location = new System.Drawing.Point(3, 120);
            this.btnQuickAccess3.Name = "btnQuickAccess3";
            this.btnQuickAccess3.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess3.TabIndex = 3;
            this.btnQuickAccess3.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName3;
            this.btnQuickAccess3.UseVisualStyleBackColor = true;
            this.btnQuickAccess3.Click += new System.EventHandler(this.btnQuickAccess3_Click);
            // 
            // btnQuickAccess7
            // 
            this.btnQuickAccess7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess7.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess7.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess7.Location = new System.Drawing.Point(3, 254);
            this.btnQuickAccess7.Name = "btnQuickAccess7";
            this.btnQuickAccess7.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess7.TabIndex = 3;
            this.btnQuickAccess7.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName7;
            this.btnQuickAccess7.UseVisualStyleBackColor = true;
            this.btnQuickAccess7.Click += new System.EventHandler(this.btnQuickAccess7_Click);
            // 
            // btnQuickAccess6
            // 
            this.btnQuickAccess6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess6.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess6.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess6.Location = new System.Drawing.Point(162, 254);
            this.btnQuickAccess6.Name = "btnQuickAccess6";
            this.btnQuickAccess6.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess6.TabIndex = 3;
            this.btnQuickAccess6.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName6;
            this.btnQuickAccess6.UseVisualStyleBackColor = true;
            this.btnQuickAccess6.Click += new System.EventHandler(this.btnQuickAccess6_Click);
            // 
            // btnQuickAccess2
            // 
            this.btnQuickAccess2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess2.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess2.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess2.Location = new System.Drawing.Point(162, 120);
            this.btnQuickAccess2.Name = "btnQuickAccess2";
            this.btnQuickAccess2.Size = new System.Drawing.Size(154, 62);
            this.btnQuickAccess2.TabIndex = 3;
            this.btnQuickAccess2.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName2;
            this.btnQuickAccess2.UseVisualStyleBackColor = true;
            this.btnQuickAccess2.Click += new System.EventHandler(this.btnQuickAccess2_Click);
            // 
            // btnQuickAccess1
            // 
            this.btnQuickAccess1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "QuickAccessName1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuickAccess1.FlatAppearance.BorderSize = 2;
            this.btnQuickAccess1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnQuickAccess1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnQuickAccess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAccess1.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickAccess1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnQuickAccess1.Location = new System.Drawing.Point(3, 53);
            this.btnQuickAccess1.Name = "btnQuickAccess1";
            this.btnQuickAccess1.Size = new System.Drawing.Size(313, 62);
            this.btnQuickAccess1.TabIndex = 3;
            this.btnQuickAccess1.Text = global::MyProfessional.Properties.Settings.Default.QuickAccessName1;
            this.btnQuickAccess1.UseVisualStyleBackColor = true;
            this.btnQuickAccess1.Click += new System.EventHandler(this.btnQuickAccess1_Click);
            // 
            // lblCalender
            // 
            this.lblCalender.AutoSize = true;
            this.lblCalender.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalender.ForeColor = System.Drawing.Color.White;
            this.lblCalender.Location = new System.Drawing.Point(234, 11);
            this.lblCalender.Name = "lblCalender";
            this.lblCalender.Size = new System.Drawing.Size(92, 36);
            this.lblCalender.TabIndex = 0;
            this.lblCalender.Text = "تاریخ روز";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblCalender);
            this.panel1.Controls.Add(this.lblTodayCalender);
            this.panel1.Location = new System.Drawing.Point(29, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 145);
            this.panel1.TabIndex = 0;
            // 
            // UcHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UcHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(728, 549);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button lblLine;
        private System.Windows.Forms.Label lblTodayCalender;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblQuickAccess;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnQuickAccess4;
        private System.Windows.Forms.Button btnQuickAccess6;
        private System.Windows.Forms.Button btnQuickAccess1;
        private System.Windows.Forms.Button btnQuickAccess2;
        private System.Windows.Forms.Button btnQuickAccess7;
        private System.Windows.Forms.Button btnQuickAccess5;
        private System.Windows.Forms.Button btnQuickAccess3;
        private System.Windows.Forms.Button btnQuickAccessAddress;
        private System.Windows.Forms.Label lblCalender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuickAccessName;
        private System.Windows.Forms.TextBox txtQuickAccessName1;
        private System.Windows.Forms.TextBox txtQuickAccessName2;
        private System.Windows.Forms.TextBox txtQuickAccessName3;
        private System.Windows.Forms.TextBox txtQuickAccessName5;
        private System.Windows.Forms.TextBox txtQuickAccessName4;
        private System.Windows.Forms.TextBox txtQuickAccessName7;
        private System.Windows.Forms.TextBox txtQuickAccessName6;
    }
}
