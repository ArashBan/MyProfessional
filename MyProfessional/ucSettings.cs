using System;
using System.Windows.Forms;
using BusinessEntity.Utilities;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace MyProfessional
{
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
        }

        #region Connection Strings
        private readonly string _backupConString =
            "Data Source=(local); Initial Catalog=MyProfessional; Integrated Security=True; MultipleActiveResultSets=True";

        private readonly string _restoreConString =
            "Data Source=(local); Initial Catalog=master; Integrated Security=True";
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
                            _ = CustomMessageBox.ShowMessageBox("!فایل بکاپ با موفقیت ذخیره شد",
                                CustomMessageBox.Status.Information);
                        }
                    }
                    catch (Exception)
                    {
                        _ = CustomMessageBox.ShowMessageBox("!فایل بکاپ را در درایوی غیر از درایو ویندوز ذخیره کنید",
            CustomMessageBox.Status.Error);
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowMessageBox(
                    "!ممکن است تمامی اطلاعات موجود در دیتابیس شما تغییر کند\n.را انتخاب کنید Yes اگر مشکلی با این مورد ندارید",
                    CustomMessageBox.Status.Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                            var ofd = new OpenFileDialog
                            {
                                Filter = "Backup File|*.ARADB"
                            };
                            if (ofd.ShowDialog() == DialogResult.OK)
                            {
                                var bkpDevice = new BackupDeviceItem(ofd.FileName, DeviceType.File);
                                rstDatabase.Devices.Add(bkpDevice);
                                rstDatabase.ReplaceDatabase = true;
                                rstDatabase.SqlRestore(srvr);
                                _ = CustomMessageBox.ShowMessageBox("!اطلاعات با موفقیت بازیابی شد",
                                    CustomMessageBox.Status.Information);
                            }
                        }
                        catch (Exception f)
                        {
                            _ = CustomMessageBox.ShowMessageBox(f.ToString(), CustomMessageBox.Status.Error);
                        }
                    }
                }
            }
        }
    }
}
