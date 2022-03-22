

namespace Mobility_Setup_Tool
{
    partial class VersionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.MinimizeButton_LBL = new System.Windows.Forms.Label();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.MaximizeButton_LBL = new System.Windows.Forms.Label();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VersionHist_DGV = new System.Windows.Forms.DataGridView();
            this.RevisionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VersionHist_DGV)).BeginInit();
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
            this.MinimizeButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.MaximizeButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CloseButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Title_LBL.Text = "Mobility Setup and Planning Tool - Version History";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(20, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.MinimumSize = new System.Drawing.Size(525, 300);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 608);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VersionHist_DGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1072, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Version History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // VersionHist_DGV
            // 
            this.VersionHist_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VersionHist_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersionHist_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevisionNumber,
            this.Description,
            this.ChangedBy,
            this.ApprovedBy,
            this.ChangedOn});
            this.VersionHist_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionHist_DGV.Location = new System.Drawing.Point(3, 2);
            this.VersionHist_DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VersionHist_DGV.Name = "VersionHist_DGV";
            this.VersionHist_DGV.RowHeadersVisible = false;
            this.VersionHist_DGV.RowHeadersWidth = 51;
            this.VersionHist_DGV.RowTemplate.Height = 29;
            this.VersionHist_DGV.Size = new System.Drawing.Size(1066, 576);
            this.VersionHist_DGV.TabIndex = 0;
            // 
            // RevisionNumber
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RevisionNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.RevisionNumber.HeaderText = "Revision Number";
            this.RevisionNumber.MinimumWidth = 50;
            this.RevisionNumber.Name = "RevisionNumber";
            this.RevisionNumber.Width = 80;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle8;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 300;
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // ChangedBy
            // 
            this.ChangedBy.HeaderText = "Changed By";
            this.ChangedBy.MinimumWidth = 6;
            this.ChangedBy.Name = "ChangedBy";
            this.ChangedBy.Width = 108;
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.HeaderText = "Approved By";
            this.ApprovedBy.MinimumWidth = 6;
            this.ApprovedBy.Name = "ApprovedBy";
            this.ApprovedBy.Width = 114;
            // 
            // ChangedOn
            // 
            this.ChangedOn.HeaderText = "Changed On";
            this.ChangedOn.MinimumWidth = 6;
            this.ChangedOn.Name = "ChangedOn";
            this.ChangedOn.Width = 110;
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(878, 40);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(223, 55);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 10;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "This is a list of all Tasklist, Equipment, CEL related changes and updates";
            // 
            // VersionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1120, 709);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TitleBar_PNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 540);
            this.Name = "VersionHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Version History";
            this.Load += new System.EventHandler(this.VersionHist_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VersionHist_Paint);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VersionHist_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.Label MinimizeButton_LBL;
        private System.Windows.Forms.Label MaximizeButton_LBL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        private System.Windows.Forms.DataGridView VersionHist_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangedOn;
    }
}