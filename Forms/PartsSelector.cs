using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Mobility_Setup_Tool.MsgBoxs;

namespace Mobility_Setup_Tool
{
    public partial class PartsSelector : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool isTopPanelDragged;
        public Point offset;
        
        
        public List<string[]> Filters;
        public List<SAPComponent> ReturnComponents;

        public PartsSelector(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void PartsSelect_Load(object sender, EventArgs e)
        {
            
            BackColor                = RefForm.ThemeController.GetBackcolor();
            TitleBar_PNL.BackColor              = RefForm.ThemeController.GetBordercolor();
            MinimizeButton_LBL.BackColor        = RefForm.ThemeController.GetBordercolor();
            MaximizeButton_LBL.BackColor        = RefForm.ThemeController.GetBordercolor();
            CloseButton_LBL.BackColor           = RefForm.ThemeController.GetBordercolor();

            ReturnComponents = new List<SAPComponent>();
        }

        public void LoadFilters(DataTable Filter)
        {
            bool        Found           = false;
            int         i, ii, iii;

            // Create new list instance 
            Filters = new List<string[]>();

            // Load filters from database 
           for (i = 0; i < Filter.Rows.Count; i++)
           {
                string RawString = Filter.Rows[i]["FILTER"].ToString();
                string[] ToAdd = RawString.Split(",");
                Filters.Add(ToAdd);
            }

            for (i = 0; i < Filters.Count; i++)
            {
                for (ii = 0; ii < Filters[i].Length; ii++)
                {
                    string RawString = Filters[i][ii].ToString();

                    if (RawString != "")
                    {
                        Found = false;
                        for(iii = 0; iii < Filter_CB.Items.Count; iii++)
                        {
                            if(RawString == Filter_CB.Items[iii].ToString())
                            {
                                Found = true;
                            }
                        }

                        if(!Found) Filter_CB.Items.Add(RawString);
                    }
                }
            }

            // Add ALL to filter 
            Filter_CB.Items.Add("ALL");
        }

        // Apply filters to list 
        private void Filter_CB_SelectedValueChanged(object sender, EventArgs e)
        {
            int Row = 1;
            if (Filter_CB.Text != "ALL")
            {
                bool Found;
                Parts_DGV.Rows.Clear();

                for (int i = 1; i < RefForm.QuoteTable.Rows.Count; i++)
                {
                    Found = false;
                    for (int ii = 0; ii < Filters[i].Length; ii++)
                    {
                        string RawString = Filters[i][ii].ToString();
                        if (RawString == Filter_CB.Text) Found = true;
                    }

                    if (Found)
                    {
                        Parts_DGV.Rows.Add();
                        Parts_DGV[1, Row - 1].Value = RefForm.QuoteTable.Rows[i][0].ToString();
                        Parts_DGV[2, Row - 1].Value = RefForm.QuoteTable.Rows[i][3].ToString();
                        Parts_DGV[3, Row - 1].Value = RefForm.QuoteTable.Rows[i][1].ToString();
                        Row++;
                    }
                }
            }
            else
            {
                for (int i = 1; i < RefForm.QuoteTable.Rows.Count; i++)
                {
                    Parts_DGV.Rows.Add();
                    Parts_DGV[1, Row - 1].Value = RefForm.QuoteTable.Rows[i][0].ToString();
                    Parts_DGV[2, Row - 1].Value = RefForm.QuoteTable.Rows[i][3].ToString();
                    Parts_DGV[3, Row - 1].Value = RefForm.QuoteTable.Rows[i][1].ToString();
                    Row++;
                }
            }
        }

        // Close button label mouse enter event 
        private void CloseButton_LBL_MouseEnter(object sender, EventArgs e)
        {
            RefForm.General_TT.SetToolTip((Label)sender, "Close");
            CloseButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        // Close button label mouse leave event 
        private void CloseButton_LBL_MouseLeave(object sender, EventArgs e) { CloseButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Close button label mouse down 
        private void CloseButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Close();
        }

        // Minimize button label mouse down event 
        private void MiniButton_LBL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized;
        }

        // Minimize button label mouse enter event 
        private void MiniButton_LBL_MouseEnter(object sender, EventArgs e)
        {
            RefForm.General_TT.SetToolTip((Label)sender, "Minimize");
            MinimizeButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        // Minimize button label mouse leave event 
        private void MiniButton_LBL_MouseLeave(object sender, EventArgs e) { MinimizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

        // Maximize button mouse enter event 
        private void MaxButton_LBL_MouseEnter(object sender, EventArgs e)
        {
            RefForm.General_TT.SetToolTip((Label)sender, "Maximize");
            MaximizeButton_LBL.BackColor = RefForm.ThemeController.GetBackcolor();
        }


        // Maximize button label mouse leave event 
        private void MaxButton_LBL_MouseLeave(object sender, EventArgs e) { MaximizeButton_LBL.BackColor = RefForm.ThemeController.GetBordercolor(); }

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

        // Title bar double click event 
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
        }

        // Titlebar mouse move event 
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TitleBar_PNL.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;
            }
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
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
            if (e.Clicks == 2) isTopPanelDragged = false;
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        // Maximize button label mouse down event 
        private void MaxButton_LBL_MouseDown(object sender, MouseEventArgs e)
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

        public List<SAPComponent> GetSelectedComponents()
        {
            return ReturnComponents;
        }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            string SS, SL, QT;

            ReturnComponents.Clear();

            for(int i = 0; i < Parts_DGV.Rows.Count; i++)
            {
                if(Convert.ToBoolean(Parts_DGV.Rows[i].Cells["Selected"].Value))
                {
                    // Check for null values
                    if (Parts_DGV.Rows[i].Cells["SpecialStock"].Value != null)  { SS = Parts_DGV.Rows[i].Cells["SpecialStock"].Value.ToString(); }  else { SS = ""; }
                    if (Parts_DGV.Rows[i].Cells["Qty"].Value != null)           { QT = Parts_DGV.Rows[i].Cells["Qty"].Value.ToString(); }           else { QT = ""; }
                    if (Parts_DGV.Rows[i].Cells["StorLoc"].Value != null)       { SL = Parts_DGV.Rows[i].Cells["StorLoc"].Value.ToString(); }       else { SL = ""; }

                    SAPComponent ToAdd = new SAPComponent
                    {
                        ZAWA            = Parts_DGV.Rows[i].Cells["SapMat"].Value.ToString(),
                        Description     = Parts_DGV.Rows[i].Cells["Desc"].Value.ToString(),
                        Qauntity        = QT,
                        StoreLocation   = SL,
                        SpecialStock    = SS
                    };

                    // Verify data selected
                    if(ToAdd.Qauntity == "")
                    {
                        MsgBox_Error("Quantity cannot be blank");
                        return;
                    }

                    if (Convert.ToInt32(ToAdd.Qauntity) <= 0)
                    {
                        MsgBox_Error($"No quantity entered for material {ToAdd.Description}");
                        return;
                    }

                    if(ToAdd.StoreLocation == "")
                    {
                        MsgBox_Error($"No store location entered for material {ToAdd.Description}");
                        return;
                    }

                    ReturnComponents.Add(ToAdd);
                }
            }

            Close();
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PartsSelect_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            ResizeRedraw = true;

            using (Pen BorderPen = new Pen(RefForm.ThemeController.GetBordercolor(), 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
            };
        }
    }
}
