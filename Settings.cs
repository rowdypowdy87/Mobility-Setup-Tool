using Mobility_Setup_Tool.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Mobility_Setup_Tool
{
    public struct SAP_DEFAULTS
    {
        public string Organization          { get; set; }
        public string Location              { get; set; }
        public string Plant                 { get; set; }
        public string Division              { get; set; }
        public string Distribution          { get; set; }
        public string WarrantyMonthLimit    { get; set; }
        public string Effect                { get; set; }
        public string PlannerGroup          { get; set; }
        public string ServerIndex           { get; set; }
        public string InputsPath            { get; set; }
        public string QuotePath             { get; set; }
        public string CELPath               { get; set; }
    }

    public struct APP_DEFAULTS
    {
        public string FunctionLocation      { get; set; }
        public string SoldToParty           { get; set; }
        public string PmActivityType        { get; set; }
        public string Priority              { get; set; }
        public string ExternalReference     { get; set; }
    }

    [DefaultProperty("Distribution")]
    public class Settings
    {
        public SAP_DEFAULTS Defaults        = new SAP_DEFAULTS();
        public APP_DEFAULTS ADefaults       = new APP_DEFAULTS();
        public InitialInputs Init = new InitialInputs();
        public const string VersionNumber   = "1.0";
        public Theme ThemeController;
        public MainForm Reference;
        public bool ToRestart = false;

        // Creation method
        public Settings(Theme Ref, MainForm Ref2)
        {
            ThemeController = Ref;
            Reference = Ref2; 
        }

        [Browsable(false)]
        public string AppData
        {
            get { return $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\[UGL]Mobility Setup and Planning Tool"; }
        }

        [Category("Application Defaults")]
        [Description("Default functional location")]
        [DisplayName("Functional Location")]
        [TypeConverter(typeof(FLConverter))]
        public string FunctionLocation
        {
            get { return ADefaults.FunctionLocation; }
            set { ADefaults.FunctionLocation = value ?? ""; }
        }

        [Category("Application Defaults")]
        [Description("Default sold to party")]
        [DisplayName("SoldToParty")]
        [TypeConverter(typeof(PartyConverter))]
        public string SoldToParty
        {
            get { return ADefaults.SoldToParty; }
            set { ADefaults.SoldToParty = value ?? ""; }
        }

        [Category("Application Defaults")]
        [Description("Default maint activity type")]
        [DisplayName("PMActivityType")]
        [TypeConverter(typeof(ActTypeConverter))]
        public string PmActivityType
        {
            get { return ADefaults.PmActivityType; }
            set { ADefaults.PmActivityType = value ?? ""; }
        }

        [Category("Application Defaults")]
        [Description("Default priority")]
        [DisplayName("Service Order Priority")]
        [TypeConverter(typeof(PriorityTypeConverter))]
        public string Priority
        {
            get { return ADefaults.Priority; }
            set { ADefaults.Priority = value ?? ""; }
        }

        [Category("Application Defaults")]
        [Description("Default external reference")]
        [DisplayName("Customer Reference")]
        public string ExternalReference
        {
            get { return ADefaults.ExternalReference; }
            set { ADefaults.ExternalReference = value ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Distribution channel for SAP")]
        [DisplayName("Distribution Channel")]
        [TypeConverter(typeof(DistChannelCB))]
        public string Distribution
        {
            get { return Defaults.Distribution; }
            set { Defaults.Distribution = value[..2] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Division of company")]
        [DisplayName("Division")]
        [TypeConverter(typeof(DivisionCB))]
        public string Division
        {
            get { return Defaults.Division; }
            set { Defaults.Division = value[..2] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Default notification effect")]
        [DisplayName("Effect")]
        [TypeConverter(typeof(EffectCB))]
        public string Effect
        {
            get { return Defaults.Effect; }
            set { Defaults.Effect = value[..1] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Current site location")]
        [DisplayName("Location")]
        [TypeConverter(typeof(LocationCB))]
        public string Location
        {
            get { return Defaults.Location; }
            set {
                if (value.Length < 7)
                    Defaults.Location = value[..6] ?? "";
                else
                    Defaults.Location = value[..7] ?? "";
            }
        }

        [Category("SAP Defaults")]
        [Description("Organization number")]
        [DisplayName("Organization")]
        [TypeConverter(typeof(OrganizationCB))]
        public string Organization
        {
            get { return Defaults.Organization; }
            set { Defaults.Organization = value[..4] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Current site planner group number")]
        [DisplayName("Planner Group")]
        [TypeConverter(typeof(PlannerGroupCB))]
        public string PlannerGroup
        {
            get { return Defaults.PlannerGroup; }
            set { Defaults.PlannerGroup = value[..3] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Current site plant number")]
        [DisplayName("Plant")]
        [TypeConverter(typeof(PlantCB))]
        public string Plant
        {
            get { return Defaults.Plant; }
            set { Defaults.Plant = value[..4] ?? ""; }
        }

        [Category("SAP Defaults")]
        [Description("Number of months for which to check if a service order is a warranty or not")]
        [DisplayName("Warranty Limit (months)")]
        [TypeConverter(typeof(WarrantySelector))]
        public string WarrantyMonthLimit
        {
            get { return Defaults.WarrantyMonthLimit; }
            set { Defaults.WarrantyMonthLimit = value ?? ""; }
        }

        [Category("Theme Settings")]
        [Description("Color of form borders and title bar")]
        [DisplayName("Border Color")]
        [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(MyTypeConverter))]
        public Color BorderColor
        {
            get { return ThemeController.ThemeBorderColor; }
            set { ThemeController.ThemeBorderColor = value != null ? value : Color.Black; }
        }

        [Category("Theme Settings"), Description("Background color of forms"), DisplayName("Background Color")]
        [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(MyTypeConverter))]
        public Color BackgroundColor
        {
            get { return ThemeController.ThemeBackgroundColor; }
            set { ThemeController.ThemeBackgroundColor = value != null ? value : Color.LightGray; }
        }

        [Category("Folder Paths")]
        [Description("Server path index for current plant")]
        [DisplayName("Server Path")]
        [Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
        public string ServerIndex
        {
            get { return Defaults.ServerIndex; }
            set { Defaults.ServerIndex = value ?? ""; }
        }

        internal class MyTypeConverter : ColorConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return false;
            }
        }

        internal class MyColorEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.Modal;
            }
            public override bool GetPaintValueSupported(ITypeDescriptorContext context)
            {
                return false;
            }
            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                ColorDialog cd = new ColorDialog
                {
                    AllowFullOpen   = true,
                    AnyColor        = true,
                    SolidColorOnly  = false
                };

                int[] CustomClrs    = new int[16];
                string FilePath     = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\[UGL]Mobility Setup and Planning Tool\\COLORS";

                // Get custom colors if they exist
                if (File.Exists(FilePath))
                {
                    using StreamReader ColorFile = new StreamReader(FilePath);
                    int i = 0;

                    while (!ColorFile.EndOfStream)
                    {
                        CustomClrs[i] = Convert.ToInt32(ColorFile.ReadLine());
                        i++;
                    }

                    ColorFile.Close();
                }

                cd.CustomColors = CustomClrs;
                cd.ShowDialog();

                // Save custom colors
                using StreamWriter file = new StreamWriter(FilePath);

                foreach (int cl in cd.CustomColors)
                {
                    file.WriteLine(cl);
                }

                file.Close();

                return cd.Color;
            }
        }

        /// <summary>
        /// Opens the MSTReset console to restart the app (since Application.Restart() does not work in this instance)
        /// </summary>
        public void RestartApp()
        {
            // Check for restart console
            if (!File.Exists("MSTReset.exe")) 
            { 
                MsgBoxs.MsgBox_Error("Restart extension missing from application files, replace re-install software");
                Environment.Exit(0);
            }
            // Build process info structure
            ProcessStartInfo AppRestart = new ProcessStartInfo()
            {
                FileName    = $"MSTReset.exe",
                Arguments   = $"-r MST.exe"
            };
            // Start restart console
            Process.Start(AppRestart);
            // Close current application
            Environment.Exit(0);
        }

        // Download data files from sharepoint
        public bool DownloadFromSharepoint(string Link, string SavePath)
        {
            FileStream SaveData;
            byte[] Data;

            // Get the data
            using (WebClient SharePoint = new WebClient())
            {
                SharePoint.UseDefaultCredentials = true;

                // Get SP link data first
                try
                {
                    Data = SharePoint.DownloadData(Link);
                }
                catch
                {
                    return false;
                }
            }

            SaveData = new FileStream(SavePath, FileMode.Create, FileAccess.Write, FileShare.Read);
            SaveData.Write(Data);
            SaveData.Close();
            SaveData.Dispose();

            return true;
        }

        // Download inputs from sharepoint
        // Check version number on sharepoint vs the application and if mismatch then download and run the update
        public void GetSharepointData()
        {
            string  SP_Quote = "", SP_Inputs = "", SP_CEL = "", Ver;
            bool    FoundPlant = false;

            // Delete file is it exists
            if (File.Exists($"{AppData}\\MST_DataLinks"))
                File.Delete($"{AppData}\\MST_DataLinks");

            // Download master links
            if (!DownloadFromSharepoint("http://uglteams/sites/fs/AdminLibrary/Mobility%20Setup%20Tool%20Databases/MST_DataLinks", $"{AppData}\\MST_DataLinks")) 
            {
                MsgBoxs.MsgBox_Error($"Could not download Master Data file {Environment.NewLine}Please check your connection{Environment.NewLine}{Environment.NewLine}Program cannot run without an active connection");
                Environment.Exit(0);
            }

            // Check version
            StreamReader MasterData = new StreamReader($"{AppData}\\MST_DataLinks");

            Ver = MasterData.ReadLine();

            if (Ver == "")
            {
                MsgBoxs.MsgBox_Error("Could not retrieve version data");
                Environment.Exit(0);
            }

            // Check version
            if (VersionNumber != Ver)
            {
                MsgBoxs.MsgBox_Error("You are using an older version of the application, the application will now be updated");

                Updater UpdaterDiag = new Updater(Reference);

                UpdaterDiag.ActualCurrentVer_LBL.Text = VersionNumber;
                UpdaterDiag.ActualLastestVer_LBL.Text = Ver;

                UpdaterDiag.ShowDialog();

                if (UpdaterDiag.DidNotUpdate)
                {
                    MsgBoxs.MsgBox_Warning("You must update the application to continue using it.");
                    Environment.Exit(0);
                }
            }

            // Get plant db links
            while (!MasterData.EndOfStream)
            {
                if (MasterData.ReadLine() == Defaults.Plant)
                {
                    SP_Quote = MasterData.ReadLine();
                    SP_Inputs = MasterData.ReadLine();
                    SP_CEL = MasterData.ReadLine();
                    FoundPlant = true;
                    break;
                }
            }

            // Close file
            MasterData.Close();

            if (!FoundPlant)
            {
                MsgBoxs.MsgBox_Error($"Cannot find database links for plant {Defaults.Plant}");

                // Give app time to close the file before clearing it
                Thread.Sleep(1000);

                // Delete corrupted settings
                ResetSettings(true);
            }

            // Download master databases for this plant
            if (!DownloadFromSharepoint(SP_Inputs, Defaults.InputsPath))
            {
                MsgBoxs.MsgBox_Error($"Could not download General Inputs database {Environment.NewLine}Please check your connection{Environment.NewLine}{Environment.NewLine}Program cannot run without an active connection");
                Environment.Exit(0);
            }
            if (!DownloadFromSharepoint(SP_Quote, Defaults.QuotePath))
            {
                MsgBoxs.MsgBox_Error($"Could not download Quoting database {Environment.NewLine}Please check your connection{Environment.NewLine}{Environment.NewLine}Program cannot run without an active connection");
                Environment.Exit(0);
            }
            if (!DownloadFromSharepoint(SP_CEL, Defaults.CELPath))
            {
                MsgBoxs.MsgBox_Error($"Could not download Entry List Templates database {Environment.NewLine}Please check your connection{Environment.NewLine}{Environment.NewLine}Program cannot run without an active connection");
                Environment.Exit(0);
            }
            
        }

        /// <summary>
        /// Get initial cruicial data for application
        /// </summary>
        public void DownloadInitialData()
        {
            // First time run ask user for input
            if (!Directory.Exists(AppData)) Directory.CreateDirectory($"{AppData}\\");

            if(!DownloadFromSharepoint("http://uglteams/sites/fs/AdminLibrary/Mobility%20Setup%20Tool%20Databases/MST_InitialInputs.xlsx", $"{AppData}\\MST_InitialInputs.xlsx"))
            {
                MsgBoxs.MsgBox_Error($"Could not download Initial Input file {Environment.NewLine}Please check your connection{Environment.NewLine}{Environment.NewLine}Program cannot run without an active connection");
                Environment.Exit(0);
            }

             // Load default intial inputs
            DataTable LoadTable = new ExcelDataTables().ConvertExcelToDataTable($"{Reference.AppSettings.AppData}\\MST_InitialInputs.xlsx", 0);

            string Org, Plant, PlanGrp, Loc, Dis, Div;

            for(int i = 0; i < LoadTable.Rows.Count; i++)
            { 
                Org      = LoadTable.Rows[i][0].ToString();
                Plant    = LoadTable.Rows[i][1].ToString();
                PlanGrp  = LoadTable.Rows[i][2].ToString();
                Loc      = LoadTable.Rows[i][3].ToString();
                Dis      = LoadTable.Rows[i][4].ToString();
                Div      = LoadTable.Rows[i][5].ToString();

                if(Org != "")
                    Reference.SapInputLists[i].Organization = Org;
                if(Plant != "")
                    Reference.SapInputLists[i].Plant = Plant;
                if(PlanGrp != "")
                    Reference.SapInputLists[i].PlannerGroup = PlanGrp;
                if(Loc != "")
                    Reference.SapInputLists[i].Location = Loc;
                if(Dis != "")
                    Reference.SapInputLists[i].DistChannel = Dis;
                if(Div != "")
                    Reference.SapInputLists[i].Division = Div;
            }

            LoadTable.Dispose();
        }

        // Load settings from file
        public void LoadSettings()
        {
            DownloadInitialData();

            if (File.Exists($"{AppData}\\APPSETTINGS"))
            {
                // Read appsettings
                StreamReader SettingsFile   = new StreamReader($"{AppData}\\APPSETTINGS");
                Defaults.Distribution       = SettingsFile.ReadLine();
                Defaults.Division           = SettingsFile.ReadLine();
                Defaults.Effect             = SettingsFile.ReadLine();
                Defaults.Location           = SettingsFile.ReadLine();
                Defaults.Organization       = SettingsFile.ReadLine();
                Defaults.PlannerGroup       = SettingsFile.ReadLine();
                Defaults.Plant              = SettingsFile.ReadLine();
                Defaults.WarrantyMonthLimit = SettingsFile.ReadLine();
                Defaults.InputsPath         = SettingsFile.ReadLine();
                Defaults.CELPath            = SettingsFile.ReadLine();
                Defaults.QuotePath          = SettingsFile.ReadLine();
                ServerIndex                 = SettingsFile.ReadLine();
                ADefaults.FunctionLocation  = SettingsFile.ReadLine();
                ADefaults.ExternalReference = SettingsFile.ReadLine();
                ADefaults.Priority          = SettingsFile.ReadLine();
                ADefaults.PmActivityType    = SettingsFile.ReadLine();
                ADefaults.SoldToParty       = SettingsFile.ReadLine();
                SettingsFile.Close();

                // Download masters
                GetSharepointData();
            }
            else
            {
                // Open initial settings dialog
                InitialSetup InitialData = new InitialSetup(Reference);

                InitialData.ShowDialog();

                // Set settings
                Defaults.Distribution           = GetPrefix(InitialData.DistriChannelCB.Text) != "" ? GetPrefix(InitialData.DistriChannelCB.Text) : "02";
                Defaults.Division               = GetPrefix(InitialData.DivisionCB.Text) != "" ? GetPrefix(InitialData.DivisionCB.Text) : "21";
                Defaults.Effect                 = "5";
                Defaults.Location               = GetPrefix(InitialData.LocationCB.Text) != "" ? GetPrefix(InitialData.LocationCB.Text) : "WA-BAS";
                Defaults.Organization           = GetPrefix(InitialData.OrganizatonCB.Text) != "" ? GetPrefix(InitialData.OrganizatonCB.Text) : "1000";
                Defaults.PlannerGroup           = GetPrefix(InitialData.PlannerGroupCB.Text) != "" ? GetPrefix(InitialData.PlannerGroupCB.Text) : "B01";
                Defaults.Plant                  = GetPrefix(InitialData.PlantNumberCB.Text) != "" ? GetPrefix(InitialData.PlantNumberCB.Text) : "1002";
                Defaults.WarrantyMonthLimit     = "12";
                Defaults.InputsPath             = $"{AppData}\\{Defaults.Plant}_GeneralInputs.xlsx";
                Defaults.CELPath                = $"{AppData}\\{Defaults.Plant}_CollectiveEntryLists.xlsm";
                Defaults.QuotePath              = $"{AppData}\\{Defaults.Plant}_QuotingAndParts.xlsx";
                ServerIndex                     = @"\\prod.local\SharedData\AUWA22\WORKSHOP\";
                ADefaults.FunctionLocation      = "";
                ADefaults.ExternalReference     = "";
                ADefaults.Priority              = "";
                ADefaults.PmActivityType        = "";
                ADefaults.SoldToParty           = "";

                SaveSettings();

                // Download masters
                GetSharepointData();
            }
        }

        // Retreives prefix from input strings (all characters to the first whitespace)
        public string GetPrefix(string input)
        {
            if (input != null && input.Length > 0) 
                return input[0..input.IndexOf(" ")];
            else
                return "";
        }

        // Delete settings files and restart the application
        public void ResetSettings(bool ShowDiag)
        {
            try
            {
                if (File.Exists($"{AppData}\\APPSETTINGS"))     File.Delete($"{AppData}\\APPSETTINGS");
                if (File.Exists($"{AppData}\\COLORS"))          File.Delete($"{AppData}\\COLORS");
                if (File.Exists($"{AppData}\\THEME"))           File.Delete($"{AppData}\\THEME");
                if (File.Exists($"{AppData}\\MST_DataLinks"))   File.Delete($"{AppData}\\MST_DataLinks");

            }
            catch 
            {
                FullReset();
            }

            if (ShowDiag)
            {
                MsgBoxs.MsgBox_Normal("Application will now restart to complete settings reset, please wait for application to re-open.");
                RestartApp();
            }
        }

        // FULL RESET
        public void FullReset()
        {
            for(int i = 0; i < 100; i++)
            { 
                if (!Directory.Exists(AppData)) break;

                try
                {
                    Directory.Delete(AppData, true);          
                }
                catch 
                {
                    Thread.Sleep(500);
                }
            }
        }

        // Save settings to file
        public void SaveSettings()
        {
            StreamWriter SettingsFile = new StreamWriter($"{AppData}\\APPSETTINGS");

            SettingsFile.WriteLine(Defaults.Distribution);
            SettingsFile.WriteLine(Defaults.Division);
            SettingsFile.WriteLine(Defaults.Effect);
            SettingsFile.WriteLine(Defaults.Location);
            SettingsFile.WriteLine(Defaults.Organization);
            SettingsFile.WriteLine(Defaults.PlannerGroup);
            SettingsFile.WriteLine(Defaults.Plant);
            SettingsFile.WriteLine(Defaults.WarrantyMonthLimit);
            SettingsFile.WriteLine(Defaults.InputsPath);
            SettingsFile.WriteLine(Defaults.CELPath);
            SettingsFile.WriteLine(Defaults.QuotePath);
            SettingsFile.WriteLine(ServerIndex);
            SettingsFile.WriteLine(ADefaults.FunctionLocation);
            SettingsFile.WriteLine(ADefaults.ExternalReference);
            SettingsFile.WriteLine(ADefaults.Priority);
            SettingsFile.WriteLine(ADefaults.PmActivityType);
            SettingsFile.WriteLine(ADefaults.SoldToParty);
            SettingsFile.Close();
        }
    

        // Get functionlocation combobox from main screen and add it to the property grid
        internal class FLConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                Settings refMyObject = context.Instance as Settings;
                ComboBox FLCB = refMyObject.Reference.FunctionLoc_CB;
                List<string> list = new List<string>();

                for (int i = 0; i < FLCB.Items.Count; i++)
                {
                    list.Add(FLCB.Items[i].ToString());
                }

                return new StandardValuesCollection(list);
            }
        }

        // Get activity type combobox from main screen and add it to the property grid
        internal class ActTypeConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                Settings refMyObject = context.Instance as Settings;
                ComboBox FLCB = refMyObject.Reference.PMActivityType_CB;
                List<string> list = new List<string>();

                for (int i = 0; i < FLCB.Items.Count; i++)
                {
                    list.Add(FLCB.Items[i].ToString());
                }

                return new StandardValuesCollection(list);
            }
        }

        // Get priority type combobox from main screen and add it to the property grid
        internal class PriorityTypeConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                Settings refMyObject = context.Instance as Settings;
                ComboBox FLCB = refMyObject.Reference.Priority_CB;
                List<string> list = new List<string>();

                for (int i = 0; i < FLCB.Items.Count; i++)
                {
                    list.Add(FLCB.Items[i].ToString());
                }

                return new StandardValuesCollection(list);
            }
        }

        // Get sold to party type combobox from main screen and add it to the property grid
        internal class PartyConverter : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                Settings refMyObject = context.Instance as Settings;
                ComboBox FLCB = refMyObject.Reference.PartyName_CB;
                List<string> list = new List<string>();

                for (int i = 0; i < FLCB.Items.Count; i++)
                {
                    list.Add(FLCB.Items[i].ToString());
                }

                return new StandardValuesCollection(list);
            }
        }

        // Get sold to party type combobox from main screen and add it to the property grid
        internal class WarrantySelector : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                List<string> list = new List<string>
                {
                    "6",
                    "12",
                    "18",
                    "24"
                };

                return new StandardValuesCollection(list);
            }
        }
        // Get sold to party type combobox from main screen and add it to the property grid
        internal class EffectCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                List<string> list = new List<string>
                {
                    "1 - Failure/Cancellation",
                    "2 - Delay to Train Operations",
                    "3 - In-Field Attendance",
                    "4 - Unplanned Unavailability",
                    "5 - No effect"
                };

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class OrganizationCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].Organization == "" || GetInputs[i].Organization == null) break;

                    list.Add(GetInputs[i].Organization);
                }

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class PlantCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].Plant == "" || GetInputs[i].Plant == null) break;

                    list.Add(GetInputs[i].Plant);
                }

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class PlannerGroupCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].PlannerGroup == "" || GetInputs[i].PlannerGroup == null) break;

                    list.Add(GetInputs[i].PlannerGroup);
                }

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class LocationCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].Location == "" || GetInputs[i].Location == null) break;

                    list.Add(GetInputs[i].Location);
                }

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class DistChannelCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].DistChannel == "" || GetInputs[i].DistChannel == null) break;

                    list.Add(GetInputs[i].DistChannel);
                }

                return new StandardValuesCollection(list);
            }
        }

        // Add all organizations to comboboc
        internal class DivisionCB : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                // Get the mainform reference
                Settings Parent = context.Instance as Settings;
                List<string> list = new List<string>();
                InitialInputs[] GetInputs = Parent.Reference.SapInputLists;

                for (int i = 0; i < GetInputs.Length; i++)
                {
                    if (GetInputs[i].Division == "" || GetInputs[i].Division == null) break;

                    list.Add(GetInputs[i].Division);
                }

                return new StandardValuesCollection(list);
            }
        }
    }
}
