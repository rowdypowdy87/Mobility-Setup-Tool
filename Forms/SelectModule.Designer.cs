
namespace Mobility_Setup_Tool.Forms
{
    partial class SelectModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectModule));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Modules_CMB = new Mobility_Setup_Tool.ExComboBox();
            this.Continue_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar.Controls.Add(this.pictureBox2);
            this.TitleBar.Controls.Add(this.LBTitle);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Controls.Add(this.MenuPanel);
            this.TitleBar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(437, 40);
            this.TitleBar.TabIndex = 5;
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
            this.LBTitle.Size = new System.Drawing.Size(360, 40);
            this.LBTitle.TabIndex = 5;
            this.LBTitle.Text = "Mobility Setup and Planning Tool - Select Module";
            this.LBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Modules_CMB
            // 
            this.Modules_CMB.FormattingEnabled = true;
            this.Modules_CMB.Items.AddRange(new object[] {
            "ZM03",
            "ZM12",
            "ZM25"});
            this.Modules_CMB.Location = new System.Drawing.Point(39, 88);
            this.Modules_CMB.Name = "Modules_CMB";
            this.Modules_CMB.Size = new System.Drawing.Size(361, 28);
            this.Modules_CMB.TabIndex = 6;
            // 
            // Continue_BTN
            // 
            this.Continue_BTN.Location = new System.Drawing.Point(39, 136);
            this.Continue_BTN.Name = "Continue_BTN";
            this.Continue_BTN.Size = new System.Drawing.Size(361, 58);
            this.Continue_BTN.TabIndex = 7;
            this.Continue_BTN.Text = "Continue";
            this.Continue_BTN.UseVisualStyleBackColor = true;
            this.Continue_BTN.Click += new System.EventHandler(this.Continue_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please select a setup module (order type):";
            // 
            // SelectModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continue_BTN);
            this.Controls.Add(this.Modules_CMB);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectModule";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectModule";
            this.Load += new System.EventHandler(this.Module_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Continue_BTN;
        public Mobility_Setup_Tool.ExComboBox Modules_CMB;
        private System.Windows.Forms.Label label1;
    }
}