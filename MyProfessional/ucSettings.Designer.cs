
namespace MyProfessional
{
    partial class UcSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSettings));
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBackup = new System.Windows.Forms.Label();
            this.pane3 = new System.Windows.Forms.Panel();
            this.lblChanges = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pane3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderSize = 2;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBackup.Location = new System.Drawing.Point(40, 276);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(250, 40);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "تهیه فایل بکاپ";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.FlatAppearance.BorderSize = 2;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRestore.Location = new System.Drawing.Point(40, 322);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(250, 40);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "بازیابی اطلاعات";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProfessional.Properties.Resources.Backup;
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblBackup);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Location = new System.Drawing.Point(366, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 383);
            this.panel2.TabIndex = 17;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.ForeColor = System.Drawing.Color.White;
            this.lblBackup.Location = new System.Drawing.Point(225, 11);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(111, 36);
            this.lblBackup.TabIndex = 0;
            this.lblBackup.Text = "بکاپ گیری";
            // 
            // pane3
            // 
            this.pane3.AutoScroll = true;
            this.pane3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.pane3.Controls.Add(this.lblChanges);
            this.pane3.Controls.Add(this.lblUpdate);
            this.pane3.Location = new System.Drawing.Point(29, 28);
            this.pane3.Name = "pane3";
            this.pane3.Size = new System.Drawing.Size(308, 383);
            this.pane3.TabIndex = 19;
            // 
            // lblChanges
            // 
            this.lblChanges.AutoSize = true;
            this.lblChanges.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanges.ForeColor = System.Drawing.Color.White;
            this.lblChanges.Location = new System.Drawing.Point(160, 11);
            this.lblChanges.Name = "lblChanges";
            this.lblChanges.Size = new System.Drawing.Size(142, 36);
            this.lblChanges.TabIndex = 0;
            this.lblChanges.Text = "تغییرات آپدیت";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUpdate.Location = new System.Drawing.Point(14, 63);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(315, 1240);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = resources.GetString("lblUpdate.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 80);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "**طراحی و توسعه: آرش بنی آشکار - دانیال درویش**";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pane3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UcSettings";
            this.Size = new System.Drawing.Size(728, 549);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pane3.ResumeLayout(false);
            this.pane3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Panel pane3;
        private System.Windows.Forms.Label lblChanges;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}
