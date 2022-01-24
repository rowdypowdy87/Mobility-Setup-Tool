using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

            BackColor                       = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor          = RefForm.ThemeController.GetBordercolor();
            MiniButton_LBL.BackColor        = RefForm.ThemeController.GetBordercolor();
            MaxiButton_LBL.BackColor        = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor       = RefForm.ThemeController.GetBordercolor();
        }


        private void EquipmentSelect_Paint(object sender, PaintEventArgs e)
        {
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
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
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
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
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
            for(int i = 0; i < EqFound_LV.Items.Count; i++)
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
    }
}
