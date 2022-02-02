using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using SAPFEWSELib;
using System.Collections.Generic;
using static Mobility_Setup_Tool.MsgBoxs;

namespace Mobility_Setup_Tool
{
    class Module_ZM12
    {
        public static AUTOSAP           Session;
        public static MobilityEquipment TemplateInfo;
        public static MobilityEquipment InputInfo;
        public static MobilityEquipment ChangeInfo;
        public static MainForm          RefForm;
        public static ExcelDataTables   TableManager = new ExcelDataTables();
        public static bool              NewEquipment = false;

        public virtual void SetMainForm(MainForm Reference)
        {
            RefForm = Reference;
            Session = new AUTOSAP(RefForm);
        }

        public virtual bool InitialEquipmentCheck(string              TemplateEquipment, 
                                                  string              InputSerial, 
                                                  string              InputZawa,
                                                  string              InputFuncLoc, 
                                                  BackgroundWorker    Parent, 
                                              ref MobilityEquipment   OutputEq) 
        {
            string InputEquipment;
  
            // Check for open session first
            if (Session.GetSession()) 
            {
                _ = RefForm.SetStatus("Checking if equipment is a material serial", 0);

                // Check if linked to material
                if (!Session.CheckMaterialSerial(InputSerial, InputZawa)) 
                {
                    return false;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus("Finding equipment number from input serial", 0);

                // Get equipment number
                InputEquipment = Session.EquipmentNumberFromSerial(InputSerial);

                // Fill output structure
                OutputEq.ZAWA               = InputZawa;
                OutputEq.SerialNumber       = InputSerial;
                OutputEq.FunctionLoc        = InputFuncLoc;

                // Cannot find equipment number
                if (InputEquipment == "") 
                {
                    return false;
                }

                if (InputEquipment.Length > 8) 
                {
                    if (InputEquipment == "No equipment found")
                    {
                        if (MsgBox_Question("No equipment number found with this serial number, do you want to create a new equipment from the template?") == DialogResult.Yes)
                        {
                            InputEquipment  = Session.CreateNewEquipment(TemplateEquipment, InputSerial, InputZawa, InputFuncLoc);
                            NewEquipment    = true;

                            // Create equipment failed
                            if (InputEquipment == "")
                            {
                                MsgBox_Error($"Failed to create new equipment from {TemplateEquipment}, please check your inputs");
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                // Update equipment number
                RefForm.Output_EQNum     = InputEquipment;
                OutputEq.EquipmentNumber = InputEquipment;

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus("Getting template equipment information", 0);

                // Get template equipment info
                Session.StartTransaction("IE03");
                Session.GetCTextField("RM63E-EQUNR").Text = TemplateEquipment;
                Session.SendVKey(0);

                // Check we have moved to next screen
                switch (Session.GetSessionInfo().ScreenNumber)
                {
                    case 100:
                        MsgBox_Error("Could not access template equipment, is the equipment locked?");
                        break;

                    default:
                        // Front tab
                        TemplateInfo.EquipmentNumber = TemplateEquipment;
                        TemplateInfo.Description = Session.GetTextField("ITOB-SHTXT").Text;
                        TemplateInfo.ObjectType = Session.GetCTextField("ITOB-EQART").Text;
                        TemplateInfo.ModelNumber = Session.GetTextField("ITOB-TYPBZ").Text;

                        RefForm.Output_EQDesc = TemplateInfo.Description;

                        // Organization Tab
                        Session.GetTab(@"T\03").Select();
                        TemplateInfo.CatProfile = Session.GetCTextField("ITOB-RBNR").Text;

                        // Sales and Dist Tab
                        Session.GetTab(@"T\06").Select();
                        TemplateInfo.DistChan = Session.GetCTextField("ITOB-VTWEG").Text;
                        TemplateInfo.Division = Session.GetCTextField("ITOB-SPART").Text;

                        // SerData
                        Session.GetTab(@"T\07").Select();
                        TemplateInfo.ZAWA = Session.GetCTextField("ITOB-MATNR").Text;
                        break;
                }

                Session.EndTransaction();

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus("Getting input equipment information", 0);

                // Get input equipment info
                Session.StartTransaction("IE03");
                Session.GetCTextField("RM63E-EQUNR").Text = InputEquipment;
                Session.SendVKey(0);

                // Check we have moved to next screen
                switch (Session.GetSessionInfo().ScreenNumber)
                {
                    // Not found
                    case 100:
                        MsgBox_Error("Could not access input equipment, is the equipment locked?");
                        return false;

                    default:
                        // Front tab
                        InputInfo.EquipmentNumber = InputEquipment;
                        InputInfo.Description = Session.GetTextField("ITOB-SHTXT").Text;
                        InputInfo.ObjectType = Session.GetCTextField("ITOB-EQART").Text;
                        InputInfo.ModelNumber = Session.GetTextField("ITOB-TYPBZ").Text;

                        // Organization Tab
                        Session.GetTab(@"T\03").Select();
                        InputInfo.CatProfile = Session.GetCTextField("ITOB-RBNR").Text;

                        // Sales and Dist Tab
                        Session.GetTab(@"T\06").Select();
                        InputInfo.DistChan = Session.GetCTextField("ITOB-VTWEG").Text;
                        InputInfo.Division = Session.GetCTextField("ITOB-SPART").Text;

                        // SerData
                        Session.GetTab(@"T\07").Select();
                        InputInfo.ZAWA = Session.GetCTextField("ITOB-MATNR").Text;

                        InputInfo.FunctionLoc = InputFuncLoc;
                        break;
                }

                Session.EndTransaction();

                // Initialize the change structure
                ChangeInfo.Description  = "";
                ChangeInfo.ObjectType   = "";
                ChangeInfo.ModelNumber  = "";
                ChangeInfo.CatProfile   = "";
                ChangeInfo.Division     = "";
                ChangeInfo.DistChan     = "";
                ChangeInfo.ZAWA         = "";

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus("Updating input equipment to template", 0);

                if (InputInfo.Description != TemplateInfo.Description) 
                {
                    if (MsgBox_Question($"Equipment description does not match template description {Environment.NewLine}CURRENT: {InputInfo.Description}{Environment.NewLine}TEMPLATE: {TemplateInfo.Description}{Environment.NewLine}Do you want to change this to match the template?") == DialogResult.Yes)
                    {
                        ChangeInfo.Description  = TemplateInfo.Description;
                        OutputEq.Description    = TemplateInfo.Description;
                    }
                }

                if (InputInfo.ObjectType != TemplateInfo.ObjectType) {
                    ChangeInfo.ObjectType   = TemplateInfo.ObjectType;
                    OutputEq.ObjectType     = TemplateInfo.ObjectType;
                }

                // Check model number integrity
                if(InputInfo.ModelNumber != "")
                { 
                    if (InputInfo.ModelNumber.Substring(InputInfo.ModelNumber.Length-4, 4).Contains("x") || InputInfo.ModelNumber.Substring(InputInfo.ModelNumber.Length - 4, 4).Contains("X") || InputInfo.ModelNumber.Contains("??"))
                    {
    LBL_FAIL_MODEL:
                        string Result = RefForm.GetInput("Model number is invalid please enter the correct number in the box below", InputInfo.ModelNumber, InputInfo.ModelNumber);

                        if (Result == "")
                        {
                            MsgBox_Error("Model number cannot be blank, please enter a model number");
                            goto LBL_FAIL_MODEL;
                        }

                        ChangeInfo.ModelNumber = Result;
                        OutputEq.ModelNumber   = Result;
                    } 
                }

                // Compare information found
                if (InputInfo.CatProfile != TemplateInfo.CatProfile)
                {
                    ChangeInfo.CatProfile = TemplateInfo.CatProfile;
                    OutputEq.CatProfile = TemplateInfo.CatProfile;
                }

                if (InputInfo.DistChan != TemplateInfo.DistChan)
                {
                    ChangeInfo.DistChan = TemplateInfo.DistChan;
                    OutputEq.DistChan = TemplateInfo.DistChan;
                }

                if (InputInfo.Division != TemplateInfo.Division)
                {
                    ChangeInfo.Division = TemplateInfo.Division;
                    OutputEq.Division = TemplateInfo.Division;
                }

                if (InputInfo.ZAWA != TemplateInfo.ZAWA)
                {
                    ChangeInfo.ZAWA = TemplateInfo.ZAWA;
                    OutputEq.ZAWA = TemplateInfo.ZAWA;
                }

                // Do equipment change
                Session.StartTransaction("IE02");
                Session.GetCTextField("RM63E-EQUNR").Text = InputInfo.EquipmentNumber;
                Session.SendVKey(0);

                // If user has asked to change description
                if (ChangeInfo.Description != "") 
                {
                    Session.GetTextField("ITOB-SHTXT").Text = ChangeInfo.Description;
                }

                Session.GetTextField("ITOB-MAPAR").Text = ChangeInfo.ModelNumber;
                Session.GetTextField("ITOB-TYPBZ").Text = ChangeInfo.ModelNumber;
                Session.GetTextField("ITOB-SERGE").Text = OutputEq.SerialNumber;

                // Organization tab
                Session.GetTab(@"T\03").Select();

                if (ChangeInfo.CatProfile != "")
                {
                    Session.GetCTextField("ITOB-RBNR").Text = ChangeInfo.CatProfile;
                    Session.SendVKey(0);
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Structure tab
                Session.GetTab(@"T\04").Select();

                if (Session.GetCTextField("ITOB-TPLNR").Text != InputFuncLoc)
                {
                    if (!Session.GetTextField("ITOBATTR-STTXT").Text.Contains("ESTO") && Session.GetCTextField("ITOB-HEQUI").Text == "")
                    {
                        Session.GetButton("FCODE_CIPL").Press();

                        if (Session.GetCTextField("ITOB-TPLNR").Text != "")
                        {
                            // Dismantle from function location
                            ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[14]")).Press();
                            ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[16]")).Press();
                        }

                        Session.GetButton("FCODE_CIPL").Press();

                        ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtIEQINSTALL-TPLNR")).Text = InputFuncLoc;

                        if (Session.GetSessionObj().ActiveWindow.Type != "GuiMainWindow") ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[16]")).Press();

                        if (Session.GetSessionInfo().ScreenNumber != 101) Session.SendVKey(3);

                        Session.GetCTextField("ITOB-SUBMT").Text = "";
                        Session.GetTextField("ITOB-TIDNR").Text = "";
                    }
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Sales tab
                Session.GetTab(@"T\06").Select();

                if (ChangeInfo.SalesOrg != "") Session.GetCTextField("ITOB-VKORG").Text = "1000";
                if (ChangeInfo.DistChan != "") Session.GetCTextField("ITOB-VTWEG").Text = ChangeInfo.DistChan;
                if (ChangeInfo.Division != "") Session.GetCTextField("ITOB-SPART").Text = ChangeInfo.Division;

                // Serial data tab
                Session.GetTab(@"T\07").Select();

                if (ChangeInfo.ZAWA != "")
                {
                    if (Session.GetCTextField("EQBS-B_CHARGE").Text == "")
                    {
                        ((GuiMenu)Session.GetFormById("wnd[0]/mbar/menu[1]/menu[5]/menu[1]")).Select();
                        ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtRISA0-MATNEU")).Text = ChangeInfo.ZAWA;
                        ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                        if (Session.GetSessionObj().ActiveWindow.Type != "GuiMainWindow")
                        {
                            ((GuiButton)Session.GetFormById("wnd[2]/usr/btnOPTION2")).Press();
                        }
                    }
                    else
                    {
                        MsgBox_Normal("Cannot change material number of an equipment installed into a storage location, please change ZAWA number manually.");
                    }
                }

                // Save
                Session.GetButton("btn[11]").Press();
                Session.ClearErrors(30, true);

                // Save
                Session.GetButton("btn[11]").Press();
                Session.EndTransaction();

                return true;

            }
                else
            {
                MsgBox_Error("Please ensure SAP is running!");
                return false;
            }

        }

        public virtual AUTOSAP ReturnSession() 
        {
            return Session;
        }

        //Check measurement point
        public virtual bool CheckMeasurementPoints(MobilityTask TaskInfo, BackgroundWorker Parent) 
        {
            if (TaskInfo.CEL == "NON-STANDARD VARIATION" || TaskInfo.CEL == "NONE" || NewEquipment) 
            {
                return true;
            }

            if (Session.GetSession())
            {
                // Import template measurements from SAP
                _ = RefForm.SetStatus("Getting template equipment measurements points", 0);
                DataTable TemplateMeasures = Session.GetMeasurementPoints(TemplateInfo.EquipmentNumber);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Import input measurements from SAP
                _ = RefForm.SetStatus("Getting input equipment measurement points", 0);
                DataTable EquipmentMeasures = Session.GetMeasurementPoints(InputInfo.EquipmentNumber);

                // Compare the measurements
                _ = RefForm.SetStatus("Comparing input measurement points to template", 0);
                List<MeasurementUpdate> MeasuresToChange = TableManager.CompareMeasurements(TemplateMeasures, EquipmentMeasures);

                int Delete = 0, Change = 0, Create = 0;

                // Sort numbers
                for(int i = 0; i < MeasuresToChange.Count; i++)
                {
                    switch(MeasuresToChange[i].Action)
                    {
                        case ACTION.CREATE:     Create++; break;
                        case ACTION.CHANGE:     Change++; break;
                        case ACTION.DEACTIVATE: Delete++; break;

                    }
                }

                // Ask user if they would like to fix measurements
                if (MeasuresToChange.Count > 0)
                {
                    if (MsgBox_Question($"EQUIPMENT MEASUREMENT ASSESSMENT:{Environment.NewLine}" +
                                        $"{Environment.NewLine}{Create} measurements missing and need to be created " +
                                        $"{Environment.NewLine}{Change} measurements found but require correction" +
                                        $"{Environment.NewLine}{Delete} duplicate measurement will be de-activated" +
                                        $"{Environment.NewLine}{Environment.NewLine}Do you want to continue?") == DialogResult.No) 
                    {
                        return false;
                    }
                }
                else
                {
                    MsgBox_Normal($"No errors found when comparing measurement");

                    // Finish
                    _ = RefForm.SetStatus("", 0);
                    TemplateMeasures.Dispose();
                    EquipmentMeasures.Dispose();
                    return true;
                }

                // Change / create measurement
                for (int i = 0; i < MeasuresToChange.Count; i++)
                {
                    // Check for cancel
                    if (Parent.CancellationPending) 
                    {
                        _ = RefForm.SetStatus("User canceled", 0);
                        return false;
                    }

                    double perc = (Convert.ToDouble(i) / (Convert.ToDouble(MeasuresToChange.Count - 1)) * 100);

                    switch (MeasuresToChange[i].Action)
                    {
                        case ACTION.CREATE:
                            if (Create > 0)
                            {
                                if (!RefForm.SetStatus($"Creating measurement point {MeasuresToChange[i].Info.Description} - [{i}/{MeasuresToChange.Count - 1}]", perc > 0 ? Convert.ToInt32(perc) : 1))
                                {
                                    return false;
                                }
                                Session.CreateMeasurementPoint(MeasuresToChange[i].Info, InputInfo.EquipmentNumber);
                            }
                            break;

                        case ACTION.CHANGE:
                            if (Change > 0)
                            {
                                if (!RefForm.SetStatus($"Changing measurement point {MeasuresToChange[i].Info.Description} - [{i}/{MeasuresToChange.Count - 1}]", perc > 0 ? Convert.ToInt32(perc) : 1)) 
                                {
                                    return false;
                                }
                                Session.ChangeMeasurementPoint(MeasuresToChange[i].Info, MeasuresToChange[i].ChangeNumber);
                            }
                            break;

                        case ACTION.DEACTIVATE:
                            if (!RefForm.SetStatus($"De-activating measurement point {MeasuresToChange[i].Info.Description} - [{i}/{MeasuresToChange.Count-1}]", perc > 0 ? Convert.ToInt32(perc) : 1))
                            {
                                return false;
                            }
                            Session.DeactiveMeasurement(MeasuresToChange[i].Info.Number);
                            break;
                    }
                }

                // Finish
                _ = RefForm.SetStatus("", 0);
                TemplateMeasures.Dispose();
                EquipmentMeasures.Dispose();

                return true;
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running!");
                return false;
            }
        }

        // Create CEL
        public virtual bool CreateEntryList(MobilityTask TaskInfo, BackgroundWorker Parent) 
        {
            // Variables
            int     ErrorCount      = 0;
            bool    OverwriteList   = false;
            string  EntryListNumber = "";
            string  KeyInput, KeyCEL;
            bool    Matched;

            if (Session.GetSession())
            {
                // Create data table from CEL tab
                _ = RefForm.SetStatus("Loading selected entry list from database", 0);

                DataTable CELTable = TableManager.ConvertExcelToDataTable_Name(RefForm.AppSettings.Defaults.CELPath, TaskInfo.CEL);

                if (CELTable == null)
                {
                    MsgBox_Error("Cannot find CEL data...");
                    return false;
                }

                // Get measurement points
                _ = RefForm.SetStatus("Getting input equipment measurement points", 0);
                DataTable InputMeasures = Session.GetMeasurementPoints(InputInfo.EquipmentNumber);

                // Create output table
                _ = RefForm.SetStatus("Building entry list data table into memory", 0);
                DataTable OutputEntryList = new DataTable();
                DataTable ErrorTable = new DataTable();

                // Add columns
                OutputEntryList.Columns.Add("Measurement Point");
                OutputEntryList.Columns.Add("Sort Order");

                ErrorTable.Columns.Add("Position");
                ErrorTable.Columns.Add("Description");

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Find measurements
                foreach (DataRow CELRow in CELTable.Rows)
                {
                    // Reset check
                    Matched = false;

                    // Concatenate position and description
                    KeyCEL = CELRow["MeasPosition"].ToString() + CELRow["MeasPoint Description"].ToString();

                    // Scan input measurements
                    foreach (DataRow InputRow in InputMeasures.Rows)
                    {
                        // Concatenate position and description of input
                        KeyInput = InputRow["Position"].ToString() + InputRow["Description"].ToString();

                        // Check CEL vs Input
                        if (KeyInput == KeyCEL)
                        {
                            Matched = true;

                            // Add to output
                            DataRow OutRow = OutputEntryList.NewRow();

                            OutRow["Measurement Point"] = InputRow["Measurement Point"].ToString();
                            OutRow["Sort Order"] = CELRow["Sort Order"].ToString();

                            OutputEntryList.Rows.Add(OutRow);

                            break;
                        }
                    }

                    // Check if we found the measurement
                    if (!Matched)
                    {
                        DataRow ErrorRow = ErrorTable.NewRow();

                        ErrorRow["Position"]    = CELRow["MeasPosition"].ToString();
                        ErrorRow["Description"] = CELRow["MeasPoint Description"].ToString();

                        ErrorTable.Rows.Add(ErrorRow);

                        ErrorCount++;
                    }

                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Errors found
                if (ErrorCount != 0)
                {
                    using (StreamWriter sw = File.CreateText(Environment.GetEnvironmentVariable("USERPROFILE") + $"\\Desktop\\CEL_ERROR{InputInfo.EquipmentNumber}.txt"))
                    {
                        foreach (DataRow row in ErrorTable.Rows)
                        {
                            sw.WriteLine(row["Position"].ToString() + " - " + row["Description"] + " - NOT FOUND IN INPUT MEASUREMENTS");
                        }
                    }

                    MsgBox_Error($"{ErrorCount} error found trying to generate entry list, please check error log CEL_ERROR.txt on your desktop for more information");

                    return false;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Check for existing lists
                _ = RefForm.SetStatus("Checking for existing entry lists", 0);

                Session.StartTransaction("IK33");
                Session.GetCTextField("IMEL-MELNR").SetFocus();
                Session.SendVKey(4);
                ((GuiTextField)Session.GetFormById("wnd[1]/usr/tabsG_SELONETABSTRIP/tabpTAB001/ssubSUBSCR_PRESEL:SAPLSDH4:0220/sub:SAPLSDH4:0220/txtG_SELFLD_TAB-LOW[0,24]")).Text = $"{InputInfo.EquipmentNumber}-{TaskInfo.Group}";
                ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                if (Session.GetSessionObj().ActiveWindow.Type != "GuiMainWindow" && !Session.GetSessionObj().ActiveWindow.Text.Contains("Restrict Value Range"))
                {
                    if (MsgBox_Question($"Entrylist [{TaskInfo.Name}] already exists do you want to overwrite?") == DialogResult.Yes)
                    {
                        Session.SendVKey(0);

                        OverwriteList = true;
                        EntryListNumber = Session.GetCTextField("IMEL-MELNR").Text;

                    }
                    else
                    {
                        return false;
                    }
                }

                if (OverwriteList)
                {
                    Session.StartTransaction("IK32");
                    Session.GetCTextField("IMEL-MELNR").Text = EntryListNumber;
                    Session.SendVKey(0);

                    // Clear list
                    Session.GetButton("btn[29]").Press();
                    Session.GetButton("btn[14]").Press();
                }
                else
                {
                    Session.StartTransaction("IK31");
                    Session.GetTextField("IMEL-NAMEL").Text = $"{InputInfo.EquipmentNumber}-{TaskInfo.Group}";
                    Session.SendVKey(0);
                }

                // MAximize SAP screen to get most lines possible
                Session.GetWindow().Maximize();

                if (TaskInfo.Name.Length > 40)
                {
                    Session.GetTextField("IMEL-MELTX").Text = TaskInfo.Name.Substring(0, 39);
                }
                else
                {
                    Session.GetTextField("IMEL-MELTX").Text = TaskInfo.Name;
                }

                GuiTableControl Table   = Session.GetTable("SAPLIMR7ERFALIST");

                // Use visible rows to determine how many lines to update at once this way
                // on smaller resolution screens the tool will still work
                // NOTE: we chose visible lines - 2 because SAP was not always showing the same
                // amount of visible lines each time.
                int MaxRow              = 0;
                int Interval            = (OutputEntryList.Rows.Count) / 100;
                int VisRows             = Table.VisibleRowCount - 2; 

                _ = RefForm.SetStatus("Uploading entry list..", 0);

                for (int i = 0; i < OutputEntryList.Rows.Count; i++)
                {
                    // Check for cancel
                    if (Parent.CancellationPending)
                    {
                        _ = RefForm.SetStatus("User canceled", 0);
                        return false;
                    }

                    if(!RefForm.SetStatus("Uploading entry list", i / VisRows * Interval)) 
                    {
                        return false;
                    }

                    ((GuiTextField)Table.FindById($"txtIMEP-SORTF[1,{MaxRow}]")).Text   = OutputEntryList.Rows[i]["Sort Order"].ToString();
                    ((GuiCTextField)Table.FindById($"ctxtIMEP-POINT[3,{MaxRow}]")).Text = OutputEntryList.Rows[i]["Measurement Point"].ToString();

                    MaxRow++;

                    if (MaxRow > VisRows)
                    {
                        Table.VerticalScrollbar.Position += VisRows+1;
                        Table  = Session.GetTable("SAPLIMR7ERFALIST");
                        MaxRow = 0;
                    }
                }

                Session.GetButton("btn[11]").Press();
                Session.EndTransaction();

                // Get CEL number
                Session.StartTransaction("IK32");
                RefForm.Output_CELNum = Session.GetCTextField("IMEL-MELNR").Text;

                _ = RefForm.SetStatus("Upload completed", 0);

                // Release memory
                CELTable.Dispose();
                InputMeasures.Dispose();
                OutputEntryList.Dispose();
                ErrorTable.Dispose();
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running!");
                return false;
            }

            return true;
        }

        // Check for existing orders
        public virtual bool InitialServiceCheck(MobilityTask TaskInfo, string Equipmentnumber, BackgroundWorker Parent) 
        {
            if (Session.GetSession())
            {
                DateTime StartDate;
                DateTime EndDate;

                StartDate = RefForm.GetBasicStartDate.AddMonths(-Convert.ToInt32(RefForm.AppSettings.WarrantyMonthLimit));
                EndDate = RefForm.GetBasicStartDate;

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus($"Checking for previous work orders in the last {RefForm.AppSettings.WarrantyMonthLimit} months..", 0);

                Session.StartTransaction("IW73");
                Session.SetVariant("/FSDS-25-32");

                // Set status exclusions to nothign
                Session.GetCheckBox("DY_OFN").Selected = true;
                Session.GetCheckBox("DY_IAR").Selected = true;
                Session.GetCheckBox("DY_MAB").Selected = true;
                Session.GetCheckBox("DY_HIS").Selected = true;

                // Expand all 
                Session.GetButton("btn[19]").Press();

                // Clear period
                Session.GetCTextField("DATUV").Text = "";
                Session.GetCTextField("DATUB").Text = "01.01.3000";

                // Equipment number
                Session.GetCTextField("EQUNR-LOW").Text = Equipmentnumber;

                // Set dates
                Session.GetCTextField("GLTRP-LOW").Text = StartDate.ToShortDateString().Replace("/", ".");
                Session.GetCTextField("GLTRP-HIGH").Text = EndDate.ToShortDateString().Replace("/", ".");

                // Set tasklist filter
                Session.GetCTextField("PLNNR-LOW").Text = TaskInfo.Group;
                Session.GetTextField("PLNAL-LOW").Text = TaskInfo.Counter;

                Session.SendVKey(8);

                if (Session.GetSessionInfo().ScreenNumber != 1000 && !TaskInfo.WarrantyClaim)
                {
                    if (MsgBox_Question($"This unit has been here with the same Task Type in the last {RefForm.AppSettings.WarrantyMonthLimit} months, are you sure this is not a warranty claim?") == DialogResult.No)
                    {
                        Session.EndTransaction();
                        return false;

                    }
                }

                Session.EndTransaction();
                return true;
   
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running");
                return false;
            }
        }

        // Create notification
        public virtual bool CreateNotification(MobilityTask             TaskInfo, 
                                               MobilityEquipment        SetupEquipment,
                                               MobilityServiceOrder     SOInfo, 
                                               BackgroundWorker         Parent) 
        {

            if (Session.GetSession())
            {
                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                _ = RefForm.SetStatus("Creating notification", 0);

                Session.StartTransaction("IW51");
                if (TaskInfo.WarrantyClaim)
                {
                    Session.GetCTextField("RIWO00-QMART").Text = "Z3";
                }else
                {
                    Session.GetCTextField("RIWO00-QMART").Text = "Z8";
                }

                Session.GetCTextField("RIWO00-QWRNUM").Text = "300424160";

                Session.SendVKey(0);

                string OutputDesc;

                // Truncate task description if longer than 40 characters
                if (TaskInfo.Name.Length > 40) 
                {
                    OutputDesc = TaskInfo.Name.Remove(40, TaskInfo.Name.Length - 40);
                }
                else 
                {
                    OutputDesc = TaskInfo.Name;
                }

                // Fill in notification
                Session.GetTextField("VIQMEL-QMTXT").Text = OutputDesc;
                Session.GetCTextField("VIQMEL-QMDAT").Text = SOInfo.PurchaseOrderDate;
                Session.GetCTextField("VIQMEL-MZEIT").Text = DateTime.Now.ToShortTimeString();
                Session.GetComboBox("VIQMEL-PRIOK").Key = SOInfo.Priority.Substring(0,1);

                Session.ClearErrors(30, true);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Reset reference object view
                ((GuiMenu)  Session.GetFormById("wnd[0]/mbar/menu[3]/menu[9]/menu[0]")).Select();
                ((GuiLabel) Session.GetFormById("wnd[1]/usr/lbl[6,3]")).SetFocus();
                ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                Session.GetCTextField("VIQMEL-AUSWK").Text      = RefForm.AppSettings.Effect;
                Session.GetCTextField("RIWO00-GEWRK").Text      = TaskInfo.Workcentre;
                Session.GetCTextField("VIQMEL-VKBUR").Text      = SOInfo.SalesOffice;
                Session.GetCTextField("VIQMEL-VKGRP").Text      = SOInfo.SalesGroup;
                Session.GetCTextField("VIQMEL-INGRP").Text      = RefForm.AppSettings.PlannerGroup;
                Session.GetCTextField("RIWO00-SWERK").Text      = RefForm.AppSettings.Plant;

                Session.SendVKey(0);

                Session.GetCTextField("VIQMEL-QMNAM").Text      = "CU";
                Session.GetTextField("VIQMEL-BSTNK").Text       = SOInfo.PurchaseOrder;
                Session.GetCTextField("VIQMEL-BSTDK").Text      = SOInfo.PurchaseOrderDate;

                // If we are not creating order without equipment
                if (!SOInfo.CreateWithoutEq) 
                {
                    Session.GetCTextField("RIWO1-EQUNR").Text   = SetupEquipment.EquipmentNumber;
                }

                Session.GetCTextField("VIQMEL-KUNUM").Text      = SOInfo.SoldToParty;

                Session.ClearErrors(30, true);

                Session.GetCTextField("VIQMEL-LTRMN").Text      = SOInfo.BasicEndDate;
                Session.ClearErrors(30, true);
                Session.GetCTextField("VIQMEL-STRMN").Text      = SOInfo.BasicStartDate;
                Session.ClearErrors(30, true);

                Session.GetShell("shell").Text                  = TaskInfo.LongText;

                Session.GetTab(@"10\TAB06").Select();

                Session.GetCTextField("ILOA-SWERK").Text        = RefForm.AppSettings.Plant;
                Session.GetCTextField("ILOA-STORT").Text        = RefForm.AppSettings.Location;
                Session.GetCTextField("RILA0-ARBPL").Text       = TaskInfo.Workcentre;
                Session.GetCTextField("ILOA-VKORG").Text        = RefForm.AppSettings.Organization;

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.ClearErrors(30, true);

                Session.GetCTextField("ILOA-VTWEG").Text        = RefForm.AppSettings.Distribution;
                Session.GetCTextField("ILOA-SPART").Text        = RefForm.AppSettings.Division;

                // Set WBS element
                if (TaskInfo.WBS != "") 
                {
                    if (Session.GetCTextField("ILOA-PROID").Text != "" || Session.GetCTextField("ILOA-PROID").Text != TaskInfo.WBS) 
                    {
                        Session.GetCTextField("ILOA-PROID").Text = "";
                        Session.ClearErrors(30, true);
                    }

                    Session.GetCTextField("ILOA-PROID").Text = TaskInfo.WBS;
                    Session.ClearErrors(30, true);
                }

                Session.GetTextField("ILOA-EQFNR").Text = SOInfo.ExternalReference != "" ? SOInfo.ExternalReference : "N/A";

                Session.GetTab(@"10\TAB01").Select();

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Reset data after location
                Session.GetCTextField("VIQMEL-IWERK").Text = RefForm.AppSettings.Plant;
                Session.GetCTextField("VIQMEL-VKBUR").Text = SOInfo.SalesOffice;
                Session.GetCTextField("VIQMEL-VKGRP").Text = SOInfo.SalesGroup;
                Session.GetCTextField("RIWO00-GEWRK").Text = TaskInfo.Workcentre;
                Session.GetCTextField("VIQMEL-VKBUR").Text = SOInfo.SalesOffice;
                Session.GetCTextField("VIQMEL-INGRP").Text = RefForm.AppSettings.PlannerGroup;
                Session.GetCTextField("RIWO00-SWERK").Text = RefForm.AppSettings.Plant;

                Session.ClearErrors(30, true);
                
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running");
                return false;
            }

            return true;
        }

        // Create service order
        public virtual bool CreateServiceOrder(MobilityTask             TaskInfo, 
                                               MobilityEquipment        SetupEquipment,
                                               MobilityServiceOrder     SOInfo, 
                                               List<SAPComponent>       Components, 
                                               BackgroundWorker         Parent) 
        {
            if (Session.GetSession())
            {
                _ = RefForm.SetStatus("Creating service order", 0);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.GetButton("*VIQMEL-AUFNR").Press();

                if (!TaskInfo.WarrantyClaim)
                {
                    ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtRIWO00-AUART")).Text = "ZM12";
                } 
                else 
                {
                    ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtRIWO00-AUART")).Text = "ZM32";
                }
                ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                Session.SendVKey(0); 
                Session.SendVKey(0); 
                Session.SendVKey(0); 
                Session.SendVKey(0); 
                Session.SendVKey(0);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Set ZDI1
                if (TaskInfo.WarrantyClaim) 
                {
                    Session.GetCTextField("PMSDO-MATNR").Text  = SetupEquipment.ZDI1;
                    Session.GetCTextField("CAUFVD-BEMOT").Text = "02";
                }
                else
                {
                    Session.GetCTextField("PMSDO-MATNR").Text = SetupEquipment.ZDI1;
                }

                Session.GetTextField("PMSDO-MENGE").Text    = "1";        // Qty
                Session.GetCTextField("PMSDO-FAKTF").Text   = "01";       // Billing form

                Session.SendVKey(0);

                Session.GetCTextField("CAUFVD-GLTRP").Text = SOInfo.BasicEndDate;
                Session.ClearErrors(30, true);
                Session.GetCTextField("CAUFVD-GSTRP").Text = SOInfo.BasicStartDate;
                Session.ClearErrors(30, true);

                Session.GetCTextField("CAUFVD-ILART").Text = SOInfo.ActivityType;
                Session.GetComboBox("CAUFVD-PRIOK").Key    = SOInfo.Priority.Substring(0,1);
                Session.GetCTextField("CAUFVD-VAPLZ").Text = TaskInfo.Workcentre;

                // Reset equipment
                Session.GetCTextField("CAUFVD-EQUNR").Text = "";
                Session.GetCTextField("CAUFVD-TPLNR").Text = "";
                Session.ClearErrors(30, true);
                Session.GetCTextField("CAUFVD-EQUNR").Text = SetupEquipment.EquipmentNumber;
                Session.ClearErrors(30, true);

                // Add missing planner group
                Session.GetCTextField("CAUFVD-INGPR").Text = RefForm.AppSettings.PlannerGroup;

                // Go to location tab
                Session.GetTab("ILOA").Select();

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.GetCTextField("ILOA-SWERK").Text    = RefForm.AppSettings.Plant;
                Session.GetCTextField("ILOA-STORT").Text    = RefForm.AppSettings.Location;
                Session.GetCTextField("RILA0-ARBPL").Text   = TaskInfo.Workcentre;
                Session.GetTextField("ILOA-EQFNR").Text     = SOInfo.ExternalReference != "" ? SOInfo.ExternalReference : "N/A";

                Session.ClearErrors(30, true);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Add tasklist
                if (TaskInfo.Group != "" || TaskInfo.CEL != "NON-STANDARD VARIATION")
                {
                    ((GuiMenu)Session.GetFormById("wnd[0]/mbar/menu[3]/menu[0]/menu[0]")).Select();
                    //if(Session.GetActiveWindow().Type != "GuiMainWindow") ((GuiButton)Session.GetFormById("wnd[1]/usr/btnSPOP-OPTION1")).Press();

                    ((GuiRadioButton)   Session.GetFormById("wnd[1]/usr/radRIHEA-PN_IHAN")).Selected    = true;
                    ((GuiCTextField)    Session.GetFormById("wnd[1]/usr/ctxtCAUFVD-PLNNR")).Text        = TaskInfo.Group;
                    ((GuiTextField)     Session.GetFormById("wnd[1]/usr/txtCAUFVD-PLNAL")).Text         = TaskInfo.Counter;
                    ((GuiButton)        Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                    // Press yes to delete current operations
                    if(Session.GetActiveWindow().Type != "GuiMainWindow")
                    {
                        ((GuiButton)Session.GetFormById("wnd[2]/usr/btnSPOP-OPTION1")).Press();
                    }    
                    
                }
                    else
                {
                    // Add planned hours
                    string PlannedHours = RefForm.GetInput("Please enter planned hours for this task", "Planned hours", "1");

                    Session.GetTab("VGUE").Select();
                    GuiTableControl Operations = Session.GetTable("SAPLCOVGTCTRL_3010");
                    ((GuiTextField)Operations.FindById("txtAFVGD-ARBEI[10,0]")).Text = PlannedHours;
                }

                // Add components
                if (Components == null)
                {
                    Session.GetTab("MUEB").Select();

                    // Check for cancel
                    if (Parent.CancellationPending)
                    {
                        _ = RefForm.SetStatus("User canceled", 0);
                        return false;
                    }

                    // Set to B03
                    if (MsgBox_Question("Would you like to change the component's store location?") == DialogResult.Yes){

                        using SelectNewStore NewStoreDialog = new SelectNewStore(RefForm);
                        NewStoreDialog.ShowDialog();

                        if (NewStoreDialog.RunChangeStore)
                        { 
                            Session.ChangeStore(NewStoreDialog.StoreLoc, NewStoreDialog.SpecStock, Parent);
                        }
                    }
                }
                    else
                {
                    GuiCTextField           CurrentLoc, CurrentStock, CurrentZAWA, CurrentItemCat;
                    GuiTextField            CurrentQty, CurrentAct;
                    GuiComponentCollection  ZAWA, Quantity, StoreLoc, SpecialStock, ItemCat, Act;
                    GuiTableControl         ComponentTable;

                    // Get table initially 
                    ComponentTable  = Session.GetTable("SAPLCOMKTCTRL_3020");
                    int VisRows     = ComponentTable.VisibleRowCount;
                    int CurRow      = 0;

                    // Find next empty slot 
                    for (int i = 0; i < ComponentTable.Rows.Count; i++)
                    {
                        // Refresh connection to table 
                        ComponentTable  = Session.GetTable("SAPLCOMKTCTRL_3020");
                        ZAWA            = ComponentTable.FindAllByName("RESBD-MATNR", "GuiCTextField");
                        CurrentZAWA     = ((GuiCTextField)ZAWA.Item(i));

                        if (CurrentZAWA.Text == "") break;

                        CurRow++;
                    }

                    // Add the components 
                    for (int i = 0; i < Components.Count; i++)
                    {
                        if (CurRow >= VisRows)
                        {
                            ComponentTable = Session.GetTable("SAPLCOMKTCTRL_3020");
                            ComponentTable.VerticalScrollbar.Position += VisRows;
                            CurRow = 1;
                        }

                        // Refresh connection to table 
                        ComponentTable          = Session.GetTable("SAPLCOMKTCTRL_3020");
                        ZAWA                    = ComponentTable.FindAllByName("RESBD-MATNR", "GuiCTextField");
                        Quantity                = ComponentTable.FindAllByName("RESBD-MENGE", "GuiTextField");
                        StoreLoc                = ComponentTable.FindAllByName("RESBD-LGORT", "GuiCTextField");
                        SpecialStock            = ComponentTable.FindAllByName("RESBD-SOBKZ_D", "GuiCTextField");
                        ItemCat                 = ComponentTable.FindAllByName("RESBD-POSTP", "GuiCTextField");
                        Act                     = ComponentTable.FindAllByName("RESBD-VORNR", "GuiTextField");

                        // Get fields in current row 
                        CurrentLoc              = ((GuiCTextField)StoreLoc.Item(CurRow));
                        CurrentStock            = ((GuiCTextField)SpecialStock.Item(CurRow));
                        CurrentZAWA             = ((GuiCTextField)ZAWA.Item(CurRow));
                        CurrentQty              = ((GuiTextField)Quantity.Item(CurRow));
                        CurrentItemCat          = ((GuiCTextField)ItemCat.Item(CurRow));
                        CurrentAct              = ((GuiTextField)Act.Item(CurRow));

                        // Add data 
                        CurrentItemCat.Text     = "L";
                        CurrentAct.Text         = "0010";
                        CurrentZAWA.Text        = Components[i].ZAWA;
                        CurrentQty.Text         = Components[i].Qauntity;
                        CurrentStock.Text       = Components[i].SpecialStock;
                        CurrentLoc.Text         = Components[i].StoreLocation;

                        Session.SendVKey(0);

                        //((GuiTextField)Session.GetFormById("wnd[1]/usr/txtRCM01-VORNR")).Text = "0010";

                        Session.ClearErrors(30, true);

                        CurRow++;
                    }
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    _ = RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Set settlement rule for warranty
                if (TaskInfo.WarrantyClaim)
                {
                    // Delete current rules
                    Session.GetButton("btn[30]").Press();
                    Session.GetButton("btn[14]").Press();
                    Session.GetButton("btn[14]").Press();

                    // Add warranty cost re-direction rule
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtCOBRB-KONTY[0,0]")).Text    = "G/L";
                    Session.SendVKey(0);
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtDKOBR-EMPGE[1,0]")).Text    = "240600";
                    Session.SendVKey(0);
                    ((GuiTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/txtCOBRB-PROZS[3,0]")).Text      = "100";
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtCOBRB-PERBZ[5,0]")).Text    = "FUL";
                    Session.SendVKey(3);
                }

                // Release order
                if (MsgBox_Question("Would you like to release this service order?") == DialogResult.Yes)
                {
                    Session.GetButton("btn[25]").Press();
                }

                Session.GetButton("btn[11]").Press();
                
                if (Session.GetActiveWindow().Type != "GuiMainWindow")
                {
                    ((GuiButton)Session.GetFormById("wnd[1]/usr/btnSPOP-OPTION1")).Press();
                   Session.GetButton("btn[11]").Press();
                }

                // Finalize order
                if(!Finalize(TaskInfo, SOInfo, SetupEquipment))
                {
                    MsgBox_Error("Failed to created service order");
                    return false;
                }
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running");
                return false;
            }

            return true;
        }

        // Create service order
        public virtual bool Finalize(MobilityTask TaskInfo, MobilityServiceOrder InputSO, MobilityEquipment InputEq) 
        {
            if (Session.GetSession())
            {
                Session.StartTransaction("IW32");
                Session.SendVKey(0);

                // Verify order created
                if (Session.GetSessionInfo().ScreenNumber != 3000) return false;

                string Customer = InputSO.CustomerName.Replace(@"/", "");
                       Customer = InputSO.CustomerName.Replace(@"\", "");

                // Verify the order was created and get the numbers
                RefForm.Output_ServiceOrder = Session.GetTextField("CAUFVD-AUFNR").Text;
                RefForm.Output_Notification = Session.GetTextField("CAUFVD-QMNUM").Text;

                // Verify inputs
                if(Session.GetCTextField("VIQMEL-KUNUM").Text == "")
                {
                    MsgBox_Warning($"There were errors in the service order creation, please verify the information for order {RefForm.Output_ServiceOrder}, [SOLD TO PART MISSING]");
                }

                if(Session.GetTextField("PMSDO-BSTKD").Text == "")
                {
                    MsgBox_Warning($"There were errors in the service order creation, please verify the information for order {RefForm.Output_ServiceOrder}, [PO MISSING]");
                }

                if(Session.GetCTextField("PMSDO-FAKTF").Text == "")
                {
                    MsgBox_Warning($"There were errors in the service order creation, please verify the information for order {RefForm.Output_ServiceOrder}, [BILLING FORM MISSING]");
                }

                Session.GetTab("ILOA").Select();

                Session.GetCTextField("ILOA-SWERK").Text = RefForm.AppSettings.Plant;
                Session.GetCTextField("ILOA-STORT").Text = RefForm.AppSettings.Location;
                Session.GetCTextField("RILA0-ARBPL").Text = TaskInfo.Workcentre;
                Session.GetTextField("ILOA-EQFNR").Text = InputSO.ExternalReference != "" ? InputSO.ExternalReference : "";

                Session.EndTransaction();

                if (TaskInfo.FolderPath != "")
                {
                    // Build path string
                    string Dir = $"{RefForm.AppSettings.ServerIndex}{TaskInfo.FolderPath}\\{RefForm.Output_ServiceOrder} {TaskInfo.Name.Replace("/", "")} SN {InputEq.SerialNumber} ({RefForm.DatabaseController.GetCustomerAbbr_ByName(InputSO.CustomerName)})";

                    // Create the path
                    Directory.CreateDirectory(Dir);
                    Directory.CreateDirectory($"{Dir}\\REPORTS");
                    Directory.CreateDirectory($"{Dir}\\PLANNING");
                    Directory.CreateDirectory($"{Dir}\\PHOTOS");
                    Directory.CreateDirectory($"{Dir}\\PHOTOS\\EAR");
                    Directory.CreateDirectory($"{Dir}\\PHOTOS\\FINAL");

                    // Verify
                    if (Directory.Exists(Dir))
                    {
                        MsgBox_Normal($"Service order created successfully, folder {Dir} has been created");
                    }
                    else
                    {
                        MsgBox_Warning("Service order created successfully, failed to create folder");
                    }
                }
                else
                {
                    MsgBox_Error("Please ensure SAP is running");
                }
            }
            else
            {
                MsgBox_Normal("Service order created successfully, no file path set for this task type so no folder was created.");
            }
            
            return true;
        }

        // Create service order
        public virtual bool CreateServiceOrderFromNotification(MobilityTask TaskInfo, MobilityEquipment SetupEquipment, MobilityServiceOrder SOInfo, List<SAPComponent> Components, string Notification, BackgroundWorker Parent)
        {
            if (Session.GetSession())
            {
                if (!Parent.CancellationPending)
                {
                    Session.StartTransaction("IW52");
                    Session.GetCTextField("RIWO00-QMNUM").Text = Notification;
                    Session.SendVKey(0);

                    // Verify the notification
                    if (Session.GetSessionInfo().ScreenNumber == 100) 
                    {
                        Session.ClearErrors(30, false);

                        if (Session.GetSessionInfo().ScreenNumber == 100) 
                        {
                            MsgBox_Error("Cannot find notification you have selected!");
                        }
                    }

                    // Check notification
                    if(Session.GetTextField("VIQMEL-QMTXT").Text != TaskInfo.Name)
                    {
                        if(MsgBox_Question($"Description {Session.GetTextField("VIQMEL-QMTXT").Text} does not match template description {TaskInfo.Name}, do you want to change it?") == DialogResult.Yes)
                        {
                            Session.GetTextField("VIQMEL-QMTXT").Text = TaskInfo.Name;
                        }
                    }

                    // Get the PO number
                    SOInfo.PurchaseOrder = Session.GetTextField("VIQMEL-BSTNK").Text;

                    CreateServiceOrder(TaskInfo, SetupEquipment, SOInfo, Components, Parent);
                }
            }
            else
            {
                MsgBox_Error("Please ensure SAP is running");
                return false;
            }

            return true;
        }
    }
}
