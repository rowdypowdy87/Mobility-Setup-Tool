
namespace Mobility_Setup_Tool.Forms
{
    partial class GetLongText
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
            this.Title_LBL = new System.Windows.Forms.Label();
            this.LongText_RTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Continue_BTN = new System.Windows.Forms.Button();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar_PNL.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_PNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(592, 35);
            this.TitleBar_PNL.TabIndex = 7;
            this.TitleBar_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar_PNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar_PNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // UGLLogo_PB
            // 
            this.UGLLogo_PB.ErrorImage = null;
            this.UGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.Sprite11;
            this.UGLLogo_PB.InitialImage = null;
            this.UGLLogo_PB.Location = new System.Drawing.Point(5, 5);
            this.UGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UGLLogo_PB.Name = "UGLLogo_PB";
            this.UGLLogo_PB.Size = new System.Drawing.Size(24, 24);
            this.UGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UGLLogo_PB.TabIndex = 6;
            this.UGLLogo_PB.TabStop = false;
            // 
            // Title_LBL
            // 
            this.Title_LBL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_LBL.Location = new System.Drawing.Point(35, 0);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(367, 35);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Get Long Text";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // LongText_RTB
            // 
            this.LongText_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LongText_RTB.Location = new System.Drawing.Point(10, 66);
            this.LongText_RTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LongText_RTB.Name = "LongText_RTB";
            this.LongText_RTB.Size = new System.Drawing.Size(571, 459);
            this.LongText_RTB.TabIndex = 8;
            this.LongText_RTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Long Text Here:";
            // 
            // Continue_BTN
            // 
            this.Continue_BTN.Location = new System.Drawing.Point(13, 532);
            this.Continue_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Continue_BTN.Name = "Continue_BTN";
            this.Continue_BTN.Size = new System.Drawing.Size(569, 51);
            this.Continue_BTN.TabIndex = 10;
            this.Continue_BTN.Text = "Continue";
            this.Continue_BTN.UseVisualStyleBackColor = true;
            this.Continue_BTN.Click += new System.EventHandler(this.Continue_BTN_Click);
            // 
            // GetLongText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 590);
            this.Controls.Add(this.Continue_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LongText_RTB);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetLongText";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GetLongText_Load);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.RichTextBox LongText_RTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Continue_BTN;
    }
}