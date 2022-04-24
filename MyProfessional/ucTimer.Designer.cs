
namespace MyProfessional
{
    partial class UcTimer
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
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWarningTimer = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimerMinute = new System.Windows.Forms.Label();
            this.lblTimerSecond = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimerPoints = new System.Windows.Forms.Label();
            this.btnTimerPause = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCalender = new System.Windows.Forms.Label();
            this.nudWarningTimer = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.btnCronometerStart = new System.Windows.Forms.Button();
            this.btnCronometerPause = new System.Windows.Forms.Button();
            this.btnCronometerMark = new System.Windows.Forms.Button();
            this.lblCronometerMinute = new System.Windows.Forms.Label();
            this.lblCronometerSecond = new System.Windows.Forms.Label();
            this.lblCronometerPoints = new System.Windows.Forms.Label();
            this.lblCronometerMiniSecond = new System.Windows.Forms.Label();
            this.lblCronometerPoints2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnCronometerStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.panel1.SuspendLayout();
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
            // btnTimerStart
            // 
            this.btnTimerStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnTimerStart.FlatAppearance.BorderSize = 2;
            this.btnTimerStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnTimerStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTimerStart.Location = new System.Drawing.Point(349, 161);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(128, 70);
            this.btnTimerStart.TabIndex = 3;
            this.btnTimerStart.Text = "شروع";
            this.btnTimerStart.UseVisualStyleBackColor = false;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Enabled = false;
            this.btnTimerStop.FlatAppearance.BorderSize = 2;
            this.btnTimerStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnTimerStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTimerStop.Location = new System.Drawing.Point(81, 161);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(128, 70);
            this.btnTimerStop.TabIndex = 5;
            this.btnTimerStop.Text = "پایان";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimer.Location = new System.Drawing.Point(500, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(116, 31);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "تایمر (دقیقه):";
            // 
            // lblWarningTimer
            // 
            this.lblWarningTimer.AutoSize = true;
            this.lblWarningTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWarningTimer.Location = new System.Drawing.Point(485, 70);
            this.lblWarningTimer.Name = "lblWarningTimer";
            this.lblWarningTimer.Size = new System.Drawing.Size(153, 31);
            this.lblWarningTimer.TabIndex = 8;
            this.lblWarningTimer.Text = "تایمر اخطار (ثانیه):";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTitle.Location = new System.Drawing.Point(522, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "عنوان:";
            // 
            // lblTimerMinute
            // 
            this.lblTimerMinute.AutoSize = true;
            this.lblTimerMinute.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimerMinute.Location = new System.Drawing.Point(167, 45);
            this.lblTimerMinute.Name = "lblTimerMinute";
            this.lblTimerMinute.Size = new System.Drawing.Size(54, 47);
            this.lblTimerMinute.TabIndex = 14;
            this.lblTimerMinute.Text = "00";
            // 
            // lblTimerSecond
            // 
            this.lblTimerSecond.AutoSize = true;
            this.lblTimerSecond.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimerSecond.Location = new System.Drawing.Point(232, 45);
            this.lblTimerSecond.Name = "lblTimerSecond";
            this.lblTimerSecond.Size = new System.Drawing.Size(54, 47);
            this.lblTimerSecond.TabIndex = 12;
            this.lblTimerSecond.Text = "00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimerPoints
            // 
            this.lblTimerPoints.AutoSize = true;
            this.lblTimerPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerPoints.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblTimerPoints.Location = new System.Drawing.Point(212, 42);
            this.lblTimerPoints.Name = "lblTimerPoints";
            this.lblTimerPoints.Size = new System.Drawing.Size(29, 47);
            this.lblTimerPoints.TabIndex = 13;
            this.lblTimerPoints.Text = ":";
            // 
            // btnTimerPause
            // 
            this.btnTimerPause.Enabled = false;
            this.btnTimerPause.FlatAppearance.BorderSize = 2;
            this.btnTimerPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnTimerPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnTimerPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTimerPause.Location = new System.Drawing.Point(215, 161);
            this.btnTimerPause.Name = "btnTimerPause";
            this.btnTimerPause.Size = new System.Drawing.Size(128, 70);
            this.btnTimerPause.TabIndex = 4;
            this.btnTimerPause.Text = "مکث";
            this.btnTimerPause.UseVisualStyleBackColor = true;
            this.btnTimerPause.Click += new System.EventHandler(this.btnTimerPause_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblCalender);
            this.panel2.Controls.Add(this.nudWarningTimer);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.lblTimerMinute);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblTimerSecond);
            this.panel2.Controls.Add(this.lblWarningTimer);
            this.panel2.Controls.Add(this.btnTimerStart);
            this.panel2.Controls.Add(this.btnTimerPause);
            this.panel2.Controls.Add(this.btnTimerStop);
            this.panel2.Controls.Add(this.lblTimerPoints);
            this.panel2.Controls.Add(this.nudTimer);
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Location = new System.Drawing.Point(29, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 256);
            this.panel2.TabIndex = 19;
            // 
            // lblCalender
            // 
            this.lblCalender.AutoSize = true;
            this.lblCalender.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalender.ForeColor = System.Drawing.Color.White;
            this.lblCalender.Location = new System.Drawing.Point(608, 11);
            this.lblCalender.Name = "lblCalender";
            this.lblCalender.Size = new System.Drawing.Size(58, 36);
            this.lblCalender.TabIndex = 0;
            this.lblCalender.Text = "تایمر";
            // 
            // nudWarningTimer
            // 
            this.nudWarningTimer.AccessibleName = "0";
            this.nudWarningTimer.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::MyProfessional.Properties.Settings.Default, "WarningTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudWarningTimer.Location = new System.Drawing.Point(363, 70);
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
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MyProfessional.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTitle.Location = new System.Drawing.Point(81, 115);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(397, 39);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = global::MyProfessional.Properties.Settings.Default.Title;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.nudTimer.Location = new System.Drawing.Point(363, 25);
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
            // btnCronometerStart
            // 
            this.btnCronometerStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnCronometerStart.FlatAppearance.BorderSize = 2;
            this.btnCronometerStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnCronometerStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCronometerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronometerStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCronometerStart.Location = new System.Drawing.Point(251, 29);
            this.btnCronometerStart.Name = "btnCronometerStart";
            this.btnCronometerStart.Size = new System.Drawing.Size(128, 70);
            this.btnCronometerStart.TabIndex = 3;
            this.btnCronometerStart.Text = "شروع";
            this.btnCronometerStart.UseVisualStyleBackColor = false;
            this.btnCronometerStart.Click += new System.EventHandler(this.btnCronometerStart_Click);
            // 
            // btnCronometerPause
            // 
            this.btnCronometerPause.Enabled = false;
            this.btnCronometerPause.FlatAppearance.BorderSize = 2;
            this.btnCronometerPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnCronometerPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCronometerPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronometerPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCronometerPause.Location = new System.Drawing.Point(251, 108);
            this.btnCronometerPause.Name = "btnCronometerPause";
            this.btnCronometerPause.Size = new System.Drawing.Size(128, 70);
            this.btnCronometerPause.TabIndex = 4;
            this.btnCronometerPause.Text = "مکث";
            this.btnCronometerPause.UseVisualStyleBackColor = true;
            this.btnCronometerPause.Click += new System.EventHandler(this.btnCronometerPause_Click);
            // 
            // btnCronometerMark
            // 
            this.btnCronometerMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.btnCronometerMark.FlatAppearance.BorderSize = 2;
            this.btnCronometerMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnCronometerMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCronometerMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronometerMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCronometerMark.Location = new System.Drawing.Point(117, 108);
            this.btnCronometerMark.Name = "btnCronometerMark";
            this.btnCronometerMark.Size = new System.Drawing.Size(128, 70);
            this.btnCronometerMark.TabIndex = 3;
            this.btnCronometerMark.Text = "حذف مارک ها";
            this.btnCronometerMark.UseVisualStyleBackColor = false;
            this.btnCronometerMark.Click += new System.EventHandler(this.btnCronometerMark_Click);
            // 
            // lblCronometerMinute
            // 
            this.lblCronometerMinute.AutoSize = true;
            this.lblCronometerMinute.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometerMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCronometerMinute.Location = new System.Drawing.Point(396, 32);
            this.lblCronometerMinute.Name = "lblCronometerMinute";
            this.lblCronometerMinute.Size = new System.Drawing.Size(54, 47);
            this.lblCronometerMinute.TabIndex = 14;
            this.lblCronometerMinute.Text = "00";
            // 
            // lblCronometerSecond
            // 
            this.lblCronometerSecond.AutoSize = true;
            this.lblCronometerSecond.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometerSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCronometerSecond.Location = new System.Drawing.Point(461, 32);
            this.lblCronometerSecond.Name = "lblCronometerSecond";
            this.lblCronometerSecond.Size = new System.Drawing.Size(54, 47);
            this.lblCronometerSecond.TabIndex = 12;
            this.lblCronometerSecond.Text = "00";
            // 
            // lblCronometerPoints
            // 
            this.lblCronometerPoints.AutoSize = true;
            this.lblCronometerPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometerPoints.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometerPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCronometerPoints.Location = new System.Drawing.Point(441, 29);
            this.lblCronometerPoints.Name = "lblCronometerPoints";
            this.lblCronometerPoints.Size = new System.Drawing.Size(29, 47);
            this.lblCronometerPoints.TabIndex = 13;
            this.lblCronometerPoints.Text = ":";
            // 
            // lblCronometerMiniSecond
            // 
            this.lblCronometerMiniSecond.AutoSize = true;
            this.lblCronometerMiniSecond.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometerMiniSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCronometerMiniSecond.Location = new System.Drawing.Point(526, 32);
            this.lblCronometerMiniSecond.Name = "lblCronometerMiniSecond";
            this.lblCronometerMiniSecond.Size = new System.Drawing.Size(54, 47);
            this.lblCronometerMiniSecond.TabIndex = 12;
            this.lblCronometerMiniSecond.Text = "00";
            // 
            // lblCronometerPoints2
            // 
            this.lblCronometerPoints2.AutoSize = true;
            this.lblCronometerPoints2.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometerPoints2.Font = new System.Drawing.Font("Sahel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometerPoints2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblCronometerPoints2.Location = new System.Drawing.Point(506, 29);
            this.lblCronometerPoints2.Name = "lblCronometerPoints2";
            this.lblCronometerPoints2.Size = new System.Drawing.Size(29, 47);
            this.lblCronometerPoints2.TabIndex = 13;
            this.lblCronometerPoints2.Text = ":";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Sahel SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(414, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 112);
            this.listBox1.TabIndex = 20;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnCronometerStop
            // 
            this.btnCronometerStop.Enabled = false;
            this.btnCronometerStop.FlatAppearance.BorderSize = 2;
            this.btnCronometerStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btnCronometerStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.btnCronometerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCronometerStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCronometerStop.Location = new System.Drawing.Point(117, 29);
            this.btnCronometerStop.Name = "btnCronometerStop";
            this.btnCronometerStop.Size = new System.Drawing.Size(128, 70);
            this.btnCronometerStop.TabIndex = 5;
            this.btnCronometerStop.Text = "پایان";
            this.btnCronometerStop.UseVisualStyleBackColor = true;
            this.btnCronometerStop.Click += new System.EventHandler(this.btnCronometerStop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCronometerStop);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.lblCronometerMinute);
            this.panel1.Controls.Add(this.lblCronometerSecond);
            this.panel1.Controls.Add(this.lblCronometerPoints2);
            this.panel1.Controls.Add(this.lblCronometerMiniSecond);
            this.panel1.Controls.Add(this.lblCronometerPoints);
            this.panel1.Controls.Add(this.btnCronometerStart);
            this.panel1.Controls.Add(this.btnCronometerMark);
            this.panel1.Controls.Add(this.btnCronometerPause);
            this.panel1.Location = new System.Drawing.Point(29, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 207);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sahel SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(590, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "کرنومتر";
            // 
            // UcTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Sahel SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UcTimer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(728, 549);
            this.Load += new System.EventHandler(this.UcTimer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblWarningTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimerMinute;
        private System.Windows.Forms.Label lblTimerSecond;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimerPoints;
        public System.Windows.Forms.NumericUpDown nudTimer;
        public System.Windows.Forms.NumericUpDown nudWarningTimer;
        private System.Windows.Forms.Button btnTimerPause;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCalender;
        public System.Windows.Forms.Button btnCronometerStart;
        private System.Windows.Forms.Button btnCronometerPause;
        public System.Windows.Forms.Button btnCronometerMark;
        private System.Windows.Forms.Label lblCronometerMinute;
        private System.Windows.Forms.Label lblCronometerSecond;
        private System.Windows.Forms.Label lblCronometerPoints;
        private System.Windows.Forms.Label lblCronometerMiniSecond;
        private System.Windows.Forms.Label lblCronometerPoints2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnCronometerStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}
