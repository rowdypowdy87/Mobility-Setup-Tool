using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mobility_Setup_Tool.Forms
{
    public partial class GetLongText : Form
    {
        readonly MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        public string LongText 
        {
            get { return LongText_RTB.Text; }
            set { LongText_RTB.Text = value; }
        }

        public GetLongText(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void GetLongText_Load(object sender, EventArgs e)
        {
            BackColor               = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor  = RefForm.ThemeController.GetBordercolor();

            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);
        }


        private void GetLongText_Paint(object sender, PaintEventArgs e)
        {
            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 2.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
                e.Graphics.DrawRectangle(BorderPen, 
                                         LongText_RTB.Location.X-1,
                                         LongText_RTB.Location.Y-1,
                                         LongText_RTB.Width+2,
                                         LongText_RTB.Height+2);
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

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
