using Mobility_Setup_Tool.Forms;
using SAPFEWSELib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using static Mobility_Setup_Tool.MsgBoxs;

public enum SETUP_MODULE : int
{
    OT_STANDARD_ZM12 = 0,
    OT_NRCCO_ZM03 = 1,
    OT_STANDARD_ZM25 = 2,
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

namespace Mobility_Setup_Tool
{
    public partial class MainForm : Form
    {
        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        public Point Start;
        public bool FromMax;
        public bool Restart = false;

        // Controllers
        private Module_ZM12 SetupModule;
        public QuoteOutput  Quoter;
        public Version      VersionController;
        public Theme        ThemeController = new Theme();
        public Databases    DatabaseController;
        public Settings     AppSettings;
        public DataTable    QuoteTable;
        public AUTOSAP      SapSession;

        // Settings
        public static bool      IsRunning       = false;
        public static bool      RunFullSetup    = false;
        public SETUP_TYPE       SetupType       = SETUP_TYPE.SINGLE;
        public List<SAP_VARS>   Variations      = new List<SAP_VARS>();
        public InitialInputs[]  SapInputLists   = new InitialInputs[9999];

        // Creation method
        public MainForm()
        {
            InitializeComponent();
            isTopPanelDragged = false;

            // Turn on dev mode
            Dev_MN.Visible = Program.DeveloperMode;

            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region OUTPUTS / INPUT VARIABLES

        /*
         * Provide access to input & output controls on the MainForm
         */

        public string Output_EQDesc
        {
            set { SetText(OutputEqDesc_TB, value); }
            get { return GetText(OutputEqDesc_TB); }
        }

        public string Output_EQNum
        {
            set { SetText(OutputEqNum_TB, value); }
            get { return GetText(OutputEqNum_TB); }
        }

        public string Output_SetupMod
        {
            set { SetText(OutputSetupModule_TB, value); }
            get { return GetText(OutputSetupModule_TB); }
        }

        public string Output_CELNum
        {
            set { SetText(OutputEntryList_TB, value); }
            get { return GetText(OutputEntryList_TB); }
        }

        public string Output_WorkCenter
        {
            set { SetText(OutputWorkCentre_TB, value); }
            get { return GetText(OutputWorkCentre_TB); }
        }

        public string Output_WBS
        {
            set { SetText(OutputWBS_TB, value); }
            get { return GetText(OutputWBS_TB); }
        }

        public string Output_Notification
        {
            set { SetText(OutputNotification_TB, value); }
            get { return GetText(OutputNotification_TB); }
        }

        public string Output_ServiceOrder
        {
            set { SetText(OutputServOrd_TB, value); }
            get { return GetText(OutputServOrd_TB); }
        }

        public string QOutput_ServiceOrderDesc
        {
            set { SetText(QServiceOrder_TB, value); }
            get { return GetText(QServiceOrder_TB); }
        }

        public string QOutput_EQNum
        {
            set { SetText(QEquipmentNum_TB, value); }
            get { return GetText(QEquipmentNum_TB); }
        }

        public string QOutput_PurchaseOrder
        {
            set { SetText(QPurchaseOrder_TB, value); }
            get { return GetText(QPurchaseOrder_TB); }
        }

        public string QOutput_NoOfVars
        {
            set { SetText(QNumOfVars_TB, value); }
            get { return GetText(QNumOfVars_TB); }
        }

        public string QOutput_MaterialPrice
        {
            set { SetText(QMaterialPrice_TB, value); }
            get { return GetText(QMaterialPrice_TB); }
        }

        public string QOutput_StandardPrice
        {
            set { SetText(QStandardPrice_TB, value); }
            get { return GetText(QStandardPrice_TB); }
        }

        public string QOutput_VariationPrice
        {
            set { SetText(QVarLabourPrice_TB, value); }
            get { return GetText(QVarLabourPrice_TB); }
        }

        public string QOutput_TotalPrice
        {
            set { SetText(QTotalPrice_TB, value); }
            get { return GetText(QTotalPrice_TB); }
        }

        public DateTime GetBasicStartDate
        {
            get { return GetDateTime(BasicStartDate_DP); }
        }

        public DateTime GetEndStartDate
        {
            get { return GetDateTime(BasicEndDate_DP); }
        }

        public string StatusInfo
        {
            set { SetStatusProgress(StatusInfo_LBL, "text", value); }
        }

        #endregion

        #region METHODS

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
                QuoteTable = ExcelManager.ConvertExcelToDataTable_Name(AppSettings.Defaults.QuotePath, Tab);

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

        // Get input from user
        public string GetInput(string Info, string Title, string Default)
        {
            string ReturnValue = "";

            using (InputBox UserInput = new InputBox(this))
            {
                UserInput.TBInformation.Text = Info;
                UserInput.Input.Text = Default;
                UserInput.Text = Title;
                UserInput.ShowDialog();

                if (UserInput.Cancel)
                    ReturnValue = "CANCEL";
                else
                    ReturnValue = UserInput.Input.Text;
            };



            return ReturnValue;
        }

        // Set status on status bar and update progress bar (if required, 0 to hide progress bar)
        public void SetStatus(string Text, int Progress)
        {

            if (Text == "")
            {
                SetStatusProgress(Progress_PB, "visible", false);
                SetStatusText(StatusText_LBL, "");
            }

            if (!Text.Contains("cancel") || Text != "")
            {

                SetStatusText(StatusText_LBL, Text);
                if (Progress > 0)
                {
                    SetStatusProgress(Progress_PB, "visible", true);
                    SetStatusProgress(Progress_PB, "value", Progress);
                }
                else
                {
                    SetStatusProgress(Progress_PB, "visible", false);
                }
            }

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { Update(); });
            }
            else
            {
                Update();
            }

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

        public int GetCBIndex(dynamic control)
        {
            int index = 0;
            control.Invoke((MethodInvoker)delegate { index = control.SelectedIndex; });
            return index;
        }

        public int GetSelectedItems(dynamic control)
        {
            int items = 0;
            control.Invoke((MethodInvoker)delegate { items = control.SelectedItems.Count; });
            return items;
        }

        public void SetStatusText(dynamic con, string val) { BeginInvoke((Action)(() => con.Text = val)); }

        delegate void SetControlValueCallback1(dynamic oControl, string propName, object propValue);
        private void SetStatusProgress(dynamic oControl, string propName, object propValue)
        {
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

        public void SetText(dynamic control, string val)
        {
            control.Invoke((MethodInvoker)delegate { control.Text = val; });
        }

        public void SetValue(dynamic control, int val)
        {
            control.Invoke((MethodInvoker)delegate { control.Value = val; });
        }

        public int GetValue(dynamic control)
        {
            int value = 0;

            control.Invoke((MethodInvoker)delegate { value = control.Value; });

            return value;
        }

        public SETUP_MODULE GetModuleNumber(string input, MobilityTask Task)
        {
            if (Task.Name != "NON-STANDARD VARIATION")
            {
                return input switch
                {
                    "OT_STANDARD_ZM12" => SETUP_MODULE.OT_STANDARD_ZM12,
                    "OT_NRCCO_ZM03" => SETUP_MODULE.OT_NRCCO_ZM03,
                    "OT_STANDARD_ZM25" => SETUP_MODULE.OT_STANDARD_ZM25,
                    _ => SETUP_MODULE.UKNOWN,
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
        private bool CheckBlankFields_Var()
        {
            if (GetText(VarSerialNumber_TB) == "")
            {
                MsgBox_Error("SERIAL NUMBER field cannot be blank");
                return false;
            }

            if (GetText(VarTemplate_CB) == "")
            {
                MsgBox_Error("Please select a TEMPLATE EQUIPMENT to use");
                return false;
            }

            if (GetText(VarTaskType_CB) == "")
            {
                MsgBox_Error("Please select a VARIATION WORK SCOPE");
                return false;
            }

            

            if (RunFullSetup)
            {
                // Check something is selected
                if (GetSelectedItems(Variations_LB) == 0)
                {
                    MsgBox_Error("Please select a notification to convert");
                    return false;
                }

                // Check variations are loaded
                if (GetItems(Variations_LB) <= 0)
                {
                    MsgBox_Error("Please load notifications for this serial number before continuing");
                    return false;
                }

                if (GetText(VarPMActivityType_CB) == "")
                {
                    MsgBox_Error("Please select a PM ACTIVITY TYPE");
                    return false;
                }

                if (GetText(VarSOPriority_CB) == "")
                {
                    MsgBox_Error("Please select a PRIORITY");
                    return false;
                }

                if (GetText(VarExternalReference_TB) == "")
                {
                    MsgBox_Error("Please enter an EXTERNAL REFERENCE");
                    return false;
                }
            }
            return true;
        }

        // Check for blank fields on main setup
        private bool CheckBlankFields_Single()
        {
            if (GetText(TemplateEquipmentList_CB) == "")
            {
                MsgBox_Error("Please select a TEMPLATE EQUIPMENT");
                return false;
            }

            if (GetText(TaskType_CB) == "")
            {
                MsgBox_Error("Please select a WORK SCOPE");
                return false;
            }

            if (AppSettings.Plant == "1002")
            {
                if (GetText(FunctionLoc_CB) == "")
                {
                    MsgBox_Error("Please select a FUNCTIONAL LOCATION");
                return false;
                }
            }

            // Only if running the whole tooling
            if (RunFullSetup == true)
            {
                if (GetText(PartyName_CB) == "")
                {
                    MsgBox_Error("Please select a SOLD TO PARTY");
                    return false;
                }

                if (GetText(PurchaseOrder_TB) == "")
                {
                    MsgBox_Error("Please enter a PURCHASE ORDER");
                    return false;
                }

                if (GetText(PMActivityType_CB) == "")
                {
                    MsgBox_Error("Please select an pm ACTIVITY TYPE");
                    return false;
                }

                if (GetText(Priority_CB) == "")
                {
                    MsgBox_Error("Please select a PRIORITY");
                    return false;
                }

                if (GetText(ExternalReference_TB) == "")
                {
                    MsgBox_Error("Please enter a EXTERNAL REFERENCE (if you do not have one enter N/A)");
                    return false;
                }
            }

            return true;
        }

        // Verify fields in the variation tab
        private bool VerifyInputs_Var()
        {
            if (RunFullSetup == true)
            {
                if (VarSOStartDate_DP.Value.CompareTo(VarSOEndDate_DP.Value) > 0)
                {
                    MsgBox_Error("The PLANNED START DATE cannot be after the PLANNED FINISH DATE");
                    //VarSOStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (VarSOEndDate_DP.Value.CompareTo(VarSOStartDate_DP.Value) < 0)
                {
                    MsgBox_Error("The PLANNED FINISH DATE cannot be before the PLANNED START DATE");
                    //VarSOStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (VarSOStartDate_DP.Value.CompareTo(DateTime.Now.AddDays(-1)) < 0)
                {
                    MsgBox_Error("The PLANNED START DATE cannot be in the past");
                    //VarSOStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (VarSOEndDate_DP.Value.CompareTo(DateTime.Now) < 0)
                {
                    MsgBox_Error("The PLANNED FINISH DATE cannot be in the past");
                    //VarSOStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Verify lead Service Order inputs
        /// </summary>
        /// <param name="Eq">referenced MobilityEquipment</param>
        /// <param name="So">referenced MobilityServiceOrder</param>
        /// <returns></returns>
        private bool VerifyInputs(ref MobilityEquipment Eq, ref MobilityServiceOrder So)
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

            // Full setup verification
            if (RunFullSetup)
            {
                if (BasicEndDate_DP.Value.CompareTo(DateTime.Today) < 0)
                {
                    MsgBox_Error("PLANNED FINISH DATE cannot be in the past");
                    //PurchaseOrderDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (BasicStartDate_DP.Value.CompareTo(DateTime.Today) < 0)
                {
                    MsgBox_Error("PLANNED START DATE cannot be in the past");
                    //PurchaseOrderDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (PurchaseOrderDate_DP.Value.CompareTo(DateTime.Today) == 1)
                {
                    MsgBox_Error("PURCHASE ORDER DATE cannot be in the future");
                    //PurchaseOrderDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (BasicStartDate_DP.Value.CompareTo(BasicEndDate_DP.Value) == 1)
                {
                    MsgBox_Error("The PLANNED START DATE cannot be after the PLANNED FINISH DATE");
                    //BasicStartDate_DP.Value = DateTime.Today.AddDays(-1.0);
                    return false;
                }

                if (BasicEndDate_DP.Value.CompareTo(BasicStartDate_DP.Value) == -1)
                {
                    MsgBox_Error("The PLANNED FINISH cannot be before the PLANNED START DATE");
                    //BasicEndDate_DP.Value = DateTime.Today.AddDays(10.0);
                    return false;
                }

                if (RequiredStartDate_DP.Value.CompareTo(RequiredEndDate_DP.Value) == 1)
                {
                    MsgBox_Warning("The REQUESTED START DATE cannot be after the REQUESTED FINISH DATE");
                    //RequiredStartDate_DP.Value = DateTime.Today;
                    return false;
                }

                if (RequiredEndDate_DP.Value.CompareTo(RequiredStartDate_DP.Value) == -1)
                {
                    MsgBox_Warning("The REQUESTED FINISH DATE cannot be before the REQUESTED START DATE");
                    //RequiredEndDate_DP.Value = DateTime.Today.AddDays(10.0);
                    return false;
                }
            }

            // Verify you want to create warranty service order
            if (WarrantyClaim_CHB.Checked && RunFullSetup)
            {
                if (MsgBox_Question($"Warranty Claim has been selected {Environment.NewLine}Are you sure you want to create a Warranty Claim Service Order?") == DialogResult.No)
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

        /// <summary>
        /// Convert Mobility Notifications to Service Orders
        /// </summary>
        /// <param name="SelectedTask">MobilityTask</param>
        /// <param name="OrderInfo">MobilityServiceOrder</param>
        /// <param name="SelectedEquipment">MobilityEquipment</param>
        /// <param name="Components">List<SAPComponents></param>
        /// <param name="NotificationNumber">Notification number to convert</param>
        private void VarSetup(MobilityTask          SelectedTask,
                              MobilityServiceOrder  OrderInfo,
                              MobilityEquipment     SelectedEquipment,
                              string                NotificationNumber,
                              List<SAPComponent>    Components)
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
                /*case SETUP_MODULE.OT_NRCCO_ZM03:
                    REMAKE THE CCO MODULE LATER
                    Output_SetupMod = "OT_NRCCO_ZM03";
                    SetupModule = new Module_NRENGINECCO();
                    SetupModule.SetMainForm(this);

                    break;*/

                case SETUP_MODULE.UKNOWN:
                    MsgBox_Error($"Setup module for task {SelectedTask.Name} is uknown please verify database entry for this task and ensure the correct setup module is entered");
                    return;

            }

            SetupModule.GetEquipment(SelectedEquipment.TemplateNumber,
                                     SelectedEquipment.SerialNumber.ToUpper(),
                                     SelectedEquipment.ZAWA,
                                     SingleSetup_BW,
                                ref  SelectedEquipment);

            if(!RunFullSetup)
            { 
                // Create CEL if required
                if (SelectedTask.CEL != "NONE" && SelectedTask.CEL != "NON-STANDARD VARIATION" && SelectedTask.CEL != null)
                {
                    switch (SetupModule.CreateEntryList(SelectedTask, SingleSetup_BW))
                    {
                        case SAPERROR.SAP_CONNECTION_FAILED:
                            MsgBox_Error("Please ensure SAP is connected");
                            return;

                        case SAPERROR.CEL_TABLE_DATA_INVALID:
                            MsgBox_Error("No database data found for selected Entry List");
                            return;

                        case SAPERROR.CEL_MPOINTS_MISSING:
                            MsgBox_Error("Variation entry list creation has failed, please ensure the input equipment is up-to-date by running the front tab");
                            return;

                        case SAPERROR.USR_CANCEL:
                            MsgBox_Normal("User cancellation detected, the tool will now stop");
                            return;
                    }
                }
                else
                {
                    MsgBox_Normal("There is no template CEL for this tasklist, equipment check complete!");
                    return;
                }

                MsgBox_Normal("Variation Entry List created successfully");
                return;
            }
                else
            {
                // Create CEL if required
                if (SelectedTask.CEL != "NONE" && SelectedTask.CEL != "NON-STANDARD VARIATION" && SelectedTask.CEL != null)
                {
                    switch (SetupModule.CreateEntryList(SelectedTask, SingleSetup_BW))
                    {
                        case SAPERROR.SAP_CONNECTION_FAILED:
                            MsgBox_Error("Please ensure SAP is connected");
                            return;

                        case SAPERROR.CEL_TABLE_DATA_INVALID:
                            MsgBox_Error("No database data found for selected Entry List");
                            return;

                        case SAPERROR.CEL_MPOINTS_MISSING:
                            MsgBox_Error("Variation entry list creation has failed, please ensure the input equipment is up-to-date by running the front tab");
                            return;

                        case SAPERROR.USR_CANCEL:
                            MsgBox_Normal("User cancellation detected, the tool will now stop");
                            return;
                    }
                }

                // Get long text
                GetLongText LText = new GetLongText(this)
                {
                    LongText = GetText(LongText_TB)
                };

                LText.ShowDialog();

                SelectedTask.LongText = LText.LongText;

                // Check notification and create service order
                switch (SetupModule.CreateServiceOrderFromNotification(SelectedTask, SelectedEquipment, OrderInfo, Components, NotificationNumber, SingleSetup_BW))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;

                    case SAPERROR.SO_CANT_FIND:
                        MsgBox_Error("Failed to create service order");
                        return;

                    case SAPERROR.STOP_TOOL:
                        return;
                }
            }
        }

        /// <summary>
        /// Setup of lead Notification & Service Order
        /// </summary>
        /// <param name="SelectedTask">MobilityTask</param>
        /// <param name="OrderInfo">MobilityServiceOrder</param>
        /// <param name="SelectedEquipment">MobilityEquipment</param>
        /// <param name="Components">List<SAPComponents></param>
        private void Setup(MobilityTask         SelectedTask,
                           MobilityServiceOrder OrderInfo,
                           MobilityEquipment    SelectedEquipment,
                           List<SAPComponent>   Components)
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
                /*case SETUP_MODULE.OT_NRCCO_ZM03:

                    Output_SetupMod = "OT_NRCCO_ZM03";
                    SetupModule = new Module_NRENGINECCO();
                    SetupModule.SetMainForm(this);

                    break;*/


                case SETUP_MODULE.UKNOWN:
                    MsgBox_Error($"Setup module for task {SelectedTask.Name} is uknown please verify database entry for this task and ensure the correct setup module is entered");
                    return;
            }

            // Equipment setup
            if (SelectedEquipment.UpdateToTemplate)
            {
                switch (SetupModule.InitialEquipmentCheck(SelectedEquipment.TemplateNumber,
                                                          SelectedEquipment.SerialNumber.ToUpper(),
                                                          SelectedEquipment.ZAWA,
                                                          SelectedEquipment.FunctionLoc,
                                                          SingleSetup_BW,
                                                      ref SelectedEquipment))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.EQ_NOT_FOUND:
                        MsgBox_Error($"Equipment number not found from serial number {SelectedEquipment.SerialNumber}");
                        return;

                    case SAPERROR.EQ_MATSERN_EXISTS:
                        MsgBox_Error($"Equipment material serial number exists with {SelectedEquipment.SerialNumber}");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;
                }
            }
            else
            {
                switch (SetupModule.GetEquipment(SelectedEquipment.TemplateNumber,
                                                 SelectedEquipment.SerialNumber.ToUpper(),
                                                 SelectedEquipment.ZAWA,
                                                 SingleSetup_BW,
                                             ref SelectedEquipment))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.EQ_NOT_FOUND:
                        MsgBox_Error($"Equipment number not found from serial number {SelectedEquipment.SerialNumber}");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;
                }

                MsgBox_Normal("This equipment type is flagged as DO NOT UPDATE TO TEMPLATE, no changes will be made to the equipment.");
            }

            // Check measurements
            switch (SetupModule.CheckMeasurementPoints(SelectedTask, SingleSetup_BW))
            {
                case SAPERROR.SAP_CONNECTION_FAILED:
                    MsgBox_Error("Please ensure SAP is connected");
                    return;

                case SAPERROR.EQ_NOT_FOUND:
                    MsgBox_Error($"Equipment number not found from serial number {SelectedEquipment.SerialNumber}");
                    return;

                case SAPERROR.CEL_MPOINTS_MISSING:
                    MsgBox_Error($"Cannot find the measurement points to generate this Entry List, ADMIN: Please check template entry list {SelectedTask.Name}");
                    return;

                case SAPERROR.USR_CANCEL:
                    MsgBox_Normal("User cancellation detected, the tool will now stop");
                    return;

                case SAPERROR.NO_NEED_TO_CREATE_CEL:
                    goto FULL_SETUP;
            }

            // Create CEL
            switch (SetupModule.CreateEntryList(SelectedTask, SingleSetup_BW))
            {
                case SAPERROR.SAP_CONNECTION_FAILED:
                    MsgBox_Error("Please ensure SAP is connected");
                    return;

                case SAPERROR.CEL_TABLE_DATA_INVALID:
                    MsgBox_Error("No database data found for selected Entry List");
                    return;

                case SAPERROR.CEL_MPOINTS_MISSING:
                    MsgBox_Error($"Cannot find the measurement points to generate this Entry List, ADMIN: Please check template entry list {SelectedTask.Name}");
                    return;

                case SAPERROR.USR_CANCEL:
                    MsgBox_Normal("User cancellation detected, the tool will now stop");
                    return;
            }

FULL_SETUP:               
            // Do service order setup
            if (RunFullSetup == true)
            {
                // Get long text
                GetLongText LText = new GetLongText(this);

                // Change long text based on warranty claim
                if (SelectedTask.WarrantyClaim)
                {
                    LText.LongText = $"{SelectedTask.Name}[WARRANTY]" +
                                     $"{Environment.NewLine}======================================================" +
                                     $"{Environment.NewLine}CONDUCT WARRANTY INVESTIGATION (HOLD FOR ENGINEERING)";
                }
                else
                    LText.LongText = SelectedTask.LongText;

                LText.ShowDialog();

                SelectedTask.LongText = LText.LongText;

                // Check service order can be setup
                switch (SetupModule.InitialServiceCheck(SelectedTask, SelectedEquipment.EquipmentNumber, SingleSetup_BW))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;

                    case SAPERROR.STOP_TOOL:
                        return;
                }

                // Create notification
                switch (SetupModule.CreateNotification(SelectedTask, SelectedEquipment, OrderInfo, SingleSetup_BW))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;
                }

                // Create service order
                switch (SetupModule.CreateServiceOrder(SelectedTask, SelectedEquipment, OrderInfo, Components, SingleSetup_BW))
                {
                    case SAPERROR.SAP_CONNECTION_FAILED:
                        MsgBox_Error("Please ensure SAP is connected");
                        return;

                    case SAPERROR.USR_CANCEL:
                        MsgBox_Normal("User cancellation detected, the tool will now stop");
                        return;

                    case SAPERROR.SO_CANT_FIND:
                        MsgBox_Error("Failed to create service order");
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

        // Hand form resizing (borderless)
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 15;

            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = PointToClient(screenPoint);

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
                cp.ExStyle |= 0x02000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Maximize window
            //WindowState = FormWindowState.Maximized;

            // Create controller instances
            AppSettings         = new Settings(ThemeController, this);
            DatabaseController  = new Databases(this);
            SapSession          = new AUTOSAP(this);

            // Set defaults
            AppSettings.LoadSettings();

            // Theme settings
            ThemeController.AddControls(TitleBar_PNL, THEME_TYPE.Border);
            ThemeController.AddControls(MinimizeButton_LBL, THEME_TYPE.Border);
            ThemeController.AddControls(MaximizeButton_LBL, THEME_TYPE.Border);
            ThemeController.AddControls(CloseButton_LBL, THEME_TYPE.Border);
            ThemeController.AddControls(this, THEME_TYPE.Back);
            ThemeController.AddControls(DataTabs_TC, THEME_TYPE.Back);

            // Set to a default
            ThemeController.SetThemeColor(Color.FromArgb(35, 71, 92), Color.FromArgb(85, 155, 189));

            // Try to load theme file & Refresh
            ThemeController.LoadTheme();
            ThemeController.RefreshTheme();

            // Load databases
            DatabaseController.Load();

            // Set field defaults
            FunctionLoc_CB.Text             = AppSettings.ADefaults.FunctionLocation;
            PartyName_CB.Text               = AppSettings.ADefaults.SoldToParty;
            PMActivityType_CB.Text          = AppSettings.ADefaults.PmActivityType;
            Priority_CB.Text                = AppSettings.ADefaults.Priority;
            VarPMActivityType_CB.Text       = AppSettings.ADefaults.PmActivityType;
            VarSOPriority_CB.Text           = AppSettings.ADefaults.Priority;
            ExternalReference_TB.Text       = AppSettings.ADefaults.ExternalReference;
            VarExternalReference_TB.Text    = AppSettings.ADefaults.ExternalReference;

            ActivityType_LBL.Focus();

            // Quote console
            Quoter = new QuoteOutput(this);
            Quoter.Hide();

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
            AppSettings Settings = new AppSettings(this)
            {
                ShowInTaskbar = false
            };
            Settings.ShowDialog();
        }

        // Setup equipment button click event 
        private void SetupEquipment_BTN_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                RunFullSetup    = false;
                IsRunning       = true;
                SetupType       = SETUP_TYPE.SINGLE;
                SingleSetup_BW.RunWorkerAsync();
            }
            else
            {
                MsgBox_Error("Tool is already running in the background, please stop the tool to re-run");
            }
        }

        private void ReqStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the planned start date to the required start date
            BasicStartDate_DP.Value = RequiredStartDate_DP.Value;
        }

        private void ReqEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the planned start date to the required start date
            BasicEndDate_DP.Value = RequiredEndDate_DP.Value;
        }

        // Setup equipment button click event 
        private void VarSetupEquipment_BTN_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                RunFullSetup    = false;
                IsRunning       = true;
                SetupType       = SETUP_TYPE.VAR;
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
                RunFullSetup    = true;
                IsRunning       = true;
                SetupType       = SETUP_TYPE.VAR;
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
                RunFullSetup    = true;
                IsRunning       = true;
                SetupType       = SETUP_TYPE.SINGLE;
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
            MobilityEquipment       InputEq         = new MobilityEquipment();
            MobilityServiceOrder    InputSO         = new MobilityServiceOrder();
            MobilityTask            InputTask;

            switch (SetupType)
            {
                case SETUP_TYPE.SINGLE:

                    // Reset outputs
                    Output_CELNum       = "";
                    Output_EQDesc       = "";
                    Output_EQNum        = "";
                    Output_Notification = "";
                    Output_ServiceOrder = "";
                    Output_SetupMod     = "";
                    Output_WBS          = "";
                    Output_WorkCenter   = "";

                    // Check blank fields
                    if (!CheckBlankFields_Single()) return;

                    // Get task info
                    InputTask                       = DatabaseController.GetTask_ByName(GetText(TaskType_CB), true);
                    InputTask.WarrantyClaim         = GetChecked(WarrantyClaim_CHB);

                    // Get input equipment info
                    InputEq.TemplateNumber          = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).EquipmentNumber;
                    InputEq.TemplateName            = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).Description;
                    InputEq.UpdateToTemplate        = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).UpdateToTemplate;
                    InputEq.ZDI1                    = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).ZDI1;
                    InputEq.ZAWA                    = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(TemplateEquipmentList_CB)).ZAWA;
                    InputEq.FunctionLoc             = DatabaseController.GetFunc_ByName(GetText(FunctionLoc_CB));
                    InputEq.SerialNumber            = GetText(EquipmentSerial_TB);

                    // Get input service order info
                    InputSO.ActualStartDate         = RequiredStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.ActualEndDate           = RequiredStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.PurchaseOrderDate       = PurchaseOrderDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.BasicStartDate          = BasicStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.BasicEndDate            = BasicEndDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.CustomerName            = GetText(PartyName_CB);
                    InputSO.PurchaseOrder           = GetText(PurchaseOrder_TB);
                    InputSO.ActivityType            = GetText(PMActivityType_CB);
                    InputSO.Priority                = GetText(Priority_CB);
                    InputSO.ExternalReference       = GetText(ExternalReference_TB);

                    Output_WBS                      = InputTask.WBS;
                    Output_WorkCenter               = InputTask.Workcentre;

                    if (VerifyInputs(ref InputEq, ref InputSO))
                    {
                        if (RunFullSetup == true)
                        {
                            INPUT_FIELD Sales = DatabaseController.GetSalesData_ByWorkCenter(InputTask.Workcentre);

                            InputSO.SalesGroup      = Sales.Name;
                            InputSO.SalesOffice     = Sales.Number;
                            InputSO.SoldToParty     = DatabaseController.GetCustomer_ByName(InputSO.CustomerName).Number;
                            InputSO.ActivityType    = DatabaseController.GetActivity_ByName(InputSO.ActivityType).Number;

                            if (InputSO.SalesGroup == "" || InputSO.SalesOffice == "" || InputSO.SoldToParty == "" || InputSO.ActivityType == "")
                            {
                                MsgBox_Error("Error finding service order data");
                                return;
                            }
                        }

                        Setup(InputTask, InputSO, InputEq, null);
                    }

                    break;

                case SETUP_TYPE.VAR:

                    // Reset outputs
                    Output_CELNum       = "";
                    Output_EQDesc       = "";
                    //Output_EQNum        = "";
                    Output_Notification = "";
                    Output_ServiceOrder = "";
                    Output_SetupMod     = "";
                    Output_WBS          = "";
                    Output_WorkCenter   = "";

                    // Check blank fields
                    if (!CheckBlankFields_Var()) return;

                    // Get task info
                    InputTask               = DatabaseController.GetTask_ByName(GetText(VarTaskType_CB), false);
                    InputTask.WarrantyClaim = false;

                    // Get input equipment info
                    InputEq.TemplateNumber              = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).EquipmentNumber;
                    InputEq.TemplateName                = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).Description;
                    InputEq.UpdateToTemplate            = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).UpdateToTemplate;
                    InputEq.ZDI1                        = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).ZDI1;
                    InputEq.ZAWA                        = DatabaseController.GetTemplateEquipment_ByIndex(GetCBIndex(VarTemplate_CB)).ZAWA;
                    InputEq.SerialNumber                = GetText(VarSerialNumber_TB);

                    // Get input service order info
                    InputSO.BasicStartDate              = VarSOStartDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.BasicEndDate                = VarSOEndDate_DP.Value.ToShortDateString().Replace("/", ".");
                    InputSO.ActivityType                = GetText(VarPMActivityType_CB);
                    InputSO.Priority                    = GetText(VarSOPriority_CB);
                    InputSO.ExternalReference           = GetText(VarExternalReference_TB);

                    if (VerifyInputs_Var())
                    {
                        if (RunFullSetup)
                        {
                            if (InputTask.Name != "NON-STANDARD VARIATION")
                            {
                                INPUT_FIELD Sales       = DatabaseController.GetSalesData_ByWorkCenter(InputTask.Workcentre);
                                InputSO.SalesGroup      = Sales.Name;
                                InputSO.SalesOffice     = Sales.Number;
                                InputSO.ActivityType    = DatabaseController.GetActivity_ByName(InputSO.ActivityType).Number;

                                if (InputSO.SalesGroup == "" || InputSO.SalesOffice == "" || InputSO.ActivityType == "")
                                {
                                    MsgBox_Error("Error finding service order data");
                                    return;
                                }
                            }

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

        // Exit menu button click event 
        private void Exit_MN_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Main form key down event 
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && IsRunning)
            {
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
            if (SapSession.GetSession())
            {
                StatusInfo_LBL.Text = "SAP Connected";
                StatusInfo_LBL.ForeColor = Color.DarkGreen;
            }
            else
            {
                StatusInfo_LBL.Text = "SAP Disconnected";
                StatusInfo_LBL.ForeColor = Color.DarkRed;
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

        private void ResyncDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleSetup_BW.CancelAsync();
            SingleSetup_BW.Dispose();
            AppSettings.ResetSettings(true);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionHistory Versions = new VersionHistory(this);

            Versions.Show();
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Clear task type if template equipent is empty
        private void TemplateEquipment_CB_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (((ComboBox)sender).Text == "")
                {
                    TaskType_CB.Items.Clear();
                }
            }
        }

        // Draw a box around the longtext RTB
        private void RightSide_TBL_Paint(object sender, PaintEventArgs e)
        {
            Point TBLoc = LongText_TB.Location;

            using (Pen BorderPen = new Pen(Color.FromArgb(130, 135, 144), 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen,
                                         TBLoc.X - 1,
                                         TBLoc.Y - 1,
                                         LongText_TB.Width + 2,
                                         LongText_TB.Height + 2);
            };
        }

        // Load notifications into variation tab
        private void LoadVariation_BTN_Click(object sender, EventArgs e)
        {
            string EqNumber, SerialNumber;
            ExcelDataTables TableManager = new ExcelDataTables();
            SerialNumber = GetText(VarSerialNumber_TB);

            // Reset eqnum
            Output_EQNum = "";

            if (SerialNumber != "" && !SerialNumber.Contains(" "))
            {
                if (SapSession.GetSession())
                {
                    SetStatus("Getting equipment details", 0);

                    // Convert serial to equipment number
                    EqNumber = SapSession.EquipmentNumberFromSerial(SerialNumber);

                    // Verify we have got the equipment number
                    if (EqNumber != "nothing")
                    {
                        Output_EQNum = EqNumber;

                        Variations_LB.Items.Clear();
                        Variations.Clear();

                        // Clear long text box text & description
                        LongText_TB.Text = "";
                        LongText_LBL.Text = "";

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

                        SetStatus("Loading notifications", 0);

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

                                SapSession.EndTransaction();
                                MsgBox_Normal("Notification loaded");
                                SetStatus("", 0);

                                break;

                            // Multiple notifications
                            case 500:
                                ((GuiMenu)SapSession.GetFormById("wnd[0]/mbar/menu[0]/menu[11]/menu[2]")).Select();
                                SapSession.SendVKey(0);

                                // Filename popup
                                Popup = (GuiModalWindow)SapSession.GetFormById("wnd[1]");
                                ((GuiCTextField)Popup.FindByName("DY_PATH", "GuiCTextField")).Text = Environment.GetEnvironmentVariable("TEMP");
                                ((GuiCTextField)Popup.FindByName("DY_FILENAME", "GuiCTextField")).Text = $"IW58DUMP{EqNumber}.txt";
                                ((GuiButton)Popup.FindById("tbar[0]/btn[11]")).Press();

                                // Add to list
                                DataTable VariationList = TableManager.ControlTexttoDataTable_IW58(Environment.GetEnvironmentVariable("TEMP") + $"\\IW58DUMP{EqNumber}.txt");

                                for (int i = 0; i < VariationList.Rows.Count; i++)
                                {
                                    SAP_VARS _madd = new SAP_VARS
                                    {
                                        Description = VariationList.Rows[i]["Description"].ToString(),
                                        Number = VariationList.Rows[i]["Notification"].ToString()
                                    };

                                    SapSession.StartTransaction("IW52");
                                    SapSession.GetCTextField("RIWO00-QMNUM").Text = _madd.Number;
                                    SapSession.SendVKey(0);

                                    _madd.LongText = SapSession.GetShell("shell").Text;

                                    Variations.Add(_madd);

                                    Variations_LB.Items.Add(Variations[i].Description);
                                }

                                VariationList.Dispose();

                                SapSession.EndTransaction();

                                MsgBox_Normal("Notifications loaded");
                                SetStatus("", 0);
                                break;

                            default:
                                MsgBox_Normal("No unconverted notifications found");
                                SetStatus("", 0);
                                break;
                        }

                    }
                    else
                    {
                        MsgBox_Normal($"No equipment number found for serial {SerialNumber}");
                        SetStatus("", 0);
                    }
                }
                else
                {
                    MsgBox_Error("Please ensure SAP is running");
                    SetStatus("", 0);
                }
            }
            else
            {
                MsgBox_Error("Please enter a valid serial number to get the variation list");
                SetStatus("", 0);
            }
        }

        // Change output information depending on tab page selection
        private void DataTabs_TC_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Quote tab
            if (e.TabPageIndex > 1)
            {
                DataTabs_TC.SelectedTab = RaiseVariation_TP;
                /*QuoteOutput_PNL.Visible = true;
                OutputOrder_PNL.Visible = false;
                Quoter.Show();*/

                MsgBox_Normal("Quote section to be released in future updates");
            }
            // Orders tabs
            else
            {
                QuoteOutput_PNL.Visible = false;
                OutputOrder_PNL.Visible = true;
                Quoter.Hide();
            }
        }



        #region WINDOW THEME EVENTS

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
            if (e.Button == MouseButtons.Left) 
                Close();
        }

        // Minimize button label mouse down event 
        public virtual void MiniButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
                WindowState = FormWindowState.Minimized;
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

        // Unselect combo boxed on re-layout event
        private void MainForm_Layout(object sender, LayoutEventArgs e)
        {
            BeginInvoke(new Action(() => { FunctionLoc_CB.Select(0, 0); }));
            BeginInvoke(new Action(() => { PartyName_CB.Select(0, 0); }));
            BeginInvoke(new Action(() => { Priority_CB.Select(0, 0); }));
            BeginInvoke(new Action(() => { PMActivityType_CB.Select(0, 0); }));
            BeginInvoke(new Action(() => { VarPMActivityType_CB.Select(0, 0); }));
            BeginInvoke(new Action(() => { VarSOPriority_CB.Select(0, 0); }));
        }

        // Override paint event on the main form
        protected override void OnPaint(PaintEventArgs e)
        {
            // Do form painting first
            base.OnPaint(e);

            // Variables
            Pen         BorderPen       = new Pen(ThemeController.GetBordercolor(), 1.0f);
            Brush       Fill            = BorderPen.Brush;
            Graphics    FormGFX         = e.Graphics;
            Rectangle   FormBorder,
                        OutputBorder,
                        TabsBorder;

            // Get rect
            FormBorder = new Rectangle(ClientRectangle.X,
                                       ClientRectangle.Y,
                                       ClientRectangle.Width - 1,
                                       ClientRectangle.Height - 1);

            OutputBorder = new Rectangle(Output_PNL.Location.X - 1,
                                         Output_PNL.Location.Y + 76,
                                         Output_PNL.Width + 1,
                                         Output_PNL.Height + 1);

            TabsBorder = new Rectangle(DataTabs_TC.Location.X - 1,
                                       DataTabs_TC.Location.Y + 101,
                                       DataTabs_TC.Width + 1,
                                       DataTabs_TC.Height - 24);

            // Draw rectangles
            FormGFX.DrawRectangle(BorderPen,    TabsBorder);
            FormGFX.FillRectangle(Fill,         TabsBorder);
            FormGFX.DrawRectangle(BorderPen,    OutputBorder);
            FormGFX.FillRectangle(Fill,         OutputBorder);
            FormGFX.DrawRectangle(BorderPen,    FormBorder);
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
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                    MaximizeButton_LBL.Image = ((Image)(Properties.Resources.ResourceManager.GetObject("MF")));
                }
            }
        }
        private void TitleBar_DoubleClick(object sender, EventArgs e)
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

            isTopPanelDragged = false;
        }

        // Titlebar mouse move event 
        public virtual void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            int Sensitivity = 5;

            if (isTopPanelDragged)
            {
                // Compute mouse position to screen instead of client
                Point MousePoint = PointToScreen(new Point(e.X, e.Y));

                // Get rid of maximize when dragging from max state
                if (WindowState == FormWindowState.Maximized)
                {       
                    // Only initiate movement of window if the mouse has moved more than the variation Sensativity
                    if (e.X > Start.X + Sensitivity || e.X < Start.X - Sensitivity &&
                        e.Y > Start.Y + Sensitivity || e.Y < Start.Y - Sensitivity)
                    { 
                        WindowState         = FormWindowState.Normal;
                        FromMax = true;
                        
                    }
                }
                else
                {
                    if (FromMax)
                        MousePoint.X -= Width/2;
                    else
                        MousePoint.Offset(offset);
                   
                    Location = MousePoint;
                }
            }
        }

        // Titlebar mouse down event 
        public virtual void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = PointToScreen(new Point(e.X, e.Y));

                // Set mouse position at mouse down
                Start = e.Location;
                FromMax = false;
                offset = new Point
                {
                    X = Location.X - pointStartPosition.X,
                    Y = Location.Y - pointStartPosition.Y
                };
    
            }
            else
                isTopPanelDragged = false;

            
        }

        // Titlebar mouse down event 
        public virtual void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            Point Position = TitleBar_PNL.PointToCurrentScreen(new Point(e.X, e.Y));

            // Maximize if you drop at top of screen
            if (Position.Y < 30)
            {
                WindowState = FormWindowState.Maximized;
            }

            isTopPanelDragged = false;
        }

        #endregion

        private void QOutputWindow_MN_Click(object sender, EventArgs e)
        {
            if (Quoter.Visible)
            {
                Quoter.Visible = false;

            }
            else
            {
                Quoter.Visible = true;
            }
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            AboutBox Box = new AboutBox(this);

            Box.Show();
        }

        
    }

    #endregion

    // Returns the position of the point in screen coordinates of that control instead
    // of the main-screen coordinates
    static class ControlExtensions
    {
        public static Point PointToCurrentScreen(this Control self, Point location)
        {
            var screenBounds = Screen.FromControl(self).Bounds;
            var globalCoordinates = self.PointToScreen(location);
            return new Point(globalCoordinates.X - screenBounds.X, globalCoordinates.Y - screenBounds.Y);
        }
    }
}
