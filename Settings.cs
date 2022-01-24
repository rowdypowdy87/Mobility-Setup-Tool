using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System;
using System.Windows.Forms;
using System.Net;
using Mobility_Setup_Tool.Forms;
using System.Collections.Generic;

namespace Mobility_Setup_Tool
{
    

    public struct SAP_DEFAULTS
    {
        public string Organization { get; set; }
        public string Location { get; set; }
        public string Plant { get; set; }
        public string Division { get; set; }
        public string Distribution { get; set; }
        public string WarrantyMonthLimit { get; set; }
        public string Effect { get; set; }
        public string PlannerGroup { get; set; }
        public string ServerIndex { get; set; }
        public string InputsPath { get; set; }
        public string QuotePath { get; set; }
        public string CELPath { get; set; }
    }

    public struct APP_DEFAULTS
    {
        public string FunctionLocation { get; set; }
        public string SoldToParty { get; set; }
        public string PmActivityType { get; set;}
        public string Priority { get; set;}
        public string ExternalReference { get; set; }
    }

    public class FunctionLocationConverter : StringConverter
    {   
        

    }

    [DefaultPropertyAttribute("Distribution")]
    public class Settings
    {
        public SAP_DEFAULTS     Defaults            = new SAP_DEFAULTS();
        public APP_DEFAULTS     ADefaults           = new APP_DEFAULTS();
        public string           AppData             = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\[UGL]Mobility Setup and Planning Tool";
        public const string     VersionNumber       = "1.0";
        public Theme            ThemeController;
        public MainForm         Reference;


        // Creation method
        public Settings(Theme Ref, MainForm Ref2) { 
            ThemeController = Ref; 
            Reference = Ref2;
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

        [CategoryAttribute("Application Defaults"), Description("Default sold to party"), DisplayName("SoldToParty")]
        public string SoldToParty
        {
            get { return ADefaults.SoldToParty; }
            set { ADefaults.SoldToParty = value ?? ""; }
        }

        [CategoryAttribute("Application Defaults"), Description("Default maint activity type"), DisplayName("PMActivityType")]
        public string PmActivityType
        {
            get { return ADefaults.PmActivityType; }
            set { ADefaults.PmActivityType = value ?? ""; }
        }

        [CategoryAttribute("Application Defaults"), Description("Default priority"), DisplayName("Service Order Priority")]
        public string Priority
        {
            get { return ADefaults.Priority; }
            set { ADefaults.Priority = value ?? ""; }
        }

        [CategoryAttribute("Application Defaults"), Description("Default external reference"), DisplayName("Customer Reference")]
        public string ExternalReference
        {
            get { return ADefaults.ExternalReference; }
            set { ADefaults.ExternalReference = value ?? ""; }
        }


        // Add property info
        [CategoryAttribute("SAP Defaults"), Description("Distribution channel for SAP"), DisplayName("Distribution Channel")]
        public string Distribution {
            get { return Defaults.Distribution; }
            set { Defaults.Distribution = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Division of company"), DisplayName("Division")]
        public string Division {
            get { return Defaults.Division; }
            set { Defaults.Division = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Default notification effect"), DisplayName("Effect")]
        public string Effect {
            get { return Defaults.Effect; }
            set { Defaults.Effect = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Current site location"), DisplayName("Location")]
        public string Location {
            get { return Defaults.Location; }
            set { Defaults.Location = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Organization number"), DisplayName("Organization")]
        public string Organization {
            get { return Defaults.Organization; }
            set { Defaults.Organization = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Current site planner group number"), DisplayName("Planner Group")]
        public string PlannerGroup {
            get { return Defaults.PlannerGroup; }
            set { Defaults.PlannerGroup = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Current site plant number"), DisplayName("Plant")]
        public string Plant {
            get { return Defaults.Plant; }
            set { Defaults.Plant = value ?? ""; }
        }

        [CategoryAttribute("SAP Defaults"), Description("Number of months for which to check if a service order is a warranty or not"), DisplayName("Warranty Limit (months)")]
        public string WarrantyMonthLimit {
            get { return Defaults.WarrantyMonthLimit; }
            set { Defaults.WarrantyMonthLimit = value ?? ""; }
        }

        [CategoryAttribute("Theme Settings"), Description("Color of form borders and title bar"), DisplayName("Border Color")]
        [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(MyTypeConverter))]
        public Color BorderColor {
            get { return ThemeController.ThemeBorderColor; }
            set { ThemeController.ThemeBorderColor = value != null ? value : Color.Black; }
        }

        [CategoryAttribute("Theme Settings"), Description("Background color of forms"), DisplayName("Background Color")]
        [Editor(typeof(MyColorEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(MyTypeConverter))]
        public Color BackgroundColor {
            get { return ThemeController.ThemeBackgroundColor; }
            set { ThemeController.ThemeBackgroundColor = value != null ? value : Color.LightGray; }
        }

        [CategoryAttribute("Folder Paths"), Description("Server path index for current plant"), DisplayName("Server Path")]
        [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]
        public string ServerIndex {
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
            public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.Modal;
            }
            public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
            {
                return false;
            }
            public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                return cd.Color;
            }
        }

    

        public void DownloadFromSharepoint(string Link, string SavePath)
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
                    MsgBoxs.MsgBox_Error($"Could not download file {Link} please check your connection");
                    return;
                }

                // Save to local DB
                SaveData = new FileStream(SavePath, FileMode.Create);
                SaveData.Write(Data);
                SaveData.Close();
            }
        }

        // Download inputs from sharepoint
        public void GetSharepointData()
        {
            string SP_Quote     = "", SP_Inputs = "", SP_CEL = "", Ver;
            bool   FoundPlant   = false;

            // Download master links
            DownloadFromSharepoint("http://uglteams/sites/fs/AdminLibrary/MST_DataLinks", $"{AppData}\\MST_DataLinks");

            // Check version
            StreamReader MasterData = new StreamReader($"{AppData}\\MST_DataLinks");

            Ver = MasterData.ReadLine();

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
                    Application.Exit();
                }
            }

            // Get plant db links
            while(!MasterData.EndOfStream)
            {
                if(MasterData.ReadLine() == Defaults.Plant)
                {
                    SP_Quote    = MasterData.ReadLine();
                    SP_Inputs   = MasterData.ReadLine();
                    SP_CEL      = MasterData.ReadLine();
                    FoundPlant  = true;
                    break;
                }
            }

            if (!FoundPlant)
            {
                MsgBoxs.MsgBox_Error($"Cannot find database links for plant {Defaults.Plant}");
                Application.Exit();
            }

            MasterData.Close();

            // Download master databases for this plant
            DownloadFromSharepoint(SP_Inputs, Defaults.InputsPath);
            DownloadFromSharepoint(SP_Quote, Defaults.QuotePath);
            DownloadFromSharepoint(SP_CEL, Defaults.CELPath);
        }

        // Load settings from file
        public void LoadSettings()
        {
            if (File.Exists($"{AppData}\\APPSETTINGS"))
            { 
                // Read appsettings
                StreamReader SettingsFile = new StreamReader($"{AppData}\\APPSETTINGS");
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

            } else {

                // First time run ask user for input
                Directory.CreateDirectory($"{AppData}\\");

                // Open initial settings dialog
                InitialSetup InitialData = new InitialSetup(Reference);

                InitialData.ShowDialog();

                // Set settings
                Defaults.Distribution       = InitialData.DistriChannelCB.Text;
                Defaults.Division           = InitialData.DivisionCB.Text;
                Defaults.Effect             = "5";
                Defaults.Location           = InitialData.LocationCB.Text;
                Defaults.Organization       = InitialData.OrganizatonCB.Text;
                Defaults.PlannerGroup       = InitialData.PlannerGroupCB.Text;
                Defaults.Plant              = InitialData.PlantNumberCB.Text;
                Defaults.WarrantyMonthLimit = "12";
                Defaults.InputsPath         = $"{AppData}\\{Defaults.Plant}_GeneralInputs.xlsx";
                Defaults.CELPath            = $"{AppData}\\{Defaults.Plant}_CollectiveEntryLists.xlsm";
                Defaults.QuotePath          = $"{AppData}\\{Defaults.Plant}_QuotingAndParts.xlsx";
                ServerIndex                 = @"\\prod.local\SharedData\AUWA22\WORKSHOP\";
                ADefaults.FunctionLocation  = "";
                ADefaults.ExternalReference = "";
                ADefaults.Priority          = "";
                ADefaults.PmActivityType    = "";
                ADefaults.SoldToParty       = "";

                SaveSettings();

                // Download masters
                GetSharepointData();
            }
        }

        // Delete appsettings file
        public void ResetSettings()
        {
            if (File.Exists($"{AppData}\\APPSETTINGS")) File.Delete($"{AppData}\\APPSETTINGS");
            if (File.Exists($"{AppData}\\THEME")) File.Delete($"{AppData}\\THEME");
            if (File.Exists($"{AppData}\\MST_DataLinks")) File.Delete($"{AppData}\\MST_DataLinks");
            if (File.Exists(Defaults.CELPath)) File.Delete(Defaults.CELPath);
            if (File.Exists(Defaults.InputsPath)) File.Delete(Defaults.InputsPath);
            if (File.Exists(Defaults.QuotePath)) File.Delete(Defaults.QuotePath);
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
    }

    // Get functionlocation combobox from main screen and add it to the property grid
    public class FLConverter : StringConverter
    { 
        public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
        public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            Settings     refMyObject    = context.Instance as Settings;
            ComboBox     FLCB           = refMyObject.Reference.FunctionLoc_CB;
            List<String> list           = new List<String>();
            
            for(int i = 0; i < FLCB.Items.Count; i++)
            {
                list.Add(FLCB.Items[i].ToString());
            }

            return new StandardValuesCollection(list);
        }
    }
}
