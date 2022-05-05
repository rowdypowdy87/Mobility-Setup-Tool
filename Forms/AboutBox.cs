using System;
using System.Drawing;
using System.Windows.Forms;

/*
 *  TEMPLATE CLASS FOR FORM DESIGN WITH ALL FEATURES, COPY THIS TO MAKE A NEW FORM FOR THE APPLICATION
 * 
 */

namespace Mobility_Setup_Tool
{
    public partial class AboutBox : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;

        public AboutBox(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            BackColor                   = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor      = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor   = RefForm.ThemeController.GetBordercolor();
            BgPanel.ForeColor           = RefForm.ThemeController.GetBordercolor();

            RefForm.ThemeController.AddControls(TitleBar_PNL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(CloseButton_LBL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(BackColor, THEME_TYPE.Back);

            // EULA
            // EULA
            AboutText.Text = $"Created for UGL Pty Ltd (2022){Environment.NewLine}" +
                             $"Written by Clinton Wheeler (clinton.wheeler@ugllimited.com){Environment.NewLine}" +
                             $"Developed by Mike Ellis (michael.ellis@ugllimited.com){Environment.NewLine}{Environment.NewLine}" +
                             $"Refer to Help -> Version History for details on previous versions"; 


            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);

            OkButton.Select();
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


        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f);
            //Brush     Fill        = BorderPen.Brush;
            Graphics FormGFX = e.Graphics;
            Rectangle FormBorder;

            // Get rect
            FormBorder = new Rectangle(ClientRectangle.X,
                                         ClientRectangle.Y,
                                         ClientRectangle.Width - 1,
                                         ClientRectangle.Height - 1);


            // Draw rectangles
            FormGFX.DrawRectangle(BorderPen, FormBorder);
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
                Point pointStartPosition = PointToScreen(new Point(e.X, e.Y));
                offset = new Point
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

        #endregion

        private void OkButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
