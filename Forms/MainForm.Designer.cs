
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
            this.Dev_MN = new System.Windows.Forms.ToolStripMenuItem();
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
            this.VNotDesc_LBL = new System.Windows.Forms.Label();
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
            this.VarSOPriority_CB = new Mobility_Setup_Tool.ExComboBox();
            this.VarSOPriority_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_LBL = new System.Windows.Forms.Label();
            this.VarPMActivityType_CB = new Mobility_Setup_Tool.ExComboBox();
            this.VarExternalReference_TB = new System.Windows.Forms.TextBox();
            this.VarCheckEntryList_BTN = new System.Windows.Forms.Button();
            this.VarRaiseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.EqInfo_GRB = new System.Windows.Forms.GroupBox();
            this.EqInfo_TBL = new System.Windows.Forms.TableLayoutPanel();
            this.VarTaskType_CB = new Mobility_Setup_Tool.ExComboBox();
            this.VarSerialNumber_LBL = new System.Windows.Forms.Label();
            this.VarTaskType_LBL = new System.Windows.Forms.Label();
            this.VarTemplate_LBL = new System.Windows.Forms.Label();
            this.VarTemplate_CB = new Mobility_Setup_Tool.ExComboBox();
            this.VarSerialNumber_TB = new System.Windows.Forms.TextBox();
            this.DataTabs_TC = new System.Windows.Forms.TabControl();
            this.InitialSetup_TP = new System.Windows.Forms.TabPage();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NotificationInput_GRB = new System.Windows.Forms.GroupBox();
            this.NotificationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SoldToParty_LBL = new System.Windows.Forms.Label();
            this.PartyName_CB = new Mobility_Setup_Tool.ExComboBox();
            this.PurchaseOrder_TB = new System.Windows.Forms.TextBox();
            this.PurchaseOrder_LBL = new System.Windows.Forms.Label();
            this.PurchaseOrderDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.RequiredEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.PurchOrderDate_LBL = new System.Windows.Forms.Label();
            this.ReqStartDate_LBL = new System.Windows.Forms.Label();
            this.ReqEndDate_LBL = new System.Windows.Forms.Label();
            this.ServOrderInput_GRB = new System.Windows.Forms.GroupBox();
            this.ServiceOrderInfo_LYT = new System.Windows.Forms.TableLayoutPanel();
            this.ActivityType_LBL = new System.Windows.Forms.Label();
            this.PMActivityType_CB = new Mobility_Setup_Tool.ExComboBox();
            this.ExternalReference_TB = new System.Windows.Forms.TextBox();
            this.BasicStartDate_LBL = new System.Windows.Forms.Label();
            this.BasicStartDate_DP = new System.Windows.Forms.DateTimePicker();
            this.BasicEndDate_LBL = new System.Windows.Forms.Label();
            this.Priority_LBL = new System.Windows.Forms.Label();
            this.ExternalRef_LBL = new System.Windows.Forms.Label();
            this.Priority_CB = new Mobility_Setup_Tool.ExComboBox();
            this.BasicEndDate_DP = new System.Windows.Forms.DateTimePicker();
            this.EquipmentInfo_GB = new System.Windows.Forms.GroupBox();
            this.EquipmentInfo_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentSerial_TB = new System.Windows.Forms.TextBox();
            this.TemplateEquipmentList_CB = new Mobility_Setup_Tool.ExComboBox();
            this.TaskType_CB = new Mobility_Setup_Tool.ExComboBox();
            this.FunctionLoc_CB = new Mobility_Setup_Tool.ExComboBox();
            this.SerialNumber_LBL = new System.Windows.Forms.Label();
            this.TemplateEquipment_LBL = new System.Windows.Forms.Label();
            this.TaskType_LBL = new System.Windows.Forms.Label();
            this.FuncLoc_LBL = new System.Windows.Forms.Label();
            this.WarrantyClaim_CHB = new System.Windows.Forms.CheckBox();
            this.SetupEquipment_BTN = new System.Windows.Forms.Button();
            this.RiaseServiceOrder_BTN = new System.Windows.Forms.Button();
            this.QuoteOrder_TP = new System.Windows.Forms.TabPage();
            this.QuoteLayout = new System.Windows.Forms.TableLayoutPanel();
            this.QuoteNotiListBox = new System.Windows.Forms.ListBox();
            this.QServOrderNum_LBL = new System.Windows.Forms.Label();
            this.QQuoteNumber_LBL = new System.Windows.Forms.Label();
            this.QQuoteTemplate_LBL = new System.Windows.Forms.Label();
            this.QuoteServiceOrder_TB = new System.Windows.Forms.TextBox();
            this.QuoteNumberTB = new System.Windows.Forms.TextBox();
            this.QuoteTemplate_CB = new Mobility_Setup_Tool.ExComboBox();
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
            this.OutputOrder_PNL = new System.Windows.Forms.TableLayoutPanel();
            this.OutputEqDesc_TB = new System.Windows.Forms.TextBox();
            this.OutputSetupModule_LBL = new System.Windows.Forms.Label();
            this.OutputEntryList_LBL = new System.Windows.Forms.Label();
            this.OutputWorkCentre_LBL = new System.Windows.Forms.Label();
            this.OutputWSB_LBL = new System.Windows.Forms.Label();
            this.OutputNotNumber_LBL = new System.Windows.Forms.Label();
            this.OutputServOrd_LBL = new System.Windows.Forms.Label();
            this.OutputEqNum_TB = new System.Windows.Forms.TextBox();
            this.OutputSetupModule_TB = new System.Windows.Forms.TextBox();
            this.OutputEntryList_TB = new System.Windows.Forms.TextBox();
            this.OutputWorkCentre_TB = new System.Windows.Forms.TextBox();
            this.OutputWBS_TB = new System.Windows.Forms.TextBox();
            this.OutputNotification_TB = new System.Windows.Forms.TextBox();
            this.OutputServOrd_TB = new System.Windows.Forms.TextBox();
            this.OEqNum_LBL = new System.Windows.Forms.Label();
            this.OutputEqDesc_LBL = new System.Windows.Forms.Label();
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
            this.QServOrderDesc_LBL = new System.Windows.Forms.Label();
            this.QEqNum_LBL = new System.Windows.Forms.Label();
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
            this.OutputOrder_PNL.SuspendLayout();
            this.QuoteOutput_PNL.SuspendLayout();
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
            this.TitleBar_PNL.Size = new System.Drawing.Size(1156, 37);
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
            this.MinimizeButton_LBL.Location = new System.Drawing.Point(1051, 0);
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
            this.MaximizeButton_LBL.Location = new System.Drawing.Point(1086, 0);
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
            this.CloseButton_LBL.Location = new System.Drawing.Point(1121, 0);
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
            this.Title_LBL.Size = new System.Drawing.Size(582, 37);
            this.Title_LBL.TabIndex = 5;
            this.Title_LBL.Text = "Mobility Setup and Planning Tool";
            this.Title_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title_LBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.Title_LBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.Title_LBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
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
            this.Help_MN,
            this.Dev_MN});
            this.MainMenu.Location = new System.Drawing.Point(1, 37);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1156, 28);
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
            // Dev_MN
            // 
            this.Dev_MN.ForeColor = System.Drawing.Color.Black;
            this.Dev_MN.Name = "Dev_MN";
            this.Dev_MN.Size = new System.Drawing.Size(82, 24);
            this.Dev_MN.Text = "Developer";
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
            this.MainStatus_SB.Location = new System.Drawing.Point(1, 958);
            this.MainStatus_SB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 7);
            this.MainStatus_SB.Name = "MainStatus_SB";
            this.MainStatus_SB.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.MainStatus_SB.Size = new System.Drawing.Size(1156, 25);
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
            this.StatusInfo_LBL.Size = new System.Drawing.Size(1028, 19);
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
            this.MainUGLLogo_PB.Location = new System.Drawing.Point(872, 5);
            this.MainUGLLogo_PB.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.MainUGLLogo_PB.Name = "MainUGLLogo_PB";
            this.MainUGLLogo_PB.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.MainUGLLogo_PB.Size = new System.Drawing.Size(255, 61);
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
            this.CheckSAP_TM.Interval = 1000;
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
            this.RaiseVariation_TP.Size = new System.Drawing.Size(1109, 539);
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
            this.VarInfoLayout_PNL.Size = new System.Drawing.Size(1101, 529);
            this.VarInfoLayout_PNL.TabIndex = 10;
            // 
            // VarInfo_GB
            // 
            this.VarInfo_GB.Controls.Add(this.RightSide_TBL);
            this.VarInfo_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarInfo_GB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarInfo_GB.Location = new System.Drawing.Point(553, 3);
            this.VarInfo_GB.Name = "VarInfo_GB";
            this.VarInfoLayout_PNL.SetRowSpan(this.VarInfo_GB, 2);
            this.VarInfo_GB.Size = new System.Drawing.Size(545, 491);
            this.VarInfo_GB.TabIndex = 0;
            this.VarInfo_GB.TabStop = false;
            this.VarInfo_GB.Text = "Variation Information";
            // 
            // RightSide_TBL
            // 
            this.RightSide_TBL.ColumnCount = 1;
            this.RightSide_TBL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightSide_TBL.Controls.Add(this.LongText_TB, 0, 3);
            this.RightSide_TBL.Controls.Add(this.VNotDesc_LBL, 0, 0);
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
            this.RightSide_TBL.Size = new System.Drawing.Size(539, 466);
            this.RightSide_TBL.TabIndex = 11;
            this.RightSide_TBL.Paint += new System.Windows.Forms.PaintEventHandler(this.RightSide_TBL_Paint);
            // 
            // LongText_TB
            // 
            this.LongText_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LongText_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LongText_TB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_TB.Location = new System.Drawing.Point(3, 310);
            this.LongText_TB.Name = "LongText_TB";
            this.LongText_TB.Size = new System.Drawing.Size(533, 259);
            this.LongText_TB.TabIndex = 11;
            this.LongText_TB.Text = "";
            // 
            // VNotDesc_LBL
            // 
            this.VNotDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VNotDesc_LBL.AutoSize = true;
            this.VNotDesc_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VNotDesc_LBL.Location = new System.Drawing.Point(178, 0);
            this.VNotDesc_LBL.Name = "VNotDesc_LBL";
            this.VNotDesc_LBL.Size = new System.Drawing.Size(182, 18);
            this.VNotDesc_LBL.TabIndex = 3;
            this.VNotDesc_LBL.Text = "NOTIFICATION DESCRIPTION";
            // 
            // LongText_LBL
            // 
            this.LongText_LBL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LongText_LBL.AutoSize = true;
            this.LongText_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongText_LBL.Location = new System.Drawing.Point(186, 289);
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
            this.LoadVariation_BTN.Size = new System.Drawing.Size(533, 39);
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
            this.Variations_LB.Size = new System.Drawing.Size(533, 220);
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
            this.VarOrderInfo_LBL.Size = new System.Drawing.Size(544, 254);
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
            this.VariationTable_TPN.Size = new System.Drawing.Size(538, 229);
            this.VariationTable_TPN.TabIndex = 0;
            // 
            // VarSOEndDate_DP
            // 
            this.VarSOEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOEndDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.VarSOEndDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VarSOEndDate_DP.Location = new System.Drawing.Point(205, 99);
            this.VarSOEndDate_DP.Name = "VarSOEndDate_DP";
            this.VarSOEndDate_DP.Size = new System.Drawing.Size(330, 26);
            this.VarSOEndDate_DP.TabIndex = 6;
            // 
            // VarSOStartDate_DP
            // 
            this.VarSOStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSOStartDate_DP.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.CustomFormat = "dd.MM.yyyy";
            this.VarSOStartDate_DP.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOStartDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.VarSOStartDate_DP.Location = new System.Drawing.Point(205, 54);
            this.VarSOStartDate_DP.Name = "VarSOStartDate_DP";
            this.VarSOStartDate_DP.Size = new System.Drawing.Size(330, 26);
            this.VarSOStartDate_DP.TabIndex = 5;
            // 
            // VPlannedFinDate_LBL
            // 
            this.VPlannedFinDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VPlannedFinDate_LBL.AutoSize = true;
            this.VPlannedFinDate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VPlannedFinDate_LBL.Location = new System.Drawing.Point(50, 103);
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
            this.VarSOStartDate_LBL.Location = new System.Drawing.Point(54, 58);
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
            this.VarExternalReference_LBL.Location = new System.Drawing.Point(53, 195);
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
            this.VarSOPriority_CB.Location = new System.Drawing.Point(205, 144);
            this.VarSOPriority_CB.Name = "VarSOPriority_CB";
            this.VarSOPriority_CB.Size = new System.Drawing.Size(330, 26);
            this.VarSOPriority_CB.TabIndex = 7;
            // 
            // VarSOPriority_LBL
            // 
            this.VarSOPriority_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSOPriority_LBL.AutoSize = true;
            this.VarSOPriority_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSOPriority_LBL.Location = new System.Drawing.Point(132, 148);
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
            this.VarPMActivityType_LBL.Location = new System.Drawing.Point(77, 13);
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
            this.VarPMActivityType_CB.Location = new System.Drawing.Point(205, 9);
            this.VarPMActivityType_CB.Name = "VarPMActivityType_CB";
            this.VarPMActivityType_CB.Size = new System.Drawing.Size(330, 26);
            this.VarPMActivityType_CB.TabIndex = 4;
            // 
            // VarExternalReference_TB
            // 
            this.VarExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarExternalReference_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarExternalReference_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.VarExternalReference_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarExternalReference_TB.Location = new System.Drawing.Point(205, 191);
            this.VarExternalReference_TB.Name = "VarExternalReference_TB";
            this.VarExternalReference_TB.Size = new System.Drawing.Size(330, 26);
            this.VarExternalReference_TB.TabIndex = 8;
            // 
            // VarCheckEntryList_BTN
            // 
            this.VarCheckEntryList_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarCheckEntryList_BTN.Location = new System.Drawing.Point(3, 500);
            this.VarCheckEntryList_BTN.Name = "VarCheckEntryList_BTN";
            this.VarCheckEntryList_BTN.Size = new System.Drawing.Size(544, 26);
            this.VarCheckEntryList_BTN.TabIndex = 2;
            this.VarCheckEntryList_BTN.Text = "Check Equipment Entry List";
            this.VarCheckEntryList_BTN.UseVisualStyleBackColor = true;
            this.VarCheckEntryList_BTN.Click += new System.EventHandler(this.VarSetupEquipment_BTN_Click);
            // 
            // VarRaiseServiceOrder_BTN
            // 
            this.VarRaiseServiceOrder_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VarRaiseServiceOrder_BTN.Location = new System.Drawing.Point(553, 500);
            this.VarRaiseServiceOrder_BTN.Name = "VarRaiseServiceOrder_BTN";
            this.VarRaiseServiceOrder_BTN.Size = new System.Drawing.Size(545, 26);
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
            this.EqInfo_GRB.Size = new System.Drawing.Size(544, 231);
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
            this.EqInfo_TBL.Size = new System.Drawing.Size(538, 206);
            this.EqInfo_TBL.TabIndex = 0;
            // 
            // VarTaskType_CB
            // 
            this.VarTaskType_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarTaskType_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VarTaskType_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VarTaskType_CB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTaskType_CB.FormattingEnabled = true;
            this.VarTaskType_CB.Location = new System.Drawing.Point(201, 158);
            this.VarTaskType_CB.Name = "VarTaskType_CB";
            this.VarTaskType_CB.Size = new System.Drawing.Size(334, 26);
            this.VarTaskType_CB.TabIndex = 3;
            // 
            // VarSerialNumber_LBL
            // 
            this.VarSerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarSerialNumber_LBL.AutoSize = true;
            this.VarSerialNumber_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_LBL.Location = new System.Drawing.Point(85, 25);
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
            this.VarTaskType_LBL.Location = new System.Drawing.Point(30, 162);
            this.VarTaskType_LBL.Name = "VarTaskType_LBL";
            this.VarTaskType_LBL.Size = new System.Drawing.Size(165, 18);
            this.VarTaskType_LBL.TabIndex = 0;
            this.VarTaskType_LBL.Text = "VARIATION WORK SCOPE:";
            this.VarTaskType_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VarTemplate_LBL
            // 
            this.VarTemplate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VarTemplate_LBL.AutoSize = true;
            this.VarTemplate_LBL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarTemplate_LBL.Location = new System.Drawing.Point(80, 84);
            this.VarTemplate_LBL.Name = "VarTemplate_LBL";
            this.VarTemplate_LBL.Size = new System.Drawing.Size(115, 36);
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
            this.VarTemplate_CB.Location = new System.Drawing.Point(201, 89);
            this.VarTemplate_CB.Name = "VarTemplate_CB";
            this.VarTemplate_CB.Size = new System.Drawing.Size(334, 26);
            this.VarTemplate_CB.TabIndex = 2;
            this.VarTemplate_CB.TextChanged += new System.EventHandler(this.VarTemplate_CB_TextChanged);
            // 
            // VarSerialNumber_TB
            // 
            this.VarSerialNumber_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VarSerialNumber_TB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VarSerialNumber_TB.Location = new System.Drawing.Point(201, 21);
            this.VarSerialNumber_TB.Name = "VarSerialNumber_TB";
            this.VarSerialNumber_TB.Size = new System.Drawing.Size(334, 26);
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
            this.DataTabs_TC.Location = new System.Drawing.Point(20, 79);
            this.DataTabs_TC.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.DataTabs_TC.Name = "DataTabs_TC";
            this.DataTabs_TC.SelectedIndex = 0;
            this.DataTabs_TC.Size = new System.Drawing.Size(1117, 570);
            this.DataTabs_TC.TabIndex = 8;
            this.DataTabs_TC.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.DataTabs_TC_Selecting);
            // 
            // InitialSetup_TP
            // 
            this.InitialSetup_TP.Controls.Add(this.MainLayout);
            this.InitialSetup_TP.Location = new System.Drawing.Point(4, 27);
            this.InitialSetup_TP.Name = "InitialSetup_TP";
            this.InitialSetup_TP.Padding = new System.Windows.Forms.Padding(3);
            this.InitialSetup_TP.Size = new System.Drawing.Size(1109, 539);
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
            this.MainLayout.Size = new System.Drawing.Size(1103, 533);
            this.MainLayout.TabIndex = 10;
            // 
            // NotificationInput_GRB
            // 
            this.NotificationInput_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationInput_GRB.Controls.Add(this.NotificationLayout);
            this.NotificationInput_GRB.Location = new System.Drawing.Point(5, 242);
            this.NotificationInput_GRB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NotificationInput_GRB.Name = "NotificationInput_GRB";
            this.NotificationInput_GRB.Size = new System.Drawing.Size(541, 288);
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
            this.NotificationLayout.Controls.Add(this.PurchOrderDate_LBL, 0, 2);
            this.NotificationLayout.Controls.Add(this.ReqStartDate_LBL, 0, 3);
            this.NotificationLayout.Controls.Add(this.ReqEndDate_LBL, 0, 4);
            this.NotificationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotificationLayout.Location = new System.Drawing.Point(3, 22);
            this.NotificationLayout.Name = "NotificationLayout";
            this.NotificationLayout.RowCount = 5;
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NotificationLayout.Size = new System.Drawing.Size(535, 263);
            this.NotificationLayout.TabIndex = 0;
            // 
            // SoldToParty_LBL
            // 
            this.SoldToParty_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SoldToParty_LBL.AutoSize = true;
            this.SoldToParty_LBL.ForeColor = System.Drawing.Color.Black;
            this.SoldToParty_LBL.Location = new System.Drawing.Point(160, 17);
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
            this.PartyName_CB.Location = new System.Drawing.Point(270, 12);
            this.PartyName_CB.Name = "PartyName_CB";
            this.PartyName_CB.Size = new System.Drawing.Size(262, 26);
            this.PartyName_CB.TabIndex = 6;
            // 
            // PurchaseOrder_TB
            // 
            this.PurchaseOrder_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PurchaseOrder_TB.Location = new System.Drawing.Point(270, 65);
            this.PurchaseOrder_TB.Name = "PurchaseOrder_TB";
            this.PurchaseOrder_TB.Size = new System.Drawing.Size(262, 26);
            this.PurchaseOrder_TB.TabIndex = 7;
            // 
            // PurchaseOrder_LBL
            // 
            this.PurchaseOrder_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PurchaseOrder_LBL.AutoSize = true;
            this.PurchaseOrder_LBL.ForeColor = System.Drawing.Color.Black;
            this.PurchaseOrder_LBL.Location = new System.Drawing.Point(142, 69);
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
            this.PurchaseOrderDate_DP.Location = new System.Drawing.Point(270, 117);
            this.PurchaseOrderDate_DP.Name = "PurchaseOrderDate_DP";
            this.PurchaseOrderDate_DP.Size = new System.Drawing.Size(262, 26);
            this.PurchaseOrderDate_DP.TabIndex = 8;
            this.PurchaseOrderDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            // 
            // RequiredStartDate_DP
            // 
            this.RequiredStartDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredStartDate_DP.CustomFormat = "dd.MM.yyyy";
            this.RequiredStartDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RequiredStartDate_DP.Location = new System.Drawing.Point(270, 169);
            this.RequiredStartDate_DP.Name = "RequiredStartDate_DP";
            this.RequiredStartDate_DP.Size = new System.Drawing.Size(262, 26);
            this.RequiredStartDate_DP.TabIndex = 9;
            this.RequiredStartDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            this.RequiredStartDate_DP.ValueChanged += new System.EventHandler(this.ReqStartDate_ValueChanged);
            // 
            // RequiredEndDate_DP
            // 
            this.RequiredEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RequiredEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.RequiredEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RequiredEndDate_DP.Location = new System.Drawing.Point(270, 222);
            this.RequiredEndDate_DP.Name = "RequiredEndDate_DP";
            this.RequiredEndDate_DP.Size = new System.Drawing.Size(262, 26);
            this.RequiredEndDate_DP.TabIndex = 10;
            this.RequiredEndDate_DP.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            this.RequiredEndDate_DP.ValueChanged += new System.EventHandler(this.ReqEndDate_ValueChanged);
            // 
            // PurchOrderDate_LBL
            // 
            this.PurchOrderDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PurchOrderDate_LBL.AutoSize = true;
            this.PurchOrderDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.PurchOrderDate_LBL.Location = new System.Drawing.Point(108, 121);
            this.PurchOrderDate_LBL.Name = "PurchOrderDate_LBL";
            this.PurchOrderDate_LBL.Size = new System.Drawing.Size(156, 18);
            this.PurchOrderDate_LBL.TabIndex = 3;
            this.PurchOrderDate_LBL.Text = "PURCHASE ORDER DATE:";
            // 
            // ReqStartDate_LBL
            // 
            this.ReqStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReqStartDate_LBL.AutoSize = true;
            this.ReqStartDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.ReqStartDate_LBL.Location = new System.Drawing.Point(116, 173);
            this.ReqStartDate_LBL.Name = "ReqStartDate_LBL";
            this.ReqStartDate_LBL.Size = new System.Drawing.Size(148, 18);
            this.ReqStartDate_LBL.TabIndex = 3;
            this.ReqStartDate_LBL.Text = "REQUIRED START DATE:";
            // 
            // ReqEndDate_LBL
            // 
            this.ReqEndDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReqEndDate_LBL.AutoSize = true;
            this.ReqEndDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.ReqEndDate_LBL.Location = new System.Drawing.Point(127, 226);
            this.ReqEndDate_LBL.Name = "ReqEndDate_LBL";
            this.ReqEndDate_LBL.Size = new System.Drawing.Size(137, 18);
            this.ReqEndDate_LBL.TabIndex = 3;
            this.ReqEndDate_LBL.Text = "REQUIRED END DATE:";
            // 
            // ServOrderInput_GRB
            // 
            this.ServOrderInput_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServOrderInput_GRB.Controls.Add(this.ServiceOrderInfo_LYT);
            this.ServOrderInput_GRB.Location = new System.Drawing.Point(556, 242);
            this.ServOrderInput_GRB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ServOrderInput_GRB.Name = "ServOrderInput_GRB";
            this.ServOrderInput_GRB.Size = new System.Drawing.Size(542, 288);
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
            this.ServiceOrderInfo_LYT.Size = new System.Drawing.Size(536, 263);
            this.ServiceOrderInfo_LYT.TabIndex = 0;
            // 
            // ActivityType_LBL
            // 
            this.ActivityType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ActivityType_LBL.AutoSize = true;
            this.ActivityType_LBL.ForeColor = System.Drawing.Color.Black;
            this.ActivityType_LBL.Location = new System.Drawing.Point(133, 17);
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
            this.PMActivityType_CB.Location = new System.Drawing.Point(261, 12);
            this.PMActivityType_CB.Name = "PMActivityType_CB";
            this.PMActivityType_CB.Size = new System.Drawing.Size(272, 26);
            this.PMActivityType_CB.TabIndex = 11;
            // 
            // ExternalReference_TB
            // 
            this.ExternalReference_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExternalReference_TB.Location = new System.Drawing.Point(261, 222);
            this.ExternalReference_TB.Name = "ExternalReference_TB";
            this.ExternalReference_TB.Size = new System.Drawing.Size(272, 26);
            this.ExternalReference_TB.TabIndex = 15;
            // 
            // BasicStartDate_LBL
            // 
            this.BasicStartDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicStartDate_LBL.AutoSize = true;
            this.BasicStartDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicStartDate_LBL.Location = new System.Drawing.Point(110, 69);
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
            this.BasicStartDate_DP.Location = new System.Drawing.Point(261, 65);
            this.BasicStartDate_DP.Name = "BasicStartDate_DP";
            this.BasicStartDate_DP.Size = new System.Drawing.Size(272, 26);
            this.BasicStartDate_DP.TabIndex = 12;
            this.BasicStartDate_DP.Value = new System.DateTime(2022, 1, 25, 0, 0, 0, 0);
            // 
            // BasicEndDate_LBL
            // 
            this.BasicEndDate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BasicEndDate_LBL.AutoSize = true;
            this.BasicEndDate_LBL.ForeColor = System.Drawing.Color.Black;
            this.BasicEndDate_LBL.Location = new System.Drawing.Point(121, 121);
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
            this.Priority_LBL.Location = new System.Drawing.Point(188, 173);
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
            this.ExternalRef_LBL.Location = new System.Drawing.Point(109, 226);
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
            this.Priority_CB.Location = new System.Drawing.Point(261, 168);
            this.Priority_CB.Name = "Priority_CB";
            this.Priority_CB.Size = new System.Drawing.Size(272, 26);
            this.Priority_CB.TabIndex = 14;
            // 
            // BasicEndDate_DP
            // 
            this.BasicEndDate_DP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BasicEndDate_DP.CustomFormat = "dd.MM.yyyy";
            this.BasicEndDate_DP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BasicEndDate_DP.Location = new System.Drawing.Point(261, 117);
            this.BasicEndDate_DP.Name = "BasicEndDate_DP";
            this.BasicEndDate_DP.Size = new System.Drawing.Size(272, 26);
            this.BasicEndDate_DP.TabIndex = 13;
            this.BasicEndDate_DP.Value = new System.DateTime(2022, 3, 6, 0, 0, 0, 0);
            // 
            // EquipmentInfo_GB
            // 
            this.MainLayout.SetColumnSpan(this.EquipmentInfo_GB, 2);
            this.EquipmentInfo_GB.Controls.Add(this.EquipmentInfo_Layout);
            this.EquipmentInfo_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInfo_GB.Location = new System.Drawing.Point(5, 3);
            this.EquipmentInfo_GB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.EquipmentInfo_GB.Name = "EquipmentInfo_GB";
            this.EquipmentInfo_GB.Size = new System.Drawing.Size(1093, 188);
            this.EquipmentInfo_GB.TabIndex = 5;
            this.EquipmentInfo_GB.TabStop = false;
            this.EquipmentInfo_GB.Text = "Equipment Information";
            // 
            // EquipmentInfo_Layout
            // 
            this.EquipmentInfo_Layout.ColumnCount = 4;
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.56302F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.27139F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.EquipmentInfo_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.EquipmentInfo_Layout.Controls.Add(this.EquipmentSerial_TB, 2, 0);
            this.EquipmentInfo_Layout.Controls.Add(this.TemplateEquipmentList_CB, 2, 1);
            this.EquipmentInfo_Layout.Controls.Add(this.TaskType_CB, 2, 2);
            this.EquipmentInfo_Layout.Controls.Add(this.FunctionLoc_CB, 2, 3);
            this.EquipmentInfo_Layout.Controls.Add(this.SerialNumber_LBL, 1, 0);
            this.EquipmentInfo_Layout.Controls.Add(this.TemplateEquipment_LBL, 1, 1);
            this.EquipmentInfo_Layout.Controls.Add(this.TaskType_LBL, 1, 2);
            this.EquipmentInfo_Layout.Controls.Add(this.FuncLoc_LBL, 1, 3);
            this.EquipmentInfo_Layout.Controls.Add(this.WarrantyClaim_CHB, 0, 0);
            this.EquipmentInfo_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentInfo_Layout.Location = new System.Drawing.Point(3, 22);
            this.EquipmentInfo_Layout.Name = "EquipmentInfo_Layout";
            this.EquipmentInfo_Layout.RowCount = 4;
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipmentInfo_Layout.Size = new System.Drawing.Size(1087, 163);
            this.EquipmentInfo_Layout.TabIndex = 0;
            // 
            // EquipmentSerial_TB
            // 
            this.EquipmentSerial_TB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EquipmentSerial_TB.Location = new System.Drawing.Point(436, 7);
            this.EquipmentSerial_TB.Name = "EquipmentSerial_TB";
            this.EquipmentSerial_TB.Size = new System.Drawing.Size(429, 26);
            this.EquipmentSerial_TB.TabIndex = 2;
            // 
            // TemplateEquipmentList_CB
            // 
            this.TemplateEquipmentList_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TemplateEquipmentList_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TemplateEquipmentList_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TemplateEquipmentList_CB.FormattingEnabled = true;
            this.TemplateEquipmentList_CB.Location = new System.Drawing.Point(436, 46);
            this.TemplateEquipmentList_CB.Name = "TemplateEquipmentList_CB";
            this.TemplateEquipmentList_CB.Size = new System.Drawing.Size(429, 26);
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
            this.TaskType_CB.Location = new System.Drawing.Point(436, 86);
            this.TaskType_CB.Name = "TaskType_CB";
            this.TaskType_CB.Size = new System.Drawing.Size(429, 26);
            this.TaskType_CB.TabIndex = 4;
            // 
            // FunctionLoc_CB
            // 
            this.FunctionLoc_CB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FunctionLoc_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FunctionLoc_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FunctionLoc_CB.FormattingEnabled = true;
            this.FunctionLoc_CB.Location = new System.Drawing.Point(436, 127);
            this.FunctionLoc_CB.Name = "FunctionLoc_CB";
            this.FunctionLoc_CB.Size = new System.Drawing.Size(429, 26);
            this.FunctionLoc_CB.TabIndex = 5;
            // 
            // SerialNumber_LBL
            // 
            this.SerialNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SerialNumber_LBL.AutoSize = true;
            this.SerialNumber_LBL.ForeColor = System.Drawing.Color.Black;
            this.SerialNumber_LBL.Location = new System.Drawing.Point(320, 11);
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
            this.TemplateEquipment_LBL.Location = new System.Drawing.Point(280, 51);
            this.TemplateEquipment_LBL.Name = "TemplateEquipment_LBL";
            this.TemplateEquipment_LBL.Size = new System.Drawing.Size(150, 18);
            this.TemplateEquipment_LBL.TabIndex = 0;
            this.TemplateEquipment_LBL.Text = "TEMPLATE EQUIPMENT:";
            // 
            // TaskType_LBL
            // 
            this.TaskType_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaskType_LBL.AutoSize = true;
            this.TaskType_LBL.ForeColor = System.Drawing.Color.Black;
            this.TaskType_LBL.Location = new System.Drawing.Point(336, 91);
            this.TaskType_LBL.Name = "TaskType_LBL";
            this.TaskType_LBL.Size = new System.Drawing.Size(94, 18);
            this.TaskType_LBL.TabIndex = 0;
            this.TaskType_LBL.Text = "WORK SCOPE:";
            // 
            // FuncLoc_LBL
            // 
            this.FuncLoc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FuncLoc_LBL.AutoSize = true;
            this.FuncLoc_LBL.ForeColor = System.Drawing.Color.Black;
            this.FuncLoc_LBL.Location = new System.Drawing.Point(272, 132);
            this.FuncLoc_LBL.Name = "FuncLoc_LBL";
            this.FuncLoc_LBL.Size = new System.Drawing.Size(158, 18);
            this.FuncLoc_LBL.TabIndex = 0;
            this.FuncLoc_LBL.Text = "FUNCTIONAL LOCATION:";
            // 
            // WarrantyClaim_CHB
            // 
            this.WarrantyClaim_CHB.AutoSize = true;
            this.WarrantyClaim_CHB.ForeColor = System.Drawing.Color.Black;
            this.WarrantyClaim_CHB.Location = new System.Drawing.Point(3, 3);
            this.WarrantyClaim_CHB.Name = "WarrantyClaim_CHB";
            this.WarrantyClaim_CHB.Size = new System.Drawing.Size(255, 22);
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
            this.SetupEquipment_BTN.Location = new System.Drawing.Point(3, 197);
            this.SetupEquipment_BTN.Name = "SetupEquipment_BTN";
            this.SetupEquipment_BTN.Size = new System.Drawing.Size(545, 39);
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
            this.RiaseServiceOrder_BTN.Location = new System.Drawing.Point(554, 197);
            this.RiaseServiceOrder_BTN.Name = "RiaseServiceOrder_BTN";
            this.RiaseServiceOrder_BTN.Size = new System.Drawing.Size(546, 39);
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
            this.QuoteOrder_TP.Size = new System.Drawing.Size(1109, 539);
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
            this.QuoteLayout.Controls.Add(this.QServOrderNum_LBL, 0, 0);
            this.QuoteLayout.Controls.Add(this.QQuoteNumber_LBL, 0, 1);
            this.QuoteLayout.Controls.Add(this.QQuoteTemplate_LBL, 0, 2);
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
            this.QuoteLayout.Size = new System.Drawing.Size(1103, 533);
            this.QuoteLayout.TabIndex = 0;
            // 
            // QuoteNotiListBox
            // 
            this.QuoteNotiListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteNotiListBox.FormattingEnabled = true;
            this.QuoteNotiListBox.ItemHeight = 20;
            this.QuoteNotiListBox.Location = new System.Drawing.Point(554, 4);
            this.QuoteNotiListBox.Name = "QuoteNotiListBox";
            this.QuoteLayout.SetRowSpan(this.QuoteNotiListBox, 3);
            this.QuoteNotiListBox.Size = new System.Drawing.Size(545, 286);
            this.QuoteNotiListBox.TabIndex = 1;
            // 
            // QServOrderNum_LBL
            // 
            this.QServOrderNum_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QServOrderNum_LBL.AutoSize = true;
            this.QServOrderNum_LBL.BackColor = System.Drawing.Color.Transparent;
            this.QServOrderNum_LBL.ForeColor = System.Drawing.Color.Black;
            this.QServOrderNum_LBL.Location = new System.Drawing.Point(35, 37);
            this.QServOrderNum_LBL.Name = "QServOrderNum_LBL";
            this.QServOrderNum_LBL.Size = new System.Drawing.Size(183, 20);
            this.QServOrderNum_LBL.TabIndex = 2;
            this.QServOrderNum_LBL.Text = "SERVICE ORDER NUMBER:";
            // 
            // QQuoteNumber_LBL
            // 
            this.QQuoteNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QQuoteNumber_LBL.AutoSize = true;
            this.QQuoteNumber_LBL.BackColor = System.Drawing.Color.Transparent;
            this.QQuoteNumber_LBL.ForeColor = System.Drawing.Color.Black;
            this.QQuoteNumber_LBL.Location = new System.Drawing.Point(61, 133);
            this.QQuoteNumber_LBL.Name = "QQuoteNumber_LBL";
            this.QQuoteNumber_LBL.Size = new System.Drawing.Size(157, 20);
            this.QQuoteNumber_LBL.TabIndex = 2;
            this.QQuoteNumber_LBL.Text = "QUOTATION NUMBER:";
            // 
            // QQuoteTemplate_LBL
            // 
            this.QQuoteTemplate_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QQuoteTemplate_LBL.AutoSize = true;
            this.QQuoteTemplate_LBL.BackColor = System.Drawing.Color.Transparent;
            this.QQuoteTemplate_LBL.ForeColor = System.Drawing.Color.Black;
            this.QQuoteTemplate_LBL.Location = new System.Drawing.Point(52, 233);
            this.QQuoteTemplate_LBL.Name = "QQuoteTemplate_LBL";
            this.QQuoteTemplate_LBL.Size = new System.Drawing.Size(166, 20);
            this.QQuoteTemplate_LBL.TabIndex = 2;
            this.QQuoteTemplate_LBL.Text = "QUOTATION TEMPLATE:";
            // 
            // QuoteServiceOrder_TB
            // 
            this.QuoteServiceOrder_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteServiceOrder_TB.Location = new System.Drawing.Point(224, 33);
            this.QuoteServiceOrder_TB.Name = "QuoteServiceOrder_TB";
            this.QuoteServiceOrder_TB.Size = new System.Drawing.Size(324, 27);
            this.QuoteServiceOrder_TB.TabIndex = 3;
            // 
            // QuoteNumberTB
            // 
            this.QuoteNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteNumberTB.Location = new System.Drawing.Point(224, 129);
            this.QuoteNumberTB.Name = "QuoteNumberTB";
            this.QuoteNumberTB.Size = new System.Drawing.Size(324, 27);
            this.QuoteNumberTB.TabIndex = 3;
            // 
            // QuoteTemplate_CB
            // 
            this.QuoteTemplate_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuoteTemplate_CB.FormattingEnabled = true;
            this.QuoteTemplate_CB.Location = new System.Drawing.Point(224, 229);
            this.QuoteTemplate_CB.Name = "QuoteTemplate_CB";
            this.QuoteTemplate_CB.Size = new System.Drawing.Size(324, 28);
            this.QuoteTemplate_CB.TabIndex = 4;
            // 
            // QuoteServiceOrder_BTN
            // 
            this.QuoteServiceOrder_BTN.BackColor = System.Drawing.Color.Transparent;
            this.QuoteLayout.SetColumnSpan(this.QuoteServiceOrder_BTN, 2);
            this.QuoteServiceOrder_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteServiceOrder_BTN.Location = new System.Drawing.Point(4, 296);
            this.QuoteServiceOrder_BTN.Name = "QuoteServiceOrder_BTN";
            this.QuoteServiceOrder_BTN.Size = new System.Drawing.Size(544, 56);
            this.QuoteServiceOrder_BTN.TabIndex = 6;
            this.QuoteServiceOrder_BTN.Text = "Quote Service Order";
            this.QuoteServiceOrder_BTN.UseVisualStyleBackColor = false;
            // 
            // LoadNotification_BTN
            // 
            this.LoadNotification_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadNotification_BTN.Location = new System.Drawing.Point(554, 296);
            this.LoadNotification_BTN.Name = "LoadNotification_BTN";
            this.LoadNotification_BTN.Size = new System.Drawing.Size(545, 56);
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
            this.QuoteOutput_LV.Size = new System.Drawing.Size(1095, 286);
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
            this.Output_PNL.Location = new System.Drawing.Point(20, 669);
            this.Output_PNL.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.Output_PNL.Name = "Output_PNL";
            this.Output_PNL.Size = new System.Drawing.Size(1117, 205);
            this.Output_PNL.TabIndex = 10;
            // 
            // QOutputInfo_GRB
            // 
            this.QOutputInfo_GRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QOutputInfo_GRB.Controls.Add(this.OutputOrder_PNL);
            this.QOutputInfo_GRB.Controls.Add(this.QuoteOutput_PNL);
            this.QOutputInfo_GRB.Location = new System.Drawing.Point(7, 5);
            this.QOutputInfo_GRB.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.QOutputInfo_GRB.Name = "QOutputInfo_GRB";
            this.QOutputInfo_GRB.Size = new System.Drawing.Size(1100, 190);
            this.QOutputInfo_GRB.TabIndex = 1;
            this.QOutputInfo_GRB.TabStop = false;
            this.QOutputInfo_GRB.Text = "Output Information";
            // 
            // OutputOrder_PNL
            // 
            this.OutputOrder_PNL.ColumnCount = 4;
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76341F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23659F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44795F));
            this.OutputOrder_PNL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55205F));
            this.OutputOrder_PNL.Controls.Add(this.OutputEqDesc_TB, 1, 0);
            this.OutputOrder_PNL.Controls.Add(this.OutputSetupModule_LBL, 0, 2);
            this.OutputOrder_PNL.Controls.Add(this.OutputEntryList_LBL, 0, 3);
            this.OutputOrder_PNL.Controls.Add(this.OutputWorkCentre_LBL, 2, 0);
            this.OutputOrder_PNL.Controls.Add(this.OutputWSB_LBL, 2, 1);
            this.OutputOrder_PNL.Controls.Add(this.OutputNotNumber_LBL, 2, 2);
            this.OutputOrder_PNL.Controls.Add(this.OutputServOrd_LBL, 2, 3);
            this.OutputOrder_PNL.Controls.Add(this.OutputEqNum_TB, 1, 1);
            this.OutputOrder_PNL.Controls.Add(this.OutputSetupModule_TB, 1, 2);
            this.OutputOrder_PNL.Controls.Add(this.OutputEntryList_TB, 1, 3);
            this.OutputOrder_PNL.Controls.Add(this.OutputWorkCentre_TB, 3, 0);
            this.OutputOrder_PNL.Controls.Add(this.OutputWBS_TB, 3, 1);
            this.OutputOrder_PNL.Controls.Add(this.OutputNotification_TB, 3, 2);
            this.OutputOrder_PNL.Controls.Add(this.OutputServOrd_TB, 3, 3);
            this.OutputOrder_PNL.Controls.Add(this.OEqNum_LBL, 0, 1);
            this.OutputOrder_PNL.Controls.Add(this.OutputEqDesc_LBL, 0, 0);
            this.OutputOrder_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputOrder_PNL.Location = new System.Drawing.Point(3, 21);
            this.OutputOrder_PNL.Name = "OutputOrder_PNL";
            this.OutputOrder_PNL.RowCount = 4;
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputOrder_PNL.Size = new System.Drawing.Size(1094, 166);
            this.OutputOrder_PNL.TabIndex = 0;
            // 
            // OutputEqDesc_TB
            // 
            this.OutputEqDesc_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputEqDesc_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputEqDesc_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputEqDesc_TB.Location = new System.Drawing.Point(273, 6);
            this.OutputEqDesc_TB.Name = "OutputEqDesc_TB";
            this.OutputEqDesc_TB.ReadOnly = true;
            this.OutputEqDesc_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputEqDesc_TB.Size = new System.Drawing.Size(270, 28);
            this.OutputEqDesc_TB.TabIndex = 1;
            this.OutputEqDesc_TB.TabStop = false;
            this.OutputEqDesc_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputSetupModule_LBL
            // 
            this.OutputSetupModule_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputSetupModule_LBL.AutoSize = true;
            this.OutputSetupModule_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputSetupModule_LBL.Location = new System.Drawing.Point(162, 94);
            this.OutputSetupModule_LBL.Name = "OutputSetupModule_LBL";
            this.OutputSetupModule_LBL.Size = new System.Drawing.Size(105, 17);
            this.OutputSetupModule_LBL.TabIndex = 3;
            this.OutputSetupModule_LBL.Text = "SETUP MODULE:";
            // 
            // OutputEntryList_LBL
            // 
            this.OutputEntryList_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputEntryList_LBL.AutoSize = true;
            this.OutputEntryList_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputEntryList_LBL.Location = new System.Drawing.Point(133, 136);
            this.OutputEntryList_LBL.Name = "OutputEntryList_LBL";
            this.OutputEntryList_LBL.Size = new System.Drawing.Size(134, 17);
            this.OutputEntryList_LBL.TabIndex = 3;
            this.OutputEntryList_LBL.Text = "ENTRY LIST NUMBER:";
            // 
            // OutputWorkCentre_LBL
            // 
            this.OutputWorkCentre_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputWorkCentre_LBL.AutoSize = true;
            this.OutputWorkCentre_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputWorkCentre_LBL.Location = new System.Drawing.Point(710, 12);
            this.OutputWorkCentre_LBL.Name = "OutputWorkCentre_LBL";
            this.OutputWorkCentre_LBL.Size = new System.Drawing.Size(100, 17);
            this.OutputWorkCentre_LBL.TabIndex = 3;
            this.OutputWorkCentre_LBL.Text = "WORK CENTER:";
            // 
            // OutputWSB_LBL
            // 
            this.OutputWSB_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputWSB_LBL.AutoSize = true;
            this.OutputWSB_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputWSB_LBL.Location = new System.Drawing.Point(713, 53);
            this.OutputWSB_LBL.Name = "OutputWSB_LBL";
            this.OutputWSB_LBL.Size = new System.Drawing.Size(97, 17);
            this.OutputWSB_LBL.TabIndex = 3;
            this.OutputWSB_LBL.Text = "WBS ELEMENT:";
            // 
            // OutputNotNumber_LBL
            // 
            this.OutputNotNumber_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputNotNumber_LBL.AutoSize = true;
            this.OutputNotNumber_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputNotNumber_LBL.Location = new System.Drawing.Point(659, 94);
            this.OutputNotNumber_LBL.Name = "OutputNotNumber_LBL";
            this.OutputNotNumber_LBL.Size = new System.Drawing.Size(151, 17);
            this.OutputNotNumber_LBL.TabIndex = 3;
            this.OutputNotNumber_LBL.Text = "NOTIFICATION NUMBER:";
            // 
            // OutputServOrd_LBL
            // 
            this.OutputServOrd_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputServOrd_LBL.AutoSize = true;
            this.OutputServOrd_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputServOrd_LBL.Location = new System.Drawing.Point(648, 136);
            this.OutputServOrd_LBL.Name = "OutputServOrd_LBL";
            this.OutputServOrd_LBL.Size = new System.Drawing.Size(162, 17);
            this.OutputServOrd_LBL.TabIndex = 3;
            this.OutputServOrd_LBL.Text = "SERVICE ORDER NUMBER:";
            // 
            // OutputEqNum_TB
            // 
            this.OutputEqNum_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputEqNum_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputEqNum_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputEqNum_TB.Location = new System.Drawing.Point(273, 47);
            this.OutputEqNum_TB.Name = "OutputEqNum_TB";
            this.OutputEqNum_TB.ReadOnly = true;
            this.OutputEqNum_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputEqNum_TB.Size = new System.Drawing.Size(270, 28);
            this.OutputEqNum_TB.TabIndex = 1;
            this.OutputEqNum_TB.TabStop = false;
            this.OutputEqNum_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputSetupModule_TB
            // 
            this.OutputSetupModule_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputSetupModule_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputSetupModule_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputSetupModule_TB.Location = new System.Drawing.Point(273, 88);
            this.OutputSetupModule_TB.Name = "OutputSetupModule_TB";
            this.OutputSetupModule_TB.ReadOnly = true;
            this.OutputSetupModule_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputSetupModule_TB.Size = new System.Drawing.Size(270, 28);
            this.OutputSetupModule_TB.TabIndex = 1;
            this.OutputSetupModule_TB.TabStop = false;
            this.OutputSetupModule_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputEntryList_TB
            // 
            this.OutputEntryList_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputEntryList_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputEntryList_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputEntryList_TB.Location = new System.Drawing.Point(273, 130);
            this.OutputEntryList_TB.Name = "OutputEntryList_TB";
            this.OutputEntryList_TB.ReadOnly = true;
            this.OutputEntryList_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputEntryList_TB.Size = new System.Drawing.Size(270, 28);
            this.OutputEntryList_TB.TabIndex = 1;
            this.OutputEntryList_TB.TabStop = false;
            this.OutputEntryList_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputWorkCentre_TB
            // 
            this.OutputWorkCentre_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputWorkCentre_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputWorkCentre_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputWorkCentre_TB.Location = new System.Drawing.Point(816, 6);
            this.OutputWorkCentre_TB.Name = "OutputWorkCentre_TB";
            this.OutputWorkCentre_TB.ReadOnly = true;
            this.OutputWorkCentre_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputWorkCentre_TB.Size = new System.Drawing.Size(275, 28);
            this.OutputWorkCentre_TB.TabIndex = 1;
            this.OutputWorkCentre_TB.TabStop = false;
            this.OutputWorkCentre_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputWBS_TB
            // 
            this.OutputWBS_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputWBS_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputWBS_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputWBS_TB.Location = new System.Drawing.Point(816, 47);
            this.OutputWBS_TB.Name = "OutputWBS_TB";
            this.OutputWBS_TB.ReadOnly = true;
            this.OutputWBS_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputWBS_TB.Size = new System.Drawing.Size(275, 28);
            this.OutputWBS_TB.TabIndex = 1;
            this.OutputWBS_TB.TabStop = false;
            this.OutputWBS_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputNotification_TB
            // 
            this.OutputNotification_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputNotification_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputNotification_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputNotification_TB.Location = new System.Drawing.Point(816, 88);
            this.OutputNotification_TB.Name = "OutputNotification_TB";
            this.OutputNotification_TB.ReadOnly = true;
            this.OutputNotification_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputNotification_TB.Size = new System.Drawing.Size(275, 28);
            this.OutputNotification_TB.TabIndex = 1;
            this.OutputNotification_TB.TabStop = false;
            this.OutputNotification_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputServOrd_TB
            // 
            this.OutputServOrd_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputServOrd_TB.BackColor = System.Drawing.SystemColors.Info;
            this.OutputServOrd_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputServOrd_TB.Location = new System.Drawing.Point(816, 130);
            this.OutputServOrd_TB.Name = "OutputServOrd_TB";
            this.OutputServOrd_TB.ReadOnly = true;
            this.OutputServOrd_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputServOrd_TB.Size = new System.Drawing.Size(275, 28);
            this.OutputServOrd_TB.TabIndex = 1;
            this.OutputServOrd_TB.TabStop = false;
            this.OutputServOrd_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OEqNum_LBL
            // 
            this.OEqNum_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OEqNum_LBL.AutoSize = true;
            this.OEqNum_LBL.ForeColor = System.Drawing.Color.Black;
            this.OEqNum_LBL.Location = new System.Drawing.Point(127, 53);
            this.OEqNum_LBL.Name = "OEqNum_LBL";
            this.OEqNum_LBL.Size = new System.Drawing.Size(140, 17);
            this.OEqNum_LBL.TabIndex = 3;
            this.OEqNum_LBL.Text = "EQUIPMENT NUMBER:";
            // 
            // OutputEqDesc_LBL
            // 
            this.OutputEqDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputEqDesc_LBL.AutoSize = true;
            this.OutputEqDesc_LBL.ForeColor = System.Drawing.Color.Black;
            this.OutputEqDesc_LBL.Location = new System.Drawing.Point(101, 12);
            this.OutputEqDesc_LBL.Name = "OutputEqDesc_LBL";
            this.OutputEqDesc_LBL.Size = new System.Drawing.Size(166, 17);
            this.OutputEqDesc_LBL.TabIndex = 3;
            this.OutputEqDesc_LBL.Text = "EQUIPMENT DESCRIPTION:";
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
            this.QuoteOutput_PNL.Controls.Add(this.QServOrderDesc_LBL, 0, 0);
            this.QuoteOutput_PNL.Controls.Add(this.QEqNum_LBL, 0, 1);
            this.QuoteOutput_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuoteOutput_PNL.Location = new System.Drawing.Point(3, 21);
            this.QuoteOutput_PNL.Name = "QuoteOutput_PNL";
            this.QuoteOutput_PNL.RowCount = 4;
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.QuoteOutput_PNL.Size = new System.Drawing.Size(1094, 166);
            this.QuoteOutput_PNL.TabIndex = 1;
            this.QuoteOutput_PNL.Visible = false;
            // 
            // QServiceOrder_TB
            // 
            this.QServiceOrder_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QServiceOrder_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QServiceOrder_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QServiceOrder_TB.Location = new System.Drawing.Point(273, 6);
            this.QServiceOrder_TB.Name = "QServiceOrder_TB";
            this.QServiceOrder_TB.ReadOnly = true;
            this.QServiceOrder_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QServiceOrder_TB.Size = new System.Drawing.Size(270, 28);
            this.QServiceOrder_TB.TabIndex = 1;
            this.QServiceOrder_TB.TabStop = false;
            this.QServiceOrder_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QPurchaseOrder_LBL
            // 
            this.QPurchaseOrder_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QPurchaseOrder_LBL.AutoSize = true;
            this.QPurchaseOrder_LBL.ForeColor = System.Drawing.Color.Black;
            this.QPurchaseOrder_LBL.Location = new System.Drawing.Point(147, 94);
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
            this.QNumOfVars_LBL.Location = new System.Drawing.Point(109, 136);
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
            this.QMaterialPrice_LBL.Location = new System.Drawing.Point(704, 12);
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
            this.QOverhaulPrice_LBL.Location = new System.Drawing.Point(628, 53);
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
            this.QVariationPrice_LBL.Location = new System.Drawing.Point(647, 94);
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
            this.QTotalPrice_LBL.Location = new System.Drawing.Point(727, 136);
            this.QTotalPrice_LBL.Name = "QTotalPrice_LBL";
            this.QTotalPrice_LBL.Size = new System.Drawing.Size(83, 17);
            this.QTotalPrice_LBL.TabIndex = 3;
            this.QTotalPrice_LBL.Text = "TOTAL PRICE:";
            // 
            // QEquipmentNum_TB
            // 
            this.QEquipmentNum_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QEquipmentNum_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QEquipmentNum_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QEquipmentNum_TB.Location = new System.Drawing.Point(273, 47);
            this.QEquipmentNum_TB.Name = "QEquipmentNum_TB";
            this.QEquipmentNum_TB.ReadOnly = true;
            this.QEquipmentNum_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QEquipmentNum_TB.Size = new System.Drawing.Size(270, 28);
            this.QEquipmentNum_TB.TabIndex = 1;
            this.QEquipmentNum_TB.TabStop = false;
            this.QEquipmentNum_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QPurchaseOrder_TB
            // 
            this.QPurchaseOrder_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QPurchaseOrder_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QPurchaseOrder_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QPurchaseOrder_TB.Location = new System.Drawing.Point(273, 88);
            this.QPurchaseOrder_TB.Name = "QPurchaseOrder_TB";
            this.QPurchaseOrder_TB.ReadOnly = true;
            this.QPurchaseOrder_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QPurchaseOrder_TB.Size = new System.Drawing.Size(270, 28);
            this.QPurchaseOrder_TB.TabIndex = 1;
            this.QPurchaseOrder_TB.TabStop = false;
            this.QPurchaseOrder_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QNumOfVars_TB
            // 
            this.QNumOfVars_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QNumOfVars_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QNumOfVars_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QNumOfVars_TB.Location = new System.Drawing.Point(273, 130);
            this.QNumOfVars_TB.Name = "QNumOfVars_TB";
            this.QNumOfVars_TB.ReadOnly = true;
            this.QNumOfVars_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QNumOfVars_TB.Size = new System.Drawing.Size(270, 28);
            this.QNumOfVars_TB.TabIndex = 1;
            this.QNumOfVars_TB.TabStop = false;
            this.QNumOfVars_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QMaterialPrice_TB
            // 
            this.QMaterialPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QMaterialPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QMaterialPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QMaterialPrice_TB.Location = new System.Drawing.Point(816, 6);
            this.QMaterialPrice_TB.Name = "QMaterialPrice_TB";
            this.QMaterialPrice_TB.ReadOnly = true;
            this.QMaterialPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QMaterialPrice_TB.Size = new System.Drawing.Size(275, 28);
            this.QMaterialPrice_TB.TabIndex = 1;
            this.QMaterialPrice_TB.TabStop = false;
            this.QMaterialPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QStandardPrice_TB
            // 
            this.QStandardPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QStandardPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QStandardPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QStandardPrice_TB.Location = new System.Drawing.Point(816, 47);
            this.QStandardPrice_TB.Name = "QStandardPrice_TB";
            this.QStandardPrice_TB.ReadOnly = true;
            this.QStandardPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QStandardPrice_TB.Size = new System.Drawing.Size(275, 28);
            this.QStandardPrice_TB.TabIndex = 1;
            this.QStandardPrice_TB.TabStop = false;
            this.QStandardPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QVarLabourPrice_TB
            // 
            this.QVarLabourPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QVarLabourPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QVarLabourPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QVarLabourPrice_TB.Location = new System.Drawing.Point(816, 88);
            this.QVarLabourPrice_TB.Name = "QVarLabourPrice_TB";
            this.QVarLabourPrice_TB.ReadOnly = true;
            this.QVarLabourPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QVarLabourPrice_TB.Size = new System.Drawing.Size(275, 28);
            this.QVarLabourPrice_TB.TabIndex = 1;
            this.QVarLabourPrice_TB.TabStop = false;
            this.QVarLabourPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QTotalPrice_TB
            // 
            this.QTotalPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QTotalPrice_TB.BackColor = System.Drawing.SystemColors.Info;
            this.QTotalPrice_TB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QTotalPrice_TB.Location = new System.Drawing.Point(816, 130);
            this.QTotalPrice_TB.Name = "QTotalPrice_TB";
            this.QTotalPrice_TB.ReadOnly = true;
            this.QTotalPrice_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QTotalPrice_TB.Size = new System.Drawing.Size(275, 28);
            this.QTotalPrice_TB.TabIndex = 1;
            this.QTotalPrice_TB.TabStop = false;
            this.QTotalPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QServOrderDesc_LBL
            // 
            this.QServOrderDesc_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QServOrderDesc_LBL.AutoSize = true;
            this.QServOrderDesc_LBL.ForeColor = System.Drawing.Color.Black;
            this.QServOrderDesc_LBL.Location = new System.Drawing.Point(79, 12);
            this.QServOrderDesc_LBL.Name = "QServOrderDesc_LBL";
            this.QServOrderDesc_LBL.Size = new System.Drawing.Size(188, 17);
            this.QServOrderDesc_LBL.TabIndex = 3;
            this.QServOrderDesc_LBL.Text = "SERVICE ORDER DESCRIPTION:";
            // 
            // QEqNum_LBL
            // 
            this.QEqNum_LBL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.QEqNum_LBL.AutoSize = true;
            this.QEqNum_LBL.ForeColor = System.Drawing.Color.Black;
            this.QEqNum_LBL.Location = new System.Drawing.Point(127, 53);
            this.QEqNum_LBL.Name = "QEqNum_LBL";
            this.QEqNum_LBL.Size = new System.Drawing.Size(140, 17);
            this.QEqNum_LBL.TabIndex = 3;
            this.QEqNum_LBL.Text = "EQUIPMENT NUMBER:";
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
            this.MainFormLayout_PNL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.MainFormLayout_PNL.Size = new System.Drawing.Size(1157, 884);
            this.MainFormLayout_PNL.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1158, 984);
            this.Controls.Add(this.MainFormLayout_PNL);
            this.Controls.Add(this.MainStatus_SB);
            this.Controls.Add(this.TitleBar_PNL);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(8750, 9444);
            this.MinimumSize = new System.Drawing.Size(1024, 840);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobility Setup Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainForm_Layout);
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
            this.OutputOrder_PNL.ResumeLayout(false);
            this.OutputOrder_PNL.PerformLayout();
            this.QuoteOutput_PNL.ResumeLayout(false);
            this.QuoteOutput_PNL.PerformLayout();
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
        private System.Windows.Forms.Label VNotDesc_LBL;
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
        public System.Windows.Forms.TextBox EquipmentSerial_TB;
        private System.Windows.Forms.TableLayoutPanel NotificationLayout;
        private System.Windows.Forms.Label SoldToParty_LBL;
        public System.Windows.Forms.TextBox PurchaseOrder_TB;
        private System.Windows.Forms.Label PurchaseOrder_LBL;
        public System.Windows.Forms.DateTimePicker RequiredStartDate_DP;
        public System.Windows.Forms.DateTimePicker RequiredEndDate_DP;
        public System.Windows.Forms.DateTimePicker PurchaseOrderDate_DP;
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
        private System.Windows.Forms.Label OutputEqDesc_LBL;
        public System.Windows.Forms.TextBox EquipmentOutput_TB;
        public System.Windows.Forms.TextBox DescriptionOutput_TB;
        public System.Windows.Forms.TextBox OutputSetupModule_TB;
        public System.Windows.Forms.TextBox CELNumberOutput_TB;
        public System.Windows.Forms.TextBox OutputWorkCentre_TB;
        public System.Windows.Forms.TextBox OutputWBS_TB;
        public System.Windows.Forms.TextBox OutputNotification_TB;
        public System.Windows.Forms.TextBox OutputServOrd_TB;
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
        public Mobility_Setup_Tool.ExComboBox VarTemplate_CB;
        public Mobility_Setup_Tool.ExComboBox VarTaskType_CB;
        public Mobility_Setup_Tool.ExComboBox VarSOPriority_CB;
        public Mobility_Setup_Tool.ExComboBox VarPMActivityType_CB;
        public Mobility_Setup_Tool.ExComboBox TemplateEquipmentList_CB;
        public Mobility_Setup_Tool.ExComboBox FunctionLoc_CB;
        public Mobility_Setup_Tool.ExComboBox TaskType_CB;
        public Mobility_Setup_Tool.ExComboBox PartyName_CB;
        public Mobility_Setup_Tool.ExComboBox PMActivityType_CB;
        public Mobility_Setup_Tool.ExComboBox Priority_CB;
        private Mobility_Setup_Tool.ExComboBox QuoteTemplate_CB;
        private System.Windows.Forms.Label PurchOrderDate_LBL;
        private System.Windows.Forms.Label ReqStartDate_LBL;
        private System.Windows.Forms.Label ReqEndDate_LBL;
        private System.Windows.Forms.Label TaskType_LBL;
        private System.Windows.Forms.Label FuncLoc_LBL;
        private System.Windows.Forms.Label QServOrderNum_LBL;
        private System.Windows.Forms.Label QQuoteNumber_LBL;
        private System.Windows.Forms.Label QQuoteTemplate_LBL;
        public System.Windows.Forms.TextBox OutputEqDesc_TB;
        private System.Windows.Forms.Label OutputSetupModule_LBL;
        private System.Windows.Forms.Label OutputEntryList_LBL;
        private System.Windows.Forms.Label OutputWorkCentre_LBL;
        private System.Windows.Forms.Label OutputWSB_LBL;
        private System.Windows.Forms.Label OutputNotNumber_LBL;
        private System.Windows.Forms.Label OutputServOrd_LBL;
        private System.Windows.Forms.Label OEqNum_LBL;
        public System.Windows.Forms.TextBox OutputEqNum_TB;
        public System.Windows.Forms.TextBox OutputEntryList_TB;
        private System.Windows.Forms.ToolStripMenuItem Dev_MN;
    }
}

