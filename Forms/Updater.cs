using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mobility_Setup_Tool.Forms
{
    public partial class Updater : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool     isTopPanelDragged;
        public Point    offset;
        public bool     DidNotUpdate = false;
        public Thread   DownloadThread;

        public Updater(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            BackColor               = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor  = RefForm.ThemeController.GetBordercolor();
            DownloadThread          = new Thread(new ThreadStart(delegate { UpdateApplication(); }));
        }


        private void Updater_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f))
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

        public void UpdateApplication()
        {
            RefForm.SetText(ActualStatus_LBL.Text, "Preparing application for update...");
            


        }

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        private void CloseApp_BTN_Click(object sender, EventArgs e)
        {
            DidNotUpdate = true;
            Close();
        }
    }
}
