using System.Windows.Forms;

namespace BusinessEntity.Utilities
{
    public static class CustomMessageBox
    {
        public static DialogResult ShowMessageBox(string text, Status status, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            switch (status)
            {
                case Status.Information:
                    return MessageBox.Show(text, "Done!", buttons, MessageBoxIcon.Information);
                case Status.Warning:
                    return MessageBox.Show(text, "Warning!", buttons, MessageBoxIcon.Warning);
                default:
                    return MessageBox.Show(text, "Error!", buttons, MessageBoxIcon.Error);
            }
            //if (status == Status.Information)
            //{
            //    return MessageBox.Show(text, "Information!", buttons, MessageBoxIcon.Information);
            //}
            //else if (status == Status.Warning)
            //{
            //    return MessageBox.Show(text, "Warning!", buttons, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    return MessageBox.Show(text, "Error!", buttons, MessageBoxIcon.Error);
            //}
        }

        public enum Status
        {
            Information, Warning, Error
        }
    }
}
