using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public class ExComboBox : ComboBox
    {
        public ExComboBox()
        {
            // Add event handlers
            Leave           += new EventHandler(ExCombo_OnLeave);
            DropDown        += new EventHandler(ExCombo_DropDown);
            DropDownClosed  += new EventHandler(ExCombo_DropDownClosed);
        }

        // When combobox drops down
        private void ExCombo_DropDown(object sender, EventArgs e)
        {
            // Turn off autocomplete when the drop down is active
            AutoCompleteMode = AutoCompleteMode.None;
        }

        // When drop down closes
        private void ExCombo_DropDownClosed(object sender, EventArgs e)
        {
            // Turn on autocomplete in normal state
            AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        // On leave event
        private void ExCombo_OnLeave(object sender, EventArgs e)
        {
            // Search all current items and verify that the input free text
            // matches one of the pre-loaded items, otherwise clear free text
            bool found = false;

            foreach(string item in Items)
            {
                if(item == Text)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Text = "";
            }
        }
    }
}
