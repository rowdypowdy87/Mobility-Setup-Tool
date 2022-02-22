
namespace Mobility_Setup_Tool
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.LBTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TBInformation = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.LBTitle);
            this.TitleBar_PNL.Controls.Add(this.pictureBox2);
            this.TitleBar_PNL.Controls.Add(this.panel1);
            this.TitleBar_PNL.Controls.Add(this.CloseButton);
            this.TitleBar_PNL.Controls.Add(this.MenuPanel);
            this.TitleBar_PNL.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(590, 40);
            this.TitleBar_PNL.TabIndex = 4;
            // 
            // LBTitle
            // 
            this.LBTitle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBTitle.Location = new System.Drawing.Point(40, 0);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(400, 40);
            this.LBTitle.TabIndex = 5;
            this.LBTitle.Text = "Mobility Setup and Planning Tool - Requires User Input";
            this.LBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mobility_Setup_Tool.Properties.Resources.WhiteICON;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 207);
            this.panel1.TabIndex = 7;
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
            this.MenuPanel.Size = new System.Drawing.Size(584, 76);
            this.MenuPanel.TabIndex = 4;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelBtn.Location = new System.Drawing.Point(308, 181);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(200, 43);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TBInformation
            // 
            this.TBInformation.BackColor = System.Drawing.SystemColors.Menu;
            this.TBInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBInformation.Location = new System.Drawing.Point(8, 46);
            this.TBInformation.Margin = new System.Windows.Forms.Padding(2);
            this.TBInformation.Multiline = true;
            this.TBInformation.Name = "TBInformation";
            this.TBInformation.Size = new System.Drawing.Size(572, 71);
            this.TBInformation.TabIndex = 8;
            // 
            // Input
            // 
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Location = new System.Drawing.Point(37, 122);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(500, 27);
            this.Input.TabIndex = 7;
            // 
            // OkayButton
            // 
            this.OkayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkayButton.Location = new System.Drawing.Point(67, 181);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(200, 43);
            this.OkayButton.TabIndex = 6;
            this.OkayButton.Text = "OKAY";
            this.OkayButton.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 248);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TBInformation);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InputBox_Paint);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.TextBox TBInformation;
        public System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button OkayButton;
    }
}