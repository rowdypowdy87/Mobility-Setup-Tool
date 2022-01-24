﻿using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using SAPFEWSELib;
using System.Collections.Generic;
using static Mobility_Setup_Tool.MsgBoxs;

namespace Mobility_Setup_Tool
{
    // Inheret base from ZM12 setup module (equipment, measures and CEL checks are the same)
    class Module_ZM25 : Module_ZM12
    {
        // Check for existing orders
        public override bool InitialServiceCheck(MobilityTask TaskInfo, string Equipmentnumber, BackgroundWorker Parent)
        {
            if (Session.GetSession())
            {
                DateTime StartDate;
                DateTime EndDate;

                StartDate = RefForm.GetBasicStartDate.AddMonths(-Convert.ToInt32(RefForm.AppSettings.WarrantyMonthLimit));
                EndDate = RefForm.GetBasicStartDate;

                if (!RefForm.SetStatus($"Checking for previous work orders in the last {RefForm.AppSettings.WarrantyMonthLimit} months..", 0)) return false;

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

        // Create service order
        public override bool CreateServiceOrder(MobilityTask TaskInfo, MobilityEquipment SetupEquipment, MobilityServiceOrder SOInfo, List<SAPComponent> Components, BackgroundWorker Parent)
        {
            if (Session.GetSession())
            {
                if (!RefForm.SetStatus("Creating service order", 0)) return false;

                Session.GetButton("*VIQMEL-AUFNR").Press();

                if (!TaskInfo.WarrantyClaim)
                {
                    ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtRIWO00-AUART")).Text = "ZM25";
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

                // Set ZDI1
                if (TaskInfo.WarrantyClaim)
                {
                    Session.GetCTextField("PMSDO-MATNR").Text = SetupEquipment.ZDI1;
                    Session.GetCTextField("CAUFVD-BEMOT").Text = "02";
                }
                else
                {
                    Session.GetCTextField("PMSDO-MATNR").Text = SetupEquipment.ZDI1;
                }

                Session.GetTextField("PMSDO-MENGE").Text = "1";        // Qty
                Session.GetCTextField("PMSDO-FAKTF").Text = "01";       // Billing form

                Session.SendVKey(0);

                Session.GetCTextField("CAUFVD-GSTRP").Text = SOInfo.BasicStartDate;

                Session.ClearErrors(30, true);

                Session.GetCTextField("CAUFVD-GLTRP").Text = SOInfo.BasicEndDate;

                Session.ClearErrors(30, true);

                Session.GetCTextField("CAUFVD-ILART").Text = SOInfo.ActivityType;
                Session.GetComboBox("CAUFVD-PRIOK").Key = SOInfo.Priority.Substring(0, 1);
                Session.GetCTextField("CAUFVD-VAPLZ").Text = TaskInfo.Workcentre;

                Session.GetTab("ILOA").Select();

                Session.GetCTextField("ILOA-SWERK").Text = RefForm.AppSettings.Plant;
                Session.GetCTextField("ILOA-STORT").Text = RefForm.AppSettings.Location;
                Session.GetCTextField("RILA0-ARBPL").Text = TaskInfo.Workcentre;
                Session.GetTextField("ILOA-EQFNR").Text = SOInfo.ExternalReference;

                Session.ClearErrors(30, true);

                // Add tasklist
                if (TaskInfo.Group != "" || TaskInfo.CEL != "NON-STANDARD VARIATION")
                {
                    ((GuiMenu)Session.GetFormById("wnd[0]/mbar/menu[3]/menu[0]/menu[0]")).Select();
                    //if(Session.GetActiveWindow().Type != "GuiMainWindow") ((GuiButton)Session.GetFormById("wnd[1]/usr/btnSPOP-OPTION1")).Press();

                    ((GuiRadioButton)Session.GetFormById("wnd[1]/usr/radRIHEA-PN_IHAN")).Selected = true;
                    ((GuiCTextField)Session.GetFormById("wnd[1]/usr/ctxtCAUFVD-PLNNR")).Text = TaskInfo.Group;
                    ((GuiTextField)Session.GetFormById("wnd[1]/usr/txtCAUFVD-PLNAL")).Text = TaskInfo.Counter;
                    ((GuiButton)Session.GetFormById("wnd[1]/tbar[0]/btn[0]")).Press();

                    // Press yes to delete current operations
                    if (Session.GetActiveWindow().Type != "GuiMainWindow")
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

                // Set to B03
                if (MsgBox_Question("Would you like to change the component's store location?") == DialogResult.Yes)
                {

                    Session.GetTab("MUEB").Select();

                    SelectNewStore NewStoreDialog = new SelectNewStore(RefForm);

                    NewStoreDialog.ShowDialog();

                    Session.ChangeStore(NewStoreDialog.StoreLoc, NewStoreDialog.SpecStock, Parent);
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
    }
}
