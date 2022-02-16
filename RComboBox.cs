using System;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public class RComboBox : ComboBox
    {
        public RComboBox()
        {
            Leave += new EventHandler(RComboBox_Leave);
        }

        // Stop from entering text
        private void RComboBox_Leave(object sender, EventArgs e)
        {
            // If its blank then leave
            if (Text == "" || Text == null) return;

            // Variables
            bool Found = false;

            // Scan the items
            for (int i = 0; i < Items.Count; i++)
            {
                if (Text == Items[i].ToString())
                {
                    Found = true;
                }
            }

            if (!Found)
            {
                //MsgBoxs.MsgBox_Error("You cannot enter free text into this field");
                Text = "";
            }

            Select(0, 0);
        }

    }
}
