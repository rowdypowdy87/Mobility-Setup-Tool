using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public static class MsgBoxs
    {
        public static DialogResult MsgBox_Normal(string text)
        {
            return (MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }

        public static DialogResult MsgBox_Error(string text)
        {
            return (MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
        }

        public static DialogResult MsgBox_Warning(string text)
        {
            return (MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning));
        }

        public static DialogResult MsgBox_Question(string text)
        {
            return (MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

      
    }
}