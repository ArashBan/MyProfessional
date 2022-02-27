using System;
using System.Windows.Forms;
using BusinessEntity.Utilities;

namespace MyProfessional
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Calender.InitializePersianCulture();
            Application.Run(new Form1());
        }
    }
}
