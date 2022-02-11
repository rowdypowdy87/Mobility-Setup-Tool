
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
            this.FileMenu_SPR = new System.Windows.Forms.ToolStripSeparator();
            this.Exit_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.Control_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.StopAuto_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.ResyncData_MNI = new System.Windows.Forms.ToolStripMenuItem();
            this.View_MN = new System.Windows.Forms.ToolStripMenuItem();
            this.QOutputWindow_MN = new System.Windows.Forms.ToolStripMenuItem();
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
            this.VarInfoLayout_PNL = new System.Windows.Forms.TableLayoutPanel();
            this.VarInfo_GB = new System.Windows.Forms.GroupBox();
            this.RightSide_TBL = new System.Windows.Forms.TableLayoutPanel();
            this.LongText_TB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LongText_LBL = new System.Windows.Forms.Label();
            this.LoadVariation_BTN = new System.Windows.Forms.Button();
            this.Variations_LB = new System.Windows.Forms.ListBox();
            this.VarOrderInfo_LBL = new System.Windows.Forms.GroupBox();
            this.VariationTable_TPN = new System.Windows.Forms.TableLayoutPanel();
            this.VarSOEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.VarSOStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.VPlannedFinDate_LBL = new System.Windows.Forms.Label();
            this.VarSOStartDate_LBL = new System.Windows.Forms.Label();
            this.VarExternalReference_LBL = new System.Windows.Forms.Label();
            this.VarSOPriority_CB = new Mobility_Setup_Tool.RComboBox();
            this.VarSOPriority_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_CB = new Mobility_Setup_Tool.RComboBox();
            this.VarExternalReference_TB = new System.Windows.Forms.TextBox();
            this.VarCheckEntryList_BTN = new System.Windows.Forms.Button();
            this.VarRaiseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.EqInfo_GRB = new System.Windows.Forms.GroupBox();
            this.EqInfo_TBL = new System.Windows.Forms.TableLayoutPanel();
            this.VarTaskType_CB = new Mobility_Setup_Tool.RComboBox();
            this.VarSerialNumber_LBL = new System.Windows.Forms.Label();
            this.VarTaskType_LBL = new System.Windows.Forms.Label();
            this.VarTemplate_LBL = new System.Windows.Forms.Label();
            this.VarTemplate_CB = new Mobility_Setup_Tool.RComboBox();
            this.VarSerialNumber_TB = new System.Windows.Forms.TextBox();
            this.DataTabs_TC = new System.Windows.Forms.TabControl();
            this.InitialSetup_TP = new System.Windows.Forms.TabPage();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NotificationInput_GRB = new System.Windows.Forms.GroupBox();
            this.NotificationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SoldToParty_LBL = new System.Windows.Forms.Label();
            this.PartyName_CB = new Mobility_Setup_Tool.RComboBox();
            this.PurchaseOrder_TB = new System.Windows.Forms.TextBox();
            this.PurchaseOrder_LBL = new System.Windows.Forms.Label();
            this.PurchaseOrderDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ServOrderInput_GRB = new System.Windows.Forms.GroupBox();
            this.ServiceOrderInfo_LYT = new System.Windows.Forms.TableLayoutPanel();
            this.ActivityType_LBL = new System.Windows.Forms.Label();
            this.PMActivityType_CB = new Mobility_Setup_Tool.RComboBox();
            this.ExternalReference_TB = new System.Windows.Forms.TextBox();
            this.BasicStartDate_LBL = new System.Windows.Forms.Label();
            this.BasicStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.BasicEndDate_LBL = new System.Windows.Forms.Label();
            this.Priority_LBL = new System.Windows.Forms.Label();
            this.ExternalRef_LBL = new System.Windows.Forms.Label();
            this.Priority_CB = new Mobility_Setup_Tool.RComboBox();
            this.BasicEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.EquipmentInfo_GB = new System.Windows.Forms.GroupBox();
            this.EquipmentInfo_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentSerial_TB = new System.Windows.Forms.TextBox();
            this.TemplateEquipmentList_CB = new Mobility_Setup_Tool.RComboBox();
            this.TaskType_CB = new Mobility_Setup_Tool.RComboBox();
            this.FunctionLoc_CB = new Mobility_Setup_Tool.RComboBox();
            this.SerialNumber_LBL = new System.Windows.Forms.Label();
            this.TemplateEquipment_LBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarrantyClaim_CHB = new System.Windows.Forms.CheckBox();
            this.SetupEquipment_BTN = new System.Windows.Forms.Button();
            this.RiaseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.QuoteOrder_TP = new System.Windows.Forms.TabPage();
            this.QuoteLayout = new System.Windows.Forms.TableLayoutPanel();
            this.QuoteNotiListBox = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.QuoteServiceOrder_TB = new System.Windows.Forms.TextBox();
            this.QuoteNumberTB = new System.Windows.Forms.TextBox();
            this.QuoteTemplate_CB = new Mobility_Setup_Tool.RComboBox();
            this.QuoteServiceOrder_BTN = new System.Windows.Forms.Button();
            this.LoadNotification_BTN = new System.Windows.Forms.Button();
            this.QuoteOutput_LV = new System.Windows.Forms.ListView();
            this.ItemType_CH = new System.Windows.Forms.ColumnHeader();
            this.TxtForQuote_CH = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Notification = new System.Windows.Forms.ColumnHeader();
            this.General_TT = new System.Windows.Forms.ToolTip(this.components);
            this.OutputInfo_TPL = new System.Windows.Forms.TableLayoutPanel();
            this.CELNumber_LBL = new System.Windows.Forms.Label();
            this.EqNumber_LBL = new System.Windows.Forms.Label();
            this.OutputInfo_GB = new System.Windows.Forms.GroupBox();
            this.Output_PNL = new System.Windows.Forms.Panel();
            this.QOutputInfo_GRB = new System.Windows.Forms.GroupBox();
            this.QuoteOutput_PNL = new System.Windows.Forms.TableLayoutPanel();
            this.QServiceOrder_TB = new System.Windows.Forms.TextBox();
            this.QPurchaseOrder_LBL = new System.Windows.Forms.Label();
            this.QNumOfVars_LBL = new System.Windows.Forms.Label();
            this.QMaterialPrice_LBL = new System.Windows.Forms.Label();
            this.QOverhaulPrice_LBL = new System.Windows.Forms.Label();
            this.QVariationPrice_LBL = new System.Windows.Forms.Label();
            this.QTotalPrice_LBL = new System.Windows.Forms.Label();
            this.QEquipmentNum_TB = new System.Windows.Forms.TextBox();
            this.QPurchaseOrder_TB = new System.Windows.Forms.TextBox();
            this.QNumOfVars_TB = new System.Windows.Forms.TextBox();
            this.QMaterialPrice_TB = new System.Windows.Forms.TextBox();
            this.QStandardPrice_TB = new System.Windows.Forms.TextBox();
            this.QVarLabourPrice_TB = new System.Windows.Forms.TextBox();
            this.QTotalPrice_TB = new System.Windows.Forms.TextBox();
            this.QEqNum_LBL = new System.Windows.Forms.Label();
            this.QServOrderDesc_LBL = new System.Windows.Forms.Label();
            this.OutputOrder_PNL = new System.Windows.Forms.TableLayoutPanel();
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
            this.label8 = new System.Windows.Forms.Label();
            this.EqDesc_LBL = new System.Windows.Forms.Label();
            this.MainFormLayout_PNL = new System.Windows.Forms.TableLayoutPanel();
            this.TitleBar_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.MainStatus_SB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).BeginInit();
            this.RaiseVariation_TP.SuspendLayout();
            this.VarInfoLayout_PNL.SuspendLayout();
            this.VarInfo_GB.SuspendLayout();
            this.RightSide_TBL.SuspendLayout();
            this.VarOrderInfo_LBL.SuspendLayout();
            this.VariationTable_TPN.SuspendLayout();
            this.EqInfo_GRB.SuspendLayout();
            this.EqInfo_TBL.SuspendLayout();
            this.DataTabs_TC.SuspendLayout();
            this.InitialSetup_TP.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.NotificationInput_GRB.SuspendLayout();
            this.NotificationLayout.SuspendLayout();
            this.ServOrderInput_GRB.SuspendLayout();
            this.ServiceOrderInfo_LYT.SuspendLayout();
            this.EquipmentInfo_GB.SuspendLayout();
            this.EquipmentInfo_Layout.SuspendLayout();
            this.QuoteOrder_TP.SuspendLayout();
            this.QuoteLayout.SuspendLayout();
            this.OutputInfo_TPL.SuspendLayout();
            this.Output_PNL.SuspendLayout();
            this.QOutputInfo_GRB.SuspendLayout();
            this.QuoteOutput_PNL.SuspendLayout();
            this.OutputOrder_PNL.SuspendLayout();
            this.MainFormLayout_PNL.SuspendLayout();
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
            this.TitleBar_PNL.Location = new System.Drawing.Point(1, 1);
            this.TitleBar_PNL.Name = "TitleBar_PNL";
            this.TitleBar_PNL.Size = new System.Drawing.Size(1278, 37);
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
            this.MinimizeButton_LBL.Location = new System.Drawing.Point(1173, 0);
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
            this.MaximizeButton_LBL.Location = new System.Drawing.Point(1208, 0);
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
            this.CloseButton_LBL.Location = new System.Drawing.Point(1243, 0);
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
            this.View_MN,
            this.Help_MN});
            this.MainMenu.Location = new System.Drawing.Point(1, 37);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(1, 0, 0, 1);
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
            this.FileMenu_SPR,
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
            // FileMenu_SPR
            // 
            this.FileMenu_SPR.Name = "FileMenu_SPR";
            this.FileMenu_SPR.Size = new System.Drawing.Size(202, 6);
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
            this.ResyncData_MNI});
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
            // ResyncData_MNI
            // 
            this.ResyncData_MNI.Name = "ResyncData_MNI";
            this.ResyncData_MNI.Size = new System.Drawing.Size(222, 26);
            this.ResyncData_MNI.Text = "Reset Setings";
            this.ResyncData_MNI.Click += new System.EventHandler(this.ResyncDataToolStripMenuItem_Click);
            // 
            // View_MN
            // 
            this.View_MN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QOutputWindow_MN});
            this.View_MN.ForeColor = System.Drawing.Color.Black;
            this.View_MN.Name = "View_MN";
            this.View_MN.Size = new System.Drawing.Size(49, 24);
            this.View_MN.Text = "View";
            // 
            // QOutputWindow_MN
            // 
            this.QOutputWindow_MN.CheckOnClick = true;
            this.QOutputWindow_MN.Name = "QOutputWindow_MN";
            this.QOutputWindow_MN.Size = new System.Drawing.Size(221, 26);
            this.QOutputWindow_MN.Text = "Quote Output Window";
            this.QOutputWindow_MN.Click += new System.EventHandler(this.QOutputWindow_MN_Click);
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
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aboutToolStripMenuItem.Text = "Version History";
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
            this.MainStatus_SB.Location = new System.Drawing.Point(1, 1120);
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
            this.MainUGLLogo_PB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUGLLogo_PB.BackColor = System.Drawing.Color.Transparent;
            this.MainUGLLogo_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainUGLLogo_PB.ErrorImage = null;
            this.MainUGLLogo_PB.Image = global::Mobility_Setup_Tool.Properties.Resources.LOGOWHITE;
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(994, 8);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
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
            this.RaiseVariation_TP.Controls.Add(this.VarInfoLayout_PNL);
            this.RaiseVariation_TP.ForeColor = System.Drawing.Color.Black;
            this.RaiseVariation_TP.Location = new System.Drawing.Point(4, 27);
            this.RaiseVariation_TP.Name = "RaiseVariation_TP";
            this.RaiseVariation_TP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RaiseVariation_TP.Size = new System.Drawing.Size(1231, 658);
            this.RaiseVariation_TP.TabIndex = 2;
            this.RaiseVariation_TP.Text = "Raise Order From Notification";
            // 
            // VarInfoLayout_PNL
            // 
            this.VarInfoLayout_PNL.ColumnCount = 2;
            this.VarInfoLayout_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VarInfoLayout_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VarInfoLayout_PNL.Controls.Add(this.VarInfo_GB, 1, 0);
            this.VarInfoLayout_PNL.Controls.Add(this.VarOrderInfo_LBL, 0, 1);
            this.VarInfoLayout_PNL.Controls.Add(this.VarCheckEntryList_BTN, 0, 2);
            this.VarInfoLayout_PNL.Controls.Add(this.VarRaiseServiceOrder_BTN, 1, 2);
            this.VarInfoLayout_PNL.Controls.Add(this.EqInfo_GRB, 0, 0);
            this.VarInfoLayout_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarInfoLayout_PNL.Location = new System.Drawing.Point(4, 5);
            this.VarInfoLayout_PNL.Name = "VarInfoLayout_PNL";
            this.VarInfoLayout_PNL.RowCount = 3;
            this.VarInfoLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.VarInfoLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.25319F));
            this.VarInfoLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74681F));
            this.VarInfoLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VarInfoLayout_PNL.Size = new System.Drawing.Size(1223, 648);
            this.VarInfoLayout_PNL.TabIndex = 10;
            // 
            // VarInfo_GB
            // 
            this.VarInfo_GB.Controls.Add(this.RightSide_TBL);
            this.VarInfo_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarInfo_GB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarInfo_GB.Location = new System.Drawing.Point(614, 3);
            this.VarInfo_GB.Name = "VarInfo_GB";
            this.VarInfoLayout_PNL.SetRowSpan(this.VarInfo_GB, 2);
            this.VarInfo_GB.Size = new System.Drawing.Size(606, 597);
            this.VarInfo_GB.TabIndex = 0;
            this.VarInfo_GB.TabStop = false;
            this.VarInfo_GB.Text = "Variation Information";
            // 
            // RightSide_TBL
            // 
            this.RightSide_TBL.ColumnCount = 1;
            this.RightSide_TBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSide_TBL.Controls.Add(this.LongText_TB, 0, 3);
            this.RightSide_TBL.Controls.Add(this.label2, 0, 0);
            this.RightSide_TBL.Controls.Add(this.LongText_LBL, 0, 2);
            this.RightSide_TBL.Controls.Add(this.LoadVariation_BTN, 0, 2);
            this.RightSide_TBL.Controls.Add(this.Variations_LB, 0, 1);
            this.RightSide_TBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSide_TBL.Location = new System.Drawing.Point(3, 22);
            this.RightSide_TBL.Name = "RightSide_TBL";
            this.RightSide_TBL.RowCount = 5;
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightSide_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightSide_TBL.Size = new System.Drawing.Size(600, 572);
            this.RightSide_TBL.TabIndex = 11;
            this.RightSide_TBL.Paint += new System.Windows.Forms.PaintEventHandler(this.RightSide_TBL_Paint);
            // 
            // LongText_TB
            // 
            this.LongText_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LongText_TB.Cursor = System.Windows.Forms.Cursors.Default;
            this.LongText_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LongText_TB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_TB.Location = new System.Drawing.Point(3, 310);
            this.LongText_TB.Name = "LongText_TB";
            this.LongText_TB.Size = new System.Drawing.Size(594, 259);
            this.LongText_TB.TabIndex = 11;
            this.LongText_TB.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOTIFICATION DESCRIPTION";
            // 
            // LongText_LBL
            // 
            this.LongText_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LongText_LBL.AutoSize = true;
            this.LongText_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_LBL.Location = new System.Drawing.Point(216, 289);
            this.LongText_LBL.Name = "LongText_LBL";
            this.LongText_LBL.Size = new System.Drawing.Size(167, 18);
            this.LongText_LBL.TabIndex = 2;
            this.LongText_LBL.Text = "NOTIFICATION LONG TEXT";
            // 
            // LoadVariation_BTN
            // 
            this.LoadVariation_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadVariation_BTN.Location = new System.Drawing.Point(3, 247);
            this.LoadVariation_BTN.Name = "LoadVariation_BTN";
            this.LoadVariation_BTN.Size = new System.Drawing.Size(594, 39);
            this.LoadVariation_BTN.TabIndex = 12;
            this.LoadVariation_BTN.Text = "Load Variations";
            this.LoadVariation_BTN.UseVisualStyleBackColor = true;
            this.LoadVariation_BTN.Click += new System.EventHandler(this.LoadVariation_BTN_Click);
            // 
            // Variations_LB
            // 
            this.Variations_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Variations_LB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Variations_LB.FormattingEnabled = true;
            this.Variations_LB.ItemHeight = 18;
            this.Variations_LB.Location = new System.Drawing.Point(3, 21);
            this.Variations_LB.Name = "Variations_LB";
            this.Variations_LB.Size = new System.Drawing.Size(594, 220);
            this.Variations_LB.TabIndex = 10;
            this.Variations_LB.SelectedIndexChanged += new System.EventHandler(this.Variations_LB_SelectionIndexChanged);
            // 
            // VarOrderInfo_LBL
            // 
            this.VarOrderInfo_LBL.Controls.Add(this.VariationTable_TPN);
            this.VarOrderInfo_LBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarOrderInfo_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarOrderInfo_LBL.Location = new System.Drawing.Point(3, 240);
            this.VarOrderInfo_LBL.Name = "VarOrderInfo_LBL";
            this.VarOrderInfo_LBL.Size = new System.Drawing.Size(605, 360);
            this.VarOrderInfo_LBL.TabIndex = 1;
            this.VarOrderInfo_LBL.TabStop = false;
            this.VarOrderInfo_LBL.Text = "Variation Order Information";
            // 
            // VariationTable_TPN
            // 
            this.VariationTable_TPN.ColumnCount = 2;
            this.VariationTable_TPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58621F));
            this.VariationTable_TPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41379F));
            this.VariationTable_TPN.Controls.Add(this.VarSOEndDate_DP, 1, 2);
            this.VariationTable_TPN.Controls.Add(this.VarSOStartDate_DP, 1, 1);
            this.VariationTable_TPN.Controls.Add(this.VPlannedFinDate_LBL, 0, 2);
            this.VariationTable_TPN.Controls.Add(this.VarSOStartDate_LBL, 0, 1);
            this.VariationTable_TPN.Controls.Add(this.VarExternalReference_LBL, 0, 4);
            this.VariationTable_TPN.Controls.Add(this.VarSOPriority_CB, 1, 3);
            this.VariationTable_TPN.Controls.Add(this.VarSOPriority_LBL, 0, 3);
            this.VariationTable_TPN.Controls.Add(this.VarPMActivityType_LBL, 0, 0);
            this.VariationTable_TPN.Controls.Add(this.VarPMActivityType_CB, 1, 0);
            this.VariationTable_TPN.Controls.Add(this.VarExternalReference_TB, 1, 4);
            this.VariationTable_TPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariationTable_TPN.Location = new System.Drawing.Point(3, 22);
            this.VariationTable_TPN.Name = "VariationTable_TPN";
            this.VariationTable_TPN.RowCount = 5;
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VariationTable_TPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VariationTable_TPN.Size = new System.Drawing.Size(599, 335);
            this.VariationTable_TPN.TabIndex = 0;
            // 
            // VarSOEndDate_DP
            // 
            this.VarSOEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOEndDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.VarSOEndDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VarSOEndDate_DP.Location = new System.Drawing.Point(228, 154);
            this.VarSOEndDate_DP.Name = "VarSOEndDate_DP";
            this.VarSOEndDate_DP.Size = new System.Drawing.Size(368, 26);
            this.VarSOEndDate_DP.TabIndex = 6;
            this.VarSOEndDate_DP.ValueChanged += new System.EventHandler(this.VarBasicEndDate_ValueChanged);
            // 
            // VarSOStartDate_DP
            // 
            this.VarSOStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOStartDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.CustomFormat = "dd.MM.yyyy";
            this.VarSOStartDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VarSOStartDate_DP.Location = new System.Drawing.Point(228, 87);
            this.VarSOStartDate_DP.Name = "VarSOStartDate_DP";
            this.VarSOStartDate_DP.Size = new System.Drawing.Size(368, 26);
            this.VarSOStartDate_DP.TabIndex = 5;
            this.VarSOStartDate_DP.ValueChanged += new System.EventHandler(this.VarBasicStartDate_ValueChanged);
            // 
            // VPlannedFinDate_LBL
            // 
            this.VPlannedFinDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VPlannedFinDate_LBL.AutoSize = true;
            this.VPlannedFinDate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VPlannedFinDate_LBL.Location = new System.Drawing.Point(73, 158);
            this.VPlannedFinDate_LBL.Name = "VPlannedFinDate_LBL";
            this.VPlannedFinDate_LBL.Size = new System.Drawing.Size(149, 18);
            this.VPlannedFinDate_LBL.TabIndex = 0;
            this.VPlannedFinDate_LBL.Text = "PLANNED FINISH DATE:";
            this.VPlannedFinDate_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSOStartDate_LBL
            // 
            this.VarSOStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSOStartDate_LBL.AutoSize = true;
            this.VarSOStartDate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_LBL.Location = new System.Drawing.Point(77, 91);
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
            this.VarExternalReference_LBL.Location = new System.Drawing.Point(76, 292);
            this.VarExternalReference_LBL.Name = "VarExternalReference_LBL";
            this.VarExternalReference_LBL.Size = new System.Drawing.Size(146, 18);
            this.VarExternalReference_LBL.TabIndex = 0;
            this.VarExternalReference_LBL.Text = "EXTERNAL REFERENCE:";
            this.VarExternalReference_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarSOPriority_CB
            // 
            this.VarSOPriority_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOPriority_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarSOPriority_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VarSOPriority_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOPriority_CB.FormattingEnabled = true;
            this.VarSOPriority_CB.Location = new System.Drawing.Point(228, 221);
            this.VarSOPriority_CB.Name = "VarSOPriority_CB";
            this.VarSOPriority_CB.Size = new System.Drawing.Size(368, 26);
            this.VarSOPriority_CB.TabIndex = 7;
            // 
            // VarSOPriority_LBL
            // 
            this.VarSOPriority_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSOPriority_LBL.AutoSize = true;
            this.VarSOPriority_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOPriority_LBL.Location = new System.Drawing.Point(155, 225);
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
            this.VarPMActivityType_LBL.Location = new System.Drawing.Point(100, 24);
            this.VarPMActivityType_LBL.Name = "VarPMActivityType_LBL";
            this.VarPMActivityType_LBL.Size = new System.Drawing.Size(122, 18);
            this.VarPMActivityType_LBL.TabIndex = 0;
            this.VarPMActivityType_LBL.Text = "PM ACTIVITY TYPE:";
            this.VarPMActivityType_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarPMActivityType_CB
            // 
            this.VarPMActivityType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarPMActivityType_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarPMActivityType_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VarPMActivityType_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarPMActivityType_CB.FormattingEnabled = true;
            this.VarPMActivityType_CB.Location = new System.Drawing.Point(228, 20);
            this.VarPMActivityType_CB.Name = "VarPMActivityType_CB";
            this.VarPMActivityType_CB.Size = new System.Drawing.Size(368, 26);
            this.VarPMActivityType_CB.TabIndex = 4;
            // 
            // VarExternalReference_TB
            // 
            this.VarExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarExternalReference_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarExternalReference_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.VarExternalReference_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarExternalReference_TB.Location = new System.Drawing.Point(228, 288);
            this.VarExternalReference_TB.Name = "VarExternalReference_TB";
            this.VarExternalReference_TB.Size = new System.Drawing.Size(368, 26);
            this.VarExternalReference_TB.TabIndex = 8;
            // 
            // VarCheckEntryList_BTN
            // 
            this.VarCheckEntryList_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarCheckEntryList_BTN.Location = new System.Drawing.Point(3, 606);
            this.VarCheckEntryList_BTN.Name = "VarCheckEntryList_BTN";
            this.VarCheckEntryList_BTN.Size = new System.Drawing.Size(605, 39);
            this.VarCheckEntryList_BTN.TabIndex = 2;
            this.VarCheckEntryList_BTN.Text = "Check Equipment Entry List";
            this.VarCheckEntryList_BTN.UseVisualStyleBackColor = true;
            this.VarCheckEntryList_BTN.Click += new System.EventHandler(this.VarSetupEquipment_BTN_Click);
            // 
            // VarRaiseServiceOrder_BTN
            // 
            this.VarRaiseServiceOrder_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarRaiseServiceOrder_BTN.Location = new System.Drawing.Point(614, 606);
            this.VarRaiseServiceOrder_BTN.Name = "VarRaiseServiceOrder_BTN";
            this.VarRaiseServiceOrder_BTN.Size = new System.Drawing.Size(606, 39);
            this.VarRaiseServiceOrder_BTN.TabIndex = 2;
            this.VarRaiseServiceOrder_BTN.Text = "Raise Variation Service Order";
            this.VarRaiseServiceOrder_BTN.UseVisualStyleBackColor = true;
            this.VarRaiseServiceOrder_BTN.Click += new System.EventHandler(this.CreateVariationOrder_BTN_Click);
            // 
            // EqInfo_GRB
            // 
            this.EqInfo_GRB.Controls.Add(this.EqInfo_TBL);
            this.EqInfo_GRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqInfo_GRB.Location = new System.Drawing.Point(3, 3);
            this.EqInfo_GRB.Name = "EqInfo_GRB";
            this.EqInfo_GRB.Size = new System.Drawing.Size(605, 231);
            this.EqInfo_GRB.TabIndex = 3;
            this.EqInfo_GRB.TabStop = false;
            this.EqInfo_GRB.Text = "Equipment Information";
            // 
            // EqInfo_TBL
            // 
            this.EqInfo_TBL.ColumnCount = 2;
            this.EqInfo_TBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.89482F));
            this.EqInfo_TBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.10518F));
            this.EqInfo_TBL.Controls.Add(this.VarTaskType_CB, 1, 2);
            this.EqInfo_TBL.Controls.Add(this.VarSerialNumber_LBL, 0, 0);
            this.EqInfo_TBL.Controls.Add(this.VarTaskType_LBL, 0, 2);
            this.EqInfo_TBL.Controls.Add(this.VarTemplate_LBL, 0, 1);
            this.EqInfo_TBL.Controls.Add(this.VarTemplate_CB, 1, 1);
            this.EqInfo_TBL.Controls.Add(this.VarSerialNumber_TB, 1, 0);
            this.EqInfo_TBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqInfo_TBL.Location = new System.Drawing.Point(3, 22);
            this.EqInfo_TBL.Name = "EqInfo_TBL";
            this.EqInfo_TBL.RowCount = 3;
            this.EqInfo_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EqInfo_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EqInfo_TBL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EqInfo_TBL.Size = new System.Drawing.Size(599, 206);
            this.EqInfo_TBL.TabIndex = 0;
            // 
            // VarTaskType_CB
            // 
            this.VarTaskType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarTaskType_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarTaskType_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VarTaskType_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTaskType_CB.FormattingEnabled = true;
            this.VarTaskType_CB.Location = new System.Drawing.Point(223, 158);
            this.VarTaskType_CB.Name = "VarTaskType_CB";
            this.VarTaskType_CB.Size = new System.Drawing.Size(368, 26);
            this.VarTaskType_CB.TabIndex = 3;
            // 
            // VarSerialNumber_LBL
            // 
            this.VarSerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSerialNumber_LBL.AutoSize = true;
            this.VarSerialNumber_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_LBL.Location = new System.Drawing.Point(107, 25);
            this.VarSerialNumber_LBL.Name = "VarSerialNumber_LBL";
            this.VarSerialNumber_LBL.Size = new System.Drawing.Size(110, 18);
            this.VarSerialNumber_LBL.TabIndex = 0;
            this.VarSerialNumber_LBL.Text = "SERIAL NUMBER:";
            this.VarSerialNumber_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarTaskType_LBL
            // 
            this.VarTaskType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarTaskType_LBL.AutoSize = true;
            this.VarTaskType_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTaskType_LBL.Location = new System.Drawing.Point(59, 162);
            this.VarTaskType_LBL.Name = "VarTaskType_LBL";
            this.VarTaskType_LBL.Size = new System.Drawing.Size(158, 18);
            this.VarTaskType_LBL.TabIndex = 0;
            this.VarTaskType_LBL.Text = "SELECT VARIATION TASK:";
            this.VarTaskType_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarTemplate_LBL
            // 
            this.VarTemplate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarTemplate_LBL.AutoSize = true;
            this.VarTemplate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTemplate_LBL.Location = new System.Drawing.Point(22, 93);
            this.VarTemplate_LBL.Name = "VarTemplate_LBL";
            this.VarTemplate_LBL.Size = new System.Drawing.Size(195, 18);
            this.VarTemplate_LBL.TabIndex = 0;
            this.VarTemplate_LBL.Text = "SELECT TEMPLATE EQUIPMENT:";
            this.VarTemplate_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarTemplate_CB
            // 
            this.VarTemplate_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarTemplate_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarTemplate_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VarTemplate_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTemplate_CB.FormattingEnabled = true;
            this.VarTemplate_CB.Location = new System.Drawing.Point(223, 89);
            this.VarTemplate_CB.Name = "VarTemplate_CB";
            this.VarTemplate_CB.Size = new System.Drawing.Size(368, 26);
            this.VarTemplate_CB.TabIndex = 2;
            this.VarTemplate_CB.TextChanged += new System.EventHandler(this.VarTemplate_CB_TextChanged);
            // 
            // VarSerialNumber_TB
            // 
            this.VarSerialNumber_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSerialNumber_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_TB.Location = new System.Drawing.Point(223, 21);
            this.VarSerialNumber_TB.Name = "VarSerialNumber_TB";
            this.VarSerialNumber_TB.Size = new System.Drawing.Size(368, 26);
            this.VarSerialNumber_TB.TabIndex = 1;
            // 
            // DataTabs_TC
            // 
            this.DataTabs_TC.Controls.Add(this.InitialSetup_TP);
            this.DataTabs_TC.Controls.Add(this.RaiseVariation_TP);
            this.DataTabs_TC.Controls.Add(this.QuoteOrder_TP);
            this.DataTabs_TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTabs_TC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataTabs_TC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataTabs_TC.Location = new System.Drawing.Point(20, 94);
            this.DataTabs_TC.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.DataTabs_TC.Name = "DataTabs_TC";
            this.DataTabs_TC.SelectedIndex = 0;
            this.DataTabs_TC.Size = new System.Drawing.Size(1239, 689);
            this.DataTabs_TC.TabIndex = 8;
            this.DataTabs_TC.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.DataTabs_TC_Selecting);
            // 
            // InitialSetup_TP
            // 
            this.InitialSetup_TP.Controls.Add(this.MainLayout);
            this.InitialSetup_TP.Location = new System.Drawing.Point(4, 27);
            this.InitialSetup_TP.Name = "InitialSetup_TP";
            this.InitialSetup_TP.Padding = new System.Windows.Forms.Padding(3);
            this.InitialSetup_TP.Size = new System.Drawing.Size(1231, 658);
            this.InitialSetup_TP.TabIndex = 3;
            this.InitialSetup_TP.Text = "Raise Lead Order";
            this.InitialSetup_TP.UseVisualStyleBackColor = true;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.NotificationInput_GRB, 0, 2);
            this.MainLayout.Controls.Add(this.ServOrderInput_GRB, 1, 2);
            this.MainLayout.Controls.Add(this.EquipmentInfo_GB, 0, 0);
            this.MainLayout.Controls.Add(this.SetupEquipment_BTN, 0, 1);
            this.MainLayout.Controls.Add(this.RiaseServiceOrder_BTN, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(3, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.23745F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.941591F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.96576F));
            this.MainLayout.Size = new System.Drawing.Size(1225, 652);
            this.MainLayout.TabIndex = 10;
            // 
            // NotificationInput_GRB
            // 
            this.NotificationInput_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationInput_GRB.Controls.Add(this.NotificationLayout);
            this.NotificationInput_GRB.Location = new System.Drawing.Point(5, 296);
            this.NotificationInput_GRB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NotificationInput_GRB.Name = "NotificationInput_GRB";
            this.NotificationInput_GRB.Size = new System.Drawing.Size(602, 353);
            this.NotificationInput_GRB.TabIndex = 1;
            this.NotificationInput_GRB.TabStop = false;
            this.NotificationInput_GRB.Text = "Notification Input";
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
            this.NotificationLayout.Size = new System.Drawing.Size(596, 328);
            this.NotificationLayout.TabIndex = 0;
            // 
            // SoldToParty_LBL
            // 
            this.SoldToParty_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SoldToParty_LBL.AutoSize = true;
            this.SoldToParty_LBL.ForeColor = System.Drawing.Color.Black;
            this.SoldToParty_LBL.Location = new System.Drawing.Point(191, 23);
            this.SoldToParty_LBL.Name = "SoldToParty_LBL";
            this.SoldToParty_LBL.Size = new System.Drawing.Size(104, 18);
            this.SoldToParty_LBL.TabIndex = 3;
            this.SoldToParty_LBL.Text = "SOLD TO PARTY:";
            // 
            // PartyName_CB
            // 
            this.PartyName_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PartyName_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PartyName_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PartyName_CB.FormattingEnabled = true;
            this.PartyName_CB.Location = new System.Drawing.Point(301, 19);
            this.PartyName_CB.Name = "PartyName_CB";
            this.PartyName_CB.Size = new System.Drawing.Size(292, 26);
            this.PartyName_CB.TabIndex = 6;
            // 
            // PurchaseOrder_TB
            // 
            this.PurchaseOrder_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchaseOrder_TB.Location = new System.Drawing.Point(301, 84);
            this.PurchaseOrder_TB.Name = "PurchaseOrder_TB";
            this.PurchaseOrder_TB.Size = new System.Drawing.Size(292, 26);
            this.PurchaseOrder_TB.TabIndex = 7;
            // 
            // PurchaseOrder_LBL
            // 
            this.PurchaseOrder_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PurchaseOrder_LBL.AutoSize = true;
            this.PurchaseOrder_LBL.ForeColor = System.Drawing.Color.Black;
            this.PurchaseOrder_LBL.Location = new System.Drawing.Point(173, 88);
            this.PurchaseOrder_LBL.Name = "PurchaseOrder_LBL";
            this.PurchaseOrder_LBL.Size = new System.Drawing.Size(122, 18);
            this.PurchaseOrder_LBL.TabIndex = 3;
            this.PurchaseOrder_LBL.Text = "PURCHASE ORDER:";
            // 
            // PurchaseOrderDate_DP
            // 
            this.PurchaseOrderDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchaseOrderDate_DP.CustomFormat = "dd.MM.yyyy";
            this.PurchaseOrderDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PurchaseOrderDate_DP.Location = new System.Drawing.Point(301, 149);
            this.PurchaseOrderDate_DP.Name = "PurchaseOrderDate_DP";
            this.PurchaseOrderDate_DP.Size = new System.Drawing.Size(292, 26);
            this.PurchaseOrderDate_DP.TabIndex = 8;
            this.PurchaseOrderDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            this.PurchaseOrderDate_DP.ValueChanged += new System.EventHandler(this.PODate_ValueChanged);
            // 
            // RequiredStartDate_DP
            // 
            this.RequiredStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredStartDate_DP.CustomFormat = "dd.MM.yyyy";
            this.RequiredStartDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RequiredStartDate_DP.Location = new System.Drawing.Point(301, 214);
            this.RequiredStartDate_DP.Name = "RequiredStartDate_DP";
            this.RequiredStartDate_DP.Size = new System.Drawing.Size(292, 26);
            this.RequiredStartDate_DP.TabIndex = 9;
            this.RequiredStartDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            this.RequiredStartDate_DP.ValueChanged += new System.EventHandler(this.ReqStartDate_ValueChanged);
            // 
            // RequiredEndDate_DP
            // 
            this.RequiredEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.RequiredEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RequiredEndDate_DP.Location = new System.Drawing.Point(301, 281);
            this.RequiredEndDate_DP.Name = "RequiredEndDate_DP";
            this.RequiredEndDate_DP.Size = new System.Drawing.Size(292, 26);
            this.RequiredEndDate_DP.TabIndex = 10;
            this.RequiredEndDate_DP.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.RequiredEndDate_DP.ValueChanged += new System.EventHandler(this.ReqEndDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 153);
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
            this.label6.Location = new System.Drawing.Point(147, 218);
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
            this.label7.Location = new System.Drawing.Point(158, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "REQUIRED END DATE:";
            // 
            // ServOrderInput_GRB
            // 
            this.ServOrderInput_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServOrderInput_GRB.Controls.Add(this.ServiceOrderInfo_LYT);
            this.ServOrderInput_GRB.Location = new System.Drawing.Point(617, 296);
            this.ServOrderInput_GRB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ServOrderInput_GRB.Name = "ServOrderInput_GRB";
            this.ServOrderInput_GRB.Size = new System.Drawing.Size(603, 353);
            this.ServOrderInput_GRB.TabIndex = 2;
            this.ServOrderInput_GRB.TabStop = false;
            this.ServOrderInput_GRB.Text = "Service Order Input";
            // 
            // ServiceOrderInfo_LYT
            // 
            this.ServiceOrderInfo_LYT.ColumnCount = 2;
            this.ServiceOrderInfo_LYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.24841F));
            this.ServiceOrderInfo_LYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.75159F));
            this.ServiceOrderInfo_LYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ServiceOrderInfo_LYT.Controls.Add(this.ActivityType_LBL, 0, 0);
            this.ServiceOrderInfo_LYT.Controls.Add(this.PMActivityType_CB, 1, 0);
            this.ServiceOrderInfo_LYT.Controls.Add(this.ExternalReference_TB, 1, 4);
            this.ServiceOrderInfo_LYT.Controls.Add(this.BasicStartDate_LBL, 0, 1);
            this.ServiceOrderInfo_LYT.Controls.Add(this.BasicStartDate_DP, 1, 1);
            this.ServiceOrderInfo_LYT.Controls.Add(this.BasicEndDate_LBL, 0, 2);
            this.ServiceOrderInfo_LYT.Controls.Add(this.Priority_LBL, 0, 3);
            this.ServiceOrderInfo_LYT.Controls.Add(this.ExternalRef_LBL, 0, 4);
            this.ServiceOrderInfo_LYT.Controls.Add(this.Priority_CB, 1, 3);
            this.ServiceOrderInfo_LYT.Controls.Add(this.BasicEndDate_DP, 1, 2);
            this.ServiceOrderInfo_LYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceOrderInfo_LYT.Location = new System.Drawing.Point(3, 22);
            this.ServiceOrderInfo_LYT.Name = "ServiceOrderInfo_LYT";
            this.ServiceOrderInfo_LYT.RowCount = 5;
            this.ServiceOrderInfo_LYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfo_LYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfo_LYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfo_LYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfo_LYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ServiceOrderInfo_LYT.Size = new System.Drawing.Size(597, 328);
            this.ServiceOrderInfo_LYT.TabIndex = 0;
            // 
            // ActivityType_LBL
            // 
            this.ActivityType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ActivityType_LBL.AutoSize = true;
            this.ActivityType_LBL.ForeColor = System.Drawing.Color.Black;
            this.ActivityType_LBL.Location = new System.Drawing.Point(163, 23);
            this.ActivityType_LBL.Name = "ActivityType_LBL";
            this.ActivityType_LBL.Size = new System.Drawing.Size(122, 18);
            this.ActivityType_LBL.TabIndex = 3;
            this.ActivityType_LBL.Text = "PM ACTIVITY TYPE:";
            // 
            // PMActivityType_CB
            // 
            this.PMActivityType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PMActivityType_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PMActivityType_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PMActivityType_CB.FormattingEnabled = true;
            this.PMActivityType_CB.Location = new System.Drawing.Point(291, 19);
            this.PMActivityType_CB.Name = "PMActivityType_CB";
            this.PMActivityType_CB.Size = new System.Drawing.Size(303, 26);
            this.PMActivityType_CB.TabIndex = 11;
            // 
            // ExternalReference_TB
            // 
            this.ExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExternalReference_TB.Location = new System.Drawing.Point(291, 281);
            this.ExternalReference_TB.Name = "ExternalReference_TB";
            this.ExternalReference_TB.Size = new System.Drawing.Size(303, 26);
            this.ExternalReference_TB.TabIndex = 15;
            // 
            // BasicStartDate_LBL
            // 
            this.BasicStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicStartDate_LBL.AutoSize = true;
            this.BasicStartDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicStartDate_LBL.Location = new System.Drawing.Point(140, 88);
            this.BasicStartDate_LBL.Name = "BasicStartDate_LBL";
            this.BasicStartDate_LBL.Size = new System.Drawing.Size(145, 18);
            this.BasicStartDate_LBL.TabIndex = 3;
            this.BasicStartDate_LBL.Text = "PLANNED START DATE:";
            // 
            // BasicStartDate_DP
            // 
            this.BasicStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BasicStartDate_DP.CustomFormat = "dd.MM.yyyy";
            this.BasicStartDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BasicStartDate_DP.Location = new System.Drawing.Point(291, 84);
            this.BasicStartDate_DP.Name = "BasicStartDate_DP";
            this.BasicStartDate_DP.Size = new System.Drawing.Size(303, 26);
            this.BasicStartDate_DP.TabIndex = 12;
            this.BasicStartDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            this.BasicStartDate_DP.ValueChanged += new System.EventHandler(this.BasicStartDate_ValueChanged);
            // 
            // BasicEndDate_LBL
            // 
            this.BasicEndDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicEndDate_LBL.AutoSize = true;
            this.BasicEndDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicEndDate_LBL.Location = new System.Drawing.Point(151, 153);
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
            this.Priority_LBL.Location = new System.Drawing.Point(218, 218);
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
            this.ExternalRef_LBL.Location = new System.Drawing.Point(139, 285);
            this.ExternalRef_LBL.Name = "ExternalRef_LBL";
            this.ExternalRef_LBL.Size = new System.Drawing.Size(146, 18);
            this.ExternalRef_LBL.TabIndex = 3;
            this.ExternalRef_LBL.Text = "EXTERNAL REFERENCE:";
            // 
            // Priority_CB
            // 
            this.Priority_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Priority_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Priority_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Priority_CB.FormattingEnabled = true;
            this.Priority_CB.Location = new System.Drawing.Point(291, 214);
            this.Priority_CB.Name = "Priority_CB";
            this.Priority_CB.Size = new System.Drawing.Size(303, 26);
            this.Priority_CB.TabIndex = 14;
            // 
            // BasicEndDate_DP
            // 
            this.BasicEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BasicEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.BasicEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BasicEndDate_DP.Location = new System.Drawing.Point(291, 149);
            this.BasicEndDate_DP.Name = "BasicEndDate_DP";
            this.BasicEndDate_DP.Size = new System.Drawing.Size(303, 26);
            this.BasicEndDate_DP.TabIndex = 13;
            this.BasicEndDate_DP.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.BasicEndDate_DP.ValueChanged += new System.EventHandler(this.BasicEndDate_ValueChanged);
            // 
            // EquipmentInfo_GB
            // 
            this.MainLayout.SetColumnSpan(this.EquipmentInfo_GB, 2);
            this.EquipmentInfo_GB.Controls.Add(this.EquipmentInfo_Layout);
            this.EquipmentInfo_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInfo_GB.Location = new System.Drawing.Point(5, 3);
            this.EquipmentInfo_GB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EquipmentInfo_GB.Name = "EquipmentInfo_GB";
            this.EquipmentInfo_GB.Size = new System.Drawing.Size(1215, 231);
            this.EquipmentInfo_GB.TabIndex = 5;
            this.EquipmentInfo_GB.TabStop = false;
            this.EquipmentInfo_GB.Text = "Equipment Information";
            // 
            // EquipmentInfo_Layout
            // 
            this.EquipmentInfo_Layout.ColumnCount = 4;
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
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
            this.EquipmentInfo_Layout.Size = new System.Drawing.Size(1209, 206);
            this.EquipmentInfo_Layout.TabIndex = 0;
            // 
            // EquipmentSerial_TB
            // 
            this.EquipmentSerial_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EquipmentSerial_TB.Location = new System.Drawing.Point(485, 12);
            this.EquipmentSerial_TB.Name = "EquipmentSerial_TB";
            this.EquipmentSerial_TB.Size = new System.Drawing.Size(477, 26);
            this.EquipmentSerial_TB.TabIndex = 2;
            // 
            // TemplateEquipmentList_CB
            // 
            this.TemplateEquipmentList_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TemplateEquipmentList_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TemplateEquipmentList_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TemplateEquipmentList_CB.FormattingEnabled = true;
            this.TemplateEquipmentList_CB.Location = new System.Drawing.Point(485, 63);
            this.TemplateEquipmentList_CB.Name = "TemplateEquipmentList_CB";
            this.TemplateEquipmentList_CB.Size = new System.Drawing.Size(477, 26);
            this.TemplateEquipmentList_CB.TabIndex = 3;
            this.TemplateEquipmentList_CB.TextChanged += new System.EventHandler(this.TemplateEquipmentList_CB_TextChanged);
            this.TemplateEquipmentList_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TemplateEquipment_CB_KeyPress);
            // 
            // TaskType_CB
            // 
            this.TaskType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskType_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TaskType_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TaskType_CB.FormattingEnabled = true;
            this.TaskType_CB.Location = new System.Drawing.Point(485, 114);
            this.TaskType_CB.Name = "TaskType_CB";
            this.TaskType_CB.Size = new System.Drawing.Size(477, 26);
            this.TaskType_CB.TabIndex = 4;
            // 
            // FunctionLoc_CB
            // 
            this.FunctionLoc_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FunctionLoc_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FunctionLoc_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FunctionLoc_CB.FormattingEnabled = true;
            this.FunctionLoc_CB.Location = new System.Drawing.Point(485, 166);
            this.FunctionLoc_CB.Name = "FunctionLoc_CB";
            this.FunctionLoc_CB.Size = new System.Drawing.Size(477, 26);
            this.FunctionLoc_CB.TabIndex = 5;
            // 
            // SerialNumber_LBL
            // 
            this.SerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SerialNumber_LBL.AutoSize = true;
            this.SerialNumber_LBL.ForeColor = System.Drawing.Color.Black;
            this.SerialNumber_LBL.Location = new System.Drawing.Point(369, 16);
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
            this.TemplateEquipment_LBL.Location = new System.Drawing.Point(329, 67);
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
            this.label4.Location = new System.Drawing.Point(360, 118);
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
            this.label5.Location = new System.Drawing.Point(336, 170);
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
            this.WarrantyClaim_CHB.Size = new System.Drawing.Size(235, 22);
            this.WarrantyClaim_CHB.TabIndex = 1;
            this.WarrantyClaim_CHB.Text = "Create Warranty Claim Service Order";
            this.WarrantyClaim_CHB.UseVisualStyleBackColor = true;
            // 
            // SetupEquipment_BTN
            // 
            this.SetupEquipment_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupEquipment_BTN.BackColor = System.Drawing.Color.Gainsboro;
            this.SetupEquipment_BTN.ForeColor = System.Drawing.Color.Black;
            this.SetupEquipment_BTN.Location = new System.Drawing.Point(3, 240);
            this.SetupEquipment_BTN.Name = "SetupEquipment_BTN";
            this.SetupEquipment_BTN.Size = new System.Drawing.Size(606, 50);
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
            this.RiaseServiceOrder_BTN.Location = new System.Drawing.Point(615, 240);
            this.RiaseServiceOrder_BTN.Name = "RiaseServiceOrder_BTN";
            this.RiaseServiceOrder_BTN.Size = new System.Drawing.Size(607, 50);
            this.RiaseServiceOrder_BTN.TabIndex = 17;
            this.RiaseServiceOrder_BTN.Text = "Raise Service Order";
            this.RiaseServiceOrder_BTN.UseVisualStyleBackColor = false;
            this.RiaseServiceOrder_BTN.Click += new System.EventHandler(this.RaiseServiceOrder_BT_Click);
            // 
            // QuoteOrder_TP
            // 
            this.QuoteOrder_TP.BackColor = System.Drawing.Color.White;
            this.QuoteOrder_TP.Controls.Add(this.QuoteLayout);
            this.QuoteOrder_TP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuoteOrder_TP.ForeColor = System.Drawing.Color.Black;
            this.QuoteOrder_TP.Location = new System.Drawing.Point(4, 27);
            this.QuoteOrder_TP.Name = "QuoteOrder_TP";
            this.QuoteOrder_TP.Padding = new System.Windows.Forms.Padding(3);
            this.QuoteOrder_TP.Size = new System.Drawing.Size(1231, 658);
            this.QuoteOrder_TP.TabIndex = 4;
            this.QuoteOrder_TP.Text = "Quote Order";
            // 
            // QuoteLayout
            // 
            this.QuoteLayout.ColumnCount = 3;
            this.QuoteLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.QuoteLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.QuoteLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.QuoteLayout.Controls.Add(this.QuoteNotiListBox, 2, 0);
            this.QuoteLayout.Controls.Add(this.label23, 0, 0);
            this.QuoteLayout.Controls.Add(this.label24, 0, 1);
            this.QuoteLayout.Controls.Add(this.label25, 0, 2);
            this.QuoteLayout.Controls.Add(this.QuoteServiceOrder_TB, 1, 0);
            this.QuoteLayout.Controls.Add(this.QuoteNumberTB, 1, 1);
            this.QuoteLayout.Controls.Add(this.QuoteTemplate_CB, 1, 2);
            this.QuoteLayout.Controls.Add(this.QuoteServiceOrder_BTN, 0, 3);
            this.QuoteLayout.Controls.Add(this.LoadNotification_BTN, 2, 3);
            this.QuoteLayout.Controls.Add(this.QuoteOutput_LV, 0, 4);
            this.QuoteLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteLayout.Location = new System.Drawing.Point(3, 3);
            this.QuoteLayout.Name = "QuoteLayout";
            this.QuoteLayout.Padding = new System.Windows.Forms.Padding(1);
            this.QuoteLayout.RowCount = 5;
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.QuoteLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.QuoteLayout.Size = new System.Drawing.Size(1225, 652);
            this.QuoteLayout.TabIndex = 0;
            // 
            // QuoteNotiListBox
            // 
            this.QuoteNotiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteNotiListBox.FormattingEnabled = true;
            this.QuoteNotiListBox.ItemHeight = 20;
            this.QuoteNotiListBox.Location = new System.Drawing.Point(614, 4);
            this.QuoteNotiListBox.Name = "QuoteNotiListBox";
            this.QuoteLayout.SetRowSpan(this.QuoteNotiListBox, 3);
            this.QuoteNotiListBox.Size = new System.Drawing.Size(607, 286);
            this.QuoteNotiListBox.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(59, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(183, 20);
            this.label23.TabIndex = 2;
            this.label23.Text = "SERVICE ORDER NUMBER:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(85, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "QUOTATION NUMBER:";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(76, 233);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(166, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "QUOTATION TEMPLATE:";
            // 
            // QuoteServiceOrder_TB
            // 
            this.QuoteServiceOrder_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteServiceOrder_TB.Location = new System.Drawing.Point(248, 33);
            this.QuoteServiceOrder_TB.Name = "QuoteServiceOrder_TB";
            this.QuoteServiceOrder_TB.Size = new System.Drawing.Size(360, 27);
            this.QuoteServiceOrder_TB.TabIndex = 3;
            // 
            // QuoteNumberTB
            // 
            this.QuoteNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteNumberTB.Location = new System.Drawing.Point(248, 129);
            this.QuoteNumberTB.Name = "QuoteNumberTB";
            this.QuoteNumberTB.Size = new System.Drawing.Size(360, 27);
            this.QuoteNumberTB.TabIndex = 3;
            // 
            // QuoteTemplate_CB
            // 
            this.QuoteTemplate_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteTemplate_CB.FormattingEnabled = true;
            this.QuoteTemplate_CB.Location = new System.Drawing.Point(248, 229);
            this.QuoteTemplate_CB.Name = "QuoteTemplate_CB";
            this.QuoteTemplate_CB.Size = new System.Drawing.Size(360, 28);
            this.QuoteTemplate_CB.TabIndex = 4;
            // 
            // QuoteServiceOrder_BTN
            // 
            this.QuoteServiceOrder_BTN.BackColor = System.Drawing.Color.Transparent;
            this.QuoteLayout.SetColumnSpan(this.QuoteServiceOrder_BTN, 2);
            this.QuoteServiceOrder_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteServiceOrder_BTN.Location = new System.Drawing.Point(4, 296);
            this.QuoteServiceOrder_BTN.Name = "QuoteServiceOrder_BTN";
            this.QuoteServiceOrder_BTN.Size = new System.Drawing.Size(604, 56);
            this.QuoteServiceOrder_BTN.TabIndex = 6;
            this.QuoteServiceOrder_BTN.Text = "Quote Service Order";
            this.QuoteServiceOrder_BTN.UseVisualStyleBackColor = false;
            // 
            // LoadNotification_BTN
            // 
            this.LoadNotification_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadNotification_BTN.Location = new System.Drawing.Point(614, 296);
            this.LoadNotification_BTN.Name = "LoadNotification_BTN";
            this.LoadNotification_BTN.Size = new System.Drawing.Size(607, 56);
            this.LoadNotification_BTN.TabIndex = 7;
            this.LoadNotification_BTN.Text = "Load Notifications";
            this.LoadNotification_BTN.UseVisualStyleBackColor = true;
            // 
            // QuoteOutput_LV
            // 
            this.QuoteOutput_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuoteOutput_LV.CheckBoxes = true;
            this.QuoteOutput_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemType_CH,
            this.TxtForQuote_CH,
            this.Price,
            this.Notification});
            this.QuoteLayout.SetColumnSpan(this.QuoteOutput_LV, 3);
            this.QuoteOutput_LV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteOutput_LV.GridLines = true;
            this.QuoteOutput_LV.HideSelection = false;
            this.QuoteOutput_LV.Location = new System.Drawing.Point(4, 358);
            this.QuoteOutput_LV.Name = "QuoteOutput_LV";
            this.QuoteOutput_LV.Size = new System.Drawing.Size(1217, 290);
            this.QuoteOutput_LV.TabIndex = 8;
            this.QuoteOutput_LV.UseCompatibleStateImageBehavior = false;
            this.QuoteOutput_LV.View = System.Windows.Forms.View.Details;
            // 
            // ItemType_CH
            // 
            this.ItemType_CH.Text = "Quote Item Type";
            this.ItemType_CH.Width = 200;
            // 
            // TxtForQuote_CH
            // 
            this.TxtForQuote_CH.Text = "Text For Quote";
            this.TxtForQuote_CH.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Item Price";
            this.Price.Width = 200;
            // 
            // Notification
            // 
            this.Notification.Text = "For Notification #";
            this.Notification.Width = 200;
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
            // Output_PNL
            // 
            this.Output_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_PNL.BackColor = System.Drawing.Color.White;
            this.Output_PNL.Controls.Add(this.QOutputInfo_GRB);
            this.Output_PNL.ForeColor = System.Drawing.Color.Black;
            this.Output_PNL.Location = new System.Drawing.Point(20, 803);
            this.Output_PNL.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Output_PNL.Name = "Output_PNL";
            this.Output_PNL.Size = new System.Drawing.Size(1239, 231);
            this.Output_PNL.TabIndex = 10;
            // 
            // QOutputInfo_GRB
            // 
            this.QOutputInfo_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QOutputInfo_GRB.Controls.Add(this.QuoteOutput_PNL);
            this.QOutputInfo_GRB.Controls.Add(this.OutputOrder_PNL);
            this.QOutputInfo_GRB.Location = new System.Drawing.Point(7, 5);
            this.QOutputInfo_GRB.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.QOutputInfo_GRB.Name = "QOutputInfo_GRB";
            this.QOutputInfo_GRB.Size = new System.Drawing.Size(1224, 218);
            this.QOutputInfo_GRB.TabIndex = 1;
            this.QOutputInfo_GRB.TabStop = false;
            this.QOutputInfo_GRB.Text = "Output Information";
            // 
            // QuoteOutput_PNL
            // 
            this.QuoteOutput_PNL.ColumnCount = 4;
            this.QuoteOutput_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76341F));
            this.QuoteOutput_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23659F));
            this.QuoteOutput_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44795F));
            this.QuoteOutput_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55205F));
            this.QuoteOutput_PNL.Controls.Add(this.QServiceOrder_TB, 1, 0);
            this.QuoteOutput_PNL.Controls.Add(this.QPurchaseOrder_LBL, 0, 2);
            this.QuoteOutput_PNL.Controls.Add(this.QNumOfVars_LBL, 0, 3);
            this.QuoteOutput_PNL.Controls.Add(this.QMaterialPrice_LBL, 2, 0);
            this.QuoteOutput_PNL.Controls.Add(this.QOverhaulPrice_LBL, 2, 1);
            this.QuoteOutput_PNL.Controls.Add(this.QVariationPrice_LBL, 2, 2);
            this.QuoteOutput_PNL.Controls.Add(this.QTotalPrice_LBL, 2, 3);
            this.QuoteOutput_PNL.Controls.Add(this.QEquipmentNum_TB, 1, 1);
            this.QuoteOutput_PNL.Controls.Add(this.QPurchaseOrder_TB, 1, 2);
            this.QuoteOutput_PNL.Controls.Add(this.QNumOfVars_TB, 1, 3);
            this.QuoteOutput_PNL.Controls.Add(this.QMaterialPrice_TB, 3, 0);
            this.QuoteOutput_PNL.Controls.Add(this.QStandardPrice_TB, 3, 1);
            this.QuoteOutput_PNL.Controls.Add(this.QVarLabourPrice_TB, 3, 2);
            this.QuoteOutput_PNL.Controls.Add(this.QTotalPrice_TB, 3, 3);
            this.QuoteOutput_PNL.Controls.Add(this.QEqNum_LBL, 0, 1);
            this.QuoteOutput_PNL.Controls.Add(this.QServOrderDesc_LBL, 0, 0);
            this.QuoteOutput_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteOutput_PNL.Location = new System.Drawing.Point(3, 21);
            this.QuoteOutput_PNL.Name = "QuoteOutput_PNL";
            this.QuoteOutput_PNL.RowCount = 4;
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.Size = new System.Drawing.Size(1218, 194);
            this.QuoteOutput_PNL.TabIndex = 1;
            this.QuoteOutput_PNL.Visible = false;
            // 
            // QServiceOrder_TB
            // 
            this.QServiceOrder_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QServiceOrder_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QServiceOrder_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QServiceOrder_TB.Location = new System.Drawing.Point(304, 10);
            this.QServiceOrder_TB.Name = "QServiceOrder_TB";
            this.QServiceOrder_TB.ReadOnly = true;
            this.QServiceOrder_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QServiceOrder_TB.Size = new System.Drawing.Size(300, 28);
            this.QServiceOrder_TB.TabIndex = 1;
            this.QServiceOrder_TB.TabStop = false;
            this.QServiceOrder_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QPurchaseOrder_LBL
            // 
            this.QPurchaseOrder_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QPurchaseOrder_LBL.AutoSize = true;
            this.QPurchaseOrder_LBL.ForeColor = System.Drawing.Color.Black;
            this.QPurchaseOrder_LBL.Location = new System.Drawing.Point(178, 111);
            this.QPurchaseOrder_LBL.Name = "QPurchaseOrder_LBL";
            this.QPurchaseOrder_LBL.Size = new System.Drawing.Size(120, 17);
            this.QPurchaseOrder_LBL.TabIndex = 3;
            this.QPurchaseOrder_LBL.Text = "PURCHASE ORDER:";
            // 
            // QNumOfVars_LBL
            // 
            this.QNumOfVars_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QNumOfVars_LBL.AutoSize = true;
            this.QNumOfVars_LBL.ForeColor = System.Drawing.Color.Black;
            this.QNumOfVars_LBL.Location = new System.Drawing.Point(140, 160);
            this.QNumOfVars_LBL.Name = "QNumOfVars_LBL";
            this.QNumOfVars_LBL.Size = new System.Drawing.Size(158, 17);
            this.QNumOfVars_LBL.TabIndex = 3;
            this.QNumOfVars_LBL.Text = "NUMBER OF VARIATIONS:";
            // 
            // QMaterialPrice_LBL
            // 
            this.QMaterialPrice_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QMaterialPrice_LBL.AutoSize = true;
            this.QMaterialPrice_LBL.ForeColor = System.Drawing.Color.Black;
            this.QMaterialPrice_LBL.Location = new System.Drawing.Point(796, 15);
            this.QMaterialPrice_LBL.Name = "QMaterialPrice_LBL";
            this.QMaterialPrice_LBL.Size = new System.Drawing.Size(106, 17);
            this.QMaterialPrice_LBL.TabIndex = 3;
            this.QMaterialPrice_LBL.Text = "MATERIAL PRICE:";
            // 
            // QOverhaulPrice_LBL
            // 
            this.QOverhaulPrice_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QOverhaulPrice_LBL.AutoSize = true;
            this.QOverhaulPrice_LBL.ForeColor = System.Drawing.Color.Black;
            this.QOverhaulPrice_LBL.Location = new System.Drawing.Point(720, 63);
            this.QOverhaulPrice_LBL.Name = "QOverhaulPrice_LBL";
            this.QOverhaulPrice_LBL.Size = new System.Drawing.Size(182, 17);
            this.QOverhaulPrice_LBL.TabIndex = 3;
            this.QOverhaulPrice_LBL.Text = "STANDARD OVERHAUL PRICE:";
            // 
            // QVariationPrice_LBL
            // 
            this.QVariationPrice_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QVariationPrice_LBL.AutoSize = true;
            this.QVariationPrice_LBL.ForeColor = System.Drawing.Color.Black;
            this.QVariationPrice_LBL.Location = new System.Drawing.Point(739, 111);
            this.QVariationPrice_LBL.Name = "QVariationPrice_LBL";
            this.QVariationPrice_LBL.Size = new System.Drawing.Size(163, 17);
            this.QVariationPrice_LBL.TabIndex = 3;
            this.QVariationPrice_LBL.Text = "VARIATION LABOUR PRICE:";
            // 
            // QTotalPrice_LBL
            // 
            this.QTotalPrice_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QTotalPrice_LBL.AutoSize = true;
            this.QTotalPrice_LBL.ForeColor = System.Drawing.Color.Black;
            this.QTotalPrice_LBL.Location = new System.Drawing.Point(819, 160);
            this.QTotalPrice_LBL.Name = "QTotalPrice_LBL";
            this.QTotalPrice_LBL.Size = new System.Drawing.Size(83, 17);
            this.QTotalPrice_LBL.TabIndex = 3;
            this.QTotalPrice_LBL.Text = "TOTAL PRICE:";
            // 
            // QEquipmentNum_TB
            // 
            this.QEquipmentNum_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QEquipmentNum_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QEquipmentNum_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QEquipmentNum_TB.Location = new System.Drawing.Point(304, 58);
            this.QEquipmentNum_TB.Name = "QEquipmentNum_TB";
            this.QEquipmentNum_TB.ReadOnly = true;
            this.QEquipmentNum_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QEquipmentNum_TB.Size = new System.Drawing.Size(300, 28);
            this.QEquipmentNum_TB.TabIndex = 1;
            this.QEquipmentNum_TB.TabStop = false;
            this.QEquipmentNum_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QPurchaseOrder_TB
            // 
            this.QPurchaseOrder_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QPurchaseOrder_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QPurchaseOrder_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QPurchaseOrder_TB.Location = new System.Drawing.Point(304, 106);
            this.QPurchaseOrder_TB.Name = "QPurchaseOrder_TB";
            this.QPurchaseOrder_TB.ReadOnly = true;
            this.QPurchaseOrder_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QPurchaseOrder_TB.Size = new System.Drawing.Size(300, 28);
            this.QPurchaseOrder_TB.TabIndex = 1;
            this.QPurchaseOrder_TB.TabStop = false;
            this.QPurchaseOrder_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QNumOfVars_TB
            // 
            this.QNumOfVars_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QNumOfVars_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QNumOfVars_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QNumOfVars_TB.Location = new System.Drawing.Point(304, 155);
            this.QNumOfVars_TB.Name = "QNumOfVars_TB";
            this.QNumOfVars_TB.ReadOnly = true;
            this.QNumOfVars_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QNumOfVars_TB.Size = new System.Drawing.Size(300, 28);
            this.QNumOfVars_TB.TabIndex = 1;
            this.QNumOfVars_TB.TabStop = false;
            this.QNumOfVars_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QMaterialPrice_TB
            // 
            this.QMaterialPrice_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QMaterialPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QMaterialPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QMaterialPrice_TB.Location = new System.Drawing.Point(908, 10);
            this.QMaterialPrice_TB.Name = "QMaterialPrice_TB";
            this.QMaterialPrice_TB.ReadOnly = true;
            this.QMaterialPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QMaterialPrice_TB.Size = new System.Drawing.Size(305, 28);
            this.QMaterialPrice_TB.TabIndex = 1;
            this.QMaterialPrice_TB.TabStop = false;
            this.QMaterialPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QStandardPrice_TB
            // 
            this.QStandardPrice_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QStandardPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QStandardPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QStandardPrice_TB.Location = new System.Drawing.Point(908, 58);
            this.QStandardPrice_TB.Name = "QStandardPrice_TB";
            this.QStandardPrice_TB.ReadOnly = true;
            this.QStandardPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QStandardPrice_TB.Size = new System.Drawing.Size(305, 28);
            this.QStandardPrice_TB.TabIndex = 1;
            this.QStandardPrice_TB.TabStop = false;
            this.QStandardPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QVarLabourPrice_TB
            // 
            this.QVarLabourPrice_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QVarLabourPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QVarLabourPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QVarLabourPrice_TB.Location = new System.Drawing.Point(908, 106);
            this.QVarLabourPrice_TB.Name = "QVarLabourPrice_TB";
            this.QVarLabourPrice_TB.ReadOnly = true;
            this.QVarLabourPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QVarLabourPrice_TB.Size = new System.Drawing.Size(305, 28);
            this.QVarLabourPrice_TB.TabIndex = 1;
            this.QVarLabourPrice_TB.TabStop = false;
            this.QVarLabourPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QTotalPrice_TB
            // 
            this.QTotalPrice_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QTotalPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QTotalPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QTotalPrice_TB.Location = new System.Drawing.Point(908, 155);
            this.QTotalPrice_TB.Name = "QTotalPrice_TB";
            this.QTotalPrice_TB.ReadOnly = true;
            this.QTotalPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QTotalPrice_TB.Size = new System.Drawing.Size(305, 28);
            this.QTotalPrice_TB.TabIndex = 1;
            this.QTotalPrice_TB.TabStop = false;
            this.QTotalPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QEqNum_LBL
            // 
            this.QEqNum_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QEqNum_LBL.AutoSize = true;
            this.QEqNum_LBL.ForeColor = System.Drawing.Color.Black;
            this.QEqNum_LBL.Location = new System.Drawing.Point(158, 63);
            this.QEqNum_LBL.Name = "QEqNum_LBL";
            this.QEqNum_LBL.Size = new System.Drawing.Size(140, 17);
            this.QEqNum_LBL.TabIndex = 3;
            this.QEqNum_LBL.Text = "EQUIPMENT NUMBER:";
            // 
            // QServOrderDesc_LBL
            // 
            this.QServOrderDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QServOrderDesc_LBL.AutoSize = true;
            this.QServOrderDesc_LBL.ForeColor = System.Drawing.Color.Black;
            this.QServOrderDesc_LBL.Location = new System.Drawing.Point(110, 15);
            this.QServOrderDesc_LBL.Name = "QServOrderDesc_LBL";
            this.QServOrderDesc_LBL.Size = new System.Drawing.Size(188, 17);
            this.QServOrderDesc_LBL.TabIndex = 3;
            this.QServOrderDesc_LBL.Text = "SERVICE ORDER DESCRIPTION:";
            // 
            // OutputOrder_PNL
            // 
            this.OutputOrder_PNL.ColumnCount = 4;
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76341F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23659F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44795F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55205F));
            this.OutputOrder_PNL.Controls.Add(this.EquipmentOutput_TB, 1, 0);
            this.OutputOrder_PNL.Controls.Add(this.label10, 0, 2);
            this.OutputOrder_PNL.Controls.Add(this.label11, 0, 3);
            this.OutputOrder_PNL.Controls.Add(this.label12, 2, 0);
            this.OutputOrder_PNL.Controls.Add(this.label13, 2, 1);
            this.OutputOrder_PNL.Controls.Add(this.label14, 2, 2);
            this.OutputOrder_PNL.Controls.Add(this.label15, 2, 3);
            this.OutputOrder_PNL.Controls.Add(this.DescriptionOutput_TB, 1, 1);
            this.OutputOrder_PNL.Controls.Add(this.SetupModOutput_TB, 1, 2);
            this.OutputOrder_PNL.Controls.Add(this.CELNumberOutput_TB, 1, 3);
            this.OutputOrder_PNL.Controls.Add(this.WorkCenterOutput_TB, 3, 0);
            this.OutputOrder_PNL.Controls.Add(this.WBSOutput_TB, 3, 1);
            this.OutputOrder_PNL.Controls.Add(this.NotificationOutput_TB, 3, 2);
            this.OutputOrder_PNL.Controls.Add(this.SOOutput_TB, 3, 3);
            this.OutputOrder_PNL.Controls.Add(this.label8, 0, 1);
            this.OutputOrder_PNL.Controls.Add(this.EqDesc_LBL, 0, 0);
            this.OutputOrder_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputOrder_PNL.Location = new System.Drawing.Point(3, 21);
            this.OutputOrder_PNL.Name = "OutputOrder_PNL";
            this.OutputOrder_PNL.RowCount = 4;
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.Size = new System.Drawing.Size(1218, 194);
            this.OutputOrder_PNL.TabIndex = 0;
            // 
            // EquipmentOutput_TB
            // 
            this.EquipmentOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EquipmentOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.EquipmentOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EquipmentOutput_TB.Location = new System.Drawing.Point(304, 10);
            this.EquipmentOutput_TB.Name = "EquipmentOutput_TB";
            this.EquipmentOutput_TB.ReadOnly = true;
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
            this.label10.Location = new System.Drawing.Point(193, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "SETUP MODULE:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(164, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "ENTRY LIST NUMBER:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(802, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "WORK CENTER:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(805, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "WBS ELEMENT:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(751, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "NOTIFICATION NUMBER:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(740, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "SERVICE ORDER NUMBER:";
            // 
            // DescriptionOutput_TB
            // 
            this.DescriptionOutput_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptionOutput_TB.BackColor = System.Drawing.SystemColors.Info;
            this.DescriptionOutput_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionOutput_TB.Location = new System.Drawing.Point(304, 58);
            this.DescriptionOutput_TB.Name = "DescriptionOutput_TB";
            this.DescriptionOutput_TB.ReadOnly = true;
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
            this.SetupModOutput_TB.Location = new System.Drawing.Point(304, 106);
            this.SetupModOutput_TB.Name = "SetupModOutput_TB";
            this.SetupModOutput_TB.ReadOnly = true;
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
            this.CELNumberOutput_TB.Location = new System.Drawing.Point(304, 155);
            this.CELNumberOutput_TB.Name = "CELNumberOutput_TB";
            this.CELNumberOutput_TB.ReadOnly = true;
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
            this.WorkCenterOutput_TB.Location = new System.Drawing.Point(908, 10);
            this.WorkCenterOutput_TB.Name = "WorkCenterOutput_TB";
            this.WorkCenterOutput_TB.ReadOnly = true;
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
            this.WBSOutput_TB.Location = new System.Drawing.Point(908, 58);
            this.WBSOutput_TB.Name = "WBSOutput_TB";
            this.WBSOutput_TB.ReadOnly = true;
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
            this.NotificationOutput_TB.Location = new System.Drawing.Point(908, 106);
            this.NotificationOutput_TB.Name = "NotificationOutput_TB";
            this.NotificationOutput_TB.ReadOnly = true;
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
            this.SOOutput_TB.Location = new System.Drawing.Point(908, 155);
            this.SOOutput_TB.Name = "SOOutput_TB";
            this.SOOutput_TB.ReadOnly = true;
            this.SOOutput_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SOOutput_TB.Size = new System.Drawing.Size(305, 28);
            this.SOOutput_TB.TabIndex = 1;
            this.SOOutput_TB.TabStop = false;
            this.SOOutput_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(158, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "EQUIPMENT NUMBER:";
            // 
            // EqDesc_LBL
            // 
            this.EqDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EqDesc_LBL.AutoSize = true;
            this.EqDesc_LBL.ForeColor = System.Drawing.Color.Black;
            this.EqDesc_LBL.Location = new System.Drawing.Point(132, 15);
            this.EqDesc_LBL.Name = "EqDesc_LBL";
            this.EqDesc_LBL.Size = new System.Drawing.Size(166, 17);
            this.EqDesc_LBL.TabIndex = 3;
            this.EqDesc_LBL.Text = "EQUIPMENT DESCRIPTION:";
            // 
            // MainFormLayout_PNL
            // 
            this.MainFormLayout_PNL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormLayout_PNL.BackColor = System.Drawing.Color.Transparent;
            this.MainFormLayout_PNL.ColumnCount = 1;
            this.MainFormLayout_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormLayout_PNL.Controls.Add(this.Output_PNL, 0, 2);
            this.MainFormLayout_PNL.Controls.Add(this.DataTabs_TC, 0, 1);
            this.MainFormLayout_PNL.Controls.Add(this.MainUGLLogo_PB, 0, 0);
            this.MainFormLayout_PNL.Location = new System.Drawing.Point(0, 68);
            this.MainFormLayout_PNL.Margin = new System.Windows.Forms.Padding(1, 30, 30, 1);
            this.MainFormLayout_PNL.Name = "MainFormLayout_PNL";
            this.MainFormLayout_PNL.RowCount = 3;
            this.MainFormLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.59269F));
            this.MainFormLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.40731F));
            this.MainFormLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainFormLayout_PNL.Size = new System.Drawing.Size(1279, 1044);
            this.MainFormLayout_PNL.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1280, 1146);
            this.Controls.Add(this.MainFormLayout_PNL);
            this.Controls.Add(this.MainStatus_SB);
            this.Controls.Add(this.TitleBar_PNL);
            this.Controls.Add(this.MainMenu);
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
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Mobility Setup Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitleBar_PNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UGLLogo_PB)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainStatus_SB.ResumeLayout(false);
            this.MainStatus_SB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUGLLogo_PB)).EndInit();
            this.RaiseVariation_TP.ResumeLayout(false);
            this.VarInfoLayout_PNL.ResumeLayout(false);
            this.VarInfo_GB.ResumeLayout(false);
            this.RightSide_TBL.ResumeLayout(false);
            this.RightSide_TBL.PerformLayout();
            this.VarOrderInfo_LBL.ResumeLayout(false);
            this.VariationTable_TPN.ResumeLayout(false);
            this.VariationTable_TPN.PerformLayout();
            this.EqInfo_GRB.ResumeLayout(false);
            this.EqInfo_TBL.ResumeLayout(false);
            this.EqInfo_TBL.PerformLayout();
            this.DataTabs_TC.ResumeLayout(false);
            this.InitialSetup_TP.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.NotificationInput_GRB.ResumeLayout(false);
            this.NotificationLayout.ResumeLayout(false);
            this.NotificationLayout.PerformLayout();
            this.ServOrderInput_GRB.ResumeLayout(false);
            this.ServiceOrderInfo_LYT.ResumeLayout(false);
            this.ServiceOrderInfo_LYT.PerformLayout();
            this.EquipmentInfo_GB.ResumeLayout(false);
            this.EquipmentInfo_Layout.ResumeLayout(false);
            this.EquipmentInfo_Layout.PerformLayout();
            this.QuoteOrder_TP.ResumeLayout(false);
            this.QuoteLayout.ResumeLayout(false);
            this.QuoteLayout.PerformLayout();
            this.OutputInfo_TPL.ResumeLayout(false);
            this.OutputInfo_TPL.PerformLayout();
            this.Output_PNL.ResumeLayout(false);
            this.QOutputInfo_GRB.ResumeLayout(false);
            this.QuoteOutput_PNL.ResumeLayout(false);
            this.QuoteOutput_PNL.PerformLayout();
            this.OutputOrder_PNL.ResumeLayout(false);
            this.OutputOrder_PNL.PerformLayout();
            this.MainFormLayout_PNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title_LBL;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem File_MN;
        private System.Windows.Forms.ToolStripMenuItem Exit_MN;
        private System.Windows.Forms.PictureBox UGLLogo_PB;
        private System.Windows.Forms.ToolStripMenuItem AppSettings_MN;
        private System.Windows.Forms.ToolStripSeparator FileMenu_SPR;
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
        private System.Windows.Forms.Label VPlannedFinDate_LBL;
        private System.Windows.Forms.Label VarSOStartDate_LBL;
        private System.Windows.Forms.Label VarExternalReference_LBL;
        private System.Windows.Forms.Label VarSOPriority_LBL;
        private System.Windows.Forms.Label VarPMActivityType_LBL;
        private System.Windows.Forms.GroupBox VarInfo_GB;
        private System.Windows.Forms.RichTextBox LongText_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LongText_LBL;
        private System.Windows.Forms.ListBox Variations_LB;
        private System.Windows.Forms.TabControl DataTabs_TC;
        private System.Windows.Forms.ToolStripMenuItem ResyncData_MNI;
        public System.Windows.Forms.ToolTip General_TT;
        private System.Windows.Forms.TabPage InitialSetup_TP;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.GroupBox NotificationInput_GRB;
        private System.Windows.Forms.GroupBox ServOrderInput_GRB;
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
        private System.Windows.Forms.TableLayoutPanel NotificationLayout;
        private System.Windows.Forms.Label SoldToParty_LBL;
        public System.Windows.Forms.TextBox PurchaseOrder_TB;
        private System.Windows.Forms.Label PurchaseOrder_LBL;
        public System.Windows.Forms.DateTimePicker RequiredStartDate_DP;
        public System.Windows.Forms.DateTimePicker RequiredEndDate_DP;
        public System.Windows.Forms.DateTimePicker PurchaseOrderDate_DP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel ServiceOrderInfo_LYT;
        private System.Windows.Forms.Label ActivityType_LBL;
        private System.Windows.Forms.Label BasicStartDate_LBL;
        private System.Windows.Forms.Label BasicEndDate_LBL;
        private System.Windows.Forms.Label Priority_LBL;
        private System.Windows.Forms.Label ExternalRef_LBL;
        private System.Windows.Forms.CheckBox WarrantyClaim_CHB;
        public System.Windows.Forms.TextBox ExternalReference_TB;
        public System.Windows.Forms.DateTimePicker BasicStartDate_DP;
        public System.Windows.Forms.DateTimePicker BasicEndDate_DP;
        private System.Windows.Forms.TableLayoutPanel VarInfoLayout_PNL;
        private System.Windows.Forms.TableLayoutPanel RightSide_TBL;
        private System.Windows.Forms.Button VarCheckEntryList_BTN;
        private System.Windows.Forms.Button VarRaiseServiceOrder_BTN;
        private System.Windows.Forms.Button LoadVariation_BTN;
        private System.Windows.Forms.GroupBox EqInfo_GRB;
        private System.Windows.Forms.TableLayoutPanel EqInfo_TBL;
        private System.Windows.Forms.Panel Output_PNL;
        private System.Windows.Forms.GroupBox QOutputInfo_GRB;
        private System.Windows.Forms.TableLayoutPanel OutputOrder_PNL;
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
        private System.Windows.Forms.TableLayoutPanel MainFormLayout_PNL;
        public System.Windows.Forms.TextBox VarExternalReference_TB;
        public System.Windows.Forms.TabPage QuoteOrder_TP;
        private System.Windows.Forms.TableLayoutPanel QuoteOutput_PNL;
        public System.Windows.Forms.TextBox QServiceOrder_TB;
        private System.Windows.Forms.Label QPurchaseOrder_LBL;
        private System.Windows.Forms.Label QNumOfVars_LBL;
        private System.Windows.Forms.Label QMaterialPrice_LBL;
        private System.Windows.Forms.Label QOverhaulPrice_LBL;
        private System.Windows.Forms.Label QVariationPrice_LBL;
        private System.Windows.Forms.Label QTotalPrice_LBL;
        public System.Windows.Forms.TextBox QEquipmentNum_TB;
        public System.Windows.Forms.TextBox QPurchaseOrder_TB;
        public System.Windows.Forms.TextBox QNumOfVars_TB;
        public System.Windows.Forms.TextBox QMaterialPrice_TB;
        public System.Windows.Forms.TextBox QStandardPrice_TB;
        public System.Windows.Forms.TextBox QVarLabourPrice_TB;
        public System.Windows.Forms.TextBox QTotalPrice_TB;
        private System.Windows.Forms.Label QEqNum_LBL;
        private System.Windows.Forms.Label QServOrderDesc_LBL;
        private System.Windows.Forms.TableLayoutPanel QuoteLayout;
        public System.Windows.Forms.ListBox QuoteNotiListBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox QuoteServiceOrder_TB;
        private System.Windows.Forms.TextBox QuoteNumberTB;
        private System.Windows.Forms.Button QuoteServiceOrder_BTN;
        private System.Windows.Forms.Button LoadNotification_BTN;
        private System.Windows.Forms.ListView QuoteOutput_LV;
        private System.Windows.Forms.ColumnHeader ItemType_CH;
        private System.Windows.Forms.ColumnHeader TxtForQuote_CH;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Notification;
        public System.Windows.Forms.ToolStripMenuItem View_MN;
        public System.Windows.Forms.ToolStripMenuItem QOutputWindow_MN;
        public RComboBox VarTemplate_CB;
        public RComboBox VarTaskType_CB;
        public RComboBox VarSOPriority_CB;
        public RComboBox VarPMActivityType_CB;
        public RComboBox TemplateEquipmentList_CB;
        public RComboBox FunctionLoc_CB;
        public RComboBox TaskType_CB;
        public RComboBox PartyName_CB;
        public RComboBox PMActivityType_CB;
        public RComboBox Priority_CB;
        private RComboBox QuoteTemplate_CB;
    }
}

