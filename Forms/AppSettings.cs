using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class AppSettings : Form
    {
        public MainForm RefForm;

        // Window movement globals
        private bool  isTopPanelDragged;
        private Point offset;

        public AppSettings(MainForm r) 
        {
            RefForm = r;
            InitializeComponent();
        }

        // Move window
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
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                //_MaxButton_Click(sender, e);
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar.PointToScreen(new Point(e.X, e.Y));
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

        private void Cancel_BTN_Click(object sender, EventArgs e) { Close(); }
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            AppSettings_PG.SelectedObject = RefForm.AppSettings;

            // Set colors
            TitleBar.BackColor            = RefForm.ThemeController.GetBordercolor();
            BackColor                     = RefForm.ThemeController.GetBackcolor();
    
        }

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            // Set colors
            TitleBar.BackColor = RefForm.ThemeController.GetBordercolor();
            BackColor = RefForm.ThemeController.GetBackcolor();

            // Set app defaults && theme settings
            RefForm.AppSettings.SaveSettings();
            RefForm.ThemeController.RefreshTheme();
            RefForm.ThemeController.SaveTheme();
        }

        private void AppSettings_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 2.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width, Height);
            };
        }
    }
}
