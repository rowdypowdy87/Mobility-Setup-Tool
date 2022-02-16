using Mobility_Setup_Tool.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;

public struct VersionInfo
{
    public string ChangeNumber  { set; get; }
    public string Description   { set; get; }
    public string ChangedBy     { get; set; }
    public string ApprovedBy    { get; set; }
    public string ChangedOn     { get; set; }
}

namespace Mobility_Setup_Tool
{
    

    // Manage all database information && loading into memory 
    public class Databases
    {
        MainForm Reference;

        // Global structures
        public List<MobilityEquipment>  EquipmentList   = new List<MobilityEquipment>();
        public List<MobilityTask>       LeadTasks       = new List<MobilityTask>();
        public List<MobilityTask>       VariationTasks  = new List<MobilityTask>();
        public List<INPUT_FIELD>        PmActivitys     = new List<INPUT_FIELD>();
        public List<INPUT_FIELD>        Customers       = new List<INPUT_FIELD>();
        public List<string>             CustomerAbbr    = new List<string>();
        public List<INPUT_FIELD>        SalesData       = new List<INPUT_FIELD>();
        public List<QuoteInformation>   QuoteInfo       = new List<QuoteInformation>();
        public List<VersionInfo>        VersionHist     = new List<VersionInfo>();
        public List<VersionInfo>        AppVersHist     = new List<VersionInfo>();
        public List<INPUT_FIELD>        FuncLoc         = new List<INPUT_FIELD>();

        public Databases(MainForm Ref) { Reference = Ref; }

        public void Load()
        {
            ExcelDataTables ExcelManager = new ExcelDataTables();
            DataTable       LoadTable;
            int             i;
            
            // Open sheet
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, 0);

            // Clear equipment list box
            Reference.TemplateEquipmentList_CB.Items.Clear();
            Reference.VarTemplate_CB.Items.Clear();

            // Add each equipment into box
            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                MobilityEquipment _add = new MobilityEquipment();

                // Fill the structure array from table
                _add.Description        = LoadTable.Rows[i][0]  != null ? LoadTable.Rows[i][0].ToString() : "";
                _add.EquipmentNumber    = LoadTable.Rows[i][1]  != null ? LoadTable.Rows[i][1].ToString() : "";
                _add.ZAWA               = LoadTable.Rows[i][2]  != null ? LoadTable.Rows[i][2].ToString() : "";
                _add.ZDI1               = LoadTable.Rows[i][3]  != null ? LoadTable.Rows[i][3].ToString() : "";

                if ((LoadTable.Rows[i][4]  != null ? LoadTable.Rows[i][4].ToString() : "") == "YES") 
                {
                    _add.UpdateToTemplate = true;
                } else 
                {
                    _add.UpdateToTemplate = false;
                }

                // Add to listbox
                Reference.TemplateEquipmentList_CB.Items.Add(LoadTable.Rows[i][0]);

                Reference.VarTemplate_CB.Items.Add(LoadTable.Rows[i][0]);

                // Add to memory
                EquipmentList.Add(_add);
            }

            LoadTable.Clear();

            // Load next sheet
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, 1);

            // Fill task arrays
            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                MobilityTask _add = new MobilityTask();

                // Fill the structure array from table'
                _add.Name           = LoadTable.Rows[i][0]  != null ? LoadTable.Rows[i][0].ToString() : "";
                _add.CEL            = LoadTable.Rows[i][1]  != null ? LoadTable.Rows[i][1].ToString() : "";
                _add.Group          = LoadTable.Rows[i][2]  != null ? LoadTable.Rows[i][2].ToString() : ""; 
                _add.Counter        = LoadTable.Rows[i][3]  != null ? LoadTable.Rows[i][3].ToString() : "";
                _add.Workcentre     = LoadTable.Rows[i][4]  != null ? LoadTable.Rows[i][4].ToString() : "";
                _add.WBS            = LoadTable.Rows[i][5]  != null ? LoadTable.Rows[i][5].ToString() : "";
                _add.Module         = LoadTable.Rows[i][6]  != null ? LoadTable.Rows[i][6].ToString() : "";
                _add.SalesDoc       = LoadTable.Rows[i][7]  != null ? LoadTable.Rows[i][7].ToString() : "";
                _add.SalesDocItem   = LoadTable.Rows[i][8]  != null ? LoadTable.Rows[i][8].ToString() : "";
                _add.LongText       = LoadTable.Rows[i][9]  != null ? LoadTable.Rows[i][9].ToString() : "";
                _add.FolderPath     = LoadTable.Rows[i][10] != null ? LoadTable.Rows[i][10].ToString() : "";
                _add.Equipment1     = LoadTable.Rows[i][11] != null ? LoadTable.Rows[i][11].ToString() : "";
                _add.Equipment2     = LoadTable.Rows[i][12] != null ? LoadTable.Rows[i][12].ToString() : ""; 
                _add.Equipment3     = LoadTable.Rows[i][13] != null ? LoadTable.Rows[i][13].ToString() : "";
                _add.Equipment4     = LoadTable.Rows[i][14] != null ? LoadTable.Rows[i][14].ToString() : ""; 
                _add.Equipment5     = LoadTable.Rows[i][15] != null ? LoadTable.Rows[i][15].ToString() : "";
                _add.Equipment6     = LoadTable.Rows[i][16] != null ? LoadTable.Rows[i][16].ToString() : "";
                _add.Equipment7     = LoadTable.Rows[i][17] != null ? LoadTable.Rows[i][17].ToString() : "";
                _add.Equipment8     = LoadTable.Rows[i][18] != null ? LoadTable.Rows[i][18].ToString() : "";
                _add.Equipment9     = LoadTable.Rows[i][19] != null ? LoadTable.Rows[i][19].ToString() : "";
                _add.Equipment10    = LoadTable.Rows[i][20] != null ? LoadTable.Rows[i][20].ToString() : "";

                // Add to memory
                LeadTasks.Add(_add);
            }

            // Load variation lists
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, 2);

            // Fill task arrays
            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                MobilityTask _add = new MobilityTask();

                // Fill the structure array from table
                _add.Name           = LoadTable.Rows[i][0]  != null ? LoadTable.Rows[i][0].ToString() : "";
                _add.CEL            = LoadTable.Rows[i][1]  != null ? LoadTable.Rows[i][1].ToString() : "";
                _add.PartsTable     = LoadTable.Rows[i][2]  != null ? LoadTable.Rows[i][2].ToString() : "";
                _add.Group          = LoadTable.Rows[i][3]  != null ? LoadTable.Rows[i][3].ToString() : ""; 
                _add.Counter        = LoadTable.Rows[i][4]  != null ? LoadTable.Rows[i][4].ToString() : "";
                _add.Workcentre     = LoadTable.Rows[i][5]  != null ? LoadTable.Rows[i][5].ToString() : "";
                _add.WBS            = LoadTable.Rows[i][6]  != null ? LoadTable.Rows[i][6].ToString() : "";
                _add.Module         = LoadTable.Rows[i][7]  != null ? LoadTable.Rows[i][7].ToString() : "";
                _add.SalesDoc       = LoadTable.Rows[i][8]  != null ? LoadTable.Rows[i][8].ToString() : "";
                _add.SalesDocItem   = LoadTable.Rows[i][9]  != null ? LoadTable.Rows[i][9].ToString() : "";
                _add.LongText       = LoadTable.Rows[i][10] != null ? LoadTable.Rows[i][10].ToString() : "";
                _add.FolderPath     = LoadTable.Rows[i][11] != null ? LoadTable.Rows[i][11].ToString() : "";
                _add.Equipment1     = LoadTable.Rows[i][12] != null ? LoadTable.Rows[i][12].ToString() : "";
                _add.Equipment2     = LoadTable.Rows[i][13] != null ? LoadTable.Rows[i][13].ToString() : ""; 
                _add.Equipment3     = LoadTable.Rows[i][14] != null ? LoadTable.Rows[i][14].ToString() : "";
                _add.Equipment4     = LoadTable.Rows[i][15] != null ? LoadTable.Rows[i][15].ToString() : ""; 
                _add.Equipment5     = LoadTable.Rows[i][16] != null ? LoadTable.Rows[i][16].ToString() : "";
                _add.Equipment6     = LoadTable.Rows[i][17] != null ? LoadTable.Rows[i][17].ToString() : "";
                _add.Equipment7     = LoadTable.Rows[i][18] != null ? LoadTable.Rows[i][18].ToString() : "";
                _add.Equipment8     = LoadTable.Rows[i][19] != null ? LoadTable.Rows[i][19].ToString() : "";
                _add.Equipment9     = LoadTable.Rows[i][20] != null ? LoadTable.Rows[i][20].ToString() : "";
                _add.Equipment10    = LoadTable.Rows[i][21] != null ? LoadTable.Rows[i][21].ToString() : "";

                // Add to memory
                VariationTasks.Add(_add);
            }

            LoadTable.Clear();

            // Load LoadTable
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, 4);

            // Clear LoadTable
            Reference.FunctionLoc_CB.Items.Clear();

            // Func loc
            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                if (LoadTable.Rows[i]["FUNCTION LOC"].ToString() == "") break;

                INPUT_FIELD Add = new INPUT_FIELD
                {
                    Name    = LoadTable.Rows[i]["FUNCTION LOC"].ToString(),
                    Number  = LoadTable.Rows[i]["FUNC LOC"].ToString()
                };

                FuncLoc.Add(Add);

                Reference.FunctionLoc_CB.Items.Add(LoadTable.Rows[i]["FUNCTION LOC"].ToString());
            }

            // Clear LoadTable
            Reference.Priority_CB.Items.Clear();
            Reference.VarSOPriority_CB.Items.Clear();

            // Priority
            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                if (LoadTable.Rows[i]["PRIORITY"].ToString() == "") break;

                Reference.Priority_CB.Items.Add(LoadTable.Rows[i]["PRIORITY"].ToString());
                Reference.VarSOPriority_CB.Items.Add(LoadTable.Rows[i]["PRIORITY"].ToString());
            }

            // Clear LoadTable
            Reference.PartyName_CB.Items.Clear();

            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                if (LoadTable.Rows[i]["SOLD TO PARTY"].ToString() == "") break;

                INPUT_FIELD _add = new INPUT_FIELD
                {
                    Name = LoadTable.Rows[i]["PARTY NAME"].ToString(),
                    Number = LoadTable.Rows[i]["SOLD TO PARTY"].ToString()
                };

                string _addA = LoadTable.Rows[i]["PARTY ABR"].ToString();

                CustomerAbbr.Add(_addA);
                Reference.PartyName_CB.Items.Add(_add.Name);
                Customers.Add(_add);
            }

            // Clear LoadTable
            Reference.PMActivityType_CB.Items.Clear();
            Reference.VarPMActivityType_CB.Items.Clear();

            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                if (LoadTable.Rows[i]["PM ACTIVITY TYPE"].ToString() == "") break;

                INPUT_FIELD _add = new INPUT_FIELD
                {
                    Name    = LoadTable.Rows[i]["ACTIVITY TYPE DESCRIPTION"] != null ? LoadTable.Rows[i]["ACTIVITY TYPE DESCRIPTION"].ToString() : "",
                    Number  = LoadTable.Rows[i]["PM ACTIVITY TYPE"]          != null ? LoadTable.Rows[i]["PM ACTIVITY TYPE"].ToString() : ""
                };

                Reference.PMActivityType_CB.Items.Add(_add.Name);
                PmActivitys.Add(_add);
                Reference.VarPMActivityType_CB.Items.Add(_add.Name);
            }

            LoadTable.Clear();

            // Load quoting information
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.QuotePath, 0);

            //Reference.QuoteTemplate_CB.Items.Clear();

            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                QuoteInformation ToAdd = new QuoteInformation  
                {
                    Equipment           = LoadTable.Rows[i][0] != null ? LoadTable.Rows[i][0].ToString() : "",
                    QuoteTemplate       = LoadTable.Rows[i][1] != null ? LoadTable.Rows[i][1].ToString() : "",
                    PartsTemplate       = LoadTable.Rows[i][2] != null ? LoadTable.Rows[i][2].ToString() : "",
                    MandPartsTemplate   = LoadTable.Rows[i][3] != null ? LoadTable.Rows[i][3].ToString() : ""
                };

                QuoteInfo.Add(ToAdd);
                //Reference.QuoteTemplate_CB.Items.Add(ToAdd.Equipment);
            }

            LoadTable.Clear();

            // Sales data
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, "SALESDATA");

            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                INPUT_FIELD ToAdd = new INPUT_FIELD
                {
                    WC      = LoadTable.Rows[i]["WORK CENTER"]  != null ? LoadTable.Rows[i]["WORK CENTER"].ToString() : "",
                    Name    = LoadTable.Rows[i]["SALES GROUP"]  != null ? LoadTable.Rows[i]["SALES GROUP"].ToString() : "",
                    Number  = LoadTable.Rows[i]["SALES OFFICE"] != null ? LoadTable.Rows[i]["SALES OFFICE"].ToString() : "",
                };

                SalesData.Add(ToAdd);
            }

            LoadTable.Clear();

            // Version history
            LoadTable = ExcelManager.ConvertExcelToDataTable(Reference.AppSettings.Defaults.InputsPath, "Version Log");

            for (i = 0; i < LoadTable.Rows.Count; i++)
            {
                VersionInfo ToAdd = new VersionInfo
                {
                    ChangeNumber    = LoadTable.Rows[i][0] != null ? LoadTable.Rows[i][0].ToString() : "",
                    Description     = LoadTable.Rows[i][1] != null ? LoadTable.Rows[i][1].ToString() : "",
                    ChangedBy       = LoadTable.Rows[i][2] != null ? LoadTable.Rows[i][2].ToString() : "",
                    ApprovedBy      = LoadTable.Rows[i][3] != null ? LoadTable.Rows[i][3].ToString() : "",
                    ChangedOn       = LoadTable.Rows[i][4] != null ? LoadTable.Rows[i][4].ToString() : ""
                };

                VersionHist.Add(ToAdd);
            }

            // Free memory
            LoadTable.Dispose();
        }
        
        public List<VersionInfo> GetVersionInfo()
        {
            return VersionHist;
        }

        public string GetQuotingVariationTab_ByName(string name)
        {
            string ret = "";

            for (int i = 0; i < QuoteInfo.Count; i++)
            { if (name == QuoteInfo[i].Equipment) ret = QuoteInfo[i].QuoteTemplate; }

            return ret;
        }

        public string GetCustomerAbbr_ByName(string CustomerName)
        {
            string ret = "";

            for (int i = 0; i < Customers.Count; i++)
            { if (CustomerName == Customers[i].Name) ret = CustomerAbbr[i]; }

            return ret;
        }

        public string GetQuotingPartsTab_ByName(string name)
        {
            string ret = "";

            for (int i = 0; i < QuoteInfo.Count; i++)
            { if (name == QuoteInfo[i].Equipment) ret = QuoteInfo[i].PartsTemplate; }

            return ret;
        }

        public string GetQuotingMandPartsTab_ByName(string name)
        {
            string ret = "";

            for (int i = 0; i < QuoteInfo.Count; i++)
            { if (name == QuoteInfo[i].Equipment) ret = QuoteInfo[i].MandPartsTemplate; }

            return ret;
        }

        public List<INPUT_FIELD> GetActivityCodes()
        { return PmActivitys;}

        public List<INPUT_FIELD> GetCustomers()
        { return Customers; }

        public List<MobilityTask> GetTasks(bool isLead)
        {
            if (isLead)
            {
                return LeadTasks;
            }else
            {
                return VariationTasks;
            }
        }

        public List<MobilityEquipment> GetTemplateEquipments() { return EquipmentList; }

        public List<QuoteInformation> GetQuotingTemplates() {return QuoteInfo;}

        // Get equipment structure by list index 
        public MobilityEquipment GetTemplateEquipment_ByIndex(int index) { return EquipmentList[index]; }

        // Get equipment structure by name 
        public MobilityEquipment GetTemplateEquipment_ByName(string name)
        {
            MobilityEquipment ret = new MobilityEquipment{ Description = "" };

            for (int i = 0; i < EquipmentList.Count; i++)
            {if (name == EquipmentList[i].Description) ret = EquipmentList[i];}

            return ret;
        }

        // Get sales structure by workcenter 
        public INPUT_FIELD GetSalesData_ByWorkCenter(string name)
        {
            INPUT_FIELD ret = new INPUT_FIELD { Number = "" };

            for (int i = 0; i < SalesData.Count; i++)
            { if (name == SalesData[i].WC) ret = SalesData[i]; }

            return ret;
        }

        // Get activity structure by name 
        public INPUT_FIELD GetActivity_ByName(string name)
        {
            INPUT_FIELD ret = new INPUT_FIELD { Number = "" };

            for (int i = 0; i < PmActivitys.Count; i++)
            { if (name == PmActivitys[i].Name) ret = PmActivitys[i]; }

            return ret;
        }

        // Get activity structure by name 
        public INPUT_FIELD GetActivity_ById(string id)
        {
            INPUT_FIELD ret = new INPUT_FIELD { Number = "" };

            for (int i = 0; i < PmActivitys.Count; i++)
            { if (id == PmActivitys[i].Number) ret = PmActivitys[i]; }

            return ret;
        }

        // Get activity structure by name 
        public string GetFunc_ByName(string name)
        {

            for (int i = 0; i < PmActivitys.Count; i++)
            { 
                if (name == FuncLoc[i].Name) 
                {
                    return FuncLoc[i].Number; 
                }
            }

            
            return "";
        }

        // Get customer structure by name 
        public INPUT_FIELD GetCustomer_ByName(string name)
        {
            INPUT_FIELD ret = new INPUT_FIELD { Number = "" };

            for (int i = 0; i < Customers.Count; i++)
            { if (name == Customers[i].Name) ret = Customers[i]; }

            return ret;
        }

        // Get customer structure by name 
        public INPUT_FIELD GetCustomer_ById(string id)
        {
            INPUT_FIELD ret = new INPUT_FIELD { Number = "" };

            for (int i = 0; i < Customers.Count; i++)
            { if (id == Customers[i].Number) ret = Customers[i]; }

            return ret;
        }

        // Get task structure by list index 
        public MobilityTask GetTask_ByIndex(int index, bool isLead)
        {
            if (isLead)
            {
                return LeadTasks[index];
            }   else
            {
                return VariationTasks[index];
            }
        }

        // Get task structure by name 
        public MobilityTask GetTask_ByName(string name, bool isLead)
        {
            MobilityTask ret = new MobilityTask { Name = "" };

            if (isLead)
            {
                for (int i = 0; i < LeadTasks.Count; i++)
                { if (name == LeadTasks[i].Name) ret = LeadTasks[i]; }
                return ret;
            }
            else
            {
                for (int i = 0; i < VariationTasks.Count; i++)
                { if (name == VariationTasks[i].Name) ret = VariationTasks[i]; }
                return ret;
            }
        }
    }
}
