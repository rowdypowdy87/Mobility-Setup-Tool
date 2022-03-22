using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class QuoteOutput : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;

        public QuoteOutput(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void QuoteOutput_Load(object sender, EventArgs e)
        {
            BackColor = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor = RefForm.ThemeController.GetBordercolor();
            MinimizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();
            MaximizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();

            RefForm.ThemeController.AddControls(TitleBar_PNL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(MinimizeButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(MaximizeButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(CloseButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(this, THEME_TYPE.Back);
        }

        #region WINDOW THEME CONTROLS

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

        // Handle resizing
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
                        Point clientPoint = this.PointToClient(screenPoint);
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

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f);
            Brush Fill = BorderPen.Brush;
            Graphics FormGFX = e.Graphics;
            Rectangle FormBorder, PanelBorder;

            // Get rect
            FormBorder = new Rectangle(ClientRectangle.X,
                                       ClientRectangle.Y,
                                       ClientRectangle.Width - 1,
                                       ClientRectangle.Height - 1);

            PanelBorder = new Rectangle(QuoteOutput_LayoutPanel.Location.X - 1,
                                        QuoteOutput_LayoutPanel.Location.Y - 1,
                                        QuoteOutput_LayoutPanel.Width + 2,
                                        QuoteOutput_LayoutPanel.Height + 2);


            // Draw rectangles
            FormGFX.DrawRectangle(BorderPen, FormBorder);
            FormGFX.DrawRectangle(BorderPen, PanelBorder);
            FormGFX.FillRectangle(Fill, PanelBorder);
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

        #endregion

        private void QOutput_VisibleChanged(object sender, EventArgs e)
        {
            RefForm.QOutputWindow_MN.Checked = Visible;
        }
    }
}
