
namespace MyProfessional
{
    partial class frmLoading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picrain7 = new System.Windows.Forms.PictureBox();
            this.picrain6 = new System.Windows.Forms.PictureBox();
            this.picrain5 = new System.Windows.Forms.PictureBox();
            this.picrain4 = new System.Windows.Forms.PictureBox();
            this.picrain3 = new System.Windows.Forms.PictureBox();
            this.picrain2 = new System.Windows.Forms.PictureBox();
            this.picrain1 = new System.Windows.Forms.PictureBox();
            this.picrain8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picrain7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(130)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Sahel", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Image = global::MyProfessional.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(682, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 22;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sahel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(322, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 38);
            this.label2.TabIndex = 27;
            this.label2.Text = "100 %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sahel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(338, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "0%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(277, 280);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 34);
            this.panel2.TabIndex = 26;
            // 
            // picWater
            // 
            this.picWater.Image = global::MyProfessional.Properties.Resources.WaterRain;
            this.picWater.Location = new System.Drawing.Point(277, 280);
            this.picWater.Margin = new System.Windows.Forms.Padding(4);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(175, 34);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWater.TabIndex = 25;
            this.picWater.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picrain7);
            this.panel1.Controls.Add(this.picrain6);
            this.panel1.Controls.Add(this.picrain5);
            this.panel1.Controls.Add(this.picrain4);
            this.panel1.Controls.Add(this.picrain3);
            this.panel1.Controls.Add(this.picrain2);
            this.panel1.Controls.Add(this.picrain1);
            this.panel1.Controls.Add(this.picrain8);
            this.panel1.Location = new System.Drawing.Point(232, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 132);
            this.panel1.TabIndex = 24;
            // 
            // picrain7
            // 
            this.picrain7.Image = ((System.Drawing.Image)(resources.GetObject("picrain7.Image")));
            this.picrain7.Location = new System.Drawing.Point(175, 10);
            this.picrain7.Margin = new System.Windows.Forms.Padding(4);
            this.picrain7.Name = "picrain7";
            this.picrain7.Size = new System.Drawing.Size(25, 59);
            this.picrain7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain7.TabIndex = 7;
            this.picrain7.TabStop = false;
            // 
            // picrain6
            // 
            this.picrain6.Image = ((System.Drawing.Image)(resources.GetObject("picrain6.Image")));
            this.picrain6.Location = new System.Drawing.Point(152, -1);
            this.picrain6.Margin = new System.Windows.Forms.Padding(4);
            this.picrain6.Name = "picrain6";
            this.picrain6.Size = new System.Drawing.Size(25, 47);
            this.picrain6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain6.TabIndex = 6;
            this.picrain6.TabStop = false;
            // 
            // picrain5
            // 
            this.picrain5.Image = ((System.Drawing.Image)(resources.GetObject("picrain5.Image")));
            this.picrain5.Location = new System.Drawing.Point(133, 6);
            this.picrain5.Margin = new System.Windows.Forms.Padding(4);
            this.picrain5.Name = "picrain5";
            this.picrain5.Size = new System.Drawing.Size(33, 81);
            this.picrain5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain5.TabIndex = 5;
            this.picrain5.TabStop = false;
            // 
            // picrain4
            // 
            this.picrain4.Image = ((System.Drawing.Image)(resources.GetObject("picrain4.Image")));
            this.picrain4.Location = new System.Drawing.Point(109, -10);
            this.picrain4.Margin = new System.Windows.Forms.Padding(4);
            this.picrain4.Name = "picrain4";
            this.picrain4.Size = new System.Drawing.Size(33, 63);
            this.picrain4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain4.TabIndex = 4;
            this.picrain4.TabStop = false;
            // 
            // picrain3
            // 
            this.picrain3.Image = ((System.Drawing.Image)(resources.GetObject("picrain3.Image")));
            this.picrain3.Location = new System.Drawing.Point(84, 5);
            this.picrain3.Margin = new System.Windows.Forms.Padding(4);
            this.picrain3.Name = "picrain3";
            this.picrain3.Size = new System.Drawing.Size(35, 89);
            this.picrain3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain3.TabIndex = 3;
            this.picrain3.TabStop = false;
            // 
            // picrain2
            // 
            this.picrain2.Image = ((System.Drawing.Image)(resources.GetObject("picrain2.Image")));
            this.picrain2.Location = new System.Drawing.Point(68, 7);
            this.picrain2.Margin = new System.Windows.Forms.Padding(4);
            this.picrain2.Name = "picrain2";
            this.picrain2.Size = new System.Drawing.Size(21, 62);
            this.picrain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain2.TabIndex = 2;
            this.picrain2.TabStop = false;
            // 
            // picrain1
            // 
            this.picrain1.Image = ((System.Drawing.Image)(resources.GetObject("picrain1.Image")));
            this.picrain1.Location = new System.Drawing.Point(43, -26);
            this.picrain1.Margin = new System.Windows.Forms.Padding(4);
            this.picrain1.Name = "picrain1";
            this.picrain1.Size = new System.Drawing.Size(35, 80);
            this.picrain1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain1.TabIndex = 1;
            this.picrain1.TabStop = false;
            // 
            // picrain8
            // 
            this.picrain8.Image = ((System.Drawing.Image)(resources.GetObject("picrain8.Image")));
            this.picrain8.Location = new System.Drawing.Point(192, -22);
            this.picrain8.Margin = new System.Windows.Forms.Padding(4);
            this.picrain8.Name = "picrain8";
            this.picrain8.Size = new System.Drawing.Size(32, 79);
            this.picrain8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrain8.TabIndex = 8;
            this.picrain8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProfessional.Properties.Resources._Rain_;
            this.pictureBox1.Location = new System.Drawing.Point(256, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(730, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picWater);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picrain7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrain8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picrain7;
        private System.Windows.Forms.PictureBox picrain6;
        private System.Windows.Forms.PictureBox picrain5;
        private System.Windows.Forms.PictureBox picrain4;
        private System.Windows.Forms.PictureBox picrain3;
        private System.Windows.Forms.PictureBox picrain2;
        private System.Windows.Forms.PictureBox picrain1;
        private System.Windows.Forms.PictureBox picrain8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}