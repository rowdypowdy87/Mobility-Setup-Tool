
namespace Mobility_Setup_Tool
{
    partial class EquipmentSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentSelect));
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.MiniButton_LBL = new System.Windows.Forms.Label();
            this.MaxiButton_LBL = new System.Windows.Forms.Label();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.EqFound_LV = new System.Windows.Forms.ListView();
            this.EqNumber = new System.Windows.Forms.ColumnHeader();
            this.EqSerial = new System.Windows.Forms.ColumnHeader();
            this.EqDesc = new System.Windows.Forms.ColumnHeader();
            this.Continue_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TitleBar_PNL.Controls.Add(this.MiniButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.MaxiButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.CloseButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Location = new System.Drawing.Point(1, 1);
            this.TitleBar_PNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(994, 35);
            this.TitleBar_PNL.TabIndex = 5;
            this.TitleBar_PNL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar_PNL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar_PNL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // MiniButton_LBL
            // 
            this.MiniButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.MiniButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiniButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiniButton_LBL.Image = ((System.Drawing.Image)(resources.GetObject("MiniButton_LBL.Image")));
            this.MiniButton_LBL.Location = new System.Drawing.Point(900, 0);
            this.MiniButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MiniButton_LBL.Name = "MiniButton_LBL";
            this.MiniButton_LBL.Size = new System.Drawing.Size(31, 35);
            this.MiniButton_LBL.TabIndex = 11;
            this.MiniButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiniButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniButton_LBL_MouseDown);
            this.MiniButton_LBL.MouseEnter += new System.EventHandler(this.MiniButton_LBL_MouseEnter);
            this.MiniButton_LBL.MouseLeave += new System.EventHandler(this.MiniButton_LBL_MouseLeave);
            // 
            // MaxiButton_LBL
            // 
            this.MaxiButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxiButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.MaxiButton_LBL.Enabled = false;
            this.MaxiButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxiButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxiButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxiButton_LBL.Image = global::Mobility_Setup_Tool.Properties.Resources.MS;
            this.MaxiButton_LBL.Location = new System.Drawing.Point(931, 0);
            this.MaxiButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MaxiButton_LBL.Name = "MaxiButton_LBL";
            this.MaxiButton_LBL.Size = new System.Drawing.Size(31, 35);
            this.MaxiButton_LBL.TabIndex = 12;
            this.MaxiButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton_LBL
            // 
            this.CloseButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.CloseButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton_LBL.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton_LBL.Image")));
            this.CloseButton_LBL.Location = new System.Drawing.Point(962, 0);
            this.CloseButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_LBL.Name = "CloseButton_LBL";
            this.CloseButton_LBL.Size = new System.Drawing.Size(31, 35);
            this.CloseButton_LBL.TabIndex = 13;
            this.CloseButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_LBL_MouseDown);
            this.CloseButton_LBL.MouseEnter += new System.EventHandler(this.CloseButton_LBL_MouseEnter);
            this.CloseButton_LBL.MouseLeave += new System.EventHandler(this.CloseButton_LBL_MouseLeave);
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
            // Title_LBL
            // 
            this.Title_LBL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title_LBL.Location = new System.Drawing.Point(34, -1);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(402, 35);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Select Equipment";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(760, 40);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(223, 52);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 10;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // EqFound_LV
            // 
            this.EqFound_LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqFound_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EqFound_LV.CheckBoxes = true;
            this.EqFound_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EqNumber,
            this.EqSerial,
            this.EqDesc});
            this.EqFound_LV.HideSelection = false;
            this.EqFound_LV.Location = new System.Drawing.Point(16, 94);
            this.EqFound_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EqFound_LV.MultiSelect = false;
            this.EqFound_LV.Name = "EqFound_LV";
            this.EqFound_LV.Size = new System.Drawing.Size(963, 512);
            this.EqFound_LV.TabIndex = 11;
            this.EqFound_LV.UseCompatibleStateImageBehavior = false;
            this.EqFound_LV.View = System.Windows.Forms.View.Details;
            this.EqFound_LV.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EqFound_LV_ItemCheck);
            // 
            // EqNumber
            // 
            this.EqNumber.Text = "Equipment Number";
            this.EqNumber.Width = 150;
            // 
            // EqSerial
            // 
            this.EqSerial.Text = "Equipment Serial";
            this.EqSerial.Width = 150;
            // 
            // EqDesc
            // 
            this.EqDesc.Text = "Equipment Description";
            this.EqDesc.Width = 300;
            // 
            // Continue_BTN
            // 
            this.Continue_BTN.Location = new System.Drawing.Point(15, 614);
            this.Continue_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Continue_BTN.Name = "Continue_BTN";
            this.Continue_BTN.Size = new System.Drawing.Size(233, 43);
            this.Continue_BTN.TabIndex = 12;
            this.Continue_BTN.Text = "Continue";
            this.Continue_BTN.UseVisualStyleBackColor = true;
            this.Continue_BTN.Click += new System.EventHandler(this.Continue_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Multiple equipment numbers found with the same serial number, please check the co" +
    "rrect equipment below.";
            // 
            // EquipmentSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(994, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continue_BTN);
            this.Controls.Add(this.EqFound_LV);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EquipmentSelect";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EquipmentSelect";
            this.Load += new System.EventHandler(this.EquipmentSelect_Load);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Label MiniButton_LBL;
        private System.Windows.Forms.Label MaxiButton_LBL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        public System.Windows.Forms.ListView EqFound_LV;
        private System.Windows.Forms.ColumnHeader EqNumber;
        private System.Windows.Forms.ColumnHeader EqSerial;
        private System.Windows.Forms.ColumnHeader EqDesc;
        private System.Windows.Forms.Button Continue_BTN;
        private System.Windows.Forms.Label label1;
    }
}