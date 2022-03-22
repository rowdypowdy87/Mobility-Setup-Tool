

namespace Mobility_Setup_Tool
{
    partial class PartsSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsSelector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.MinimizeButton_LBL = new System.Windows.Forms.Label();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.MaximizeButton_LBL = new System.Windows.Forms.Label();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.Holder_PNL = new System.Windows.Forms.Panel();
            this.Parts_DGV = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SapMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManuPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorLoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SpecialStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter_LBL = new System.Windows.Forms.Label();
            this.Filter_CB = new Mobility_Setup_Tool.ExComboBox();
            this.Cancel_BTN = new System.Windows.Forms.Button();
            this.Continue_BTN = new System.Windows.Forms.Button();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.Holder_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parts_DGV)).BeginInit();
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
            this.TitleBar_PNL.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_PNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(1120, 35);
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
            this.MinimizeButton_LBL.Location = new System.Drawing.Point(1028, 0);
            this.MinimizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton_LBL.Name = "MinimizeButton_LBL";
            this.MinimizeButton_LBL.Size = new System.Drawing.Size(31, 35);
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
            this.UGLLogo_PB.Location = new System.Drawing.Point(5, 5);
            this.UGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.MaximizeButton_LBL.Location = new System.Drawing.Point(1059, 0);
            this.MaximizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton_LBL.Name = "MaximizeButton_LBL";
            this.MaximizeButton_LBL.Size = new System.Drawing.Size(31, 35);
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
            this.CloseButton_LBL.Location = new System.Drawing.Point(1089, 0);
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
            this.Title_LBL.Location = new System.Drawing.Point(35, 0);
            this.Title_LBL.Name = "Title_LBL";
            this.Title_LBL.Size = new System.Drawing.Size(402, 35);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Component Select Screen";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Holder_PNL
            // 
            this.Holder_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holder_PNL.BackColor = System.Drawing.Color.White;
            this.Holder_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Holder_PNL.Controls.Add(this.Parts_DGV);
            this.Holder_PNL.Controls.Add(this.Filter_LBL);
            this.Holder_PNL.Controls.Add(this.Filter_CB);
            this.Holder_PNL.Controls.Add(this.Cancel_BTN);
            this.Holder_PNL.Controls.Add(this.Continue_BTN);
            this.Holder_PNL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Holder_PNL.Location = new System.Drawing.Point(14, 93);
            this.Holder_PNL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Holder_PNL.Name = "Holder_PNL";
            this.Holder_PNL.Size = new System.Drawing.Size(1090, 602);
            this.Holder_PNL.TabIndex = 5;
            // 
            // Parts_DGV
            // 
            this.Parts_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parts_DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Parts_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parts_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.SapMat,
            this.Desc,
            this.ManuPart,
            this.Qty,
            this.StorLoc,
            this.SpecialStock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Parts_DGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.Parts_DGV.Location = new System.Drawing.Point(12, 42);
            this.Parts_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parts_DGV.Name = "Parts_DGV";
            this.Parts_DGV.RowHeadersVisible = false;
            this.Parts_DGV.RowHeadersWidth = 51;
            this.Parts_DGV.RowTemplate.Height = 29;
            this.Parts_DGV.Size = new System.Drawing.Size(1063, 506);
            this.Parts_DGV.TabIndex = 4;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Select";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 50;
            // 
            // SapMat
            // 
            this.SapMat.HeaderText = "SAP Material";
            this.SapMat.MinimumWidth = 6;
            this.SapMat.Name = "SapMat";
            this.SapMat.Width = 125;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.Width = 400;
            // 
            // ManuPart
            // 
            this.ManuPart.HeaderText = "Manufacturer Part Number";
            this.ManuPart.MinimumWidth = 6;
            this.ManuPart.Name = "ManuPart";
            this.ManuPart.Width = 200;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // StorLoc
            // 
            this.StorLoc.HeaderText = "Storage Location";
            this.StorLoc.Items.AddRange(new object[] {
            "B01",
            "B03",
            "B04"});
            this.StorLoc.MinimumWidth = 6;
            this.StorLoc.Name = "StorLoc";
            this.StorLoc.Width = 125;
            // 
            // SpecialStock
            // 
            this.SpecialStock.HeaderText = "Special Stock Indicator";
            this.SpecialStock.MinimumWidth = 6;
            this.SpecialStock.Name = "SpecialStock";
            this.SpecialStock.Width = 125;
            // 
            // Filter_LBL
            // 
            this.Filter_LBL.AutoSize = true;
            this.Filter_LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Filter_LBL.ForeColor = System.Drawing.Color.Black;
            this.Filter_LBL.Location = new System.Drawing.Point(18, 14);
            this.Filter_LBL.Name = "Filter_LBL";
            this.Filter_LBL.Size = new System.Drawing.Size(53, 15);
            this.Filter_LBL.TabIndex = 3;
            this.Filter_LBL.Text = "FILTERS:";
            // 
            // Filter_CB
            // 
            this.Filter_CB.FormattingEnabled = true;
            this.Filter_CB.Location = new System.Drawing.Point(85, 10);
            this.Filter_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Filter_CB.Name = "Filter_CB";
            this.Filter_CB.Size = new System.Drawing.Size(236, 23);
            this.Filter_CB.TabIndex = 2;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel_BTN.ForeColor = System.Drawing.Color.Black;
            this.Cancel_BTN.Location = new System.Drawing.Point(286, 553);
            this.Cancel_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.Size = new System.Drawing.Size(270, 40);
            this.Cancel_BTN.TabIndex = 1;
            this.Cancel_BTN.Text = "Cancel";
            this.Cancel_BTN.UseVisualStyleBackColor = true;
            // 
            // Continue_BTN
            // 
            this.Continue_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Continue_BTN.ForeColor = System.Drawing.Color.Black;
            this.Continue_BTN.Location = new System.Drawing.Point(11, 553);
            this.Continue_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Continue_BTN.Name = "Continue_BTN";
            this.Continue_BTN.Size = new System.Drawing.Size(270, 40);
            this.Continue_BTN.TabIndex = 1;
            this.Continue_BTN.Text = "Continue";
            this.Continue_BTN.UseVisualStyleBackColor = true;
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(880, 37);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(223, 55);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 10;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // PartsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1120, 709);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.Holder_PNL);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 709);
            this.Name = "PartsSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Components";
            this.Load += new System.EventHandler(this.PartsSelect_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PartsSelect_Paint);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.Holder_PNL.ResumeLayout(false);
            this.Holder_PNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parts_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Label MinimizeButton_LBL;
        private System.Windows.Forms.Label MaximizeButton_LBL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.Panel Holder_PNL;
        public System.Windows.Forms.DataGridView Parts_DGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SapMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManuPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn StorLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialStock;
        private System.Windows.Forms.Label Filter_LBL;
        public Mobility_Setup_Tool.ExComboBox Filter_CB;
        private System.Windows.Forms.Button Cancel_BTN;
        private System.Windows.Forms.Button Continue_BTN;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
    }
}