
namespace Mobility_Setup_Tool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar_PNL = new System.Windows.Forms.Panel();
            this.MinimizeButton_LBL = new System.Windows.Forms.Label();
            this.MaximizeButton_LBL = new System.Windows.Forms.Label();
            this.CloseButton_LBL = new System.Windows.Forms.Label();
            this.UGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.Title_LBL = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.File_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.AppSettings_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.Control_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.StopAuto_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.resyncDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatus_SB = new System.Windows.Forms.StatusStrip();
            this.Progress_PB = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusText_LBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusInfo_LBL = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainUGLLogo_PB = new System.Windows.Forms.PictureBox();
            this.SingleSetup_BW = new System.ComponentModel.BackgroundWorker();
            this.CheckSAP_TM = new System.Windows.Forms.Timer(this.components);
            this.RaiseVariation_TP = new System.Windows.Forms.TabPage();
            this.VarInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VarInfo_GB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LongText_TB = new System.Windows.Forms.RichTextBox();
            this.Variations_LB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LongText_LBL = new System.Windows.Forms.Label();
            this.VarOrderInfo_LBL = new System.Windows.Forms.GroupBox();
            this.VariationTable_TPN = new System.Windows.Forms.TableLayoutPanel();
            this.VarSerialNumber_LBL = new System.Windows.Forms.Label();
            this.VarSerialNumber_TB = new System.Windows.Forms.TextBox();
            this.VarTemplate_CB = new System.Windows.Forms.ComboBox();
            this.VarTemplate_LBL = new System.Windows.Forms.Label();
            this.VarTaskType_CB = new System.Windows.Forms.ComboBox();
            this.VarTaskType_LBL = new System.Windows.Forms.Label();
            this.VarSOEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.VarSOStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.VarSOStartDate_LBL = new System.Windows.Forms.Label();
            this.VarExternalReference_LBL = new System.Windows.Forms.Label();
            this.VarSOPriority_CB = new System.Windows.Forms.ComboBox();
            this.VarSOPriority_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_CB = new System.Windows.Forms.ComboBox();
            this.VarExternalReference_TB = new System.Windows.Forms.TextBox();
            this.VarCheckEntryList_BTN = new System.Windows.Forms.Button();
            this.VarRaiseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.DataTabs_TC = new System.Windows.Forms.TabControl();
            this.InitialSetup_TP = new System.Windows.Forms.TabPage();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.EqDesc_LBL = new System.Windows.Forms.Label();
            this.EquipmentOutput_TB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DescriptionOutput_TB = new System.Windows.Forms.TextBox();
            this.SetupModOutput_TB = new System.Windows.Forms.TextBox();
            this.CELNumberOutput_TB = new System.Windows.Forms.TextBox();
            this.WorkCenterOutput_TB = new System.Windows.Forms.TextBox();
            this.WBSOutput_TB = new System.Windows.Forms.TextBox();
            this.NotificationOutput_TB = new System.Windows.Forms.TextBox();
            this.SOOutput_TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NotificationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SoldToParty_LBL = new System.Windows.Forms.Label();
            this.PartyName_CB = new System.Windows.Forms.ComboBox();
            this.PurchaseOrder_TB = new System.Windows.Forms.TextBox();
            this.PurchaseOrder_LBL = new System.Windows.Forms.Label();
            this.PurchaseOrderDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServiceOrderInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ActivityType_LBL = new System.Windows.Forms.Label();
            this.PMActivityType_CB = new System.Windows.Forms.ComboBox();
            this.ExternalReference_TB = new System.Windows.Forms.TextBox();
            this.BasicStartDate_LBL = new System.Windows.Forms.Label();
            this.BasicStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.BasicEndDate_LBL = new System.Windows.Forms.Label();
            this.Priority_LBL = new System.Windows.Forms.Label();
            this.ExternalRef_LBL = new System.Windows.Forms.Label();
            this.Priority_CB = new System.Windows.Forms.ComboBox();
            this.BasicEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.SetupEquipment_BTN = new System.Windows.Forms.Button();
            this.RiaseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.EquipmentInfo_GB = new System.Windows.Forms.GroupBox();
            this.EquipmentInfo_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentSerial_TB = new System.Windows.Forms.TextBox();
            this.TemplateEquipmentList_CB = new System.Windows.Forms.ComboBox();
            this.TaskType_CB = new System.Windows.Forms.ComboBox();
            this.FunctionLoc_CB = new System.Windows.Forms.ComboBox();
            this.SerialNumber_LBL = new System.Windows.Forms.Label();
            this.TemplateEquipment_LBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarrantyClaim_CHB = new System.Windows.Forms.CheckBox();
            this.General_TT = new System.Windows.Forms.ToolTip(this.components);
            this.OutputInfo_TPL = new System.Windows.Forms.TableLayoutPanel();
            this.CELNumber_LBL = new System.Windows.Forms.Label();
            this.EqNumber_LBL = new System.Windows.Forms.Label();
            this.OutputInfo_GB = new System.Windows.Forms.GroupBox();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.MainStatus_SB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).BeginInit();
            this.RaiseVariation_TP.SuspendLayout();
            this.VarInfoLayout.SuspendLayout();
            this.VarInfo_GB.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.VarOrderInfo_LBL.SuspendLayout();
            this.VariationTable_TPN.SuspendLayout();
            this.DataTabs_TC.SuspendLayout();
            this.InitialSetup_TP.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.NotificationLayout.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ServiceOrderInfoLayout.SuspendLayout();
            this.EquipmentInfo_GB.SuspendLayout();
            this.EquipmentInfo_Layout.SuspendLayout();
            this.OutputInfo_TPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar_PNL
            // 
            this.TitleBar_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleBar_PNL.Controls.Add(this.MinimizeButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.MaximizeButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.CloseButton_LBL);
            this.TitleBar_PNL.Controls.Add(this.UGLLogo_PB);
            this.TitleBar_PNL.Controls.Add(this.Title_LBL);
            this.TitleBar_PNL.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleBar_PNL.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(1280, 37);
            this.TitleBar_PNL.TabIndex = 3;
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
            this.MinimizeButton_LBL.Location = new System.Drawing.Point(1175, 0);
            this.MinimizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton_LBL.Name = "MinimizeButton_LBL";
            this.MinimizeButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.MinimizeButton_LBL.TabIndex = 7;
            this.MinimizeButton_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeButton_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniButton_LBL_MouseDown);
            this.MinimizeButton_LBL.MouseEnter += new System.EventHandler(this.MiniButton_LBL_MouseEnter);
            this.MinimizeButton_LBL.MouseLeave += new System.EventHandler(this.MiniButton_LBL_MouseLeave);
            // 
            // MaximizeButton_LBL
            // 
            this.MaximizeButton_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton_LBL.BackColor = System.Drawing.Color.Gray;
            this.MaximizeButton_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton_LBL.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeButton_LBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeButton_LBL.Image = global::Mobility_Setup_Tool.Properties.Resources.MS;
            this.MaximizeButton_LBL.Location = new System.Drawing.Point(1210, 0);
            this.MaximizeButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton_LBL.Name = "MaximizeButton_LBL";
            this.MaximizeButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.MaximizeButton_LBL.TabIndex = 7;
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
            this.CloseButton_LBL.Location = new System.Drawing.Point(1245, 0);
            this.CloseButton_LBL.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton_LBL.Name = "CloseButton_LBL";
            this.CloseButton_LBL.Size = new System.Drawing.Size(35, 37);
            this.CloseButton_LBL.TabIndex = 7;
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
            this.Title_LBL.Size = new System.Drawing.Size(280, 37);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.AutoSize = false;
            this.MainMenu.BackColor = System.Drawing.Color.LightGray;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_MN,
            this.Control_MN,
            this.Help_MN});
            this.MainMenu.Location = new System.Drawing.Point(1, 37);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1278, 28);
            this.MainMenu.TabIndex = 4;
            // 
            // File_MN
            // 
            this.File_MN.BackColor = System.Drawing.Color.LightGray;
            this.File_MN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppSettings_MN,
            this.toolStripSeparator1,
            this.Exit_MN});
            this.File_MN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.File_MN.Name = "File_MN";
            this.File_MN.Size = new System.Drawing.Size(41, 24);
            this.File_MN.Text = "File";
            // 
            // AppSettings_MN
            // 
            this.AppSettings_MN.Name = "AppSettings_MN";
            this.AppSettings_MN.Size = new System.Drawing.Size(205, 26);
            this.AppSettings_MN.Text = "Application Settings";
            this.AppSettings_MN.Click += new System.EventHandler(this.FileOptions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // Exit_MN
            // 
            this.Exit_MN.BackColor = System.Drawing.Color.White;
            this.Exit_MN.ForeColor = System.Drawing.Color.Black;
            this.Exit_MN.Name = "Exit_MN";
            this.Exit_MN.Size = new System.Drawing.Size(205, 26);
            this.Exit_MN.Text = "Exit";
            this.Exit_MN.Click += new System.EventHandler(this.Exit_MN_Click);
            // 
            // Control_MN
            // 
            this.Control_MN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StopAuto_MN,
            this.resyncDataToolStripMenuItem});
            this.Control_MN.ForeColor = System.Drawing.Color.Black;
            this.Control_MN.Name = "Control_MN";
            this.Control_MN.Size = new System.Drawing.Size(65, 24);
            this.Control_MN.Text = "Control";
            // 
            // StopAuto_MN
            // 
            this.StopAuto_MN.Name = "StopAuto_MN";
            this.StopAuto_MN.Size = new System.Drawing.Size(222, 26);
            this.StopAuto_MN.Text = "Stop Automation [ESC]";
            this.StopAuto_MN.Click += new System.EventHandler(this.StopAuto_MN_Click);
            // 
            // resyncDataToolStripMenuItem
            // 
            this.resyncDataToolStripMenuItem.Name = "resyncDataToolStripMenuItem";
            this.resyncDataToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.resyncDataToolStripMenuItem.Text = "Reset Setings";
            this.resyncDataToolStripMenuItem.Click += new System.EventHandler(this.ResyncDataToolStripMenuItem_Click);
            // 
            // Help_MN
            // 
            this.Help_MN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.Help_MN.ForeColor = System.Drawing.Color.Black;
            this.Help_MN.Name = "Help_MN";
            this.Help_MN.Size = new System.Drawing.Size(49, 24);
            this.Help_MN.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Enabled = false;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Enabled = false;
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aboutToolStripMenuItem.Text = "Version Control";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainStatus_SB
            // 
            this.MainStatus_SB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainStatus_SB.AutoSize = false;
            this.MainStatus_SB.BackColor = System.Drawing.Color.LightGray;
            this.MainStatus_SB.Dock = System.Windows.Forms.DockStyle.None;
            this.MainStatus_SB.GripMargin = new System.Windows.Forms.Padding(5);
            this.MainStatus_SB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatus_SB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress_PB,
            this.StatusText_LBL,
            this.StatusInfo_LBL});
            this.MainStatus_SB.Location = new System.Drawing.Point(1, 919);
            this.MainStatus_SB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 7);
            this.MainStatus_SB.Name = "MainStatus_SB";
            this.MainStatus_SB.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.MainStatus_SB.Size = new System.Drawing.Size(1278, 25);
            this.MainStatus_SB.SizingGrip = false;
            this.MainStatus_SB.TabIndex = 7;
            this.MainStatus_SB.Text = "StatusBar";
            // 
            // Progress_PB
            // 
            this.Progress_PB.Name = "Progress_PB";
            this.Progress_PB.Padding = new System.Windows.Forms.Padding(5, 2, 2, 2);
            this.Progress_PB.Size = new System.Drawing.Size(81, 17);
            this.Progress_PB.Step = 1;
            // 
            // StatusText_LBL
            // 
            this.StatusText_LBL.BackColor = System.Drawing.Color.Transparent;
            this.StatusText_LBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusText_LBL.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusText_LBL.ForeColor = System.Drawing.Color.Black;
            this.StatusText_LBL.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.StatusText_LBL.Name = "StatusText_LBL";
            this.StatusText_LBL.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.StatusText_LBL.Size = new System.Drawing.Size(12, 21);
            this.StatusText_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusInfo_LBL
            // 
            this.StatusInfo_LBL.AutoSize = false;
            this.StatusInfo_LBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusInfo_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusInfo_LBL.ForeColor = System.Drawing.Color.Black;
            this.StatusInfo_LBL.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.StatusInfo_LBL.Name = "StatusInfo_LBL";
            this.StatusInfo_LBL.Size = new System.Drawing.Size(1150, 19);
            this.StatusInfo_LBL.Spring = true;
            this.StatusInfo_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainUGLLogo_PB
            // 
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(1007, 69);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(255, 73);
            this.MainUGLLogo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUGLLogo_PB.TabIndex = 9;
            this.MainUGLLogo_PB.TabStop = false;
            // 
            // SingleSetup_BW
            // 
            this.SingleSetup_BW.WorkerSupportsCancellation = true;
            this.SingleSetup_BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SingleSetup_DoWork);
            this.SingleSetup_BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SingleSetup_Completed);
            // 
            // CheckSAP_TM
            // 
            this.CheckSAP_TM.Enabled = true;
            this.CheckSAP_TM.Interval = 60000;
            this.CheckSAP_TM.Tick += new System.EventHandler(this.CheckSAP_Tick);
            // 
            // RaiseVariation_TP
            // 
            this.RaiseVariation_TP.BackColor = System.Drawing.Color.White;
            this.RaiseVariation_TP.Controls.Add(this.VarInfoLayout);
            this.RaiseVariation_TP.ForeColor = System.Drawing.Color.Black;
            this.RaiseVariation_TP.Location = new System.Drawing.Point(4, 27);
            this.RaiseVariation_TP.Name = "RaiseVariation_TP";
            this.RaiseVariation_TP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RaiseVariation_TP.Size = new System.Drawing.Size(1231, 746);
            this.RaiseVariation_TP.TabIndex = 2;
            this.RaiseVariation_TP.Text = "Raise Variation";
            // 
            // VarInfoLayout
            // 
            this.VarInfoLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarInfoLayout.ColumnCount = 2;
            this.VarInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VarInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VarInfoLayout.Controls.Add(this.VarInfo_GB, 1, 0);
            this.VarInfoLayout.Controls.Add(this.VarOrderInfo_LBL, 0, 0);
            this.VarInfoLayout.Controls.Add(this.VarCheckEntryList_BTN, 0, 1);
            this.VarInfoLayout.Controls.Add(this.VarRaiseServiceOrder_BTN, 1, 1);
            this.VarInfoLayout.Location = new System.Drawing.Point(4, 5);
            this.VarInfoLayout.Name = "VarInfoLayout";
            this.VarInfoLayout.RowCount = 2;
            this.VarInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66304F));
            this.VarInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.336957F));
            this.VarInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VarInfoLayout.Size = new System.Drawing.Size(1223, 736);
            this.VarInfoLayout.TabIndex = 10;
            // 
            // VarInfo_GB
            // 
            this.VarInfo_GB.Controls.Add(this.tableLayoutPanel3);
            this.VarInfo_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarInfo_GB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarInfo_GB.Location = new System.Drawing.Point(614, 3);
            this.VarInfo_GB.Name = "VarInfo_GB";
            this.VarInfo_GB.Size = new System.Drawing.Size(606, 676);
            this.VarInfo_GB.TabIndex = 0;
            this.VarInfo_GB.TabStop = false;
            this.VarInfo_GB.Text = "Variation Information";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LongText_TB, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Variations_LB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LongText_LBL, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 651);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // LongText_TB
            // 
            this.LongText_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LongText_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LongText_TB.Cursor = System.Windows.Forms.Cursors.Default;
            this.LongText_TB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_TB.Location = new System.Drawing.Point(3, 359);
            this.LongText_TB.Name = "LongText_TB";
            this.LongText_TB.Size = new System.Drawing.Size(594, 289);
            this.LongText_TB.TabIndex = 11;
            this.LongText_TB.Text = "";
            // 
            // Variations_LB
            // 
            this.Variations_LB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Variations_LB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variations_LB.FormattingEnabled = true;
            this.Variations_LB.ItemHeight = 18;
            this.Variations_LB.Location = new System.Drawing.Point(3, 35);
            this.Variations_LB.Name = "Variations_LB";
            this.Variations_LB.Size = new System.Drawing.Size(594, 274);
            this.Variations_LB.TabIndex = 10;
            this.Variations_LB.SelectedIndexChanged += new System.EventHandler(this.Variations_LB_SelectionIndexChanged);
            this.Variations_LB.DoubleClick += new System.EventHandler(this.Variation_LB_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "VARIATIONS RAISED";
            // 
            // LongText_LBL
            // 
            this.LongText_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LongText_LBL.AutoSize = true;
            this.LongText_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_LBL.Location = new System.Drawing.Point(216, 338);
            this.LongText_LBL.Name = "LongText_LBL";
            this.LongText_LBL.Size = new System.Drawing.Size(167, 18);
            this.LongText_LBL.TabIndex = 2;
            this.LongText_LBL.Text = "NOTIFICATION LONG TEXT";
            // 
            // VarOrderInfo_LBL
            // 
            this.VarOrderInfo_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VarOrderInfo_LBL.Controls.Add(this.VariationTable_TPN);
            this.VarOrderInfo_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarOrderInfo_LBL.Location = new System.Drawing.Point(3, 3);
            this.VarOrderInfo_LBL.Name = "VarOrderInfo_LBL";
            this.VarOrderInfo_LBL.Size = new System.Drawing.Size(605, 676);
            this.VarOrderInfo_LBL.TabIndex = 1;
            this.VarOrderInfo_LBL.TabStop = false;
            this.VarOrderInfo_LBL.Text = "Variation Order Information";
            // 
            // VariationTable_TPN
            // 
            this.VariationTable_TPN.ColumnCount = 2;
            this.VariationTable_TPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58621F));
            this.VariationTable_TPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41379F));
            this.VariationTable_TPN.Controls.Add(this.VarSerialNumber_LBL, 0, 0);
            this.VariationTable_TPN.Controls.Add(this.VarSerialNumber_TB, 1, 0);
            this.VariationTable_TPN.Controls.Add(this.VarTemplate_CB, 1, 1);
            this.VariationTable_TPN.Controls.Add(this.VarTemplate_LBL, 0, 1);
            this.VariationTable_TPN.Controls.Add(this.VarTaskType_CB, 1, 2);
            this.VariationTable_TPN.Controls.Add(this.VarTaskType_LBL, 0, 2);
            this.VariationTable_TPN.Controls.Add(this.VarSOEndDate_DP, 1, 5);
            this.VariationTable_TPN.Controls.Add(this.VarSOStartDate_DP, 1, 4);
            this.VariationTable_TPN.Controls.Add(this.label1, 0, 5);
            this.VariationTable_TPN.Controls.Add(this.VarSOStartDate_LBL, 0, 4);
            this.VariationTable_TPN.Controls.Add(this.VarExternalReference_LBL, 0, 7);
            this.VariationTable_TPN.Controls.Add(this.VarSOPriority_CB, 1, 6);
            this.VariationTable_TPN.Controls.Add(this.VarSOPriority_LBL, 0, 6);
            this.VariationTable_TPN.Controls.Add(this.VarPMActivityType_LBL, 0, 3);
            this.VariationTable_TPN.Controls.Add(this.VarPMActivityType_CB, 1, 3);
            this.VariationTable_TPN.Controls.Add(this.VarExternalReference_TB, 1, 7);
            this.VariationTable_TPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariationTable_TPN.Location = new System.Drawing.Point(3, 22);
            this.VariationTable_TPN.Name = "VariationTable_TPN";
            this.VariationTable_TPN.RowCount = 8;
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VariationTable_TPN.Size = new System.Drawing.Size(599, 651);
            this.VariationTable_TPN.TabIndex = 0;
            // 
            // VarSerialNumber_LBL
            // 
            this.VarSerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSerialNumber_LBL.AutoSize = true;
            this.VarSerialNumber_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_LBL.Location = new System.Drawing.Point(20, 22);
            this.VarSerialNumber_LBL.Name = "VarSerialNumber_LBL";
            this.VarSerialNumber_LBL.Size = new System.Drawing.Size(202, 36);
            this.VarSerialNumber_LBL.TabIndex = 0;
            this.VarSerialNumber_LBL.Text = "SERIAL NUMBER:\r\n(Press ENTER to load variations)";
            this.VarSerialNumber_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSerialNumber_TB
            // 
            this.VarSerialNumber_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSerialNumber_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_TB.Location = new System.Drawing.Point(228, 27);
            this.VarSerialNumber_TB.Name = "VarSerialNumber_TB";
            this.VarSerialNumber_TB.Size = new System.Drawing.Size(368, 26);
            this.VarSerialNumber_TB.TabIndex = 1;
            this.VarSerialNumber_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VarSerialNumber_KeyDown);
            // 
            // VarTemplate_CB
            // 
            this.VarTemplate_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarTemplate_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTemplate_CB.FormattingEnabled = true;
            this.VarTemplate_CB.Location = new System.Drawing.Point(228, 108);
            this.VarTemplate_CB.Name = "VarTemplate_CB";
            this.VarTemplate_CB.Size = new System.Drawing.Size(368, 26);
            this.VarTemplate_CB.TabIndex = 2;
            this.VarTemplate_CB.TextChanged += new System.EventHandler(this.VarTemplate_CB_TextChanged);
            // 
            // VarTemplate_LBL
            // 
            this.VarTemplate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarTemplate_LBL.AutoSize = true;
            this.VarTemplate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTemplate_LBL.Location = new System.Drawing.Point(27, 112);
            this.VarTemplate_LBL.Name = "VarTemplate_LBL";
            this.VarTemplate_LBL.Size = new System.Drawing.Size(195, 18);
            this.VarTemplate_LBL.TabIndex = 0;
            this.VarTemplate_LBL.Text = "SELECT TEMPLATE EQUIPMENT:";
            this.VarTemplate_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarTaskType_CB
            // 
            this.VarTaskType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarTaskType_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTaskType_CB.FormattingEnabled = true;
            this.VarTaskType_CB.Location = new System.Drawing.Point(228, 189);
            this.VarTaskType_CB.Name = "VarTaskType_CB";
            this.VarTaskType_CB.Size = new System.Drawing.Size(368, 26);
            this.VarTaskType_CB.TabIndex = 3;
            // 
            // VarTaskType_LBL
            // 
            this.VarTaskType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarTaskType_LBL.AutoSize = true;
            this.VarTaskType_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTaskType_LBL.Location = new System.Drawing.Point(64, 193);
            this.VarTaskType_LBL.Name = "VarTaskType_LBL";
            this.VarTaskType_LBL.Size = new System.Drawing.Size(158, 18);
            this.VarTaskType_LBL.TabIndex = 0;
            this.VarTaskType_LBL.Text = "SELECT VARIATION TASK:";
            this.VarTaskType_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSOEndDate_DP
            // 
            this.VarSOEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOEndDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.Location = new System.Drawing.Point(228, 432);
            this.VarSOEndDate_DP.Name = "VarSOEndDate_DP";
            this.VarSOEndDate_DP.Size = new System.Drawing.Size(368, 26);
            this.VarSOEndDate_DP.TabIndex = 6;
            // 
            // VarSOStartDate_DP
            // 
            this.VarSOStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOStartDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.Location = new System.Drawing.Point(228, 351);
            this.VarSOStartDate_DP.Name = "VarSOStartDate_DP";
            this.VarSOStartDate_DP.Size = new System.Drawing.Size(368, 26);
            this.VarSOStartDate_DP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANNED FINISH DATE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSOStartDate_LBL
            // 
            this.VarSOStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSOStartDate_LBL.AutoSize = true;
            this.VarSOStartDate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_LBL.Location = new System.Drawing.Point(77, 355);
            this.VarSOStartDate_LBL.Name = "VarSOStartDate_LBL";
            this.VarSOStartDate_LBL.Size = new System.Drawing.Size(145, 18);
            this.VarSOStartDate_LBL.TabIndex = 0;
            this.VarSOStartDate_LBL.Text = "PLANNED START DATE:";
            this.VarSOStartDate_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarExternalReference_LBL
            // 
            this.VarExternalReference_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarExternalReference_LBL.AutoSize = true;
            this.VarExternalReference_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarExternalReference_LBL.Location = new System.Drawing.Point(76, 600);
            this.VarExternalReference_LBL.Name = "VarExternalReference_LBL";
            this.VarExternalReference_LBL.Size = new System.Drawing.Size(146, 18);
            this.VarExternalReference_LBL.TabIndex = 0;
            this.VarExternalReference_LBL.Text = "EXTERNAL REFERENCE:";
            this.VarExternalReference_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSOPriority_CB
            // 
            this.VarSOPriority_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOPriority_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOPriority_CB.FormattingEnabled = true;
            this.VarSOPriority_CB.Location = new System.Drawing.Point(228, 513);
            this.VarSOPriority_CB.Name = "VarSOPriority_CB";
            this.VarSOPriority_CB.Size = new System.Drawing.Size(368, 26);
            this.VarSOPriority_CB.TabIndex = 7;
            // 
            // VarSOPriority_LBL
            // 
            this.VarSOPriority_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSOPriority_LBL.AutoSize = true;
            this.VarSOPriority_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOPriority_LBL.Location = new System.Drawing.Point(155, 517);
            this.VarSOPriority_LBL.Name = "VarSOPriority_LBL";
            this.VarSOPriority_LBL.Size = new System.Drawing.Size(67, 18);
            this.VarSOPriority_LBL.TabIndex = 0;
            this.VarSOPriority_LBL.Text = "PRIORITY:";
            this.VarSOPriority_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarPMActivityType_LBL
            // 
            this.VarPMActivityType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarPMActivityType_LBL.AutoSize = true;
            this.VarPMActivityType_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarPMActivityType_LBL.Location = new System.Drawing.Point(100, 274);
            this.VarPMActivityType_LBL.Name = "VarPMActivityType_LBL";
            this.VarPMActivityType_LBL.Size = new System.Drawing.Size(122, 18);
            this.VarPMActivityType_LBL.TabIndex = 0;
            this.VarPMActivityType_LBL.Text = "PM ACTIVITY TYPE:";
            this.VarPMActivityType_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarPMActivityType_CB
            // 
            this.VarPMActivityType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarPMActivityType_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarPMActivityType_CB.FormattingEnabled = true;
            this.VarPMActivityType_CB.Location = new System.Drawing.Point(228, 270);
            this.VarPMActivityType_CB.Name = "VarPMActivityType_CB";
            this.VarPMActivityType_CB.Size = new System.Drawing.Size(368, 26);
            this.VarPMActivityType_CB.TabIndex = 4;
            // 
            // VarExternalReference_TB
            // 
            this.VarExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarExternalReference_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarExternalReference_TB.Location = new System.Drawing.Point(228, 596);
            this.VarExternalReference_TB.Name = "VarExternalReference_TB";
            this.VarExternalReference_TB.Size = new System.Drawing.Size(368, 26);
            this.VarExternalReference_TB.TabIndex = 8;
            // 
            // VarCheckEntryList_BTN
            // 
            this.VarCheckEntryList_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarCheckEntryList_BTN.Location = new System.Drawing.Point(3, 685);
            this.VarCheckEntryList_BTN.Name = "VarCheckEntryList_BTN";
            this.VarCheckEntryList_BTN.Size = new System.Drawing.Size(605, 48);
            this.VarCheckEntryList_BTN.TabIndex = 2;
            this.VarCheckEntryList_BTN.Text = "Check Equipment Entry List";
            this.VarCheckEntryList_BTN.UseVisualStyleBackColor = true;
            this.VarCheckEntryList_BTN.Click += new System.EventHandler(this.VarSetupEquipment_BTN_Click);
            // 
            // VarRaiseServiceOrder_BTN
            // 
            this.VarRaiseServiceOrder_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarRaiseServiceOrder_BTN.Location = new System.Drawing.Point(614, 685);
            this.VarRaiseServiceOrder_BTN.Name = "VarRaiseServiceOrder_BTN";
            this.VarRaiseServiceOrder_BTN.Size = new System.Drawing.Size(606, 48);
            this.VarRaiseServiceOrder_BTN.TabIndex = 2;
            this.VarRaiseServiceOrder_BTN.Text = "Raise Variation Service Order";
            this.VarRaiseServiceOrder_BTN.UseVisualStyleBackColor = true;
            this.VarRaiseServiceOrder_BTN.Click += new System.EventHandler(this.CreateVariationOrder_BTN_Click);
            // 
            // DataTabs_TC
            // 
            this.DataTabs_TC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTabs_TC.Controls.Add(this.InitialSetup_TP);
            this.DataTabs_TC.Controls.Add(this.RaiseVariation_TP);
            this.DataTabs_TC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataTabs_TC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataTabs_TC.Location = new System.Drawing.Point(21, 122);
            this.DataTabs_TC.Margin = new System.Windows.Forms.Padding(9);
            this.DataTabs_TC.Name = "DataTabs_TC";
            this.DataTabs_TC.SelectedIndex = 0;
            this.DataTabs_TC.Size = new System.Drawing.Size(1239, 777);
            this.DataTabs_TC.TabIndex = 8;
            // 
            // InitialSetup_TP
            // 
            this.InitialSetup_TP.Controls.Add(this.MainLayout);
            this.InitialSetup_TP.Location = new System.Drawing.Point(4, 27);
            this.InitialSetup_TP.Name = "InitialSetup_TP";
            this.InitialSetup_TP.Padding = new System.Windows.Forms.Padding(3);
            this.InitialSetup_TP.Size = new System.Drawing.Size(1231, 746);
            this.InitialSetup_TP.TabIndex = 3;
            this.InitialSetup_TP.Text = "Raise Lead Order";
            this.InitialSetup_TP.UseVisualStyleBackColor = true;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.groupBox1, 0, 3);
            this.MainLayout.Controls.Add(this.groupBox2, 0, 2);
            this.MainLayout.Controls.Add(this.groupBox3, 1, 2);
            this.MainLayout.Controls.Add(this.SetupEquipment_BTN, 0, 1);
            this.MainLayout.Controls.Add(this.RiaseServiceOrder_BTN, 1, 1);
            this.MainLayout.Controls.Add(this.EquipmentInfo_GB, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(3, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.23745F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.941591F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.96576F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.66486F));
            this.MainLayout.Size = new System.Drawing.Size(1225, 740);
            this.MainLayout.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76341F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23659F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55205F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EqDesc_LBL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentOutput_TB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionOutput_TB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SetupModOutput_TB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CELNumberOutput_TB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.WorkCenterOutput_TB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.WBSOutput_TB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NotificationOutput_TB, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.SOOutput_TB, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(154, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "EQUIPMENT NUMBER:";
            // 
            // EqDesc_LBL
            // 
            this.EqDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EqDesc_LBL.AutoSize = true;
            this.EqDesc_LBL.ForeColor = System.Drawing.Color.Black;
            this.EqDesc_LBL.Location = new System.Drawing.Point(126, 64);
            this.EqDesc_LBL.Name = "EqDesc_LBL";
            this.EqDesc_LBL.Size = new System.Drawing.Size(171, 18);
            this.EqDesc_LBL.TabIndex = 3;
            this.EqDesc_LBL.Text = "EQUIPMENT DESCRIPTION:";
            // 
            // EquipmentOutput_TB
            // 
            this.EquipmentOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EquipmentOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.EquipmentOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EquipmentOutput_TB.Location = new System.Drawing.Point(303, 10);
            this.EquipmentOutput_TB.Name = "EquipmentOutput_TB";
            this.EquipmentOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EquipmentOutput_TB.Size = new System.Drawing.Size(300, 28);
            this.EquipmentOutput_TB.TabIndex = 1;
            this.EquipmentOutput_TB.TabStop = false;
            this.EquipmentOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(191, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "SETUP MODULE:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(162, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "ENTRY LIST NUMBER:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(798, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "WORK CENTER:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(801, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "WBS ELEMENT:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(741, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "NOTIFICATION NUMBER:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(735, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "SERVICE ORDER NUMBER:";
            // 
            // DescriptionOutput_TB
            // 
            this.DescriptionOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptionOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionOutput_TB.Location = new System.Drawing.Point(303, 59);
            this.DescriptionOutput_TB.Name = "DescriptionOutput_TB";
            this.DescriptionOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescriptionOutput_TB.Size = new System.Drawing.Size(300, 28);
            this.DescriptionOutput_TB.TabIndex = 1;
            this.DescriptionOutput_TB.TabStop = false;
            this.DescriptionOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetupModOutput_TB
            // 
            this.SetupModOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SetupModOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.SetupModOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetupModOutput_TB.Location = new System.Drawing.Point(303, 108);
            this.SetupModOutput_TB.Name = "SetupModOutput_TB";
            this.SetupModOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetupModOutput_TB.Size = new System.Drawing.Size(300, 28);
            this.SetupModOutput_TB.TabIndex = 1;
            this.SetupModOutput_TB.TabStop = false;
            this.SetupModOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CELNumberOutput_TB
            // 
            this.CELNumberOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CELNumberOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.CELNumberOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CELNumberOutput_TB.Location = new System.Drawing.Point(303, 158);
            this.CELNumberOutput_TB.Name = "CELNumberOutput_TB";
            this.CELNumberOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CELNumberOutput_TB.Size = new System.Drawing.Size(300, 28);
            this.CELNumberOutput_TB.TabIndex = 1;
            this.CELNumberOutput_TB.TabStop = false;
            this.CELNumberOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WorkCenterOutput_TB
            // 
            this.WorkCenterOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WorkCenterOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.WorkCenterOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkCenterOutput_TB.Location = new System.Drawing.Point(905, 10);
            this.WorkCenterOutput_TB.Name = "WorkCenterOutput_TB";
            this.WorkCenterOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WorkCenterOutput_TB.Size = new System.Drawing.Size(305, 28);
            this.WorkCenterOutput_TB.TabIndex = 1;
            this.WorkCenterOutput_TB.TabStop = false;
            this.WorkCenterOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WBSOutput_TB
            // 
            this.WBSOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WBSOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.WBSOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WBSOutput_TB.Location = new System.Drawing.Point(905, 59);
            this.WBSOutput_TB.Name = "WBSOutput_TB";
            this.WBSOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WBSOutput_TB.Size = new System.Drawing.Size(305, 28);
            this.WBSOutput_TB.TabIndex = 1;
            this.WBSOutput_TB.TabStop = false;
            this.WBSOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NotificationOutput_TB
            // 
            this.NotificationOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NotificationOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.NotificationOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NotificationOutput_TB.Location = new System.Drawing.Point(905, 108);
            this.NotificationOutput_TB.Name = "NotificationOutput_TB";
            this.NotificationOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NotificationOutput_TB.Size = new System.Drawing.Size(305, 28);
            this.NotificationOutput_TB.TabIndex = 1;
            this.NotificationOutput_TB.TabStop = false;
            this.NotificationOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SOOutput_TB
            // 
            this.SOOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SOOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.SOOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SOOutput_TB.Location = new System.Drawing.Point(905, 158);
            this.SOOutput_TB.Name = "SOOutput_TB";
            this.SOOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SOOutput_TB.Size = new System.Drawing.Size(305, 28);
            this.SOOutput_TB.TabIndex = 1;
            this.SOOutput_TB.TabStop = false;
            this.SOOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.NotificationLayout);
            this.groupBox2.Location = new System.Drawing.Point(3, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification Input";
            // 
            // NotificationLayout
            // 
            this.NotificationLayout.ColumnCount = 2;
            this.NotificationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotificationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NotificationLayout.Controls.Add(this.SoldToParty_LBL, 0, 0);
            this.NotificationLayout.Controls.Add(this.PartyName_CB, 1, 0);
            this.NotificationLayout.Controls.Add(this.PurchaseOrder_TB, 1, 1);
            this.NotificationLayout.Controls.Add(this.PurchaseOrder_LBL, 0, 1);
            this.NotificationLayout.Controls.Add(this.PurchaseOrderDate_DP, 1, 2);
            this.NotificationLayout.Controls.Add(this.RequiredStartDate_DP, 1, 3);
            this.NotificationLayout.Controls.Add(this.RequiredEndDate_DP, 1, 4);
            this.NotificationLayout.Controls.Add(this.label3, 0, 2);
            this.NotificationLayout.Controls.Add(this.label6, 0, 3);
            this.NotificationLayout.Controls.Add(this.label7, 0, 4);
            this.NotificationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationLayout.Location = new System.Drawing.Point(3, 22);
            this.NotificationLayout.Name = "NotificationLayout";
            this.NotificationLayout.RowCount = 5;
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.Size = new System.Drawing.Size(600, 250);
            this.NotificationLayout.TabIndex = 0;
            // 
            // SoldToParty_LBL
            // 
            this.SoldToParty_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SoldToParty_LBL.AutoSize = true;
            this.SoldToParty_LBL.ForeColor = System.Drawing.Color.Black;
            this.SoldToParty_LBL.Location = new System.Drawing.Point(193, 16);
            this.SoldToParty_LBL.Name = "SoldToParty_LBL";
            this.SoldToParty_LBL.Size = new System.Drawing.Size(104, 18);
            this.SoldToParty_LBL.TabIndex = 3;
            this.SoldToParty_LBL.Text = "SOLD TO PARTY:";
            // 
            // PartyName_CB
            // 
            this.PartyName_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PartyName_CB.FormattingEnabled = true;
            this.PartyName_CB.Location = new System.Drawing.Point(303, 12);
            this.PartyName_CB.Name = "PartyName_CB";
            this.PartyName_CB.Size = new System.Drawing.Size(294, 26);
            this.PartyName_CB.TabIndex = 6;
            // 
            // PurchaseOrder_TB
            // 
            this.PurchaseOrder_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchaseOrder_TB.Location = new System.Drawing.Point(303, 62);
            this.PurchaseOrder_TB.Name = "PurchaseOrder_TB";
            this.PurchaseOrder_TB.Size = new System.Drawing.Size(294, 26);
            this.PurchaseOrder_TB.TabIndex = 7;
            // 
            // PurchaseOrder_LBL
            // 
            this.PurchaseOrder_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PurchaseOrder_LBL.AutoSize = true;
            this.PurchaseOrder_LBL.ForeColor = System.Drawing.Color.Black;
            this.PurchaseOrder_LBL.Location = new System.Drawing.Point(175, 66);
            this.PurchaseOrder_LBL.Name = "PurchaseOrder_LBL";
            this.PurchaseOrder_LBL.Size = new System.Drawing.Size(122, 18);
            this.PurchaseOrder_LBL.TabIndex = 3;
            this.PurchaseOrder_LBL.Text = "PURCHASE ORDER:";
            // 
            // PurchaseOrderDate_DP
            // 
            this.PurchaseOrderDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchaseOrderDate_DP.Location = new System.Drawing.Point(303, 112);
            this.PurchaseOrderDate_DP.Name = "PurchaseOrderDate_DP";
            this.PurchaseOrderDate_DP.Size = new System.Drawing.Size(294, 26);
            this.PurchaseOrderDate_DP.TabIndex = 8;
            this.PurchaseOrderDate_DP.Value = new System.DateTime(2021, 9, 20, 0, 0, 0, 0);
            // 
            // RequiredStartDate_DP
            // 
            this.RequiredStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredStartDate_DP.Location = new System.Drawing.Point(303, 162);
            this.RequiredStartDate_DP.Name = "RequiredStartDate_DP";
            this.RequiredStartDate_DP.Size = new System.Drawing.Size(294, 26);
            this.RequiredStartDate_DP.TabIndex = 9;
            this.RequiredStartDate_DP.Value = new System.DateTime(2021, 9, 20, 0, 0, 0, 0);
            // 
            // RequiredEndDate_DP
            // 
            this.RequiredEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredEndDate_DP.Location = new System.Drawing.Point(303, 212);
            this.RequiredEndDate_DP.Name = "RequiredEndDate_DP";
            this.RequiredEndDate_DP.Size = new System.Drawing.Size(294, 26);
            this.RequiredEndDate_DP.TabIndex = 10;
            this.RequiredEndDate_DP.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(141, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "PURCHASE ORDER DATE:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(149, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "REQUIRED START DATE:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(160, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "REQUIRED END DATE:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ServiceOrderInfoLayout);
            this.groupBox3.Location = new System.Drawing.Point(615, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Order Input";
            // 
            // ServiceOrderInfoLayout
            // 
            this.ServiceOrderInfoLayout.ColumnCount = 2;
            this.ServiceOrderInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.24841F));
            this.ServiceOrderInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75159F));
            this.ServiceOrderInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ServiceOrderInfoLayout.Controls.Add(this.ActivityType_LBL, 0, 0);
            this.ServiceOrderInfoLayout.Controls.Add(this.PMActivityType_CB, 1, 0);
            this.ServiceOrderInfoLayout.Controls.Add(this.ExternalReference_TB, 1, 4);
            this.ServiceOrderInfoLayout.Controls.Add(this.BasicStartDate_LBL, 0, 1);
            this.ServiceOrderInfoLayout.Controls.Add(this.BasicStartDate_DP, 1, 1);
            this.ServiceOrderInfoLayout.Controls.Add(this.BasicEndDate_LBL, 0, 2);
            this.ServiceOrderInfoLayout.Controls.Add(this.Priority_LBL, 0, 3);
            this.ServiceOrderInfoLayout.Controls.Add(this.ExternalRef_LBL, 0, 4);
            this.ServiceOrderInfoLayout.Controls.Add(this.Priority_CB, 1, 3);
            this.ServiceOrderInfoLayout.Controls.Add(this.BasicEndDate_DP, 1, 2);
            this.ServiceOrderInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceOrderInfoLayout.Location = new System.Drawing.Point(3, 22);
            this.ServiceOrderInfoLayout.Name = "ServiceOrderInfoLayout";
            this.ServiceOrderInfoLayout.RowCount = 5;
            this.ServiceOrderInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfoLayout.Size = new System.Drawing.Size(601, 250);
            this.ServiceOrderInfoLayout.TabIndex = 0;
            // 
            // ActivityType_LBL
            // 
            this.ActivityType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ActivityType_LBL.AutoSize = true;
            this.ActivityType_LBL.ForeColor = System.Drawing.Color.Black;
            this.ActivityType_LBL.Location = new System.Drawing.Point(164, 16);
            this.ActivityType_LBL.Name = "ActivityType_LBL";
            this.ActivityType_LBL.Size = new System.Drawing.Size(122, 18);
            this.ActivityType_LBL.TabIndex = 3;
            this.ActivityType_LBL.Text = "PM ACTIVITY TYPE:";
            // 
            // PMActivityType_CB
            // 
            this.PMActivityType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PMActivityType_CB.FormattingEnabled = true;
            this.PMActivityType_CB.Location = new System.Drawing.Point(292, 12);
            this.PMActivityType_CB.Name = "PMActivityType_CB";
            this.PMActivityType_CB.Size = new System.Drawing.Size(306, 26);
            this.PMActivityType_CB.TabIndex = 11;
            // 
            // ExternalReference_TB
            // 
            this.ExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExternalReference_TB.Location = new System.Drawing.Point(292, 212);
            this.ExternalReference_TB.Name = "ExternalReference_TB";
            this.ExternalReference_TB.Size = new System.Drawing.Size(306, 26);
            this.ExternalReference_TB.TabIndex = 15;
            // 
            // BasicStartDate_LBL
            // 
            this.BasicStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicStartDate_LBL.AutoSize = true;
            this.BasicStartDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicStartDate_LBL.Location = new System.Drawing.Point(141, 66);
            this.BasicStartDate_LBL.Name = "BasicStartDate_LBL";
            this.BasicStartDate_LBL.Size = new System.Drawing.Size(145, 18);
            this.BasicStartDate_LBL.TabIndex = 3;
            this.BasicStartDate_LBL.Text = "PLANNED START DATE:";
            // 
            // BasicStartDate_DP
            // 
            this.BasicStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BasicStartDate_DP.Location = new System.Drawing.Point(292, 62);
            this.BasicStartDate_DP.Name = "BasicStartDate_DP";
            this.BasicStartDate_DP.Size = new System.Drawing.Size(306, 26);
            this.BasicStartDate_DP.TabIndex = 12;
            this.BasicStartDate_DP.Value = new System.DateTime(2021, 9, 20, 9, 42, 51, 0);
            // 
            // BasicEndDate_LBL
            // 
            this.BasicEndDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicEndDate_LBL.AutoSize = true;
            this.BasicEndDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicEndDate_LBL.Location = new System.Drawing.Point(152, 116);
            this.BasicEndDate_LBL.Name = "BasicEndDate_LBL";
            this.BasicEndDate_LBL.Size = new System.Drawing.Size(134, 18);
            this.BasicEndDate_LBL.TabIndex = 3;
            this.BasicEndDate_LBL.Text = "PLANNED END DATE:";
            // 
            // Priority_LBL
            // 
            this.Priority_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Priority_LBL.AutoSize = true;
            this.Priority_LBL.ForeColor = System.Drawing.Color.Black;
            this.Priority_LBL.Location = new System.Drawing.Point(219, 166);
            this.Priority_LBL.Name = "Priority_LBL";
            this.Priority_LBL.Size = new System.Drawing.Size(67, 18);
            this.Priority_LBL.TabIndex = 3;
            this.Priority_LBL.Text = "PRIORITY:";
            // 
            // ExternalRef_LBL
            // 
            this.ExternalRef_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExternalRef_LBL.AutoSize = true;
            this.ExternalRef_LBL.ForeColor = System.Drawing.Color.Black;
            this.ExternalRef_LBL.Location = new System.Drawing.Point(140, 216);
            this.ExternalRef_LBL.Name = "ExternalRef_LBL";
            this.ExternalRef_LBL.Size = new System.Drawing.Size(146, 18);
            this.ExternalRef_LBL.TabIndex = 3;
            this.ExternalRef_LBL.Text = "EXTERNAL REFERENCE:";
            // 
            // Priority_CB
            // 
            this.Priority_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Priority_CB.FormattingEnabled = true;
            this.Priority_CB.Location = new System.Drawing.Point(292, 162);
            this.Priority_CB.Name = "Priority_CB";
            this.Priority_CB.Size = new System.Drawing.Size(306, 26);
            this.Priority_CB.TabIndex = 14;
            // 
            // BasicEndDate_DP
            // 
            this.BasicEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BasicEndDate_DP.Location = new System.Drawing.Point(292, 112);
            this.BasicEndDate_DP.Name = "BasicEndDate_DP";
            this.BasicEndDate_DP.Size = new System.Drawing.Size(306, 26);
            this.BasicEndDate_DP.TabIndex = 13;
            this.BasicEndDate_DP.Value = new System.DateTime(2021, 9, 20, 9, 42, 51, 0);
            // 
            // SetupEquipment_BTN
            // 
            this.SetupEquipment_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupEquipment_BTN.BackColor = System.Drawing.Color.Gainsboro;
            this.SetupEquipment_BTN.ForeColor = System.Drawing.Color.Black;
            this.SetupEquipment_BTN.Location = new System.Drawing.Point(3, 190);
            this.SetupEquipment_BTN.Name = "SetupEquipment_BTN";
            this.SetupEquipment_BTN.Size = new System.Drawing.Size(606, 38);
            this.SetupEquipment_BTN.TabIndex = 16;
            this.SetupEquipment_BTN.Text = "Setup Equipment";
            this.SetupEquipment_BTN.UseVisualStyleBackColor = false;
            this.SetupEquipment_BTN.Click += new System.EventHandler(this.SetupEquipment_BTN_Click);
            // 
            // RiaseServiceOrder_BTN
            // 
            this.RiaseServiceOrder_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RiaseServiceOrder_BTN.BackColor = System.Drawing.Color.Gainsboro;
            this.RiaseServiceOrder_BTN.ForeColor = System.Drawing.Color.Black;
            this.RiaseServiceOrder_BTN.Location = new System.Drawing.Point(615, 190);
            this.RiaseServiceOrder_BTN.Name = "RiaseServiceOrder_BTN";
            this.RiaseServiceOrder_BTN.Size = new System.Drawing.Size(607, 38);
            this.RiaseServiceOrder_BTN.TabIndex = 17;
            this.RiaseServiceOrder_BTN.Text = "Raise Service Order";
            this.RiaseServiceOrder_BTN.UseVisualStyleBackColor = false;
            this.RiaseServiceOrder_BTN.Click += new System.EventHandler(this.RaiseServiceOrder_BT_Click);
            // 
            // EquipmentInfo_GB
            // 
            this.EquipmentInfo_GB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayout.SetColumnSpan(this.EquipmentInfo_GB, 2);
            this.EquipmentInfo_GB.Controls.Add(this.EquipmentInfo_Layout);
            this.EquipmentInfo_GB.Location = new System.Drawing.Point(3, 3);
            this.EquipmentInfo_GB.Name = "EquipmentInfo_GB";
            this.EquipmentInfo_GB.Size = new System.Drawing.Size(1219, 181);
            this.EquipmentInfo_GB.TabIndex = 5;
            this.EquipmentInfo_GB.TabStop = false;
            this.EquipmentInfo_GB.Text = "Equipment Information";
            // 
            // EquipmentInfo_Layout
            // 
            this.EquipmentInfo_Layout.ColumnCount = 4;
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.EquipmentInfo_Layout.Controls.Add(this.EquipmentSerial_TB, 2, 0);
            this.EquipmentInfo_Layout.Controls.Add(this.TemplateEquipmentList_CB, 2, 1);
            this.EquipmentInfo_Layout.Controls.Add(this.TaskType_CB, 2, 2);
            this.EquipmentInfo_Layout.Controls.Add(this.FunctionLoc_CB, 2, 3);
            this.EquipmentInfo_Layout.Controls.Add(this.SerialNumber_LBL, 1, 0);
            this.EquipmentInfo_Layout.Controls.Add(this.TemplateEquipment_LBL, 1, 1);
            this.EquipmentInfo_Layout.Controls.Add(this.label4, 1, 2);
            this.EquipmentInfo_Layout.Controls.Add(this.label5, 1, 3);
            this.EquipmentInfo_Layout.Controls.Add(this.WarrantyClaim_CHB, 0, 0);
            this.EquipmentInfo_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInfo_Layout.Location = new System.Drawing.Point(3, 22);
            this.EquipmentInfo_Layout.Name = "EquipmentInfo_Layout";
            this.EquipmentInfo_Layout.RowCount = 4;
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.Size = new System.Drawing.Size(1213, 156);
            this.EquipmentInfo_Layout.TabIndex = 0;
            // 
            // EquipmentSerial_TB
            // 
            this.EquipmentSerial_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EquipmentSerial_TB.Location = new System.Drawing.Point(296, 6);
            this.EquipmentSerial_TB.Name = "EquipmentSerial_TB";
            this.EquipmentSerial_TB.Size = new System.Drawing.Size(511, 26);
            this.EquipmentSerial_TB.TabIndex = 2;
            // 
            // TemplateEquipmentList_CB
            // 
            this.TemplateEquipmentList_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TemplateEquipmentList_CB.FormattingEnabled = true;
            this.TemplateEquipmentList_CB.Location = new System.Drawing.Point(296, 45);
            this.TemplateEquipmentList_CB.Name = "TemplateEquipmentList_CB";
            this.TemplateEquipmentList_CB.Size = new System.Drawing.Size(511, 26);
            this.TemplateEquipmentList_CB.TabIndex = 3;
            this.TemplateEquipmentList_CB.TextChanged += new System.EventHandler(this.TemplateEquipmentList_CB_TextChanged);
            this.TemplateEquipmentList_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TemplateEquipment_CB_KeyPress);
            // 
            // TaskType_CB
            // 
            this.TaskType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskType_CB.FormattingEnabled = true;
            this.TaskType_CB.Location = new System.Drawing.Point(296, 84);
            this.TaskType_CB.Name = "TaskType_CB";
            this.TaskType_CB.Size = new System.Drawing.Size(511, 26);
            this.TaskType_CB.TabIndex = 4;
            // 
            // FunctionLoc_CB
            // 
            this.FunctionLoc_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FunctionLoc_CB.FormattingEnabled = true;
            this.FunctionLoc_CB.Location = new System.Drawing.Point(296, 123);
            this.FunctionLoc_CB.Name = "FunctionLoc_CB";
            this.FunctionLoc_CB.Size = new System.Drawing.Size(511, 26);
            this.FunctionLoc_CB.TabIndex = 5;
            // 
            // SerialNumber_LBL
            // 
            this.SerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SerialNumber_LBL.AutoSize = true;
            this.SerialNumber_LBL.ForeColor = System.Drawing.Color.Black;
            this.SerialNumber_LBL.Location = new System.Drawing.Point(180, 10);
            this.SerialNumber_LBL.Name = "SerialNumber_LBL";
            this.SerialNumber_LBL.Size = new System.Drawing.Size(110, 18);
            this.SerialNumber_LBL.TabIndex = 0;
            this.SerialNumber_LBL.Text = "SERIAL NUMBER:";
            // 
            // TemplateEquipment_LBL
            // 
            this.TemplateEquipment_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TemplateEquipment_LBL.AutoSize = true;
            this.TemplateEquipment_LBL.ForeColor = System.Drawing.Color.Black;
            this.TemplateEquipment_LBL.Location = new System.Drawing.Point(140, 49);
            this.TemplateEquipment_LBL.Name = "TemplateEquipment_LBL";
            this.TemplateEquipment_LBL.Size = new System.Drawing.Size(150, 18);
            this.TemplateEquipment_LBL.TabIndex = 0;
            this.TemplateEquipment_LBL.Text = "TEMPLATE EQUIPMENT:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(171, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECT TASK TYPE:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(147, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "FUNCTION LOCATION:";
            // 
            // WarrantyClaim_CHB
            // 
            this.WarrantyClaim_CHB.AutoSize = true;
            this.WarrantyClaim_CHB.ForeColor = System.Drawing.Color.Black;
            this.WarrantyClaim_CHB.Location = new System.Drawing.Point(3, 3);
            this.WarrantyClaim_CHB.Name = "WarrantyClaim_CHB";
            this.WarrantyClaim_CHB.Size = new System.Drawing.Size(131, 22);
            this.WarrantyClaim_CHB.TabIndex = 1;
            this.WarrantyClaim_CHB.Text = "Warranty Claim?";
            this.WarrantyClaim_CHB.UseVisualStyleBackColor = true;
            // 
            // General_TT
            // 
            this.General_TT.IsBalloon = true;
            // 
            // OutputInfo_TPL
            // 
            this.OutputInfo_TPL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputInfo_TPL.ColumnCount = 4;
            this.OutputInfo_TPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.OutputInfo_TPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.OutputInfo_TPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.OutputInfo_TPL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.OutputInfo_TPL.Controls.Add(this.CELNumber_LBL, 0, 3);
            this.OutputInfo_TPL.Location = new System.Drawing.Point(0, 0);
            this.OutputInfo_TPL.Name = "OutputInfo_TPL";
            this.OutputInfo_TPL.RowCount = 4;
            this.OutputInfo_TPL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OutputInfo_TPL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OutputInfo_TPL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OutputInfo_TPL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OutputInfo_TPL.Size = new System.Drawing.Size(200, 100);
            this.OutputInfo_TPL.TabIndex = 0;
            // 
            // CELNumber_LBL
            // 
            this.CELNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CELNumber_LBL.AutoSize = true;
            this.CELNumber_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CELNumber_LBL.Location = new System.Drawing.Point(79, 71);
            this.CELNumber_LBL.Name = "CELNumber_LBL";
            this.CELNumber_LBL.Size = new System.Drawing.Size(137, 17);
            this.CELNumber_LBL.TabIndex = 12;
            this.CELNumber_LBL.Text = "ENTRY LIST NUMBER:";
            this.CELNumber_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EqNumber_LBL
            // 
            this.EqNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EqNumber_LBL.AutoSize = true;
            this.EqNumber_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqNumber_LBL.Location = new System.Drawing.Point(73, 0);
            this.EqNumber_LBL.Name = "EqNumber_LBL";
            this.EqNumber_LBL.Size = new System.Drawing.Size(143, 17);
            this.EqNumber_LBL.TabIndex = 11;
            this.EqNumber_LBL.Text = "EQUIPMENT NUMBER:";
            this.EqNumber_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputInfo_GB
            // 
            this.OutputInfo_GB.Location = new System.Drawing.Point(0, 0);
            this.OutputInfo_GB.Name = "OutputInfo_GB";
            this.OutputInfo_GB.Size = new System.Drawing.Size(200, 100);
            this.OutputInfo_GB.TabIndex = 0;
            this.OutputInfo_GB.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1280, 945);
            this.Controls.Add(this.MainUGLLogo_PB);
            this.Controls.Add(this.MainStatus_SB);
            this.Controls.Add(this.TitleBar_PNL);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.DataTabs_TC);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(8750, 9444);
            this.MinimumSize = new System.Drawing.Size(1280, 945);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Mobility Setup Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainStatus_SB.ResumeLayout(false);
            this.MainStatus_SB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.RaiseVariation_TP.ResumeLayout(false);
            this.VarInfoLayout.ResumeLayout(false);
            this.VarInfo_GB.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.VarOrderInfo_LBL.ResumeLayout(false);
            this.VariationTable_TPN.ResumeLayout(false);
            this.VariationTable_TPN.PerformLayout();
            this.DataTabs_TC.ResumeLayout(false);
            this.InitialSetup_TP.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.NotificationLayout.ResumeLayout(false);
            this.NotificationLayout.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ServiceOrderInfoLayout.ResumeLayout(false);
            this.ServiceOrderInfoLayout.PerformLayout();
            this.EquipmentInfo_GB.ResumeLayout(false);
            this.EquipmentInfo_Layout.ResumeLayout(false);
            this.EquipmentInfo_Layout.PerformLayout();
            this.OutputInfo_TPL.ResumeLayout(false);
            this.OutputInfo_TPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File_MN;
        private System.Windows.Forms.ToolStripMenuItem Exit_MN;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.ToolStripMenuItem AppSettings_MN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox MainUGLLogo_PB;
        private System.Windows.Forms.ToolStripMenuItem Control_MN;
        private System.Windows.Forms.ToolStripMenuItem StopAuto_MN;
        public System.ComponentModel.BackgroundWorker SingleSetup_BW;
        public System.Windows.Forms.Panel TitleBar_PNL;
        private System.Windows.Forms.Label CloseButton_LBL;
        private System.Windows.Forms.Label MaximizeButton_LBL;
        private System.Windows.Forms.Label MinimizeButton_LBL;
        public System.Windows.Forms.ToolStripStatusLabel StatusText_LBL;
        private System.Windows.Forms.ToolStripMenuItem Help_MN;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfo_LBL;
        private System.Windows.Forms.Timer CheckSAP_TM;
        public System.Windows.Forms.StatusStrip MainStatus_SB;
        public System.Windows.Forms.ToolStripProgressBar Progress_PB;
        private System.Windows.Forms.TabPage RaiseVariation_TP;
        private System.Windows.Forms.GroupBox VarOrderInfo_LBL;
        private System.Windows.Forms.TableLayoutPanel VariationTable_TPN;
        private System.Windows.Forms.Label VarSerialNumber_LBL;
        private System.Windows.Forms.TextBox VarSerialNumber_TB;
        private System.Windows.Forms.Label VarTemplate_LBL;
        private System.Windows.Forms.Label VarTaskType_LBL;
        private System.Windows.Forms.DateTimePicker VarSOEndDate_DP;
        private System.Windows.Forms.DateTimePicker VarSOStartDate_DP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VarSOStartDate_LBL;
        private System.Windows.Forms.Label VarExternalReference_LBL;
        private System.Windows.Forms.Label VarSOPriority_LBL;
        private System.Windows.Forms.Label VarPMActivityType_LBL;
        private System.Windows.Forms.TextBox VarExternalReference_TB;
        private System.Windows.Forms.GroupBox VarInfo_GB;
        private System.Windows.Forms.RichTextBox LongText_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LongText_LBL;
        private System.Windows.Forms.ListBox Variations_LB;
        private System.Windows.Forms.TabControl DataTabs_TC;
        public System.Windows.Forms.ComboBox VarTemplate_CB;
        public System.Windows.Forms.ComboBox VarTaskType_CB;
        public System.Windows.Forms.ComboBox VarSOPriority_CB;
        public System.Windows.Forms.ComboBox VarPMActivityType_CB;
        private System.Windows.Forms.ToolStripMenuItem resyncDataToolStripMenuItem;
        public System.Windows.Forms.ToolTip General_TT;
        private System.Windows.Forms.TabPage InitialSetup_TP;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel OutputInfo_TPL;
        private System.Windows.Forms.Label CELNumber_LBL;
        private System.Windows.Forms.Label EqNumber_LBL;
        private System.Windows.Forms.GroupBox OutputInfo_GB;
        private System.Windows.Forms.Button SetupEquipment_BTN;
        private System.Windows.Forms.Button RiaseServiceOrder_BTN;
        private System.Windows.Forms.GroupBox EquipmentInfo_GB;
        private System.Windows.Forms.TableLayoutPanel EquipmentInfo_Layout;
        private System.Windows.Forms.Label SerialNumber_LBL;
        private System.Windows.Forms.Label TemplateEquipment_LBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox EquipmentSerial_TB;
        public System.Windows.Forms.ComboBox TemplateEquipmentList_CB;
        public System.Windows.Forms.ComboBox FunctionLoc_CB;
        public System.Windows.Forms.ComboBox TaskType_CB;
        private System.Windows.Forms.TableLayoutPanel NotificationLayout;
        public System.Windows.Forms.ComboBox PartyName_CB;
        private System.Windows.Forms.Label SoldToParty_LBL;
        public System.Windows.Forms.TextBox PurchaseOrder_TB;
        private System.Windows.Forms.Label PurchaseOrder_LBL;
        public System.Windows.Forms.DateTimePicker RequiredStartDate_DP;
        public System.Windows.Forms.DateTimePicker RequiredEndDate_DP;
        public System.Windows.Forms.DateTimePicker PurchaseOrderDate_DP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel ServiceOrderInfoLayout;
        private System.Windows.Forms.Label ActivityType_LBL;
        private System.Windows.Forms.Label BasicStartDate_LBL;
        private System.Windows.Forms.Label BasicEndDate_LBL;
        private System.Windows.Forms.Label Priority_LBL;
        private System.Windows.Forms.Label ExternalRef_LBL;
        private System.Windows.Forms.CheckBox WarrantyClaim_CHB;
        public System.Windows.Forms.ComboBox PMActivityType_CB;
        public System.Windows.Forms.TextBox ExternalReference_TB;
        public System.Windows.Forms.DateTimePicker BasicStartDate_DP;
        public System.Windows.Forms.ComboBox Priority_CB;
        public System.Windows.Forms.DateTimePicker BasicEndDate_DP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EqDesc_LBL;
        public System.Windows.Forms.TextBox EquipmentOutput_TB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox DescriptionOutput_TB;
        public System.Windows.Forms.TextBox SetupModOutput_TB;
        public System.Windows.Forms.TextBox CELNumberOutput_TB;
        public System.Windows.Forms.TextBox WorkCenterOutput_TB;
        public System.Windows.Forms.TextBox WBSOutput_TB;
        public System.Windows.Forms.TextBox NotificationOutput_TB;
        public System.Windows.Forms.TextBox SOOutput_TB;
        private System.Windows.Forms.TableLayoutPanel VarInfoLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button VarCheckEntryList_BTN;
        private System.Windows.Forms.Button VarRaiseServiceOrder_BTN;
    }
}

