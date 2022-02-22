using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SAPFEWSELib;
using System.Collections.Generic;
using static Mobility_Setup_Tool.MsgBoxs;

namespace Mobility_Setup_Tool
{
    class Module_NRENGINECCO : Module_ZM12
    {
        public override bool InitialEquipmentCheck(string               TemplateEquipment, 
                                                   string               InputSerial, 
                                                   string               InputZawa, 
                                                   string               InputFuncLoc, 
                                                   BackgroundWorker     Parent, 
                                               ref MobilityEquipment    OutputEq) 
        {
            string InputEquipment;

            // Check for open session first
            if (Session.GetSession()) 
            {
                RefForm.SetStatus("Checking if equipment is a material serial", 0);

                // Check if linked to material
                if (!Session.CheckMaterialSerial(InputSerial, InputZawa)) 
                {
                    return false;
                }

                RefForm.SetStatus("Finding equipment number from input serial", 0);

                // Get equipment number
                InputEquipment = Session.EquipmentNumberFromSerial(InputSerial);
                RefForm.Output_EQNum = InputEquipment;

                // Fill output structure
                OutputEq.EquipmentNumber = InputEquipment;
                OutputEq.ZAWA = InputZawa;
                OutputEq.SerialNumber = InputSerial;
                OutputEq.FunctionLoc = InputFuncLoc;

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

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
                            InputEquipment = Session.CreateNewEquipment(TemplateEquipment, InputSerial, InputZawa, InputFuncLoc);

                            if (InputEquipment == "") MsgBox_Error($"Failed to create new equipment from {TemplateEquipment}, please check your inputs");
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                RefForm.SetStatus("Getting template equipment information", 0);

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
                        TemplateInfo.EquipmentNumber    = TemplateEquipment;
                        TemplateInfo.Description        = Session.GetTextField("ITOB-SHTXT").Text;
                        TemplateInfo.ObjectType         = Session.GetCTextField("ITOB-EQART").Text;
                        TemplateInfo.ModelNumber        = Session.GetTextField("ITOB-TYPBZ").Text;

                        RefForm.Output_EQDesc           = TemplateInfo.Description;

                        // Organization Tab
                        Session.GetTab(@"T\03").Select();
                        TemplateInfo.CatProfile         = Session.GetCTextField("ITOB-RBNR").Text;

                        // Sales and Dist Tab
                        Session.GetTab(@"T\06").Select();
                        TemplateInfo.DistChan           = Session.GetCTextField("ITOB-VTWEG").Text;
                        TemplateInfo.Division           = Session.GetCTextField("ITOB-SPART").Text;

                        // SerData
                        Session.GetTab(@"T\07").Select();
                        TemplateInfo.ZAWA               = Session.GetCTextField("ITOB-MATNR").Text;
                        break;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.EndTransaction();

                RefForm.SetStatus("Getting input equipment information", 0);

                // Get input equipment info
                Session.StartTransaction("IE03");
                Session.GetCTextField("RM63E-EQUNR").Text = InputEquipment;
                Session.SendVKey(0);

                // Check we have moved to next screen
                switch (Session.GetSessionInfo().ScreenNumber)
                {
                    case 100:
                        MsgBox_Error("Could not access input equipment, is the equipment locked?");
                        return false;

                    default:
                        // Front tab
                        InputInfo.EquipmentNumber   = InputEquipment;
                        InputInfo.Description       = Session.GetTextField("ITOB-SHTXT").Text;
                        InputInfo.ObjectType        = Session.GetCTextField("ITOB-EQART").Text;
                        InputInfo.ModelNumber       = Session.GetTextField("ITOB-TYPBZ").Text;

                        // Organization Tab
                        Session.GetTab(@"T\03").Select();
                        InputInfo.CatProfile        = Session.GetCTextField("ITOB-RBNR").Text;

                        // Sales and Dist Tab
                        Session.GetTab(@"T\06").Select();
                        InputInfo.DistChan          = Session.GetCTextField("ITOB-VTWEG").Text;
                        InputInfo.Division          = Session.GetCTextField("ITOB-SPART").Text;

                        // SerData
                        Session.GetTab(@"T\07").Select();
                        InputInfo.ZAWA              = Session.GetCTextField("ITOB-MATNR").Text;

                        InputInfo.FunctionLoc       = InputFuncLoc;
                        break;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.EndTransaction();
        
                // Compare two structures
                bool Matching = true;

                // Initialize the change structure
                ChangeInfo.Description = "";
                ChangeInfo.ObjectType = "";
                ChangeInfo.ModelNumber = "";
                ChangeInfo.CatProfile = "";
                ChangeInfo.Division = "";
                ChangeInfo.DistChan = "";
                ChangeInfo.ZAWA = "";

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                RefForm.SetStatus("Updating input equipment to template", 0);

                if (InputInfo.Description != TemplateInfo.Description && !InputInfo.Description.Contains("LOCO")) 
                {
                    if (MsgBox_Question($"Equipment description {InputInfo.Description} does not match template description {TemplateInfo.Description}. Do you want to change this to match the template?") == DialogResult.Yes)
                    {
                        Matching = false;
                        ChangeInfo.Description = TemplateInfo.Description;
                        OutputEq.Description = TemplateInfo.Description;
                    }
                }

                if (InputInfo.ObjectType != TemplateInfo.ObjectType) 
                {
                    Matching = false;
                    ChangeInfo.ObjectType = TemplateInfo.ObjectType;
                    OutputEq.ObjectType = TemplateInfo.ObjectType;
                }

                if (InputInfo.CatProfile != TemplateInfo.CatProfile) 
                {
                    Matching = false;
                    ChangeInfo.CatProfile = TemplateInfo.CatProfile;
                    OutputEq.CatProfile = TemplateInfo.CatProfile;
                }

                if (InputInfo.DistChan != TemplateInfo.DistChan)
                {
                    Matching = false;
                    ChangeInfo.DistChan = TemplateInfo.DistChan;
                    OutputEq.DistChan = TemplateInfo.DistChan;
                }

                if (InputInfo.Division != TemplateInfo.Division)
                {
                    Matching = false;
                    ChangeInfo.Division = TemplateInfo.Division;
                    OutputEq.Division = TemplateInfo.Division;
                }

                if (InputInfo.ZAWA != TemplateInfo.ZAWA) 
                {
                    Matching = false;
                    ChangeInfo.ZAWA = TemplateInfo.ZAWA;
                    OutputEq.ZAWA = TemplateInfo.ZAWA;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Do equipment change
                if (!Matching)
                {
                    Session.StartTransaction("IE02");
                    Session.GetCTextField("RM63E-EQUNR").Text = InputInfo.EquipmentNumber;
                    Session.SendVKey(0);

                    if (ChangeInfo.Description != "") Session.GetTextField("ITOB-SHTXT").Text = ChangeInfo.Description;
                    if (ChangeInfo.ModelNumber != "") Session.GetTextField("ITOB-TYPBZ").Text = ChangeInfo.ModelNumber;

                    // Organization tab
                    Session.GetTab(@"T\03").Select();

                    if (ChangeInfo.CatProfile != "") 
                    {
                        Session.GetCTextField("ITOB-RBNR").Text = ChangeInfo.CatProfile;
                        Session.SendVKey(0);
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

                    // Check for cancel
                    if (Parent.CancellationPending)
                    {
                        MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                        RefForm.SetStatus("User canceled", 0);
                        return false;
                    }

                }

                return true;

            } else {
                return false;
            }

        }

        // Check for existing orders
        public override bool InitialServiceCheck(MobilityTask TaskInfo, string Equipmentnumber, BackgroundWorker Parent) 
        {
            if (Session.GetSession())
            {
                DateTime StartDate;
                DateTime EndDate;

                StartDate = RefForm.GetBasicStartDate.AddMonths(-Convert.ToInt32(RefForm.AppSettings.WarrantyMonthLimit));
                EndDate = RefForm.GetBasicStartDate;

                RefForm.SetStatus($"Checking for previous work orders in the last {RefForm.AppSettings.WarrantyMonthLimit} months..", 0);

                Session.StartTransaction("IW73");
                Session.SetVariant("/FSDS-25-32");

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

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
                Session.GetCTextField("EQUNR-LOW").Text     = Equipmentnumber;

                // Set dates
                Session.GetCTextField("GLTRP-LOW").Text     = StartDate.ToShortDateString().Replace("/", ".");
                Session.GetCTextField("GLTRP-HIGH").Text    = EndDate.ToShortDateString().Replace("/", ".");

                // Set tasklist filter
                Session.GetCTextField("PLNNR-LOW").Text = TaskInfo.Group;
                Session.GetTextField("PLNAL-LOW").Text  = TaskInfo.Counter;

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
        public override bool CreateNotification(MobilityTask            TaskInfo, 
                                                MobilityEquipment       SetupEquipment, 
                                                MobilityServiceOrder    SOInfo, 
                                                BackgroundWorker        Parent) 
        {
            if (Session.GetSession())
            {
                RefForm.SetStatus("Creating notification", 0);

                Session.StartTransaction("IW51");
                Session.GetCTextField("RIWO00-QMART").Text = "Z8";
                Session.GetCTextField("RIWO00-QWRNUM").Text = "300424160";

                Session.SendVKey(0);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

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
                Session.GetTextField("VIQMEL-QMTXT").Text       = OutputDesc;
                Session.GetCTextField("VIQMEL-QMDAT").Text      = SOInfo.PurchaseOrderDate;
                Session.GetCTextField("VIQMEL-MZEIT").Text      = DateTime.Now.ToShortTimeString();
                Session.GetComboBox("VIQMEL-PRIOK").Key         = SOInfo.Priority.Substring(0,1);

                Session.ClearErrors(30, true);

                // Reset reference object view
                ((GuiMenu)Session.GetFormById("wnd[0]/mbar/menu[3]/menu[9]/menu[0]")).Select();
                ((GuiLabel)Session.GetFormById("wnd[1]/usr/lbl[6,3]")).SetFocus();
                ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                Session.GetCTextField("VIQMEL-AUSWK").Text      = RefForm.AppSettings.Effect;
                Session.GetCTextField("RIWO00-GEWRK").Text      = TaskInfo.Workcentre;
                Session.GetCTextField("VIQMEL-VKBUR").Text      = SOInfo.SalesOffice;
                Session.GetCTextField("VIQMEL-INGRP").Text      = SOInfo.PlannerGroup;
                Session.GetCTextField("RIWO00-SWERK").Text      = SOInfo.Plant;

                Session.SendVKey(0);

                Session.GetCTextField("VIQMEL-QMNAM").Text = "CU";
                Session.GetTextField("VIQMEL-BSTNK").Text = SOInfo.PurchaseOrder;
                Session.GetCTextField("VIQMEL-BSTDK").Text = SOInfo.PurchaseOrderDate;
                if (!SOInfo.CreateWithoutEq) Session.GetCTextField("RIWO1-EQUNR").Text = SetupEquipment.EquipmentNumber;
                Session.GetCTextField("VIQMEL-KUNUM").Text = SOInfo.SoldToParty;

                Session.ClearErrors(30, true);

                Session.GetCTextField("VIQMEL-LTRMN").Text      = SOInfo.BasicEndDate;
                Session.ClearErrors(30, true);
                Session.GetCTextField("VIQMEL-STRMN").Text      = SOInfo.BasicStartDate;
                Session.ClearErrors(30, true);

                Session.GetShell("shell").Text = TaskInfo.LongText;

                Session.GetCTextField("VIQMEL-KDAUF").Text      = TaskInfo.SalesDoc;
                Session.GetCTextField("VIQMEL-KDPOS").Text      = TaskInfo.SalesDocItem;

                Session.ClearErrors(30, true);

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.GetTab(@"10\TAB06").Select();

                if (!SOInfo.CreateWithoutEq)
                {
                    Session.GetCTextField("ILOA-SWERK").Text    = RefForm.AppSettings.Plant;
                    Session.GetCTextField("ILOA-STORT").Text    = RefForm.AppSettings.Location;
                    Session.GetCTextField("RILA0-ARBPL").Text   = TaskInfo.Workcentre;
                    Session.GetCTextField("ILOA-VKORG").Text    = RefForm.AppSettings.Organization;

                    Session.ClearErrors(30, true);

                    Session.GetCTextField("ILOA-VTWEG").Text    = RefForm.AppSettings.Distribution;
                    Session.GetCTextField("ILOA-SPART").Text    = RefForm.AppSettings.Division;

                    // Set WBS element
                    /*if (TaskInfo.WBS != "") {
                        if (Session.GetCTextField("ILOA-PROID").Text != "" || Session.GetCTextField("ILOA-PROID").Text != TaskInfo.WBS) {
                            Session.GetCTextField("ILOA-PROID").Text = "";
                            Session.ClearErrors(30, true);
                        }

                        Session.GetCTextField("ILOA-PROID").Text = TaskInfo.WBS;
                        Session.ClearErrors(30, true);
                    }*/

                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.GetTextField("ILOA-EQFNR").Text = SOInfo.ExternalReference;

                Session.GetTab(@"10\TAB01").Select();

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
        public override bool CreateServiceOrder(MobilityTask TaskInfo, MobilityEquipment SetupEquipment, MobilityServiceOrder SOInfo, List<SAPComponent> Components, BackgroundWorker Parent)
        {
            if (Session.GetSession())
            {
                RefForm.SetStatus("Creating service order", 0);

                Session.GetButton("*VIQMEL-AUFNR").Press();

                if (!TaskInfo.WarrantyClaim)
                {
                    ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtRIWO00-AUART")).Text = "ZM03";
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
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.GetCTextField("CAUFVD-GSTRP").Text      = SOInfo.BasicStartDate;

                Session.ClearErrors(30, true);

                Session.GetCTextField("CAUFVD-GLTRP").Text      = SOInfo.BasicEndDate;

                Session.ClearErrors(30, true);

                Session.GetCTextField("CAUFVD-ILART").Text      = "062";
                Session.GetComboBox("CAUFVD-PRIOK").Key         = SOInfo.Priority.Substring(0, 1);
                Session.GetCTextField("CAUFVD-VAPLZ").Text      = TaskInfo.Workcentre;

                Session.GetTab("ILOA").Select();

                Session.GetCTextField("ILOA-SWERK").Text        = RefForm.AppSettings.Plant;
                Session.GetCTextField("ILOA-STORT").Text        = RefForm.AppSettings.Location;
                Session.GetCTextField("RILA0-ARBPL").Text       = TaskInfo.Workcentre;
                Session.GetTextField("ILOA-EQFNR").Text         = SOInfo.ExternalReference;

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                Session.ClearErrors(30, true);

                // Add tasklist
                if (TaskInfo.Group != "" || TaskInfo.CEL != "NON-STANDARD VARIATION")
                {
                    ((GuiMenu)Session.GetFormById("wnd[0]/mbar/menu[3]/menu[0]/menu[4]")).Select();
                    if (Session.GetActiveWindow().Type != "GuiMainWindow") ((GuiButton)Session.GetFormById("wnd[1]/usr/btnSPOP-OPTION1")).Press();

                    Session.GetCTextField("PN_PLNNR-LOW").Text = TaskInfo.Group;
                    Session.GetTextField("PN_PLNAL-LOW").Text = TaskInfo.Counter;

                    Session.SendVKey(8);
                    if (Session.GetSessionInfo().ScreenNumber != 3000) Session.SendVKey(8);
                    Session.SendVKey(0);
                    Session.SendVKey(0);
                }
                else
                {
                    // Add planned hours
                    string PlannedHours = RefForm.GetInput("Please enter planned hours for this task", "Planned hours", "1");

                    Session.GetTab("VGUE").Select();
                    GuiTableControl Operations = Session.GetTable("SAPLCOVGTCTRL_3010");
                    ((GuiTextField)Operations.FindById("txtAFVGD-ARBEI[10,0]")).Text = PlannedHours;
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Add components
                if (Components == null)
                {
                    Session.GetTab("MUEB").Select();

                    // Set to B03
                    if (MsgBox_Question("Would you like to change the component's store location?") == DialogResult.Yes)
                    {

                        SelectNewStore NewStoreDialog = new SelectNewStore(RefForm);

                        NewStoreDialog.ShowDialog();

                        Session.ChangeStore(NewStoreDialog.StoreLoc, NewStoreDialog.SpecStock, Parent);
                    }

                }
                else
                {
                    GuiCTextField CurrentLoc, CurrentStock, CurrentZAWA, CurrentItemCat;
                    GuiTextField CurrentQty, CurrentAct;
                    GuiComponentCollection ZAWA, Quantity, StoreLoc, SpecialStock, ItemCat, Act;
                    GuiTableControl ComponentTable;

                    // Get table initially 
                    ComponentTable = Session.GetTable("SAPLCOMKTCTRL_3020");
                    int VisRows = ComponentTable.VisibleRowCount;
                    int CurRow = 0;

                    // Find next empty slot 
                    for (int i = 0; i < ComponentTable.Rows.Count; i++)
                    {
                        // Refresh connection to table 
                        ComponentTable = Session.GetTable("SAPLCOMKTCTRL_3020");
                        ZAWA = ComponentTable.FindAllByName("RESBD-MATNR", "GuiCTextField");
                        CurrentZAWA = ((GuiCTextField)ZAWA.Item(i));

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

                        // Check for cancel
                        if (Parent.CancellationPending)
                        {
                            MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                            RefForm.SetStatus("User canceled", 0);
                            return false;
                        }

                        // Refresh connection to table 
                        ComponentTable      = Session.GetTable("SAPLCOMKTCTRL_3020");
                        ZAWA                = ComponentTable.FindAllByName("RESBD-MATNR", "GuiCTextField");
                        Quantity            = ComponentTable.FindAllByName("RESBD-MENGE", "GuiTextField");
                        StoreLoc            = ComponentTable.FindAllByName("RESBD-LGORT", "GuiCTextField");
                        SpecialStock        = ComponentTable.FindAllByName("RESBD-SOBKZ_D", "GuiCTextField");
                        ItemCat             = ComponentTable.FindAllByName("RESBD-POSTP", "GuiCTextField");
                        Act                 = ComponentTable.FindAllByName("RESBD-VORNR", "GuiTextField");

                        // Get fields in current row 
                        CurrentLoc          = ((GuiCTextField)StoreLoc.Item(CurRow));
                        CurrentStock        = ((GuiCTextField)SpecialStock.Item(CurRow));
                        CurrentZAWA         = ((GuiCTextField)ZAWA.Item(CurRow));
                        CurrentQty          = ((GuiTextField)Quantity.Item(CurRow));
                        CurrentItemCat      = ((GuiCTextField)ItemCat.Item(CurRow));
                        CurrentAct          = ((GuiTextField)Act.Item(CurRow));

                        // Add data 
                        CurrentItemCat.Text = "L";
                        CurrentAct.Text     = "0010";
                        CurrentZAWA.Text    = Components[i].ZAWA;
                        CurrentQty.Text     = Components[i].Qauntity;
                        CurrentStock.Text   = Components[i].SpecialStock;
                        CurrentLoc.Text     = Components[i].StoreLocation;

                        Session.SendVKey(0);

                        //((GuiTextField)Session.GetFormById("wnd[1]/usr/txtRCM01-VORNR")).Text = "0010";

                        Session.ClearErrors(30, true);

                        CurRow++;

                    }
                }

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
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
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtCOBRB-KONTY[0,0]")).Text = "G/L";
                    Session.SendVKey(0);
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtDKOBR-EMPGE[1,0]")).Text = "240600";
                    Session.SendVKey(0);
                    ((GuiTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/txtCOBRB-PROZS[3,0]")).Text = "100";
                    ((GuiCTextField)Session.GetFormById("wnd[0]/usr/tblSAPLKOBSTC_RULES/ctxtCOBRB-PERBZ[5,0]")).Text = "FUL";
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

                // Check for cancel
                if (Parent.CancellationPending)
                {
                    MsgBox_Normal("User cancel detected, the tool will now be stopped.");
                    RefForm.SetStatus("User canceled", 0);
                    return false;
                }

                // Finalize order
                if (!Finalize(TaskInfo, SOInfo, SetupEquipment))
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
        public override bool Finalize(MobilityTask TaskInfo, MobilityServiceOrder InputSO, MobilityEquipment InputEq) 
        {
            string Customer = "";
            string Dir = "";

            if (TaskInfo.FolderPath != "")
            {
                if (Session.GetSession())
                {
                    Session.StartTransaction("IW32");
                    Session.SendVKey(0);

                    // Verify order created
                    if (Session.GetSessionInfo().ScreenNumber != 3000)
                    {
                        return false;
                    }

                    Customer = InputSO.CustomerName.Replace(@"/", "");
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


                    // Build path string
                    Dir = $"{RefForm.AppSettings.ServerIndex}{TaskInfo.FolderPath}\\{RefForm.Output_ServiceOrder} {TaskInfo.Name.Replace("/", "")} SN {InputEq.SerialNumber} ({Customer})";

                    Session.EndTransaction();

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

    }
}
