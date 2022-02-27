
namespace MyProfessional
{
    partial class ucTimer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWarningTimer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudWarningTimer = new System.Windows.Forms.NumericUpDown();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStart.Location = new System.Drawing.Point(434, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 70);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStop.Location = new System.Drawing.Point(166, 253);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(128, 70);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "پایان";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimer.Location = new System.Drawing.Point(568, 162);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(116, 31);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "تایمر (دقیقه):";
            // 
            // lblWarningTimer
            // 
            this.lblWarningTimer.AutoSize = true;
            this.lblWarningTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWarningTimer.Location = new System.Drawing.Point(288, 162);
            this.lblWarningTimer.Name = "lblWarningTimer";
            this.lblWarningTimer.Size = new System.Drawing.Size(153, 31);
            this.lblWarningTimer.TabIndex = 8;
            this.lblWarningTimer.Text = "تایمر اخطار (ثانیه):";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTitle.Location = new System.Drawing.Point(595, 207);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "عنوان:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblMinute.Location = new System.Drawing.Point(305, 348);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(54, 47);
            this.lblMinute.TabIndex = 14;
            this.lblMinute.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSecond.Location = new System.Drawing.Point(370, 348);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(54, 47);
            this.lblSecond.TabIndex = 12;
            this.lblSecond.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblPoints.Location = new System.Drawing.Point(350, 345);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(29, 47);
            this.lblPoints.TabIndex = 13;
            this.lblPoints.Text = ":";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 2;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPause.Location = new System.Drawing.Point(300, 253);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(128, 70);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "مکث";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitle.Location = new System.Drawing.Point(166, 207);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(397, 39);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = global::MyProfessional.Properties.Settings.Default.Title;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudWarningTimer
            // 
            this.nudWarningTimer.AccessibleName = "0";
            this.nudWarningTimer.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MyProfessional.Properties.Settings.Default, "WarningTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudWarningTimer.Location = new System.Drawing.Point(166, 162);
            this.nudWarningTimer.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWarningTimer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudWarningTimer.Name = "nudWarningTimer";
            this.nudWarningTimer.Size = new System.Drawing.Size(115, 39);
            this.nudWarningTimer.TabIndex = 1;
            this.nudWarningTimer.Tag = "";
            this.nudWarningTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWarningTimer.Value = global::MyProfessional.Properties.Settings.Default.WarningTimer;
            // 
            // nudTimer
            // 
            this.nudTimer.AccessibleDescription = "";
            this.nudTimer.AccessibleName = "0";
            this.nudTimer.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MyProfessional.Properties.Settings.Default, "Timer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudTimer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimer.Location = new System.Drawing.Point(447, 162);
            this.nudTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(115, 39);
            this.nudTimer.TabIndex = 0;
            this.nudTimer.Tag = "";
            this.nudTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimer.Value = global::MyProfessional.Properties.Settings.Default.Timer;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWarningTimer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.nudWarningTimer);
            this.Controls.Add(this.nudTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucTimer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(728, 549);
            this.Load += new System.EventHandler(this.UCTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblWarningTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblPoints;
        public System.Windows.Forms.NumericUpDown nudTimer;
        public System.Windows.Forms.NumericUpDown nudWarningTimer;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Button btnStart;
    }
}
