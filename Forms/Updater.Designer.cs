
namespace Mobility_Setup_Tool.Forms
{
    partial class Updater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentVersion_LBL = new System.Windows.Forms.Label();
            this.LatestVersion_LBL = new System.Windows.Forms.Label();
            this.Status_LBL = new System.Windows.Forms.Label();
            this.ActualCurrentVer_LBL = new System.Windows.Forms.Label();
            this.ActualLastestVer_LBL = new System.Windows.Forms.Label();
            this.CloseApp_BTN = new System.Windows.Forms.Button();
            this.ActualStatus_LBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(806, 37);
            this.TitleBar_PNL.TabIndex = 6;
            this.TitleBar_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar_PNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar_PNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // UGLLogo_PB
            // 
            this.UGLLogo_PB.ErrorImage = null;
            this.UGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.Sprite11;
            this.UGLLogo_PB.InitialImage = null;
            this.UGLLogo_PB.Location = new System.Drawing.Point(6, 6);
            this.UGLLogo_PB.Name = "UGLLogo_PB";
            this.UGLLogo_PB.Size = new System.Drawing.Size(24, 24);
            this.UGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UGLLogo_PB.TabIndex = 6;
            this.UGLLogo_PB.TabStop = false;
            // 
            // Title_LBL
            // 
            this.Title_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_LBL.Location = new System.Drawing.Point(35, 0);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(459, 37);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Updater";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.CurrentVersion_LBL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LatestVersion_LBL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Status_LBL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ActualCurrentVer_LBL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ActualLastestVer_LBL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CloseApp_BTN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ActualStatus_LBL, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 183);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // CurrentVersion_LBL
            // 
            this.CurrentVersion_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CurrentVersion_LBL.AutoSize = true;
            this.CurrentVersion_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentVersion_LBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentVersion_LBL.Location = new System.Drawing.Point(25, 0);
            this.CurrentVersion_LBL.Name = "CurrentVersion_LBL";
            this.CurrentVersion_LBL.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.CurrentVersion_LBL.Size = new System.Drawing.Size(124, 40);
            this.CurrentVersion_LBL.TabIndex = 0;
            this.CurrentVersion_LBL.Text = "Current Version: ";
            this.CurrentVersion_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LatestVersion_LBL
            // 
            this.LatestVersion_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LatestVersion_LBL.AutoSize = true;
            this.LatestVersion_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LatestVersion_LBL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LatestVersion_LBL.Location = new System.Drawing.Point(38, 40);
            this.LatestVersion_LBL.Name = "LatestVersion_LBL";
            this.LatestVersion_LBL.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.LatestVersion_LBL.Size = new System.Drawing.Size(111, 40);
            this.LatestVersion_LBL.TabIndex = 0;
            this.LatestVersion_LBL.Text = "Latest Version: ";
            this.LatestVersion_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Status_LBL
            // 
            this.Status_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Status_LBL.AutoSize = true;
            this.Status_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status_LBL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Status_LBL.Location = new System.Drawing.Point(91, 80);
            this.Status_LBL.Name = "Status_LBL";
            this.Status_LBL.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Status_LBL.Size = new System.Drawing.Size(58, 40);
            this.Status_LBL.TabIndex = 0;
            this.Status_LBL.Text = "Status: ";
            this.Status_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActualCurrentVer_LBL
            // 
            this.ActualCurrentVer_LBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ActualCurrentVer_LBL.AutoSize = true;
            this.ActualCurrentVer_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualCurrentVer_LBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualCurrentVer_LBL.Location = new System.Drawing.Point(155, 10);
            this.ActualCurrentVer_LBL.Name = "ActualCurrentVer_LBL";
            this.ActualCurrentVer_LBL.Size = new System.Drawing.Size(0, 20);
            this.ActualCurrentVer_LBL.TabIndex = 0;
            this.ActualCurrentVer_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActualLastestVer_LBL
            // 
            this.ActualLastestVer_LBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ActualLastestVer_LBL.AutoSize = true;
            this.ActualLastestVer_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualLastestVer_LBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ActualLastestVer_LBL.Location = new System.Drawing.Point(155, 50);
            this.ActualLastestVer_LBL.Name = "ActualLastestVer_LBL";
            this.ActualLastestVer_LBL.Size = new System.Drawing.Size(0, 20);
            this.ActualLastestVer_LBL.TabIndex = 0;
            this.ActualLastestVer_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CloseApp_BTN
            // 
            this.CloseApp_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.CloseApp_BTN, 2);
            this.CloseApp_BTN.Location = new System.Drawing.Point(271, 128);
            this.CloseApp_BTN.Name = "CloseApp_BTN";
            this.CloseApp_BTN.Size = new System.Drawing.Size(220, 46);
            this.CloseApp_BTN.TabIndex = 1;
            this.CloseApp_BTN.Text = "Cancel";
            this.CloseApp_BTN.UseVisualStyleBackColor = true;
            this.CloseApp_BTN.Click += new System.EventHandler(this.CloseApp_BTN_Click);
            // 
            // ActualStatus_LBL
            // 
            this.ActualStatus_LBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ActualStatus_LBL.AutoSize = true;
            this.ActualStatus_LBL.Location = new System.Drawing.Point(155, 90);
            this.ActualStatus_LBL.Name = "ActualStatus_LBL";
            this.ActualStatus_LBL.Size = new System.Drawing.Size(147, 20);
            this.ActualStatus_LBL.TabIndex = 2;
            this.ActualStatus_LBL.Text = "Preparing for update";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(23, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 185);
            this.panel1.TabIndex = 8;
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(539, 45);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(255, 73);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 11;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(806, 348);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.TitleBar_PNL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Updater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Updater_Load);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CurrentVersion_LBL;
        private System.Windows.Forms.Label LatestVersion_LBL;
        private System.Windows.Forms.Label Status_LBL;
        private System.Windows.Forms.Button CloseApp_BTN;
        public System.Windows.Forms.Label ActualCurrentVer_LBL;
        public System.Windows.Forms.Label ActualLastestVer_LBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label ActualStatus_LBL;
    }
}