using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProfessional
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        int[] _rainSpeed = { 4, 6, 8, 3, 5, 6, 7, 4 };
        private readonly int _lodingSpeed = 2;
        private float _initialpercentage;
        Form1 frm1 = new Form1();

        private void frmLoading_Load(object sender, EventArgs e)
        {
            frm1.Show();
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:

                        picrain1.Location = new Point(picrain1.Location.X, picrain1.Location.Y + _rainSpeed[i]);
                        if (picrain1.Location.Y > panel1.Size.Height + picrain1.Size.Height)
                        {
                            picrain1.Location = new Point(picrain1.Location.X, 0 - picrain1.Size.Height);
                        }
                        break;
                    case 1:

                        picrain2.Location = new Point(picrain2.Location.X, picrain2.Location.Y + _rainSpeed[i]);
                        if (picrain2.Location.Y > panel1.Size.Height + picrain2.Size.Height)
                        {
                            picrain2.Location = new Point(picrain2.Location.X, 0 - picrain2.Size.Height);
                        }
                        break;
                    case 2:

                        picrain3.Location = new Point(picrain3.Location.X, picrain3.Location.Y + _rainSpeed[i]);
                        if (picrain3.Location.Y > panel1.Size.Height + picrain3.Size.Height)
                        {
                            picrain3.Location = new Point(picrain3.Location.X, 0 - picrain3.Size.Height);
                        }
                        break;
                    case 3:

                        picrain4.Location = new Point(picrain4.Location.X, picrain4.Location.Y + _rainSpeed[i]);
                        if (picrain4.Location.Y > panel1.Size.Height + picrain4.Size.Height)
                        {
                            picrain4.Location = new Point(picrain4.Location.X, 0 - picrain4.Size.Height);
                        }
                        break;
                    case 4:

                        picrain5.Location = new Point(picrain5.Location.X, picrain5.Location.Y + _rainSpeed[i]);
                        if (picrain5.Location.Y > panel1.Size.Height + picrain5.Size.Height)
                        {
                            picrain5.Location = new Point(picrain5.Location.X, 0 - picrain5.Size.Height);
                        }
                        break;
                    case 5:

                        picrain6.Location = new Point(picrain6.Location.X, picrain6.Location.Y + _rainSpeed[i]);
                        if (picrain6.Location.Y > panel1.Size.Height + picrain6.Size.Height)
                        {
                            picrain6.Location = new Point(picrain6.Location.X, 0 - picrain6.Size.Height);
                        }
                        break;
                    case 6:

                        picrain7.Location = new Point(picrain7.Location.X, picrain7.Location.Y + _rainSpeed[i]);
                        if (picrain7.Location.Y > panel1.Size.Height + picrain7.Size.Height)
                        {
                            picrain7.Location = new Point(picrain7.Location.X, 0 - picrain7.Size.Height);
                        }
                        break;
                    case 7:

                        picrain8.Location = new Point(picrain8.Location.X, picrain8.Location.Y + _rainSpeed[i]);
                        if (picrain8.Location.Y > panel1.Size.Height + picrain8.Size.Height)
                        {
                            picrain8.Location = new Point(picrain8.Location.X, 0 - picrain8.Size.Height);
                        }
                        break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm1.Show();
            _initialpercentage += _lodingSpeed;
            var percentage = _initialpercentage / picWater.Height * 100;
            label1.Text = (int)percentage + " %";
            if (percentage == 100)
            {
                frm1.timer1.Start();
                label1.Visible = false;
                label2.Visible = true;
                this.Hide();
            }
            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + _lodingSpeed);
            if (panel2.Location.X > picWater.Location.Y + picWater.Height)
            {
                frm1.timer1.Start();
                label1.Text = "100 %";
                timer2.Stop();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
