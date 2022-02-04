using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Mobility_Setup_Tool.Forms
{
    public partial class Updater : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool          isTopPanelDragged;
        public Point         offset;
        public bool          DidNotUpdate = false;
        public string        ProgStatus;
        public string        FilePath;

        public Updater(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            RefForm.Visible         = false;
            FilePath                = $"{RefForm.AppSettings.AppData}\\MST_Update.exe";

            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);

            UpdateApplication();
        }

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen BorderPen = new Pen(Color.Black, 1.0f);
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

        public void UpdateApplication()
        {
            WebClient SharePoint    = new WebClient();
            Uri       Link          = new Uri("http://uglteams/sites/fs/AdminLibrary/Mobility%20Setup%20Tool/MST_Update");

            SharePoint.UseDefaultCredentials = true;

            // Set event handlers
            SharePoint.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
            SharePoint.DownloadFileCompleted   += new AsyncCompletedEventHandler(DownloadCompletedCallback);

            // Download upate
            SharePoint.DownloadFileAsync(Link, FilePath);
        }

        // Progress updated
        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            ActualStatus_LBL.Text = $"Downloading update [{e.BytesReceived/1000000}MB/{e.TotalBytesToReceive/1000000}MBs] {e.ProgressPercentage}%";
        }

        // Download completed
        private void DownloadCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            ProgStatus = $"Running update";

            // Start the exe
            using (Process Installer = new Process())
            {
                Installer.StartInfo.UseShellExecute = true;
                Installer.StartInfo.FileName        = FilePath;
                Installer.StartInfo.Verb            = "runas";

                Installer.Start();
            };

            MsgBoxs.MsgBox_Normal("The application will now update, please follow the instructions of the installer and run the Mobilty Setup Tool again once you are done. Thank you");
            Application.Exit();
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) 
        { 
            isTopPanelDragged = false; 
        }

        private void CloseApp_BTN_Click(object sender, EventArgs e)
        {
            DidNotUpdate = true;
            Close();
        }
    }
}
