using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class EquipmentSelect : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        public string SelectedItem = "";

        public EquipmentSelect(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void EquipmentSelect_Load(object sender, EventArgs e)
        {
            BackColor = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor = RefForm.ThemeController.GetBordercolor();
            MiniButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();
            MaxiButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();

            RefForm.ThemeController.AddControls(TitleBar_PNL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(MiniButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(MaxiButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(CloseButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(BackColor, THEME_TYPE.Back);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoubleBuffered = true;
            ResizeRedraw = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
            };
        }

        // Close button label mouse enter event 
        private void CloseButton_LBL_MouseEnter(object sender, EventArgs e)
        {
            RefForm.General_TT.SetToolTip((Label)sender, "Close");
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        // Close button label mouse leave event 
        private void CloseButton_LBL_MouseLeave(object sender, EventArgs e) { CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Close button label mouse down 
        private void CloseButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Close();
        }

        // Minimize button label mouse down event 
        private void MiniButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized;
        }

        // Minimize button label mouse enter event 
        private void MiniButton_LBL_MouseEnter(object sender, EventArgs e)
        {
            RefForm.General_TT.SetToolTip((Label)sender, "Minimize");
            MiniButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        // Minimize button label mouse leave event 
        private void MiniButton_LBL_MouseLeave(object sender, EventArgs e) { MiniButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Titlebar mouse move event 
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

            }
        }

        // Move window
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));

                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                //_MaxButton_Click(sender, e);
            }
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = this.Location.X - pointStartPosition.X,
                    Y = this.Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2) isTopPanelDragged = false;
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EqFound_LV.Items.Count; i++)
            {
                if (EqFound_LV.Items[i].Checked)
                {
                    SelectedItem = EqFound_LV.Items[i].SubItems[0].Text;
                }
            }

            if (SelectedItem == "")
            {
                MsgBoxs.MsgBox_Error("Nothing was selected!");
            }
            else
            {
                Close();
            }
        }

        // I need to know the last item checked
        private ListViewItem lastItemChecked;

        private void EqFound_LV_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != EqFound_LV.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastItemChecked.Checked = false;
            }

            // store current item
            lastItemChecked = EqFound_LV.Items[e.Index];
        }
    }
}
