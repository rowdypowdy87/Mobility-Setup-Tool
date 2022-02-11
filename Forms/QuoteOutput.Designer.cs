

namespace Mobility_Setup_Tool
{
    partial class QuoteOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteOutput));
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.MinimizeButton_LBL = new System.Windows.Forms.Label();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.MaximizeButton_LBL = new System.Windows.Forms.Label();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.QuoteOutput_LayoutPanel = new System.Windows.Forms.Panel();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.MinimizeButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.MaximizeButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.CloseButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Controls.Add(this.MenuPanel);
            this.TitleBar_PNL.Location = new System.Drawing.Point(1, 1);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(1278, 37);
            this.TitleBar_PNL.TabIndex = 4;
            this.TitleBar_PNL.DoubleClick += new System.EventHandler(this.TitleBar_DoubleClick);
            this.TitleBar_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar_PNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar_PNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MinimizeButton_LBL
            // 
            this.MinimizeButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeButton_LBL.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton_LBL.Image")));
            this.MinimizeButton_LBL.Location = new System.Drawing.Point(1173, 0);
            this.MinimizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton_LBL.Name = "MinimizeButton_LBL";
            this.MinimizeButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.MinimizeButton_LBL.TabIndex = 8;
            this.MinimizeButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniButton_LBL_MouseDown);
            this.MinimizeButton_LBL.MouseEnter += new System.EventHandler(this.MiniButton_LBL_MouseEnter);
            this.MinimizeButton_LBL.MouseLeave += new System.EventHandler(this.MiniButton_LBL_MouseLeave);
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
            // MaximizeButton_LBL
            // 
            this.MaximizeButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.MaximizeButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeButton_LBL.Image = global::Mobility_Setup_Tool.Properties.Resources.MS;
            this.MaximizeButton_LBL.Location = new System.Drawing.Point(1208, 0);
            this.MaximizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton_LBL.Name = "MaximizeButton_LBL";
            this.MaximizeButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.MaximizeButton_LBL.TabIndex = 9;
            this.MaximizeButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaximizeButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MaxButton_LBL_MouseDown);
            this.MaximizeButton_LBL.MouseEnter += new System.EventHandler(this.MaxButton_LBL_MouseEnter);
            this.MaximizeButton_LBL.MouseLeave += new System.EventHandler(this.MaxButton_LBL_MouseLeave);
            // 
            // CloseButton_LBL
            // 
            this.CloseButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.CloseButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton_LBL.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton_LBL.Image")));
            this.CloseButton_LBL.Location = new System.Drawing.Point(1243, 0);
            this.CloseButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_LBL.Name = "CloseButton_LBL";
            this.CloseButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.CloseButton_LBL.TabIndex = 10;
            this.CloseButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_LBL_MouseDown);
            this.CloseButton_LBL.MouseEnter += new System.EventHandler(this.CloseButton_LBL_MouseEnter);
            this.CloseButton_LBL.MouseLeave += new System.EventHandler(this.CloseButton_LBL_MouseLeave);
            // 
            // Title_LBL
            // 
            this.Title_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_LBL.Location = new System.Drawing.Point(35, 0);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(459, 37);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Quote Output";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(0, 37);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1120, 71);
            this.MenuPanel.TabIndex = 4;
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(1002, 45);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(255, 73);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 10;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // QuoteOutput_LayoutPanel
            // 
            this.QuoteOutput_LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteOutput_LayoutPanel.BackColor = System.Drawing.Color.White;
            this.QuoteOutput_LayoutPanel.Location = new System.Drawing.Point(33, 135);
            this.QuoteOutput_LayoutPanel.Name = "QuoteOutput_LayoutPanel";
            this.QuoteOutput_LayoutPanel.Size = new System.Drawing.Size(1212, 771);
            this.QuoteOutput_LayoutPanel.TabIndex = 11;
            // 
            // QuoteOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1280, 945);
            this.Controls.Add(this.QuoteOutput_LayoutPanel);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "QuoteOutput";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quote Output";
            this.Load += new System.EventHandler(this.QuoteOutput_Load);
            this.VisibleChanged += new System.EventHandler(this.QOutput_VisibleChanged);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label MinimizeButton_LBL;
        private System.Windows.Forms.Label MaximizeButton_LBL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        private System.Windows.Forms.Panel QuoteOutput_LayoutPanel;
    }
}