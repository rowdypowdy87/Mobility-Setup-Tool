using OfficeOpenXml;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Mobility_Setup_Tool
{
    public enum ACTION : int
    {
        CREATE = 0,
        CHANGE = 1,
        DEACTIVATE = 2,
        NOTHING = 3
    };

    public struct MeasurementUpdate
    {
        public MobilityMeasurement Info { get; set; }
        public ACTION Action { get; set; }
        public string ChangeNumber { get; set; }
    }

    class ExcelDataTables
    {
        public const int EXACT = 0;
        public const int PARTIAL = 1;
        public const int NOMATCH = 2;

        // Convert excel sheet into readable data table in memory 
        // I did not create this method
        public DataTable ConvertExcelToDataTable(string path, dynamic sheetnumber)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var pck = new ExcelPackage();

            try
            {
                pck.Load(File.OpenRead(path));
            }
            catch
            {
                MsgBoxs.MsgBox_Error($"Failed to open database @{path}. Please verify the file exists and is not already open and try. If problem persists contact Administator");
                return null;
            }
            var ws = pck.Workbook.Worksheets[sheetnumber];
            DataTable tbl = new DataTable();
            bool hasHeader = true;
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (var rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                var row = tbl.NewRow();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
                tbl.Rows.Add(row);
            }
            pck.Dispose();
            return tbl;
        }

        // Convert excel sheet into readable data table in memory 
        // I did not create this method
        public DataTable ConvertExcelToDataTable_Name(string path, string sheetname)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var pck = new ExcelPackage();

            try { pck.Load(File.OpenRead(path)); } catch (Exception e) { MsgBoxs.MsgBox_Error(e.Message); return null; }
            var ws = pck.Workbook.Worksheets[sheetname];
            DataTable tbl = new DataTable();
            bool hasHeader = true;
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
            }
            var startRow = hasHeader ? 2 : 1;
            for (var rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                var row = tbl.NewRow();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
                tbl.Rows.Add(row);
            }
            pck.Dispose();
            return tbl;
        }

        // Convert from text
        public DataTable ControlTexttoDataTable_IW58(string path)
        {
            string Text;

            try
            {
                Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MsgBoxs.MsgBox_Error(ex.Message); return null;
            }

            DataTable Export = new DataTable();

            // Create columns
            Export.Columns.Add("Order");
            Export.Columns.Add("Notification");
            Export.Columns.Add("Notifictn type");
            Export.Columns.Add("Notif.date");
            Export.Columns.Add("Effect");
            Export.Columns.Add("Room");
            Export.Columns.Add("Description");
            Export.Columns.Add("Req. start");
            Export.Columns.Add("Location");
            Export.Columns.Add("User status");
            Export.Columns.Add("Breakdown");
            Export.Columns.Add("Priority");
            Export.Columns.Add("PO Number");
            Export.Columns.Add("Coding");
            Export.Columns.Add("System status");
            Export.Columns.Add("Reported by");
            Export.Columns.Add("Equipment");
            Export.Columns.Add("Created By");
            Export.Columns.Add("Changed by");

            // Split text into rows with columns
            string[] TextData = Text.Split("|");

            for (int i = 24; i < TextData.Length; i += 23)
            {
                // Create and add new row
                DataRow NewRow = Export.NewRow();

                NewRow["Order"] = TextData[i].Trim();
                NewRow["Notification"] = TextData[i + 1].Trim();
                NewRow["Notifictn type"] = TextData[i + 2].Trim();
                NewRow["Notif.date"] = TextData[i + 3].Trim();
                NewRow["Effect"] = TextData[i + 4].Trim();
                NewRow["Room"] = TextData[i + 5].Trim();
                NewRow["Description"] = TextData[i + 6].Trim();
                NewRow["Req. start"] = TextData[i + 7].Trim();
                NewRow["Location"] = TextData[i + 8].Trim();
                NewRow["User status"] = TextData[i + 9].Trim();
                NewRow["Breakdown"] = TextData[i + 10].Trim();
                NewRow["Priority"] = TextData[i + 11].Trim();
                NewRow["PO Number"] = TextData[i + 12].Trim();
                NewRow["Coding"] = TextData[i + 13].Trim();
                NewRow["System status"] = TextData[i + 14].Trim();
                NewRow["Reported by"] = TextData[i + 15].Trim();
                NewRow["Equipment"] = TextData[i + 16].Trim();
                NewRow["Created By"] = TextData[i + 17].Trim();
                NewRow["Changed by"] = TextData[i + 18].Trim();

                // Add data
                Export.Rows.Add(NewRow);
            }

            // Return data table
            return Export;
        }

        // Convert from text
        public DataTable ControlTexttoDataTable(string path)
        {
            string Text;

            try
            {
                Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MsgBoxs.MsgBox_Error(ex.Message); return null;
            }

            DataTable Export = new DataTable();

            // Create columns
            Export.Columns.Add("Measurement Point");
            Export.Columns.Add("Equipment");
            Export.Columns.Add("Position");
            Export.Columns.Add("Description");
            Export.Columns.Add("Characteristic Name");
            Export.Columns.Add("Decimal Places");
            Export.Columns.Add("Code Group");
            Export.Columns.Add("Target Value");
            Export.Columns.Add("Lower Limit");
            Export.Columns.Add("Upper Limit");
            Export.Columns.Add("Text");
            Export.Columns.Add("ValueCode Sufficient");
            Export.Columns.Add("Is Counter");

            // Split text into rows with columns
            string[] TextData = Text.Split("|");

            for (int i = 15; i < TextData.Length; i += 14)
            {
                // Create and add new row
                DataRow NewRow = Export.NewRow();

                NewRow["Measurement Point"] = !ContainsChars(TextData[i].Trim()) ? "" : TextData[i].Trim();
                NewRow["Equipment"] = !ContainsChars(TextData[i + 1].Trim()) ? "" : TextData[i + 1].Trim();
                NewRow["Position"] = !ContainsChars(TextData[i + 2].Trim()) ? "" : TextData[i + 2].Trim();
                NewRow["Description"] = !ContainsChars(TextData[i + 3].Trim()) ? "" : TextData[i + 3].Trim();
                NewRow["Characteristic Name"] = !ContainsChars(TextData[i + 4].Trim()) ? "" : TextData[i + 4].Trim();
                NewRow["Decimal Places"] = !ContainsChars(TextData[i + 5].Trim()) ? "" : TextData[i + 5].Trim();
                NewRow["Code Group"] = !ContainsChars(TextData[i + 6].Trim()) ? "" : TextData[i + 6].Trim();
                NewRow["Target Value"] = !ContainsChars(TextData[i + 7].Trim()) ? "" : TextData[i + 7].Trim();
                NewRow["Lower Limit"] = !ContainsChars(TextData[i + 8].Trim()) ? "" : TextData[i + 8].Trim();
                NewRow["Upper Limit"] = !ContainsChars(TextData[i + 9].Trim()) ? "" : TextData[i + 9].Trim();
                NewRow["Text"] = !ContainsChars(TextData[i + 10].Trim()) ? "" : TextData[i + 10].Trim();
                NewRow["ValueCode Sufficient"] = !ContainsChars(TextData[i + 11].Trim()) ? "" : TextData[i + 11].Trim();
                NewRow["Is Counter"] = !ContainsChars(TextData[i + 12].Trim()) ? "" : TextData[i + 12].Trim();

                // Add data
                Export.Rows.Add(NewRow);
            }

            // Return data table
            return Export;
        }

        // Check if a string contains characters or is just white space 
        public bool ContainsChars(string Input)
        {
            bool ret = false;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input.Substring(i, 1) != " ") ret = true;
            }

            return ret;
        }

        // Convert table to measure list
        public List<MobilityMeasurement> ConvertTableToList(DataTable Input)
        {
            List<MobilityMeasurement> ReturnVal = new List<MobilityMeasurement>();

            for (int i = 0; i < Input.Rows.Count; i++)
            {
                // Create instances
                MobilityMeasurement MeasToAdd = new MobilityMeasurement
                {
                    // Build measurement point
                    Number = Input.Rows[i]["Measurement Point"].ToString(),
                    Position = Input.Rows[i]["Position"].ToString(),
                    Description = Input.Rows[i]["Description"].ToString(),
                    CharCode = Input.Rows[i]["Characteristic Name"].ToString(),
                    Decimals = Input.Rows[i]["Decimal Places"].ToString(),
                    CodeGroup = Input.Rows[i]["Code Group"].ToString(),
                    TargetValue = Input.Rows[i]["Target Value"].ToString(),
                    LowerLimit = Input.Rows[i]["Lower Limit"].ToString(),
                    UpperLimit = Input.Rows[i]["Upper Limit"].ToString(),
                    TargetText = Input.Rows[i]["Text"].ToString(),
                    IsCounter = Input.Rows[i]["Is Counter"].ToString(),
                    IsValueCodeSuff = Input.Rows[i]["ValueCode Sufficient"].ToString()
                };

                // Build measurement update structure
                ReturnVal.Add(MeasToAdd);
            }

            return ReturnVal;
        }

        // Check for missing measurements or errors in fields of measurements VS template equipment in SAP
        public List<MeasurementUpdate> CompareMeasurements(DataTable CompareBase, DataTable CompareOther)
        {
            // Comparing variables
            List<MobilityMeasurement> Base = ConvertTableToList(CompareBase);
            List<MobilityMeasurement> Other = ConvertTableToList(CompareOther);
            List<MeasurementUpdate> Updates = new List<MeasurementUpdate>();
            MeasurementUpdate Test;
            bool FoundMeas = false;

            // Empty equipment measures
            if (CompareOther == null)
            {
                // Build compare string from first table
                for (int i = 0; i < Base.Count; i++)
                {
                    Test = new MeasurementUpdate
                    {
                        Action = ACTION.CREATE,
                        Info = Base[i]
                    };

                    Updates.Add(Test);
                }

                return Updates;
            }

            // Build compare string from first table
            for (int i = 0; i < Base.Count; i++)
            {
                // Scan second table for this string
                for (int ii = 0; ii < Other.Count; ii++)
                {
                    FoundMeas = false;

                    // Check each template measurements are in the input equipment and if they match exactly or not
                    switch (Compare(Base[i], Other[ii]))
                    {
                        case EXACT:
                            Test = new MeasurementUpdate
                            {
                                Action = ACTION.NOTHING,
                                Info = Other[ii],
                                ChangeNumber = Other[ii].Number
                            };

                            Updates.Add(Test);

                            // Break ii loop
                            FoundMeas = true;

                            break;

                        case PARTIAL:

                            Test = new MeasurementUpdate
                            {
                                Action = ACTION.CHANGE,
                                Info = Base[i],
                                ChangeNumber = Other[ii].Number
                            };

                            Updates.Add(Test);

                            // Break ii loop
                            FoundMeas = true;

                            break;

                    }

                    if (FoundMeas) break;
                }

                // Add create measure to list
                if (!FoundMeas)
                {
                    Test = new MeasurementUpdate
                    {
                        Action = ACTION.CREATE,
                        Info = Base[i]
                    };

                    Updates.Add(Test);
                }
            }

            // Scan for obselete measurements
            for (int j = 0; j < Other.Count; j++)
            {
                FoundMeas = false;

                for (int jj = 0; jj < Updates.Count; jj++)
                {
                    if (Updates[jj].ChangeNumber == Other[j].Number)
                    {
                        FoundMeas = true;
                    }
                }

                // Add create measure to list
                if (!FoundMeas)
                {
                    Test = new MeasurementUpdate
                    {
                        Action = ACTION.DEACTIVATE,
                        Info = Other[j],
                        ChangeNumber = Other[j].Number
                    };

                    Updates.Add(Test);
                }
            }

            // Return updates
            List<MeasurementUpdate> Return = new List<MeasurementUpdate>();

            // Remove any measurements that are already correct
            for (int i = 0; i < Updates.Count; i++)
            {
                if (Updates[i].Action == ACTION.CHANGE || Updates[i].Action == ACTION.DEACTIVATE || Updates[i].Action == ACTION.CREATE)
                {
                    for (int j = 0; j < Base.Count; j++)
                    {
                        if (Updates[i].Info.Position == Base[j].Position &&
                           Updates[i].Info.Description == Base[j].Description)
                        {

                            // Search to make sure the measurement is not already in the update list to change
                            FoundMeas = false;
                            for (int ii = 0; ii < Return.Count; ii++)
                            {
                                if (Return[ii].Info.Number == Updates[i].Info.Number)
                                {
                                    FoundMeas = true;
                                }
                            }

                            if (!FoundMeas) Return.Add(Updates[i]);
                        }
                    }
                }
            }

            return Return;
        }

        // Compares 2 measurements
        public int Compare(MobilityMeasurement Base, MobilityMeasurement Compare)
        {
            if (Compare.Description == Base.Description &&
                Compare.Position == Base.Position &&
                Compare.CharCode == Base.CharCode &&
                Compare.CodeGroup == Base.CodeGroup &&
                Compare.UpperLimit == Base.UpperLimit &&
                Compare.LowerLimit == Base.LowerLimit &&
                Compare.TargetText == Base.TargetText &&
                Compare.TargetValue == Base.TargetValue &&
                Compare.IsValueCodeSuff == Base.IsValueCodeSuff &&
                Compare.IsCounter == Base.IsCounter &&
                Compare.Decimals == Base.Decimals)
            {
                return EXACT;
            }

            if (Compare.Description == Base.Description &&
                Compare.Position == Base.Position &&
                Compare.CharCode == Base.CharCode)
            {
                return PARTIAL;
            }

            return NOMATCH;
        }
    }
}
