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

            RefForm.ThemeController.AddControls(TitleBar_PNL, THEME_TYPE.Border);
            RefForm.ThemeController.AddControls(BackColor, THEME_TYPE.Back);

            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);
        }

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen         BorderPen       = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f);
            Graphics    FormGFX         = e.Graphics;
            Rectangle   FormBorder;

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
