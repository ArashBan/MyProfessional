
namespace MyProfessional
{
    partial class ucHome
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
            this.lblCalender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTodayCalender = new System.Windows.Forms.Label();
            this.lblQuickAccess = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVikings = new System.Windows.Forms.Button();
            this.btnProgramming = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnThe100 = new System.Windows.Forms.Button();
            this.btnAtriya = new System.Windows.Forms.Button();
            this.btnVisualProjectPage = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lblLength.Location = new System.Drawing.Point(136, 14);
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
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblLine.Location = new System.Drawing.Point(5, 6);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(120, 40);
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
            this.lblQuickAccess.AutoSize = true;
            this.lblQuickAccess.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickAccess.ForeColor = System.Drawing.Color.White;
            this.lblQuickAccess.Location = new System.Drawing.Point(186, 11);
            this.lblQuickAccess.Name = "lblQuickAccess";
            this.lblQuickAccess.Size = new System.Drawing.Size(146, 36);
            this.lblQuickAccess.TabIndex = 0;
            this.lblQuickAccess.Text = "دسترسی سریع";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lblQuickAccess);
            this.panel4.Controls.Add(this.btnVikings);
            this.panel4.Controls.Add(this.btnProgramming);
            this.panel4.Controls.Add(this.btnWeekly);
            this.panel4.Controls.Add(this.btnFilm);
            this.panel4.Controls.Add(this.btnThe100);
            this.panel4.Controls.Add(this.btnAtriya);
            this.panel4.Controls.Add(this.btnVisualProjectPage);
            this.panel4.Location = new System.Drawing.Point(29, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 319);
            this.panel4.TabIndex = 18;
            // 
            // btnVikings
            // 
            this.btnVikings.FlatAppearance.BorderSize = 2;
            this.btnVikings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnVikings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnVikings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVikings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVikings.Location = new System.Drawing.Point(162, 190);
            this.btnVikings.Name = "btnVikings";
            this.btnVikings.Size = new System.Drawing.Size(154, 60);
            this.btnVikings.TabIndex = 3;
            this.btnVikings.Text = "سریال وایکینگز";
            this.btnVikings.UseVisualStyleBackColor = true;
            this.btnVikings.Click += new System.EventHandler(this.btnVikings_Click);
            // 
            // btnProgramming
            // 
            this.btnProgramming.FlatAppearance.BorderSize = 2;
            this.btnProgramming.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnProgramming.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnProgramming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProgramming.Location = new System.Drawing.Point(3, 190);
            this.btnProgramming.Name = "btnProgramming";
            this.btnProgramming.Size = new System.Drawing.Size(154, 60);
            this.btnProgramming.TabIndex = 3;
            this.btnProgramming.Text = "صفحه کدنویسی";
            this.btnProgramming.UseVisualStyleBackColor = true;
            this.btnProgramming.Click += new System.EventHandler(this.btnProgramming_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.FlatAppearance.BorderSize = 2;
            this.btnWeekly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnWeekly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnWeekly.Location = new System.Drawing.Point(3, 124);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(154, 60);
            this.btnWeekly.TabIndex = 3;
            this.btnWeekly.Text = "برنامه هفتگی";
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.FlatAppearance.BorderSize = 2;
            this.btnFilm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFilm.Location = new System.Drawing.Point(3, 256);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(154, 60);
            this.btnFilm.TabIndex = 3;
            this.btnFilm.Text = "صفحه فیلم";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnThe100
            // 
            this.btnThe100.FlatAppearance.BorderSize = 2;
            this.btnThe100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnThe100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnThe100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThe100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnThe100.Location = new System.Drawing.Point(162, 256);
            this.btnThe100.Name = "btnThe100";
            this.btnThe100.Size = new System.Drawing.Size(154, 60);
            this.btnThe100.TabIndex = 3;
            this.btnThe100.Text = "سریال صد";
            this.btnThe100.UseVisualStyleBackColor = true;
            this.btnThe100.Click += new System.EventHandler(this.btnThe100_Click);
            // 
            // btnAtriya
            // 
            this.btnAtriya.FlatAppearance.BorderSize = 2;
            this.btnAtriya.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnAtriya.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnAtriya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtriya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAtriya.Location = new System.Drawing.Point(162, 124);
            this.btnAtriya.Name = "btnAtriya";
            this.btnAtriya.Size = new System.Drawing.Size(154, 60);
            this.btnAtriya.TabIndex = 3;
            this.btnAtriya.Text = "دوره آتریا";
            this.btnAtriya.UseVisualStyleBackColor = true;
            this.btnAtriya.Click += new System.EventHandler(this.btnAtriya_Click);
            // 
            // btnVisualProjectPage
            // 
            this.btnVisualProjectPage.FlatAppearance.BorderSize = 2;
            this.btnVisualProjectPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnVisualProjectPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnVisualProjectPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualProjectPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVisualProjectPage.Location = new System.Drawing.Point(3, 58);
            this.btnVisualProjectPage.Name = "btnVisualProjectPage";
            this.btnVisualProjectPage.Size = new System.Drawing.Size(313, 60);
            this.btnVisualProjectPage.TabIndex = 3;
            this.btnVisualProjectPage.Text = "صفحه پروژه های ویژوال استودیو";
            this.btnVisualProjectPage.UseVisualStyleBackColor = true;
            this.btnVisualProjectPage.Click += new System.EventHandler(this.btnVisualProjectPage_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(728, 549);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Label lblCalender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblLine;
        private System.Windows.Forms.Label lblTodayCalender;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblQuickAccess;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVikings;
        private System.Windows.Forms.Button btnThe100;
        private System.Windows.Forms.Button btnVisualProjectPage;
        private System.Windows.Forms.Button btnAtriya;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnProgramming;
        private System.Windows.Forms.Button btnWeekly;
    }
}
