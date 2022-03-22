

namespace Mobility_Setup_Tool
{
    partial class AboutBox
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
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.BgPanel = new System.Windows.Forms.Panel();
            this.AboutText = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).BeginInit();
            this.BgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.CloseButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Location = new System.Drawing.Point(1, 1);
            this.TitleBar_PNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(568, 35);
            this.TitleBar_PNL.TabIndex = 4;
            this.TitleBar_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar_PNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar_PNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // UGLLogo_PB
            // 
            this.UGLLogo_PB.ErrorImage = null;
            this.UGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.Sprite11;
            this.UGLLogo_PB.InitialImage = null;
            this.UGLLogo_PB.Location = new System.Drawing.Point(4, 4);
            this.UGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UGLLogo_PB.Name = "UGLLogo_PB";
            this.UGLLogo_PB.Size = new System.Drawing.Size(24, 24);
            this.UGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UGLLogo_PB.TabIndex = 6;
            this.UGLLogo_PB.TabStop = false;
            // 
            // CloseButton_LBL
            // 
            this.CloseButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.CloseButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton_LBL.Image = global::Mobility_Setup_Tool.Properties.Resources.X;
            this.CloseButton_LBL.Location = new System.Drawing.Point(537, 0);
            this.CloseButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_LBL.Name = "CloseButton_LBL";
            this.CloseButton_LBL.Size = new System.Drawing.Size(31, 35);
            this.CloseButton_LBL.TabIndex = 10;
            this.CloseButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_LBL_MouseDown);
            this.CloseButton_LBL.MouseEnter += new System.EventHandler(this.CloseButton_LBL_MouseEnter);
            this.CloseButton_LBL.MouseLeave += new System.EventHandler(this.CloseButton_LBL_MouseLeave);
            // 
            // Title_LBL
            // 
            this.Title_LBL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_LBL.Location = new System.Drawing.Point(34, -1);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(264, 35);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - About";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(13, 40);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(223, 55);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 10;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // BgPanel
            // 
            this.BgPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BgPanel.Controls.Add(this.AboutText);
            this.BgPanel.Location = new System.Drawing.Point(16, 100);
            this.BgPanel.Name = "BgPanel";
            this.BgPanel.Padding = new System.Windows.Forms.Padding(5);
            this.BgPanel.Size = new System.Drawing.Size(544, 166);
            this.BgPanel.TabIndex = 12;
            // 
            // AboutText
            // 
            this.AboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutText.Location = new System.Drawing.Point(5, 5);
            this.AboutText.Multiline = true;
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(532, 154);
            this.AboutText.TabIndex = 0;
            this.AboutText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(187, 274);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(202, 44);
            this.OkButton.TabIndex = 13;
            this.OkButton.Text = "Okay";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(570, 327);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.BgPanel);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version History";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.BgPanel.ResumeLayout(false);
            this.BgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        private System.Windows.Forms.Panel BgPanel;
        private System.Windows.Forms.TextBox AboutText;
        private System.Windows.Forms.Button OkButton;
    }
}