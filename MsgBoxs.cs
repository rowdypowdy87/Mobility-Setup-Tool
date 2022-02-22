using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public static class MsgBoxs
    {
        public static void MsgBox_Normal(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgBox_Error(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgBox_Warning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult MsgBox_Question(string text)
        {
            return (MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }
    }
}