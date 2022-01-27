using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class SelectNewStore : Form
    {
        bool            isTopPanelDragged;
        Point           offset;
        MainForm        RefForm;
        public string   StoreLoc {get; set;}
        public string   SpecStock {get; set;}
        public bool     RunChangeStore = true;

        public SelectNewStore(MainForm r) 
        {
            RefForm     = r;

            InitializeComponent();
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e) {
            if (isTopPanelDragged) {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

            }
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
            else {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2) {
                isTopPanelDragged = false;
                //_MaxButton_Click(sender, e);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
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

        // Main form paint event 
        private void NewStore_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw   = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 2.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width, Height);
            };
        }

        // Theme EVENTS
        private void CloseButton_LBL_MouseEnter(object sender, EventArgs e) 
        {
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        private void CloseButton_LBL_MouseLeave(object sender, EventArgs e) 
        {
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();
        }

        private void CloseButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void SelectNewStore_Load(object sender, EventArgs e) 
        {
            TitleBar_PNL.BackColor    = RefForm.ThemeController.GetBordercolor();
            Border_PNL.ForeColor      = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor();

            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);
        }

        private void Apply_BTN_Click(object sender, EventArgs e) 
        {
            StoreLoc  = StoreLocation_TB.Text;
            SpecStock = SpecialStock_TB.Text;

            if(StoreLoc == "")
            {
                MsgBoxs.MsgBox_Warning("Please enter a store location!");
            }
            else
            { 
                Close();
            }
        }

        private void Cancel_BTN_Click(object sender, EventArgs e) {
            RunChangeStore = false;
            Close();
        }
    }
}
