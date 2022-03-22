using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class InitialSetup : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        public bool DidNotUpdate = false;

        public InitialSetup(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void InitialSetup_Load(object sender, EventArgs e)
        {
            //BackColor = RefForm.ThemeController.GetBackcolor();
            //TitleBar_PNL.BackColor = RefForm.ThemeController.GetBordercolor();
        }

        private void InitialSetup_Paint(object sender, PaintEventArgs e)
        {
            using (Pen BorderPen = new Pen(Color.Black, 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
            };
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

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            if (PlantNumberCB.Text == "")
            {
                MsgBoxs.MsgBox_Error("Plant number is a mandatory field, please select a plant");
                return;
            }
            Close();
        }
    }
}
