using SAPFEWSELib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static Mobility_Setup_Tool.MsgBoxs;
using Mobility_Setup_Tool.Forms;

public enum SETUP_MODULE: int
{
    OT_STANDARD_ZM12 = 0,
    OT_NRCCO_ZM03  = 1,
    OT_STANDARD_ZM25   = 2,
    UKNOWN = -1
}

public enum SETUP_TYPE
{
    SINGLE = 0,
    BULK = 1,
    VAR = 2
}

public struct SAP_VARS
{
    public string Description { get; set; }
    public string LongText { get; set; }
    public string Number { get; set; }
}

public struct INPUT_FIELD
{
    public string Number { get; set; }
    public string Name { get; set; }
    public string WC { get; set; }
}

public enum RESIZE_MODE
{
    LEFT = 0,
    RIGHT = 1,
    TOP = 2,
    BOTTOM = 3,
    BOTTOMLEFT = 4,
    BOTTOMRIGHT = 5,
    NONE = 6
};

namespace Mobility_Setup_Tool
{
    public partial class MainForm : Form
    {
        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        
        
        public RESIZE_MODE Mode = RESIZE_MODE.NONE;
        public bool Resizing = false;

        // Controllers
        private Module_ZM12 SetupModule;
        public QuoteConsole QuoteOutput;
        public Version      VersionController;
        public Theme        ThemeController = new Theme();
        public Databases    DatabaseController;
        public Settings     AppSettings;
        public DataTable    QuoteTable;
        public AUTOSAP      SapSession;

        // Settings
        public static bool   IsRunning            = false;
        public static bool   RunFullSetup         = false;
        public SETUP_TYPE    SetupType            = SETUP_TYPE.SINGLE;
        public List<SAP_VARS> Variations          = new List<SAP_VARS>();

        // Creation method
        public MainForm() {
            InitializeComponent();


            isTopPanelDragged = false;
        }

        // Control form output texts
        public string Output_EQDesc {
            set { SetText(DescriptionOutput_TB, value); }
            get { return GetText(DescriptionOutput_TB); }
        }

        public string Output_EQNum {
            set { SetText(EquipmentOutput_TB, value); }
            get { return GetText(EquipmentOutput_TB); }
        }

        public string Output_SetupMod {
            set { SetText(SetupModOutput_TB, value); }
            get { return GetText(SetupModOutput_TB); }
        }

        public string Output_CELNum {
            set { SetText(CELNumberOutput_TB, value); }
            get { return GetText(CELNumberOutput_TB); }
        }

        public string Output_WorkCenter {
            set { SetText(WorkCenterOutput_TB, value); }
            get { return GetText(WorkCenterOutput_TB); }
        }

        public string Output_WBS {
            set { SetText(WBSOutput_TB, value); }
            get { return GetText(WBSOutput_TB); }
        }

        public string Output_Notification {
            set { SetText(NotificationOutput_TB, value); }
            get { return GetText(NotificationOutput_TB); }
        }

        public string Output_ServiceOrder {
            set { SetText(SOOutput_TB, value); }
            get { return GetText(SOOutput_TB); }
        }

        public DateTime GetBasicStartDate 
        {
            get { return GetDateTime(BasicStartDate_DP); }
        }

        public DateTime GetEndStartDate {
            get { return GetDateTime(BasicEndDate_DP); }
        }

        public string StatusInfo {
            set { SetStatusProgress(StatusInfo_LBL, "text" ,value); }
        }

        #region METHODS

        // Get input from user
        public string GetInput(string Info, string Title, string Default)
        {
            string ReturnValue = "";

            using (InputBox UserInput = new InputBox(this))
            {
                UserInput.TBInformation.Text    = Info;
                UserInput.Input.Text            = Default;
                UserInput.Text                  = Title;
                UserInput.ShowDialog();

                ReturnValue = UserInput.Result;
            };
            
            return ReturnValue;
        }

        public bool SetStatus(string Text, int Progress) {

            if (Text == ""){
                SetStatusProgress(Progress_PB, "visible", false);
                SetStatusText(StatusText_LBL, "");
            }

            if (!Text.Contains("cancel") || Text != "") {

                SetStatusText(StatusText_LBL, Text);
                if (Progress > 0) {
                    SetStatusProgress(Progress_PB, "visible", true);
                    SetStatusProgress(Progress_PB, "value", Progress);
                }
                else {
                    SetStatusProgress(Progress_PB, "visible", false);
                }
            }

            if (InvokeRequired) {
                Invoke((MethodInvoker)delegate { Update(); });
            }
            else {
                this.Update();
            }
            return true;
        }

        // Cross threading methods for controls
        public string GetText(dynamic control) 
        {
            string strFolderName = "";
            control.Invoke((MethodInvoker)delegate { strFolderName = control.Text; });
            return strFolderName;
        }

        public int GetItems(ListBox control)
        {
            int itemcount = 0;
            control.Invoke((MethodInvoker)delegate { itemcount = control.Items.Count; });
            return itemcount;
        }

        public bool GetChecked(CheckBox control)
        {
            bool index = false;
            control.Invoke((MethodInvoker)delegate { index = control.Checked; });
            return index;
        }

        public int GetCBIndex(dynamic control) {
            int index = 0;
            control.Invoke((MethodInvoker)delegate { index = control.SelectedIndex; });
            return index;
        }

        public void SetStatusText(dynamic con, string val) { BeginInvoke((Action)(() => con.Text = val)); }

        delegate void SetControlValueCallback1(dynamic oControl, string propName, object propValue);
        private void SetStatusProgress(dynamic oControl, string propName, object propValue) {
            if (oControl.GetCurrentParent().InvokeRequired)
            {
                SetControlValueCallback1 d = new SetControlValueCallback1(SetStatusProgress);
                oControl.GetCurrentParent().Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        public void SetText(dynamic control, string val) {
            control.Invoke((MethodInvoker)delegate { control.Text = val; });
        }

        public void SetValue(dynamic control, int val) {
            control.Invoke((MethodInvoker)delegate { control.Value = val; });
        }

        public int GetValue(dynamic control) {
            int value = 0;

            control.Invoke((MethodInvoker)delegate { value = control.Value; });

            return value;
        }

        public SETUP_MODULE GetModuleNumber(string input, MobilityTask Task)
        {
            if(Task.Name != "")
            { 
                return input switch
                {
                    "OT_STANDARD_ZM12"  => SETUP_MODULE.OT_STANDARD_ZM12,
                    "OT_NRCCO_ZM03"     => SETUP_MODULE.OT_NRCCO_ZM03,
                    "OT_STANDARD_ZM25"  => SETUP_MODULE.OT_STANDARD_ZM25,
                    _                   => SETUP_MODULE.UKNOWN,
                };
            }
                else
            {
                SelectModule Window = new SelectModule(this);

                Window.ShowDialog();

                return Window.Modules_CMB.Text switch
                {
                    "ZM12" => SETUP_MODULE.OT_STANDARD_ZM12,
                    "ZM03" => SETUP_MODULE.OT_NRCCO_ZM03,
                    "ZM25" => SETUP_MODULE.OT_STANDARD_ZM25,
                    _ => SETUP_MODULE.UKNOWN,
                };
            }
        }

        public DateTime GetDateTime(DateTimePicker control) 
        {
            DateTime getValue = DateTime.Now;

            control.Invoke((MethodInvoker)delegate { getValue = control.Value; });

            return getValue;
        }

        // Check for variation blank fields
        private bool CheckBlankFields_Var(bool Full)
        {
            if(GetText(VarSerialNumber_TB) == "")
            {
                MsgBox_Error("Serial number field cannot be blank");
                return false;
            }

            if (GetText(VarTemplate_CB) == "")
            {
                MsgBox_Error("Please select a template equipment to use");
                return false;
            }

            if (GetText(VarTaskType_CB) == "")
            {
                MsgBox_Error("Please select a task to use");
                return false;
            }


            if (Full)
            {
                // Check variations are loaded
                if (GetItems(Variations_LB) <= 0)
                {
                    MsgBox_Error("Please load variations before continuing (enter serial number and double click the variations list box on the right)");
                    return false;
                }

                if (GetText(VarPMActivityType_CB) == "")
                {
                    MsgBox_Error("Please select an activity type");
                    return false;
                }

                if (GetText(VarSOPriority_CB) == "")
                {
                    MsgBox_Error("Please select an priority");
                    return false;
                }

                if (GetText(VarExternalReference_TB) == "")
                {
                    MsgBox_Error("Please enter an external reference");
                    return false;
                }

                if (GetDateTime(VarSOStartDate_DP) > DateTime.Now)
                {
                    MsgBox_Error("Start date cannot be after the current date");
                    return false;
                }

                if (GetDateTime(VarSOEndDate_DP) < GetDateTime(VarSOStartDate_DP))
                {
                    MsgBox_Error("End date cannot be before start date");
                    return false;
                }
            }
            return true;
        }

        // Check for blank fields on main setup
        private bool CheckBlankFields_Single(ref MobilityServiceOrder So)
        {
            if (GetText(EquipmentSerial_TB) == "")
            {
                if (MsgBox_Question("You have not entered a serial number, would you like to create a Service Order without an Equipment number?") == DialogResult.Yes)
                {
                    So.CreateWithoutEq = true;
                }
                else
                {
                    return false;
                }
            }

            if (GetText(TemplateEquipmentList_CB) == "")
            {
                MsgBox_Error("Please select a template equipment as the basis for the check");
                return false;
            }

            if (GetText(TaskType_CB) == "")
            {
                MsgBox_Error("Please select a task type");
                return false;
            }

            // Only if running the whole tooling
            if (RunFullSetup == true)
            {

                if (GetText(PartyName_CB) == "")
                {
                    MsgBox_Error("Please select a SoldToParty");
                    return false;
                }

                if (GetText(PurchaseOrder_TB) == "")
                {
                    MsgBox_Error("Please enter a Purchase Order number");
                    return false;
                }

                if (GetText(PMActivityType_CB) == "")
                {
                    MsgBox_Error("Please select a PM Activity Type");
                    return false;
                }

                if (GetText(Priority_CB) == "")
                {
                    MsgBox_Error("Please select a Service Order Priority");
                    return false;
                }

                if (GetText(ExternalReference_TB) == "")
                {
                    MsgBox_Error("Please enter a External Reference Number (if you do not have one enter N/A)");
                    return false;
                }
            }

            return true;
        }

        private bool VerifyInputs(ref MobilityEquipment Eq, ref MobilityServiceOrder So)
        {
            /*if (RunFullSetup == true) Doing this error checking on the fly now/
            {
                if (RequiredStartDate_DP.Value < DateTime.Now.AddDays(-1))
                {
                    MsgBox_Error("The Required Start Date cannot be in the past. Please ensure the Required Start Date is the same as the current date or after.");
                    return false;
                }

                if (RequiredStartDate_DP.Value > RequiredStartDate_DP.Value)
                {
                    MsgBox_Error("The Required Start Date cannot be greater the the Required End Date");
                    return false;
                }

                if (BasicStartDate_DP.Value < DateTime.Now.AddDays(-1))
                {
                    MsgBox_Error("The Basic Start Date cannot be in the past. Please ensure the Basic Start Date is the same as the current date or after.");
                    return false;
                }

                if (BasicStartDate_DP.Value > BasicEndDate_DP.Value)
                {
                    MsgBox_Error("The Basic Start Date cannot be greater the the Required End Date");
                    return false;
                }

                if (PurchaseOrderDate_DP.Value > DateTime.Now)
                {
                    MsgBox_Error("The Purchase Order Date cannot be in the future.");
                    return false;
                }
            }*/

            // Verify you want to create warranty service order
            if (WarrantyClaim_CHB.Checked && RunFullSetup)
            {
                if(MsgBox_Question($"Warranty Claim has been selected {Environment.NewLine}Are you sure you want to create a Warranty Claim Service Order?") == DialogResult.No)
                {
                    return false;
                }
            }

            bool Found = false;

            // Verify selection
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment1 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment2 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment3 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment4 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment5 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment6 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment7 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment8 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment9 == Eq.TemplateName) Found = true;
            if (DatabaseController.GetTask_ByName(GetText(TaskType_CB), true).Equipment10 == Eq.TemplateName) Found = true;


            if (!Found)
            {
                MsgBox_Error("The task you have selected is not compatible with this equipment!");
                return false;
            }

            return true;
        }

        // Variation setup
        private void VarSetup(MobilityTask              SelectedTask, 
                              MobilityServiceOrder      OrderInfo,
                              MobilityEquipment         SelectedEquipment, 
                              string                    NotificationNumber, 
                              List<SAPComponent>        Components)
        {
            // Check fields are filled
            switch (GetModuleNumber(SelectedTask.Module, SelectedTask))
            {
                // Standard setup
                case SETUP_MODULE.OT_STANDARD_ZM12:

                    Output_SetupMod = "OT_STANDARD_ZM12";
                    SetupModule     = new Module_ZM12();
                    SetupModule.SetMainForm(this);

                    break;

                // Standard setup
                case SETUP_MODULE.OT_STANDARD_ZM25:

                    Output_SetupMod = "OT_STANDARD_ZM25";
                    SetupModule     = new Module_ZM25();
                    SetupModule.SetMainForm(this);

                    break;

                // NR CCO
                case SETUP_MODULE.OT_NRCCO_ZM03:

                    Output_SetupMod = "OT_NRCCO_ZM03";
                    SetupModule     = new Module_NRENGINECCO();
                    SetupModule.SetMainForm(this);

                    break;

                case SETUP_MODULE.UKNOWN:
                    MsgBox_Error($"Setup module for task {SelectedTask.Name} is uknown please verify database entry for this task and ensure the correct setup module is entered");
                    break;

            }

            // Equipment setup
            if (SelectedEquipment.UpdateToTemplate)
            {
                if(!SetupModule.InitialEquipmentCheck(SelectedEquipment.TemplateNumber,
                                                      SelectedEquipment.SerialNumber.ToUpper(),
                                                      SelectedEquipment.ZAWA,
                                                      SelectedEquipment.FunctionLoc,
                                                      SingleSetup_BW,
                                                  ref SelectedEquipment))
                {
                    MsgBox_Error("Initial equipment check has failed");
                }
            }
            else
            {
                MsgBox_Normal("This equipment type is flagged as DO NOT UPDATE TO TEMPLATE, no changes will be made to the equipment.");
            }

            // Check measurements
            if (SetupModule.CheckMeasurementPoints(SelectedTask, SingleSetup_BW) == false)
            {
                if (SingleSetup_BW.CancellationPending) {
                    MsgBox_Normal("User cancelled");
                }
                return;
            }

            // Create CEL
            if (SelectedTask.CEL != "NONE" && SelectedTask.CEL != "NON-STANDARD VARIATION" && SelectedTask.CEL != null)
            { 
                if (SetupModule.CreateEntryList(SelectedTask, SingleSetup_BW) == false)
                {
                    if (SingleSetup_BW.CancellationPending) {
                        MsgBox_Normal("User cancelled");
                    }
                    return;
                }
            }
                else
            {
                // Only if we are doing equipment check, stop here is no CEL is required
                if(!RunFullSetup)
                { 
                    MsgBox_Normal("There is no template CEL for this tasklist, equipment check complete!");
                    return;
                }
            }

            if(RunFullSetup)
            {
                // Get long text
                GetLongText LText = new GetLongText(this)
                {
                    LongText = LongText_TB.Text
                };

                LText.ShowDialog();

                SelectedTask.LongText = LText.LongText;

                // Check notification and create service order
                if (SetupModule.CreateServiceOrderFromNotification(SelectedTask, SelectedEquipment, OrderInfo, Components, NotificationNumber, SingleSetup_BW) == false)
                {
                    if (SingleSetup_BW.CancellationPending) {
                        MsgBox_Normal("User cancelled");
                    }
                    return;
                }
            }
            else
            {
                MsgBox_Normal("Equipment setup completed successfully!");
            }
        }

        // Initial overhaul setup
        private void Setup(MobilityTask SelectedTask, MobilityServiceOrder OrderInfo, MobilityEquipment SelectedEquipment, List<SAPComponent> Components)
        {
            // Check fields are filled
            switch (GetModuleNumber(SelectedTask.Module, SelectedTask)) 
            {
                // Standard setup
                case SETUP_MODULE.OT_STANDARD_ZM12:

                    Output_SetupMod = "OT_STANDARD_ZM12";
                    SetupModule = new Module_ZM12();
                    SetupModule.SetMainForm(this);

                    break;

                // Standard setup
                case SETUP_MODULE.OT_STANDARD_ZM25:

                    Output_SetupMod = "OT_STANDARD_ZM25";
                    SetupModule = new Module_ZM25();
                    SetupModule.SetMainForm(this);

                    break;

                 // NR CCO
                case SETUP_MODULE.OT_NRCCO_ZM03:

                    Output_SetupMod = "OT_NRCCO_ZM03";
                    SetupModule = new Module_NRENGINECCO();
                    SetupModule.SetMainForm(this);

                    break;


                case SETUP_MODULE.UKNOWN:
                    MsgBox_Error($"Setup module for task {SelectedTask.Name} is uknown please verify database entry for this task and ensure the correct setup module is entered");
                    break;

            }

            // Equipment setup
            if (SelectedEquipment.UpdateToTemplate)
            {
                if (!SetupModule.InitialEquipmentCheck(SelectedEquipment.TemplateNumber,
                                                       SelectedEquipment.SerialNumber.ToUpper(),
                                                       SelectedEquipment.ZAWA,
                                                       SelectedEquipment.FunctionLoc,
                                                       SingleSetup_BW,
                                                   ref SelectedEquipment)) 
                {
                    MsgBox_Error("Initial equipment check has failed");
                }
            } 
            else 
            {
                MsgBox_Normal("This equipment type is flagged as DO NOT UPDATE TO TEMPLATE, no changes will be made to the equipment.");
            }

            // Check measurements
            if (SetupModule.CheckMeasurementPoints(SelectedTask, SingleSetup_BW) == false) 
            {
                if (SingleSetup_BW.CancellationPending) MsgBox_Normal("User cancelled");
                return;
            }

            // Create CEL
            if (SetupModule.CreateEntryList(SelectedTask, SingleSetup_BW) == false) 
            {
                if (SingleSetup_BW.CancellationPending) MsgBox_Normal("User cancelled");
                return;
            }

            // Do service order setup
            if (RunFullSetup == true) 
            {
                // Get long text
                GetLongText LText = new GetLongText(this);
                
                LText.LongText = SelectedTask.LongText;
                LText.ShowDialog();

                SelectedTask.LongText = LText.LongText;

                // Check service order can be setup
                if (!SetupModule.InitialServiceCheck(SelectedTask, SelectedEquipment.EquipmentNumber, SingleSetup_BW)) 
                {
                    if (SingleSetup_BW.CancellationPending) MsgBox_Normal("User cancelled");
                    return;
                }

                // Create notification
                if (!SetupModule.CreateNotification(SelectedTask, SelectedEquipment, OrderInfo, SingleSetup_BW)) 
                {
                    if (SingleSetup_BW.CancellationPending) MsgBox_Normal("User cancelled");
                    return;
                }

                // Create service order
                if (!SetupModule.CreateServiceOrder(SelectedTask, SelectedEquipment, OrderInfo, Components, SingleSetup_BW)) 
                {
                    if (SingleSetup_BW.CancellationPending) MsgBox_Normal("User cancelled");
                    return;
                }

            } 
            else 
            {
                MsgBox_Normal("Equipment setup completed successfully!");
            }
        }

        #endregion

        #region FORM & CONTROL EVENTS

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 12;

            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12;
                            else
                                m.Result = (IntPtr)14;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2;
                            else
                                m.Result = (IntPtr)11;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15;
                            else
                                m.Result = (IntPtr)17;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) 
        {
            // Create controller instances
            AppSettings         = new Settings(ThemeController, this);
            DatabaseController  = new Databases(this);
            SapSession          = new AUTOSAP(this);
            //QuoteOutput         = new QuoteConsole(this);
            //QuoteOutput.Hide();

            

            // Set defaults
            AppSettings.LoadSettings();

            // Set field defaults
            FunctionLoc_CB.Text             = AppSettings.ADefaults.FunctionLocation;
            PartyName_CB.Text               = AppSettings.ADefaults.SoldToParty;
            PMActivityType_CB.Text          = AppSettings.ADefaults.PmActivityType;
            Priority_CB.Text                = AppSettings.ADefaults.Priority;
            ExternalReference_TB.Text       = AppSettings.ADefaults.ExternalReference;
            VarPMActivityType_CB.Text       = AppSettings.ADefaults.PmActivityType;
            VarSOPriority_CB.Text           = AppSettings.ADefaults.Priority;
            VarExternalReference_TB.Text    = AppSettings.ADefaults.ExternalReference;

            // Theme settings
            ThemeController.AddControls(CloseButton_LBL, "border");
            ThemeController.AddControls(MinimizeButton_LBL, "border");
            ThemeController.AddControls(MaximizeButton_LBL, "border");
            ThemeController.AddControls(this, "background");
            ThemeController.AddControls(TitleBar_PNL, "border");

            // Set to a default
            ThemeController.SetThemeColor(Color.FromArgb(35, 71, 92), Color.FromArgb(85, 155, 189));

            // Try to load theme file & Refresh
            ThemeController.LoadTheme();
            ThemeController.RefreshTheme();

            // Load databases
            DatabaseController.Load();

            // Hide progress bar
            SetStatusProgress(Progress_PB, "visible", false);
            CheckSAP_Tick(this, null);
        }

        // Equipment list combobox text changed event 
        private void TemplateEquipmentList_CB_TextChanged(object sender, EventArgs e) 
        {
            // If there is text in the field
            if (TemplateEquipmentList_CB.Text != "")
            {
                // Clear combobox
                TaskType_CB.Items.Clear();

                List<MobilityTask> LeadTasks = DatabaseController.GetTasks(true);

                // Search for matching equipment name in task data table and add to task list combo
                for (int Row = 0; Row < LeadTasks.Count(); Row++) 
                {
                    if (LeadTasks[Row].Equipment1 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment2 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment3 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment4 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment5 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment6 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment7 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment8 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment9 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                    if (LeadTasks[Row].Equipment10 == TemplateEquipmentList_CB.Text) TaskType_CB.Items.Add(LeadTasks[Row].Name);
                }
            }
        }

        // Equipment serial numbert text changed event 
        private void EquipmentSerial_TB_TextChanged(object sender, EventArgs e) 
        {
            string SerialCheck = EquipmentSerial_TB.Text;

            if (SerialCheck.Contains(" ")) MsgBox_Error("SAP serial numbers cannot contain blank spaces! please remove the spaces.");
        }

        // Options menu click event 
        private void FileOptions_Click(object sender, EventArgs e) 
        {
            AppSettings Settings = new AppSettings(this);
            Settings.ShowInTaskbar = false;
            Settings.ShowDialog();
        }

        // Setup equipment button click event 
        private void SetupEquipment_BTN_Click(object sender, EventArgs e)
        { 
            if (!IsRunning) 
            {
                RunFullSetup = false;
                IsRunning = true;
                SetupType = SETUP_TYPE.SINGLE;
                SingleSetup_BW.RunWorkerAsync();
            } 
                else 
            {
                MsgBox_Error("Tool is already running in the background, please stop the tool to re-run");
            }
        }

        // Setup equipment button click event 
        private void VarSetupEquipment_BTN_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                RunFullSetup = false;
                IsRunning = true;
                SetupType = SETUP_TYPE.VAR;
                SingleSetup_BW.RunWorkerAsync();
            }
            else
            {
                MsgBox_Error("Tool is already running in the background, please stop the tool to re-run");
            }
        }

        // Variation service orders 
        private void CreateVariationOrder_BTN_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                RunFullSetup = true;
                IsRunning = true;
                SetupType = SETUP_TYPE.VAR;
                SingleSetup_BW.RunWorkerAsync();
            }
            else
            {
                MsgBox_Error("Tool is already running in the background, please stop the tool to re-run");
            }
        }

        // Raise service order button click event 
        private void RaiseServiceOrder_BT_Click(object sender, EventArgs e)
        {
            if (!IsRunning) 
            {
                RunFullSetup = true;
                IsRunning = true;
                SetupType = SETUP_TYPE.SINGLE;
                SingleSetup_BW.RunWorkerAsync();
            } 
                else  
            {
                MsgBox_Error("Tool is already running in the background, please stop the tool to re-run");
            }
        }

        // Stop macro menu button click event 
        private void StopAuto_MN_Click(object sender, EventArgs e) 
        {
            IsRunning = false;
            SingleSetup_BW.CancelAsync(); 
        }

        // Background worker DoWork event 
        private void SingleSetup_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MobilityEquipment    InputEq    = new MobilityEquipment();
            MobilityServiceOrder InputSO    = new MobilityServiceOrder();
            MobilityTask         InputTask  = new MobilityTask();

            // Reset outputs
            Output_CELNum           = "";
            Output_EQDesc           = "";
            Output_EQNum            = "";
            Output_Notification     = "";
            Output_ServiceOrder     = "";
            Output_SetupMod         = "";
            Output_WBS              = "";
            Output_WorkCenter       = "";

            switch (SetupType) 
            {
                case SETUP_TYPE.SINGLE:

                    // Check fro blank fields
                    if (CheckBlankFields_Single(ref InputSO))
                    {
                        // Get task info
                        InputTask                   = DatabaseController.GetTask_ByName(GetText(TaskType_CB), true);
                        InputTask.WarrantyClaim     = GetChecked(WarrantyClaim_CHB);

                        // Get input equipment info
                        InputEq.TemplateNumber      = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).EquipmentNumber;
                        InputEq.TemplateName        = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).Description;
                        InputEq.UpdateToTemplate    = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).UpdateToTemplate;
                        InputEq.ZDI1                = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).ZDI1;
                        InputEq.ZAWA                = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).ZAWA;
                        InputEq.FunctionLoc         = GetText(FunctionLoc_CB);
                        InputEq.SerialNumber        = GetText(EquipmentSerial_TB);

                        // Get input service order info
                        InputSO.ActualStartDate     = RequiredStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.ActualEndDate       = RequiredStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.PurchaseOrderDate   = PurchaseOrderDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.BasicStartDate      = BasicStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.BasicEndDate        = BasicEndDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.CustomerName        = GetText(PartyName_CB);
                        InputSO.PurchaseOrder       = GetText(PurchaseOrder_TB);
                        InputSO.ActivityType        = GetText(PMActivityType_CB);
                        InputSO.Priority            = GetText(Priority_CB);
                        InputSO.ExternalReference   = GetText(ExternalReference_TB);
                     
                        Output_WBS                  = InputTask.WBS;
                        Output_WorkCenter           = InputTask.Workcentre;

                        if (RunFullSetup == true) 
                        {
                            INPUT_FIELD Sales       = DatabaseController.GetSalesData_ByWorkCenter(InputTask.Workcentre);

                            InputSO.SalesGroup      = Sales.Name;
                            InputSO.SalesOffice     = Sales.Number;
                            InputSO.SoldToParty     = DatabaseController.GetCustomer_ByName(InputSO.CustomerName).Number;
                            InputSO.ActivityType    = DatabaseController.GetActivity_ByName(InputSO.ActivityType).Number;

                            if(InputSO.SalesGroup == "" || InputSO.SalesOffice == "" || InputSO.SoldToParty == "" || InputSO.ActivityType == "")
                            {
                                MsgBox_Error("Error finding service order data");
                                return;
                            }
                        }

                        // Verify data and run setup
                        if (VerifyInputs(ref InputEq, ref InputSO)) 
                        { 
                            Setup(InputTask, InputSO, InputEq, null);    
                        }
                    }

                    break;

                case SETUP_TYPE.VAR:

                    if(CheckBlankFields_Var(RunFullSetup))
                    {
                        // Get task info
                        InputTask                   = DatabaseController.GetTask_ByName(GetText(VarTaskType_CB),false);
                        InputTask.WarrantyClaim     = false;

                        // Get input equipment info
                        InputEq.TemplateNumber      = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).EquipmentNumber;
                        InputEq.TemplateName        = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).Description;
                        InputEq.UpdateToTemplate    = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).UpdateToTemplate;
                        InputEq.ZDI1                = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).ZDI1;
                        InputEq.ZAWA                = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).ZAWA;
                        InputEq.SerialNumber        = GetText(VarSerialNumber_TB);

                        // Get input service order info
                        InputSO.BasicStartDate      = VarSOStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.BasicEndDate        = VarSOEndDate_DP.Value.ToShortDateString().Replace("/", ".");
                        InputSO.ActivityType        = GetText(VarPMActivityType_CB);
                        InputSO.Priority            = GetText(VarSOPriority_CB);
                        InputSO.ExternalReference   = GetText(VarExternalReference_TB);

                        // Sales data
                        if (RunFullSetup == true)
                        {
                            INPUT_FIELD Sales = DatabaseController.GetSalesData_ByWorkCenter(InputTask.Workcentre);

                            InputSO.SalesGroup      = Sales.Name;
                            InputSO.SalesOffice     = Sales.Number;
                            InputSO.ActivityType    = DatabaseController.GetActivity_ByName(InputSO.ActivityType).Number;

                            if (InputSO.SalesGroup == "" || InputSO.SalesOffice == ""  || InputSO.ActivityType == "")
                            {
                                MsgBox_Error("Error finding service order data");
                                return;
                            }
                        }

                        // Full setup
                        if (RunFullSetup)
                        {
                            List<SAPComponent> Components = null;

                            if (InputTask.Group == "")
                            { 
                                if (MsgBox_Question("Do you want to add components to this variation?") == DialogResult.Yes) 
                                {
                                    Components = GetParts(GetText(VarTaskType_CB));
                                }
                            }

                            VarSetup(InputTask, InputSO, InputEq, Variations[GetCBIndex(Variations_LB)].Number, Components);
                        }
                            else
                        {
                            VarSetup(InputTask, InputSO, InputEq, "", null);
                        }
                    }

                    break;

                default:
                    MsgBox_Error("Setup type is uknown!");
                    break;
            }
        }

        // Parts picker 
        public List<SAPComponent> GetParts(string PartTemplate)
        {
            // Get parts list tab from database 
            string Tab = DatabaseController.GetQuotingPartsTab_ByName(PartTemplate);

            PartsSelector Parts = new PartsSelector(this);

            if (Tab != "")
            {
                // Load info 
                ExcelDataTables ExcelManager = new ExcelDataTables();
                QuoteTable                   = ExcelManager.ConvertExcelToDataTable_Name(AppSettings.Defaults.QuotePath, Tab);

                // Could not find tab 
                if (QuoteTable == null) MsgBox_Error("Error opening Quoting Database, please restart application &/or computer");

                // Load filters 
                Parts.LoadFilters(QuoteTable);

                // Clear list 
                Parts.Parts_DGV.Rows.Clear();

                // Add to list 
                for (int i = 1; i < QuoteTable.Rows.Count; i++)
                {
                    Parts.Parts_DGV.Rows.Add();

                    Parts.Parts_DGV[1, i - 1].Value = QuoteTable.Rows[i][0].ToString();
                    Parts.Parts_DGV[2, i - 1].Value = QuoteTable.Rows[i][3].ToString();
                    Parts.Parts_DGV[3, i - 1].Value = QuoteTable.Rows[i][1].ToString();
                    
                }
            }
            else
            {
                //MsgBox_Error($"Cannot find quoting variations for {QuoteTemplate_CB.Text}");
                return null;
            }

            Parts.ShowDialog();

            return Parts.GetSelectedComponents();

        }

        // Close button label mouse enter event 
        public virtual void CloseButton_LBL_MouseEnter(object sender, EventArgs e) 
        {
            General_TT.SetToolTip((Label)sender, "Close");
            CloseButton_LBL.BackColor = ThemeController.GetBackcolor(); 
        }

        // Close button label mouse leave event 
        public virtual void CloseButton_LBL_MouseLeave(object sender, EventArgs e) 
        { 
            CloseButton_LBL.BackColor = ThemeController.GetBordercolor(); 
        }

        // Close button label mouse down 
        public virtual void CloseButton_LBL_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left) Close();
        }

        // Minimize button label mouse down event 
        public virtual void MiniButton_LBL_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)  WindowState = FormWindowState.Minimized;
        }

        // Minimize button label mouse enter event 
        private void MiniButton_LBL_MouseEnter(object sender, EventArgs e) 
        {
            General_TT.SetToolTip((Label)sender, "Minimize");
            MinimizeButton_LBL.BackColor = ThemeController.GetBackcolor(); 
        }

        // Minimize button label mouse leave event 
        public virtual void MiniButton_LBL_MouseLeave(object sender, EventArgs e) 
        { 
            MinimizeButton_LBL.BackColor = ThemeController.GetBordercolor(); 
        }

        // Maximize button mouse enter event 
        public virtual void MaxButton_LBL_MouseEnter(object sender, EventArgs e) 
        {
            General_TT.SetToolTip((Label)sender, "Maximize");
            MaximizeButton_LBL.BackColor = ThemeController.GetBackcolor();
        }


        // Maximize button label mouse leave event 
        public virtual void MaxButton_LBL_MouseLeave(object sender, EventArgs e) 
        { 
            MaximizeButton_LBL.BackColor = ThemeController.GetBordercolor();
        }

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen       BorderPen  = new Pen(ThemeController.GetBordercolor(), 1.0f);
            Brush     Fill       = BorderPen.Brush;
            Graphics  FormGFX    = e.Graphics;
            Rectangle FormBorder,
                      OutputBorder,
                      TabsBorder;

            // Get rect
            FormBorder   = new Rectangle(ClientRectangle.X,
                                         ClientRectangle.Y, 
                                         ClientRectangle.Width - 1, 
                                         ClientRectangle.Height - 1);

            OutputBorder = new Rectangle(Output_PNL.Location.X - 1,
                                         Output_PNL.Location.Y + 67,
                                         Output_PNL.Width + 1,
                                         Output_PNL.Height + 1);
            
            TabsBorder   = new Rectangle(DataTabs_TC.Location.X - 1,
                                         DataTabs_TC.Location.Y + 92,
                                         DataTabs_TC.Width + 1,
                                         DataTabs_TC.Height - 24);

            // Draw rectangles
            FormGFX.DrawRectangle(BorderPen, TabsBorder);
            FormGFX.FillRectangle(Fill, TabsBorder);
            FormGFX.DrawRectangle(BorderPen, OutputBorder);
            FormGFX.FillRectangle(Fill, OutputBorder);
            FormGFX.DrawRectangle(BorderPen, FormBorder);
        }

        // Title movements
        public virtual void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;

            }
        }

        // Move window
        public virtual void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged        = true;
                Point pointStartPosition = PointToScreen(new Point(e.X, e.Y));

                offset = new Point
                {
                    X = Location.X - pointStartPosition.X,
                    Y = Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                //_MaxButton_Click(sender, e);
            }
        }

        public virtual void Title_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
        }

        // Maximize button label mouse down event 
        public virtual void MaxButton_LBL_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left) 
            {
                if (WindowState == FormWindowState.Maximized) 
                {
                    WindowState = FormWindowState.Normal;
                    MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MS")));
                } else 
                {
                    WindowState = FormWindowState.Maximized;
                    MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MF")));
                }
            }
        }

        // Title bar double click event 
        public virtual void TitleBar_DoubleClick(object sender, EventArgs e) 
        {
            if (WindowState == FormWindowState.Maximized) 
            {
                WindowState = FormWindowState.Normal;
                MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MS")));
            } 
            else 
            {
                WindowState = FormWindowState.Maximized;
                MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MF")));
            }
        }

        // Titlebar mouse move event 
        public virtual void TitleBar_MouseMove(object sender, MouseEventArgs e) 
        {
            if (isTopPanelDragged) 
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;
            }
        }

        // Titlebar mouse down event 
        public virtual void TitleBar_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left) 
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            } 
            else 
            {
                isTopPanelDragged = false;
            }

            // Double click to drag
            if (e.Clicks == 2) 
            {
                if (WindowState == FormWindowState.Maximized) 
                {
                    WindowState = FormWindowState.Normal;
                }
                else 
                { 
                    WindowState = FormWindowState.Maximized;
                }

                isTopPanelDragged = false;
            }
        }

        // Titlebar mouse down event 
        public virtual  void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        // Exit menu button click event 
        private void Exit_MN_Click(object sender, EventArgs e) { Close(); }

        // Main form key down event 
        private void MainForm_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Escape && IsRunning) {
                SingleSetup_BW.CancelAsync();
                SetStatus("Cancelling..", 0);
            }
        }

        // Background work completed event 
        private void SingleSetup_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) 
        {
            IsRunning = false;
            SetStatus("", 0);
        }

        // SAP verify timer Tick event 
        private void CheckSAP_Tick(object sender, EventArgs e) 
        {
            // Only if tool is currently idling
            if (!IsRunning) 
            { 
                if (SapSession.GetSession()) 
                {
                    StatusInfo_LBL.Text = "SAP Connected";
                    StatusInfo_LBL.ForeColor = Color.DarkGreen;
                } else 
                {
                    StatusInfo_LBL.Text = "SAP Disconnected";
                    StatusInfo_LBL.ForeColor = Color.DarkRed;
                }
            }
        }

        // Variations list box selection changed event 
        private void Variations_LB_SelectionIndexChanged(object sender, EventArgs e) 
        {
            if (Variations_LB.SelectedIndex > -1) 
            {
                LongText_LBL.Text = $"LONG TEXT - {Variations[Variations_LB.SelectedIndex].Number}";
                LongText_TB.Text = Variations[Variations_LB.SelectedIndex].LongText;
            }
        }

        // Variation template combo box text change event 
        private void VarTemplate_CB_TextChanged(object sender, EventArgs e)
        {
            // Clear combobox
            VarTaskType_CB.Items.Clear();

            // Search for matching equipment name in task data table and add to task list combo
            for (int Row = 0; Row < DatabaseController.GetTasks(false).Count(); Row++) 
            {
                if (DatabaseController.GetTasks(false)[Row].Equipment1 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment2 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment3 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment4 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment5 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment6 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment7 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment8 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment9 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
                if (DatabaseController.GetTasks(false)[Row].Equipment10 == VarTemplate_CB.Text) VarTaskType_CB.Items.Add(DatabaseController.GetTasks(false)[Row].Name);
            }

            VarTaskType_CB.Items.Add("NON-STANDARD VARIATION");
        }

        #endregion

        private void ResyncDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings.ResetSettings();
            AppSettings.GetSharepointData();
            AppSettings.LoadSettings();
            DatabaseController.Load();

            MsgBox_Normal("Reset settings, re-sync data completed");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionHistory Versions = new VersionHistory(this);

            Versions.Show();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Clear task type if template equipent is empty
        private void TemplateEquipment_CB_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(((ComboBox)sender).Text == "")
                {
                    TaskType_CB.Items.Clear();
                }
            }
        }

        private void PODate_ValueChanged(object sender, EventArgs e)
        {
            if (PurchaseOrderDate_DP.Value.CompareTo(DateTime.Today) == 1)
            {
                MsgBox_Warning("You cannot enter a date greater than the current date!");
                PurchaseOrderDate_DP.Value = DateTime.Today.AddDays(-1.0);
            }
        }

        private void BasicStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (BasicStartDate_DP.Value.CompareTo(BasicEndDate_DP.Value) == 1)
            {
                MsgBox_Warning("You cannot enter a date greater than the planned end date!");
                BasicStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
            }
        }

        private void BasicEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (BasicEndDate_DP.Value.CompareTo(BasicStartDate_DP.Value) == -1)
            {
                MsgBox_Warning("You cannot enter a date less than the planned start date!");
                BasicEndDate_DP.Value = DateTime.Today.AddDays(10.0);
            }
        }

        private void ReqStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the planned start date to the required start date
            BasicStartDate_DP.Value = RequiredStartDate_DP.Value;

            // Check
            if (RequiredStartDate_DP.Value.CompareTo(RequiredEndDate_DP.Value) == 1)
            {
                MsgBox_Warning("Required start date cannot be greater than required end date");
                RequiredStartDate_DP.Value = DateTime.Today;
            }
        }

        private void ReqEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the planned start date to the required start date
            BasicEndDate_DP.Value = RequiredEndDate_DP.Value;

            if (RequiredEndDate_DP.Value.CompareTo(RequiredStartDate_DP.Value) == -1)
            {
                MsgBox_Warning("Required end date cannot be less than required start date");
                RequiredEndDate_DP.Value = DateTime.Today.AddDays(10.0);
            }
        }

        // Draw a box around the longtext RTB
        private void RightSide_TBL_Paint(object sender, PaintEventArgs e)
        {
            Point TBLoc = LongText_TB.Location;

            using (Pen BorderPen = new Pen(Color.FromArgb(130,135,144), 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 
                                         TBLoc.X - 1, 
                                         TBLoc.Y - 1,
                                         LongText_TB.Width + 2, 
                                         LongText_TB.Height + 2);
            };
        }

        private void LoadVariation_BTN_Click(object sender, EventArgs e)
        {
            string          EqNumber, SerialNumber;
            ExcelDataTables TableManager            = new ExcelDataTables();
            SerialNumber                            = GetText(VarSerialNumber_TB);

            if (SerialNumber != "" && !SerialNumber.Contains(" "))
            {
                if (SapSession.GetSession())
                {
                    _ = SetStatus("Getting equipment details", 0);

                    // Convert serial to equipment number
                    EqNumber = SapSession.EquipmentNumberFromSerial(SerialNumber);

                    // Verify we have got the equipment number
                    if (EqNumber != "NO EQUIPMENT FOUND")
                    {
                        Variations_LB.Items.Clear();
                        Variations.Clear();

                        SapSession.StartTransaction("ZIW58");
                        SapSession.SetVariant("/FSDS-25-32");
                        SapSession.GetButton("%_QMART_%_APP_%-VALU_PUSH").Press();
                        GuiModalWindow Popup = (GuiModalWindow)SapSession.GetFormById("wnd[1]");
                        ((GuiButton)Popup.FindById("tbar[0]/btn[16]")).Press();
                        ((GuiButton)Popup.FindById("tbar[0]/btn[8]")).Press();
                        SapSession.GetCTextField("QMART-LOW").Text = "Z3";
                        SapSession.GetCTextField("EQUNR-LOW").Text = EqNumber;

                        // Set to not show converted notification
                        SapSession.GetCTextField("AUFNR-LOW").SetFocus();
                        SapSession.SendVKey(2);
                        SapSession.SendVKey(0);

                        SapSession.SendVKey(8);

                        _ = SetStatus("Loading notifications", 0);

                        switch (SapSession.GetSessionInfo().ScreenNumber)
                        {
                            // One notification
                            case 7200:
                                SAP_VARS _add = new SAP_VARS
                                {
                                    LongText = SapSession.GetShell("shell").Text,
                                    Description = SapSession.GetTextField("VIQMEL-QMTXT").Text,
                                    Number = SapSession.GetTextField("VIQMEL-QMNUM").Text
                                };


                                Variations.Add(_add);
                                Variations_LB.Items.Add(Variations[0].Description);

                                MsgBox_Normal("Notification loaded");
                                _ = SetStatus("", 0);

                                break;

                            // Multiple notifications
                            case 500:
                                ((GuiMenu)SapSession.GetFormById("wnd[0]/mbar/menu[0]/menu[11]/menu[2]")).Select();
                                SapSession.SendVKey(0);

                                // Filename popup
                                Popup = (GuiModalWindow)SapSession.GetFormById("wnd[1]");
                                ((GuiCTextField)Popup.FindByName("DY_PATH", "GuiCTextField")).Text          = Environment.GetEnvironmentVariable("TEMP");
                                ((GuiCTextField)Popup.FindByName("DY_FILENAME", "GuiCTextField")).Text      = $"IW58DUMP{EqNumber}.txt";
                                ((GuiButton)Popup.FindById("tbar[0]/btn[11]")).Press();

                                // Add to list
                                DataTable VariationList = TableManager.ControlTexttoDataTable_IW58(Environment.GetEnvironmentVariable("TEMP") + $"\\IW58DUMP{EqNumber}.txt");

                                for (int i = 0; i < VariationList.Rows.Count; i++)
                                {
                                    SAP_VARS _madd = new SAP_VARS
                                    {
                                        Description = VariationList.Rows[i]["Description"].ToString(),
                                        Number      = VariationList.Rows[i]["Notification"].ToString()
                                    };

                                    SapSession.StartTransaction("IW52");
                                    SapSession.GetCTextField("RIWO00-QMNUM").Text = _madd.Number;
                                    SapSession.SendVKey(0);

                                    _madd.LongText = SapSession.GetShell("shell").Text;

                                    Variations.Add(_madd);

                                    Variations_LB.Items.Add(Variations[i].Description);
                                }

                                VariationList.Dispose();

                                MsgBox_Normal("Notifications loaded");
                                _ = SetStatus("", 0);
                                break;

                            default:
                                MsgBox_Error("No unconverted notifications found");
                                _ = SetStatus("", 0);
                                break;
                        }

                    }
                    else
                    {
                        MsgBox_Error($"No equipment number found for serial {SerialNumber}");
                        _ = SetStatus("", 0);
                    }
                }
                else
                {
                    MsgBox_Error("Please ensure SAP is running");
                    _ = SetStatus("", 0);
                }
            }
            else
            {
                MsgBox_Error("Please enter a serial number to get the variation list");
                _ = SetStatus("", 0);
            }
        }

        // Change output information depending on tab page selection
        private void DataTabs_TC_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Quote tab
            if (e.TabPageIndex > 1)
            {
                QuoteOutput_PNL.Visible = true;
                OutputOrder_PNL.Visible = false;
            }
            // Orders tabs
                else
            {
                QuoteOutput_PNL.Visible = false;
                OutputOrder_PNL.Visible = true;
            }
        }

        private void VarBasicEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (VarSOEndDate_DP.Value.CompareTo(VarSOStartDate_DP.Value) == -1)
            {
                MsgBox_Warning("You cannot enter a date less than the planned start date!");
                VarSOEndDate_DP.Value = DateTime.Today.AddDays(10.0);
            }
        }

        private void VarBasicStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (VarSOStartDate_DP.Value.CompareTo(VarSOEndDate_DP.Value) == 1)
            {
                MsgBox_Warning("You cannot enter a date greater than the planned end date!");
                VarSOStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
            }
        }
    }
}
