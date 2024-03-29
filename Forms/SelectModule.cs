﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool.Forms
{
    public partial class SelectModule : Form
    {
        public MainForm RefForm;

        public SelectModule(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new EventHandler(Continue_BTN_Click));
            else
                Close();
        }

        private void Module_Load(object sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new AssemblyLoadEventHandler(Module_Load));
            else
            { 
                TitleBar.BackColor = RefForm.ThemeController.GetBordercolor();
                BackColor = RefForm.ThemeController.GetBackcolor();

                RefForm.ThemeController.AddControls(TitleBar, THEME_TYPE.Border);
                RefForm.ThemeController.AddControls(BackColor, THEME_TYPE.Back);

                // Manually centre the form to MainForm
                Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);
            }
        }

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f);
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
    }
}
