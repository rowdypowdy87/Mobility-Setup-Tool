using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class VersionHistory : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;

        public VersionHistory(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void VersionHist_Load(object sender, EventArgs e)
        {
            BackColor                       = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor          = RefForm.ThemeController.GetBordercolor();
            MinimizeButton_LBL.BackColor    = RefForm.ThemeController.GetBordercolor();
            MaximizeButton_LBL.BackColor    = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor       = RefForm.ThemeController.GetBordercolor();

            List<VersionInfo> VersionHist = RefForm.DatabaseController.GetVersionInfo();

            for (int i = 0; i < VersionHist.Count; i++)
            {
                VersionHist_DGV.Rows.Add();

                VersionHist_DGV[0, i].Value = VersionHist[i].ChangeNumber;
                VersionHist_DGV[1, i].Value = VersionHist[i].Description;
                VersionHist_DGV[2, i].Value = VersionHist[i].ChangedOn;
                VersionHist_DGV[3, i].Value = VersionHist[i].ApprovedBy;
                VersionHist_DGV[4, i].Value = VersionHist[i].ChangedBy;
            }

        }


        // Close button label mouse enter event 
        private void CloseButton_LBL_MouseEnter(object sender, EventArgs e) { CloseButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor(); }

        // Close button label mouse leave event 
        private void CloseButton_LBL_MouseLeave(object sender, EventArgs e) { CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Close button label mouse down 
        private void CloseButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Hide();
        }

        // Minimize button label mouse down event 
        private void MiniButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized;
        }

        // Minimize button label mouse enter event 
        private void MiniButton_LBL_MouseEnter(object sender, EventArgs e) { MinimizeButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor(); }

        // Minimize button label mouse leave event 
        private void MiniButton_LBL_MouseLeave(object sender, EventArgs e) { MinimizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Maximize button mouse enter event 
        private void MaxButton_LBL_MouseEnter(object sender, EventArgs e) { MaximizeButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor(); }

        // Maximize button label mouse leave event 
        private void MaxButton_LBL_MouseLeave(object sender, EventArgs e) { MaximizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 12;

            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12;
                            else
                                m.Result = (IntPtr)14;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2;
                            else
                                m.Result = (IntPtr)11;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15;
                            else
                                m.Result = (IntPtr)17;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        // Title bar double click event 
        private void TitleBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MS")));
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MF")));
            }
        }

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

        // Titlebar mouse down event 
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged           = true;
                Point pointStartPosition    = PointToScreen(new Point(e.X, e.Y));
                offset                      = new Point
                {
                    X = Location.X - pointStartPosition.X,
                    Y = Location.Y - pointStartPosition.Y
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

        // Maximize button label mouse down event 
        private void MaxButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MS")));
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                    MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MF")));
                }
            }
        }

        private void VersionHist_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
            };
        }
    }
}
