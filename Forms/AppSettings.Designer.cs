
namespace Mobility_Setup_Tool
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.WarLimit_TT = new System.Windows.Forms.ToolTip(this.components);
            this.AppColor_CD = new System.Windows.Forms.ColorDialog();
            this.AppSettings_PG = new System.Windows.Forms.PropertyGrid();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.Apply_BTN = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar.Controls.Add(this.pictureBox2);
            this.TitleBar.Controls.Add(this.LBTitle);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Controls.Add(this.MenuPanel);
            this.TitleBar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1007, 40);
            this.TitleBar.TabIndex = 4;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mobility_Setup_Tool.Properties.Resources.Sprite11;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // LBTitle
            // 
            this.LBTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBTitle.Location = new System.Drawing.Point(40, 0);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(505, 40);
            this.LBTitle.TabIndex = 5;
            this.LBTitle.Text = "Mobility Setup and Planning Tool - Application Settings";
            this.LBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.LBTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.LBTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1248, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 35);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Location = new System.Drawing.Point(0, 40);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1280, 76);
            this.MenuPanel.TabIndex = 4;
            // 
            // AppSettings_PG
            // 
            this.AppSettings_PG.Location = new System.Drawing.Point(17, 57);
            this.AppSettings_PG.Name = "AppSettings_PG";
            this.AppSettings_PG.Size = new System.Drawing.Size(555, 611);
            this.AppSettings_PG.TabIndex = 12;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel_BTN.Location = new System.Drawing.Point(307, 688);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(265, 60);
            this.Cancel_BTN.TabIndex = 11;
            this.Cancel_BTN.Text = "Close";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // Apply_BTN
            // 
            this.Apply_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apply_BTN.Location = new System.Drawing.Point(17, 688);
            this.Apply_BTN.Name = "Apply_BTN";
            this.Apply_BTN.Size = new System.Drawing.Size(264, 60);
            this.Apply_BTN.TabIndex = 10;
            this.Apply_BTN.Text = "Apply";
            this.Apply_BTN.UseVisualStyleBackColor = true;
            this.Apply_BTN.Click += new System.EventHandler(this.Apply_BTN_Click);
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 773);
            this.Controls.Add(this.AppSettings_PG);
            this.Controls.Add(this.Cancel_BTN);
            this.Controls.Add(this.Apply_BTN);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppSettings";
            this.Load += new System.EventHandler(this.AppSettings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AppSettings_Paint);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.ToolTip WarLimit_TT;
        private System.Windows.Forms.ColorDialog AppColor_CD;
        private System.Windows.Forms.PropertyGrid AppSettings_PG;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.Button Apply_BTN;
    }
}