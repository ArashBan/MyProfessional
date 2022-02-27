using System;
using System.Windows.Forms;
using BusinessEntity.Utilities;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace MyProfessional
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        #region Connection Strings

        private readonly string _backupConString =
            @"data source=(local);initial catalog=MyProfessional;integrated security=True;multipleactiveresultsets=True";

        private readonly string _restoreConString =
            "Data Source=(local);Initial Catalog=master;Integrated Security=True";

        #endregion

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(_backupConString))
            {
                var srvConn = new ServerConnection(con);
                var srvr = new Server(srvConn);
                if (srvr != null)
                {
                    try
                    {
                        var bkpDatabase = new Backup
                        {
                            Action = BackupActionType.Database,
                            Database = "MyProfessional"
                        };
                        var sfd = new SaveFileDialog
                        {
                            Filter = "Backup File|*.ARADB",
                            FileName = DateTime.Now.ToShortDateString().Replace('/', '.') + "_Backup"
                        };
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            var bkpDevice = new BackupDeviceItem(sfd.FileName, DeviceType.File);
                            bkpDatabase.Devices.Add(bkpDevice);
                            bkpDatabase.SqlBackup(srvr);
                            CustomMessageBox.ShowMessageBox("!فایل بکاپ با موفقیت ذخیره شد",
                                CustomMessageBox.Conditions.Information);
                        }
                    }
                    catch (Exception) { CustomMessageBox.ShowMessageBox("!فایل بکاپ را در درایوی غیر از درایو ویندوز ذخیره کنید",
                            CustomMessageBox.Conditions.Error); }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult Check = CustomMessageBox.ShowMessageBox(
                "!!!ممکن است تمامی اطلاعات موجود در دیتابیس شما تغییر کند \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید",
                CustomMessageBox.Conditions.Warning, MessageBoxButtons.YesNo);
            if (Check == DialogResult.Yes)
            {
                SqlConnection.ClearAllPools();
                using (var con = new SqlConnection(_restoreConString))
                {
                    var srvConn = new ServerConnection(con);
                    var srvr = new Server(srvConn);
                    srvr.KillAllProcesses("MyProfessional");
                    if (srvr != null)
                    {
                        try
                        {
                            var rstDatabase = new Restore
                            {
                                Action = RestoreActionType.Database,
                                Database = "MyProfessional"
                            };
                            var opfd = new OpenFileDialog
                            {
                                Filter = "Backup File|*.ARADB"
                            };
                            if (opfd.ShowDialog() == DialogResult.OK)
                            {
                                var bkpDevice = new BackupDeviceItem(opfd.FileName, DeviceType.File);
                                rstDatabase.Devices.Add(bkpDevice);
                                rstDatabase.ReplaceDatabase = true;
                                rstDatabase.SqlRestore(srvr);
                                CustomMessageBox.ShowMessageBox("!اطلاعات با موفقیت بازیابی شد",
                                    CustomMessageBox.Conditions.Information);
                            }
                        }
                        catch (Exception f) { CustomMessageBox.ShowMessageBox(f.ToString(), CustomMessageBox.Conditions.Error); }
                    }
                }
            }
        }
    }
}