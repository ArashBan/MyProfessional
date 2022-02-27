using System.Windows.Forms;

namespace BusinessEntity.Utilities
{
    public static class CustomMessageBox
    {
        public static DialogResult ShowMessageBox(string text, Conditions condition, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            switch (condition)
            {
                case Conditions.Information:
                    return MessageBox.Show(text, "Done!", buttons, MessageBoxIcon.Information);
                case Conditions.Warning:
                    return MessageBox.Show(text, "Warning!", buttons, MessageBoxIcon.Warning);
                default:
                    return MessageBox.Show(text, "Error!", buttons, MessageBoxIcon.Error);
            }
            //if (condition == Conditions.Information)
            //{
            //    return MessageBox.Show(text, "Information!", buttons, MessageBoxIcon.Information);
            //}
            //else if (condition == Conditions.Warning)
            //{
            //    return MessageBox.Show(text, "Warning!", buttons, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    return MessageBox.Show(text, "Error!", buttons, MessageBoxIcon.Error);
            //}
        }

        public enum Conditions
        {
            Information, Warning, Error
        }
    }
}
