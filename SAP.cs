using SAPFEWSELib;

using SapROTWr;

using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

using static Mobility_Setup_Tool.MsgBoxs;

/*
    LIBRARY TO AUTOMATE SAP WITH C# USING SAP SCRIPTING ENGINE
    WRITTEN BY CLINTON WHEELER - STRICTLY FOR USE BY UGL PTY LTD
    WRITTEN 2021 
*/

namespace Mobility_Setup_Tool
{
    // Structure to hold SAP mobility info
    public struct MobilityTask
    {
        public string Name { set; get; }
        public string CEL { set; get; }
        public string PartsTable { get; set; }
        public string Group { set; get; }
        public string Counter { set; get; }
        public string Workcentre { set; get; }
        public string WBS { get; set; }
        public string Module { get; set; }
        public string LongText { set; get; }
        public string SalesDoc { get; set; }
        public string SalesDocItem { get; set; }
        public string Equipment1 { set; get; }
        public string Equipment2 { set; get; }
        public string Equipment3 { set; get; }
        public string Equipment4 { set; get; }
        public string Equipment5 { set; get; }
        public string Equipment6 { set; get; }
        public string Equipment7 { set; get; }
        public string Equipment8 { set; get; }
        public string Equipment9 { set; get; }
        public string Equipment10 { set; get; }
        public string FolderPath { set; get; }
        public bool WarrantyClaim { get; set; }
    };

    public struct SAPComponent
    {
        public string ZAWA { get; set; }
        public string Qauntity { get; set; }
        public string StoreLocation { get; set; }
        public string SpecialStock { get; set; }
        public string Description { get; set; }
    }

    public struct QuoteInformation
    {
        public string Equipment { get; set; }
        public string QuoteTemplate { get; set; }
        public string PartsTemplate { get; set; }
        public string MandPartsTemplate { get; set; }
    };

    public struct MobilityMeasurement
    {
        public string Number { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string CharCode { get; set; }
        public string CodeGroup { get; set; }
        public string Decimals { get; set; }
        public string TargetValue { get; set; }
        public string IsValueCodeSuff { get; set; }
        public string IsCounter { get; set; }
        public string LowerLimit { get; set; }
        public string UpperLimit { get; set; }
        public string TargetText { get; set; }

    };

    public struct MobilityEquipment
    {
        public string SerialNumber { set; get; }
        public string EquipmentNumber { set; get; }
        public string Description { set; get; }
        public string ObjectType { set; get; }
        public string CatProfile { set; get; }
        public string SalesOrg { set; get; }
        public string DistChan { set; get; }
        public string Division { set; get; }
        public string EntryListName { set; get; }
        public string FunctionLoc { set; get; }
        public string ZAWA { set; get; }
        public string ZDI1 { set; get; }
        public string ModelNumber { set; get; }
        public string TemplateName { set; get; }
        public string TemplateNumber { set; get; }
        public bool UpdateToTemplate { set; get; }
    };

    public struct MobilityServiceOrder
    {
        public string Description { set; get; }
        public string NotificationType { set; get; }
        public string BasicStartDate { set; get; }
        public string BasicEndDate { set; get; }
        public string ActualStartDate { set; get; }
        public string ActualEndDate { set; get; }
        public string OrderType { set; get; }
        public string PurchaseOrder { set; get; }
        public string PurchaseOrderDate { set; get; }
        public string SoldToParty { set; get; }
        public string CustomerName { set; get; }
        public string Priority { set; get; }
        public string ActivityType { set; get; }
        public string SalesGroup { set; get; }
        public string SalesOffice { set; get; }
        public string ExternalReference { set; get; }
        public string Plant { set; get; }
        public string PlannerGroup { set; get; }
        public string Location { set; get; }
        public bool CreateWithoutEq { set; get; }
    };

    public class AUTOSAP : IDisposable
    {
        // Global class variables
        public  GuiSession          SapSession          { get; set; }
        public  GuiMainWindow       SapWindow           { get; set; }
        public  GuiApplication      SapApp              { get; set; }
        public  GuiConnection       SapConnection       { get; set; }
        public  bool                SapConnected        { get; set; }
        public  MainForm            RefForm;
        private bool                disposedValue;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="ParentForm">Parent Form</param>
        public AUTOSAP(MainForm ParentForm)
        {
            RefForm = ParentForm;
        }

        /// <summary>
        /// Connects to a currently open SAP session
        /// </summary>
        /// <returns>true/false</returns>
        public bool GetSession()
        {
            GuiComponent Con    = null;
            object SapGui       = null;

            // Create new instance of running object table wrapper
            CSapROTWrapper SapROT = new CSapROTWrapper();

            // Try find the SAPGUI object from the running object table
            try
            {
                SapGui = SapROT.GetROTEntry("SAPGUI");
            }
            catch
            {
                SapConnected = false;
                return false;
            }

            if (SapGui == null) return false;

            // Find the scripting engine object from SAPGUI
            try
            {
                SapApp = SapGui.GetType().InvokeMember("GetScriptingEngine", BindingFlags.InvokeMethod, null, SapGui, null) as GuiApplication;
            }
            catch
            {
                SapConnected = false;
                return false;
            }

            // Find connection to scripting engine
            for (int i = 0; i < SapApp.Children.Count; i++)
            {
                Con = SapApp.Children.ElementAt(i);

                if (Con.Type == "GuiConnection")
                {
                    SapConnection = (GuiConnection)Con;
                }
            }

            // Verify the connection
            if (SapConnection == null)
            {
                SapConnected = false;
                return false;
            }

            // Try to get SAP session
            try
            {
                SapSession = (GuiSession)SapConnection.Children.ElementAt(0);
            }
            catch
            {
                SapConnected = false;
                return false;
            }

            // Try to get SAP window
            try
            {
                SapWindow = (GuiMainWindow)SapSession.Children.ElementAt(0);
            }
            catch
            {
                SapConnected = false;
                return false;
            }

            // Success
            SapConnected = true;
            return true;
        }

        /// <summary>
        /// Get currently active (focused) window in SAP
        /// </summary>
        /// <returns>GuiFrameWindow object</returns>
        public GuiFrameWindow GetActiveWindow()
        {
            return SapSession.ActiveWindow;
        }

        /// <summary>
        /// Checks SAP connection
        /// </summary>
        /// <returns>true/false</returns>
        public bool CheckConnected()
        {
            return SapConnected;
        }

        /// <summary>
        /// Gets a form by address
        /// </summary>
        /// <param name="FormID">SAP form address</param>
        /// <returns>New object</returns>
        public dynamic GetFormById(string FormID)
        {
            if (SapConnected)
            {
                return SapSession.FindById(FormID);
            }
            return null;
        }

        /// <summary>
        /// Gets a form by name
        /// </summary>
        /// <param name="FormName">Form Name</param>
        /// <param name="FormType">Form Type (e.g GuiTextField)</param>
        /// <returns>New object</returns>
        public dynamic GetFormByName(string FormName, string FormType)
        {
            if (SapConnected)
            {
                return SapWindow.FindByName(FormName, FormType);
            }

            return null;
        }

        /// <summary>
        /// Gets a GuiShell object
        /// </summary>
        /// <param name="ShellName">Name of object</param>
        /// <returns>New GuiShell object</returns>
        public GuiShell GetShell(string ShellName)
        {
            GuiShell Shell = null;

            if (SapConnected)
            {
                try
                {
                    Shell = (GuiShell)SapWindow.FindByName(ShellName, "GuiShell");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }

            return Shell;
        }

        /// <summary>
        /// Starts a SAP transaction
        /// </summary>
        /// <param name="transCode">Transaction code</param>
        public void StartTransaction(string transCode)
        {
            if (SapConnected)
            {
                SapSession.StartTransaction(transCode);

                string statusTxt = ((GuiStatusbar)SapWindow.FindById("sbar")).Text;

                if (statusTxt.Contains("You are not authorized to use transaction"))
                {
                    MsgBox_Error($"You are not authorized to use transaction {transCode}.");
                }
            }
        }

        /// <summary>
        /// Change store location of all components in a SAP service order
        /// </summary>
        /// <param name="NewStoreLocation">Store location</param>
        /// <param name="NewSpecialStock">Special stock indicator (can be blank)</param>
        /// <param name="Parent">Parent thread</param>
        /// <returns>true/false</returns>
        public bool ChangeStore(string NewStoreLocation, string NewSpecialStock, BackgroundWorker Parent)
        {
            //Variables
            GuiComponentCollection  StoreLocations, SpecialStock;
            GuiCTextField           CurrentLoc, CurrentStock, Check;
            GuiTableControl         ComponentTable;
            int                     VisibleRow, RowJump;
            string                  PrevLoc, PrevStock;

            VisibleRow = 0;

            if (SapConnected)
            {
                SapWindow.SetFocus();

                for (int i = 0; i < 9999; i++)
                {
                    // Re init collection
                    ComponentTable  = ((GuiTableControl)SapWindow.FindByName("SAPLCOMKTCTRL_3020", "GuiTableControl"));
                    StoreLocations  = ComponentTable.FindAllByName("RESBD-LGORT", "GuiCTextField");
                    SpecialStock    = ComponentTable.FindAllByName("RESBD-SOBKZ_D", "GuiCTextField");

                    // Try to change
                    if (StoreLocations.Item(VisibleRow).Type == "GuiCTextField")
                    {
                        // Get field collections
                        CurrentLoc      = ((GuiCTextField)StoreLocations.Item(VisibleRow));
                        CurrentStock    = ((GuiCTextField)SpecialStock.Item(VisibleRow));
                        Check           = ((GuiCTextField)ComponentTable.FindAllByName("RESBD-MATNR", "GuiCTextField").Item(VisibleRow));

                        // Exit on blank
                        if (Check.Text == "") break;

                        // Get current value in case of error
                        PrevLoc             = CurrentLoc.Text;
                        PrevStock           = CurrentStock.Text;

                        // Change to updated value
                        CurrentLoc.Text     = NewStoreLocation;
                        CurrentStock.Text   = NewSpecialStock;

                        // Revert if failed
                        if (!ClearErrors(5, false))
                        {
                            // Re-connect to fields
                            ComponentTable      = ((GuiTableControl)SapWindow.FindByName("SAPLCOMKTCTRL_3020", "GuiTableControl"));
                            StoreLocations      = ComponentTable.FindAllByName("RESBD-LGORT", "GuiCTextField");
                            SpecialStock        = ComponentTable.FindAllByName("RESBD-SOBKZ_D", "GuiCTextField");
                            CurrentLoc          = ((GuiCTextField)StoreLocations.Item(VisibleRow));
                            CurrentStock        = ((GuiCTextField)SpecialStock.Item(VisibleRow));
                            CurrentLoc.Text     = PrevLoc;
                            CurrentStock.Text   = PrevStock;

                            ClearErrors(5, false);
                        }

                        if (Parent.CancellationPending) { return false; }

                        // Re-init table
                        ComponentTable = ((GuiTableControl)SapWindow.FindByName("SAPLCOMKTCTRL_3020", "GuiTableControl"));

                        RowJump = StoreLocations.Count - 1;

                        VisibleRow++;

                        // Move scroll bar if we go out of range
                        if (VisibleRow > RowJump)
                        {

                            ComponentTable.VerticalScrollbar.Position += RowJump;
                            VisibleRow = 0;

                        }
                    }
                }

                return true;

            }

            return false;
        }

        /// <summary>
        /// Get the main SAP window
        /// </summary>
        /// <returns>GuiMainWindow object</returns>
        public GuiMainWindow GetWindow() { return SapWindow; }

        /// <summary>
        /// Gets SAP application
        /// </summary>
        /// <returns>GuiApplication object</returns>
        public GuiApplication GetApp() { return SapApp; }

        /// <summary>
        /// Gets the current session information
        /// </summary>
        /// <returns>GuiSessionInfo object</returns>
        public GuiSessionInfo GetSessionInfo() { return SapSession.Info; }

        /// <summary>
        /// Gets SAP session
        /// </summary>
        /// <returns>GuiSession object</returns>
        public GuiSession GetSessionObj() { return SapSession; }

        /// <summary>
        /// Ends current transaction
        /// </summary>
        public void EndTransaction() { SapSession.EndTransaction(); }

        /// <summary>
        /// Gets all fields by name
        /// </summary>
        /// <param name="fieldName">Field name (can be blank)</param>
        /// <param name="fieldType">Field type</param>
        /// <returns>GuiComponentCollection</returns>
        public GuiComponentCollection GetAllByName(string fieldName, string fieldType)
        {
            if (SapConnected)
            {
                try
                {
                    return SapWindow.FindAllByName(fieldName, fieldType);
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {

                // SAP not connected return null
                return null;
            }
        }

        /// <summary>
        /// Gets a combobox form
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns>GuiComboBox object</returns>
        public GuiComboBox GetComboBox(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiComboBox)SapWindow.FindByName(fieldName, "GuiComboBox");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets Ctext field by address
        /// </summary>
        /// <param name="Address">Gui address in SAP</param>
        /// <returns>GuiCTextField object</returns>
        public GuiCTextField GetCTextFieldByID(string Address)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiCTextField)SapWindow.FindById(Address);
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                // SAP not connected return null
                return null;
            }
        }

        /// <summary>
        /// Gets text field by address
        /// </summary>
        /// <param name="Address">Gui address in SAP</param>
        /// <returns>GuiTextField object</returns>
        public GuiTextField GetTextFieldByID(string Address)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiTextField)SapWindow.FindById(Address);
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
            // SAP not connected return null
        }

        /// <summary>
        /// Get button by id
        /// </summary>
        /// <param name="Address">Button address in SAP</param>
        /// <returns>GuiButton object</returns>
        public GuiButton GetButtonByID(string Address)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiButton)SapWindow.FindById(Address);
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get CText field by name
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns>GuiCTextfield object</returns>
        public GuiCTextField GetCTextField(string fieldName)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiCTextField)SapWindow.FindByName(fieldName, "GuiCTextField");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get CText field by name
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns>GuiCTextfield object</returns>
        public GuiTextField GetTextField(string fieldName)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiTextField)SapWindow.FindByName(fieldName, "GuiTextField");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get button by name
        /// </summary>
        /// <param name="fieldName">Name of button</param>
        /// <returns>GuiButton object</returns>
        public GuiButton GetButton(string fieldName)
        {
            if (SapConnected)
            {
                // Try to find by name and catch any exceptions
                try
                {
                    return (GuiButton)SapWindow.FindByName(fieldName, "GuiButton");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get table by name
        /// </summary>
        /// <param name="fieldName">Table name</param>
        /// <returns>GuiTableControl object</returns>
        public GuiTableControl GetTable(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiTableControl)SapWindow.FindByName(fieldName, "GuiTableControl");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get grid view by name
        /// </summary>
        /// <param name="fieldName">Grid name</param>
        /// <returns>GuiGridView</returns>
        public GuiGridView GetGridView(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiGridView)SapWindow.FindByName(fieldName, "GuiGridView");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get check box by name
        /// </summary>
        /// <param name="fieldName">Check box name</param>
        /// <returns>GuiCheckBox</returns>
        public GuiCheckBox GetCheckBox(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiCheckBox)SapWindow.FindByName(fieldName, "GuiCheckBox");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get radio button by name
        /// </summary>
        /// <param name="fieldName">Radio button name</param>
        /// <returns>GuiRadioButton</returns>
        public GuiRadioButton GetRadioButton(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiRadioButton)SapWindow.FindByName(fieldName, "GuiRadioButton");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get tab by name
        /// </summary>
        /// <param name="fieldName">Tab name</param>
        /// <returns>GuiTab</returns>
        public GuiTab GetTab(string fieldName)
        {
            if (SapConnected)
            {
                try
                {
                    return (GuiTab)SapWindow.FindByName(fieldName, "GuiTab");
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); return null; }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Send a keystroke to the main SAP window
        /// </summary>
        /// <param name="keyId">Key ID (0 - Enter, 2 - F2, 4 - F4, 8 - F8)</param>
        public void SendVKey(int keyId)
        {
            if (SapConnected)
            {
                try
                {
                    SapWindow.SendVKey(keyId);
                }
                catch (Exception ex) { MsgBox_Error(ex.Message); }
            }
            // SAP not connected return null
            return;
        }

        /// <summary>
        /// Tries to clear common errors until no errors or warning exist, otherwise it will fail
        /// </summary>
        /// <param name="RetryAmount">How many times to retry</param>
        /// <param name="ShowError">Show error box?</param>
        /// <returns>true/false</returns>
        public bool ClearErrors(int RetryAmount, bool ShowError)
        {
            int Retrys = 0;

            if (SapConnected)
            {
                SendVKey(0);

                while (SapSession.ActiveWindow.Type != "GuiMainWindow")
                {
                    string WindowText = SapSession.ActiveWindow.Text;

                    if (WindowText.Contains("Priority Change"))
                    {
                        GuiButton button = (GuiButton)SapSession.ActiveWindow.FindByName("BUTTON_2", "GuiButton");
                        button.Press();
                    }

                    if (WindowText.Contains("Delete partner(s)"))
                    {
                        GuiButton button = (GuiButton)SapSession.ActiveWindow.FindByName("POP-OPTION1", "GuiButton");
                        button.Press();
                    }

                    SendVKey(0);
                    SendVKey(0);

                    Retrys++;

                    // Check how many times
                    if (Retrys > RetryAmount)
                    {
                        if (ShowError) MsgBox_Error("Could not clear popup error/warning");
                        break;
                    }
                }

                // Check status bar
                GuiStatusbar status = (GuiStatusbar)SapWindow.FindById("sbar");

                // Reset retry
                Retrys = 0;

                while (status.Text != "")
                {
                    SendVKey(0);
                    Retrys++;

                    // Check how many times
                    if (Retrys > RetryAmount)
                    {
                        if (ShowError) MsgBox_Error("Could not clear status bar error/warning");
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Sets SAP variant
        /// </summary>
        /// <param name="VarName">Variant name</param>
        public void SetVariant(string VarName)
        {
            if (SapConnected)
            {
                GetButton("btn[17]").Press();

                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtV-LOW")).Text = VarName;
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/ctxtENVIR-LOW")).Text = "";
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtENAME-LOW")).Text = "";
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtAENAME-LOW")).Text = "";
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtMLANGU-LOW")).Text = "";

                SendVKey(8);
            }
        }

        /// <summary>
        /// Creates SAP measurement point
        /// </summary>
        /// <param name="NewMeasurement">MobilityMeasurement</param>
        /// <param name="EquipmentNumber">Equipment Number</param>
        public void CreateMeasurementPoint(MobilityMeasurement NewMeasurement, string EquipmentNumber)
        {
            if (SapConnected)
            {
                SapSession.StartTransaction("IK01");

                string temp = GetCTextField("RIMR0-MPOTY").Text;

                GetCTextField("RIMR0-MPOTY").Text = "IEQ";
                if (temp != "IEQ") { SendVKey(0); }
                GetCTextField("EQUI-EQUNR").Text = EquipmentNumber;
                GetCTextField("IMPT-MPTYP").Text = "Z";

                SendVKey(0);

                // Check results
                switch (GetSessionInfo().ScreenNumber)
                {
                    // Equipment locked
                    case 1110:
                        MsgBox_Error($"Could not create measurement point {NewMeasurement.Description}");
                        break;

                    // All good
                    default:
                        GetTextField("IMPT-PSORT").Text = NewMeasurement.Position;
                        GetCTextField("IMPT-ATNAM").Text = NewMeasurement.CharCode;
                        GetCTextField("IMPT-CODGR").Text = NewMeasurement.CodeGroup;

                        ClearErrors(30, true);

                        GetTextField("IMPT-PTTXT").Text = NewMeasurement.Description;
                        GetTextField("IMPT-DECIM").Text = NewMeasurement.Decimals;
                        GetTextField("RIMR0-DESIC").Text = NewMeasurement.TargetValue;
                        GetTextField("IMPT-DSTXT").Text = NewMeasurement.TargetText;

                        ClearErrors(30, true);

                        // Check boxes
                        if (NewMeasurement.IsValueCodeSuff == "X") GetCheckBox("IMPT-CDSUF").Selected = true;
                        if (NewMeasurement.IsCounter == "X") GetCheckBox("IMPT-INDCT").Selected = true;

                        // Goto upper and lower limits
                        GetButton("DETAIL").Press();
                        ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMAC")).Text = NewMeasurement.UpperLimit;
                        ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMIC")).Text = NewMeasurement.LowerLimit;
                        ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[0]")).Press();

                        // Save
                        GetButton("btn[11]").Press();

                        break;

                }
            }
        }

        /// <summary>
        /// Change measurement point
        /// </summary>
        /// <param name="ExistingMeasurement">MobilityMeasurement</param>
        /// <param name="Number">Measurement number</param>
        public void ChangeMeasurementPoint(MobilityMeasurement ExistingMeasurement, string Number)
        {
            if (SapConnected)
            {
                StartTransaction("IK02");
                GetCTextField("IMPT-POINT").Text = Number;
                SendVKey(0);
                // Clear decimals and description
                GetTextField("IMPT-DECIM").Text = "";
                GetTextField("RIMR0-DESIC").Text = "";
                SendVKey(0);
                SendVKey(0);
                // Clear upper and lower limits
                GetButton("DETAIL").Press();
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMAC")).Text = "";
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMIC")).Text = "";
                ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[0]")).Press();
                // Save
                GetButton("btn[11]").Press();

                // Enter data
                StartTransaction("IK02");

                GetCTextField("IMPT-POINT").Text = Number;
                SendVKey(0);

                // Update position
                if (ExistingMeasurement.Position != GetTextField("IMPT-PSORT").Text)
                {
                    GetTextField("IMPT-PSORT").Text = ExistingMeasurement.Position;
                    SendVKey(0);
                    SendVKey(0);
                }

                GetTextField("IMPT-PTTXT").Text = ExistingMeasurement.Description;
                GetTextField("IMPT-DECIM").Text = ExistingMeasurement.Decimals;
                GetCTextField("IMPT-CODGR").Text = ExistingMeasurement.CodeGroup;
                GetTextField("RIMR0-DESIC").Text = ExistingMeasurement.TargetValue;
                SendVKey(0);
                GetTextField("IMPT-DSTXT").Text = ExistingMeasurement.TargetText;
                if (ExistingMeasurement.IsCounter == "X") GetCheckBox("IMPT-INDCT").Selected = true; else GetCheckBox("IMPT-INDCT").Selected = false;
                if (ExistingMeasurement.IsValueCodeSuff == "X") GetCheckBox("IMPT-CDSUF").Selected = true; else GetCheckBox("IMPT-CDSUF").Selected = false;

                // Upper lower limit
                GetButton("DETAIL").Press();
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMAC")).Text = ExistingMeasurement.UpperLimit;
                ((GuiTextField)SapSession.FindById("wnd[1]/usr/txtRIMR0-MRMIC")).Text = ExistingMeasurement.LowerLimit;
                ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[0]")).Press();

                // Save
                GetButton("btn[11]").Press();
            }
        }

        /// <summary>
        /// De-activate measurement point
        /// </summary>
        /// <param name="Number">Measpoint number</param>
        public void DeactiveMeasurement(string Number)
        {
            if (SapConnected)
            {
                SapSession.StartTransaction("IK02");
                GetCTextField("IMPT-POINT").Text = Number;
                SendVKey(0);
                string Title = GetTextField("IMPT-PTTXT").Text;

                if (Title.Length > 30)
                    GetTextField("IMPT-PTTXT").Text = Title[..30] + "_OLD";
                else
                    GetTextField("IMPT-PTTXT").Text = Title + "_OLD";

                GetFormById("wnd[0]/mbar/menu[0]/menu[7]/menu[0]/menu[0]").Select();
                GetButton("btn[11]").Press();
            }
        }

        // Get equipment number from serial number
        public string EquipmentNumberFromSerial(string Serial)
        {
            if (SapConnected)
            {
                SapSession.StartTransaction("IE06");

                SetVariant("/FSDS-25-45");

                GetCTextField("EQUNR-LOW").Text         = "";
                GetCTextField("EQUNR-HIGH").Text        = "";
                GetTextField("EQKTX-LOW").Text          = "";
                GetTextField("EQKTX-HIGH").Text         = "";
                GetCTextField("MATNR-LOW").Text         = "";
                GetCTextField("MATNR-HIGH").Text        = "";
                GetTextField("SERNR-LOW").Text          = "";
                GetTextField("SERNR-HIGH").Text         = "";
                GetCTextField("EQART-LOW").Text         = "";
                GetCTextField("EQART-HIGH").Text        = "";
                GetCTextField("STAI1-LOW").Text         = "";
                GetCTextField("STAI1-HIGH").Text        = "";
                GetCTextField("STRNO-LOW").Text         = "";
                GetCTextField("STRNO-HIGH").Text        = "";
                GetTextField("SERNR-LOW").Text          = Serial;
                GetCTextField("VARIANT").Text           = "/FS DEFAULT";

                SendVKey(8);

                ClearErrors(30, true);

                switch (GetSessionInfo().ScreenNumber)
                {
                    case 1000:
                        return "nothing";

                    case 500:

                        EquipmentSelect ToFind = new EquipmentSelect(RefForm);

                        GuiGridView EqTable = GetGridView("shell");

                        for (int i = 0; i < EqTable.RowCount; i++)
                        {
                            string[] ToAdd = new string[3];

                            ToAdd[0] = EqTable.GetCellValue(i, "EQUNR");
                            ToAdd[2] = EqTable.GetCellValue(i, "EQKTX");
                            ToAdd[1] = EqTable.GetCellValue(i, "SERNR");

                            ToFind.EqFound_LV.Items.Add(new ListViewItem(ToAdd));

                        }

                        ToFind.ShowDialog();

                        return ToFind.SelectedItem;

                    default:
                        return ((GuiCTextField)SapWindow.FindByName("ITOBATTR-EQUNR", "GuiCTextField")).Text;
                }
            }
            // SAP not connected return null
            return null;
        }

        /// <summary>
        /// Creates a new equipment number
        /// </summary>
        /// <param name="TemplateEq">Template number</param>
        /// <param name="SerialNumber">Serial number of equipment</param>
        /// <param name="MaterialNumber">ZAWA material</param>
        /// <returns>New equipment number</returns>
        public string CreateNewEquipment(string TemplateEq, string SerialNumber, string MaterialNumber)
        {
            if (SapConnected)
            {
                StartTransaction("IE01");

                GetCTextField("RM63E-EQUNR").Text = "";
                GetCTextField("RM63E-EQTYP").Text = "S";
                GetCTextField("RM63E-REFEQ").Text = TemplateEq;
                GetCTextField("RM63E-REFMA").Text = "";
                SendVKey(0);
                ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[30]")).Press();
                ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[30]")).Press();
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-CPMPT")).Selected = true;
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-CPMPX")).Selected = true;
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-CPMPC")).Selected = true;
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-CPMPD")).Selected = true;
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-CPKON")).Selected = true;
                ((GuiCheckBox)SapSession.FindById("wnd[1]/usr/chkRILOCP-J_3GCPBAU")).Selected = true;
                ((GuiButton)SapSession.FindById("wnd[1]/tbar[0]/btn[7]")).Press();

                GetTab(@"T\07").Select();
                GetTextField("ITOB-SERNR").Text = SerialNumber;
                GetCTextField("ITOB-MATNR").Text = MaterialNumber;

                GetButton("btn[11]").Press();
                EndTransaction();

                StartTransaction("IE02");

                return GetCTextField("RM63E-EQUNR").Text;

            }
            // SAP not connected return null
            return null;
        }

        public bool CheckMaterialSerial(string serial, string material)
        {
            if (SapConnected)
            {
                SapSession.StartTransaction("IQ02");

                ((GuiCTextField)SapWindow.FindByName("RISA0-MATNR", "GuiCTextField")).Text = material;
                ((GuiCTextField)SapWindow.FindByName("RISA0-SERNR", "GuiCTextField")).Text = serial;

                SapWindow.SendVKey(0);

                if (SapSession.Info.ScreenNumber != 1000)
                {
                    if (((GuiCTextField)SapWindow.FindByName("ITOBATTR-EQUNR", "GuiCTextField")).Text == "")
                    {
                        MsgBox_Error("This equipment serial number is linked to a material number in SAP but no equipment, please convert the material serial number to an equipment number to continue");
                        return false;
                    }
                    return true;
                }

                return true;
            }
            // SAP not connected return false
            return false;
        }

        /// <summary>
        /// Gets measurement points of an equipment and puts into memory
        /// </summary>
        /// <param name="InputEquipment">Equipment number</param>
        /// <returns>DataTable of measurements</returns>
        public DataTable GetMeasurementPoints(string InputEquipment)
        {
            ExcelDataTables TableManager = new ExcelDataTables();

            if (SapConnected)
            {
                StartTransaction("IK07");
                SetVariant("/FSDS-25-123");
                GetCTextField("EQUNR-LOW").Text = InputEquipment;
                SendVKey(8);

                switch (GetSessionInfo().ScreenNumber)
                {
                    // No measurements
                    case 1000: return null;

                    // Single point
                    case 5110:
                        DataTable Table = new DataTable();

                        // Create columns
                        Table.Columns.Add("Measurement Point");
                        Table.Columns.Add("Equipment");
                        Table.Columns.Add("Position");
                        Table.Columns.Add("Description");
                        Table.Columns.Add("Characteristic Name");
                        Table.Columns.Add("Decimal Places");
                        Table.Columns.Add("Code Group");
                        Table.Columns.Add("Target Value");
                        Table.Columns.Add("Lower Limit");
                        Table.Columns.Add("Upper Limit");
                        Table.Columns.Add("Text");
                        Table.Columns.Add("ValueCode Sufficient");
                        Table.Columns.Add("Is Counter");

                        // Create and add new row
                        DataRow NewRow = Table.NewRow();

                        NewRow["Measurement Point"]     = GetTextField("IMPT-POINT").Text;
                        NewRow["Equipment"]             = GetTextField("RIMR0-MPOBK").Text;
                        NewRow["Position"]              = GetTextField("IMPT-PSORT").Text;
                        NewRow["Description"]           = GetTextField("IMPT-PTTXT").Text;
                        NewRow["Characteristic Name"]   = GetCTextField("IMPT-ATNAM").Text;
                        NewRow["Decimal Places"]        = GetTextField("IMPT-DECIM").Text;
                        NewRow["Code Group"]            = GetCTextField("IMPT-CODGR").Text;
                        NewRow["Target Value"]          = GetTextField("RIMR0-DESIC").Text;
                        NewRow["Text"]                  = GetTextField("IMPT-DSTXT").Text;
                        NewRow["ValueCode Sufficient"]  = !GetCheckBox("IMPT-CDSUF").Selected ? "" : "X";
                        NewRow["Is Counter"]            = !GetCheckBox("IMPT-INDCT").Selected ? "" : "X";

                        // Open the upper lower limit box
                        GetButton("DETAIL").Press();
                        NewRow["Lower Limit"]           = ((GuiTextField)GetFormById("wnd[1]/usr/txtRIMR0-MRMAC")).Text;
                        NewRow["Upper Limit"]           = ((GuiTextField)GetFormById("wnd[1]/usr/txtRIMR0-MRMIC")).Text;
                        
                        EndSession();

                        return Table;

                    // List view
                    default:

                        // Build unique filename
                        string FilePath = $"{Environment.GetEnvironmentVariable("TEMP")}\\";
                        string FileName = $"IK08DUMP{InputEquipment}{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.txt";

                        GuiMenu Menu = (GuiMenu)SapWindow.FindById("wnd[0]/mbar/menu[0]/menu[10]/menu[2]");

                        Menu.Select();

                        // Text file format popup
                        GuiModalWindow Popup = (GuiModalWindow)SapSession.FindById("wnd[1]");
                        ((GuiRadioButton)Popup.FindById("usr/subSUBSCREEN_STEPLOOP:SAPLSPO5:0150/sub:SAPLSPO5:0150/radSPOPLI-SELFLAG[0,0]")).Select();
                        ((GuiButton)Popup.FindById("tbar[0]/btn[0]")).Press();

                        // Filename popup
                        Popup = (GuiModalWindow)SapSession.FindById("wnd[1]");
                        ((GuiCTextField)Popup.FindByName("DY_PATH", "GuiCTextField")).Text = FilePath;
                        ((GuiCTextField)Popup.FindByName("DY_FILENAME", "GuiCTextField")).Text = FileName;
                        ((GuiButton)Popup.FindById("tbar[0]/btn[11]")).Press();

                        return TableManager.ControlTexttoDataTable($"{FilePath}{FileName}");

                }
            }
            // SAP not connected return null
            return null;
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        // End session
        public void EndSession()
        {
            SapConnection = null;
            SapApp = null;
            SapWindow = null;
            SapConnected = false;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }

                // Free memory
                EndSession();

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
