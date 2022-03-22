using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class AppSettings : Form
    {
        public MainForm RefForm;

        // Window movement globals
        private bool isTopPanelDragged;
        private Point offset;
        public string CurPlant;

        public AppSettings(MainForm r)
        {
            RefForm = r;
            InitializeComponent();

            CurPlant = RefForm.AppSettings.Plant;
        }

        // Move window
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
                Location = newPoint;
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;

            }
        }

        // Move window
        private void Title_MouseDown(object sender, MouseEventArgs e)
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
            TitleBar.BackColor = RefForm.ThemeController.GetBordercolor();
            BackColor = RefForm.ThemeController.GetBackcolor();
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

            // Set field defaults
            RefForm.FunctionLoc_CB.Text = RefForm.AppSettings.ADefaults.FunctionLocation;
            RefForm.PartyName_CB.Text = RefForm.AppSettings.ADefaults.SoldToParty;
            RefForm.PMActivityType_CB.Text = RefForm.AppSettings.ADefaults.PmActivityType;
            RefForm.Priority_CB.Text = RefForm.AppSettings.ADefaults.Priority;
            RefForm.ExternalReference_TB.Text = RefForm.AppSettings.ADefaults.ExternalReference;
            RefForm.VarPMActivityType_CB.Text = RefForm.AppSettings.ADefaults.PmActivityType;
            RefForm.VarSOPriority_CB.Text = RefForm.AppSettings.ADefaults.Priority;
            RefForm.VarExternalReference_TB.Text = RefForm.AppSettings.ADefaults.ExternalReference;

            // Plants have changed
            if (RefForm.AppSettings.Plant != CurPlant)
            {
                if (MsgBoxs.MsgBox_Question("The Plant has been changed. A restart is required before these changes will take effect. Do you want to restart now?") == DialogResult.Yes)
                {
                    RefForm.AppSettings.Restart();
                }
            }

            // Close form after applying settings
            Close();
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
