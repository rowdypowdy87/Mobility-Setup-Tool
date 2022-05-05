using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public struct InitialInputs
    {
        public string Organization     { get; set; }
        public string Plant            { get; set; }
        public string PlannerGroup     { get; set; }
        public string Location         { get; set; }
        public string DistChannel      { get; set; }
        public string Division         { get; set; }
    }

    public partial class InitialSetup : Form
    {
        public MainForm RefForm;

        // Window movement globals
        public bool                         isTopPanelDragged;
        public Point                        offset;
        public bool                         DidNotUpdate = false;
        

        public InitialSetup(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void InitialSetup_Load(object sender, EventArgs e)
        {
            // Add all misc sap inputs to intial input combos
            for(int i = 0; i < RefForm.SapInputLists.Length; i++)
            { 
                if(RefForm.SapInputLists[i].Organization != "" && RefForm.SapInputLists[i].Organization != null)
                    _ = OrganizatonCB.Items.Add(RefForm.SapInputLists[i].Organization);

                if(RefForm.SapInputLists[i].Plant != "" && RefForm.SapInputLists[i].Plant  != null)
                    _ = PlantNumberCB.Items.Add(RefForm.SapInputLists[i].Plant);

                if(RefForm.SapInputLists[i].PlannerGroup != "" && RefForm.SapInputLists[i].PlannerGroup  != null)
                    _ = PlannerGroupCB.Items.Add(RefForm.SapInputLists[i].PlannerGroup);

                if(RefForm.SapInputLists[i].Location != "" && RefForm.SapInputLists[i].Location  != null)
                    _ = LocationCB.Items.Add(RefForm.SapInputLists[i].Location);

                if(RefForm.SapInputLists[i].Division != "" && RefForm.SapInputLists[i].Division  != null)
                    _ = DivisionCB.Items.Add(RefForm.SapInputLists[i].Division);

                if(RefForm.SapInputLists[i].DistChannel != "" && RefForm.SapInputLists[i].DistChannel  != null)
                    _ = DistriChannelCB.Items.Add(RefForm.SapInputLists[i].DistChannel);
            }

            // Check if loaded
            if (OrganizatonCB.Items.Count <= 0 || 
                PlannerGroupCB.Items.Count <= 0 ||
                PlantNumberCB.Items.Count <= 0 ||
                DivisionCB.Items.Count <= 0 ||
                DistriChannelCB.Items.Count <= 0 ||
                LocationCB.Items.Count <= 0)
            {
                MsgBoxs.MsgBox_Error("Data load error, application will auto-reset");
                RefForm.AppSettings.FullReset();
                Environment.Exit(0);
            }


            // Manually centre the form to MainForm
            Location = new Point((RefForm.Location.X + RefForm.Width / 2) - Width / 2, (RefForm.Location.Y + RefForm.Height / 2) - Height / 2);
        }

        private void InitialSetup_Paint(object sender, PaintEventArgs e)
        {
            using (Pen BorderPen = new Pen(Color.Black, 1.0f))
            {
                e.Graphics.DrawRectangle(BorderPen, 0, 0, Width - 1, Height - 1);
            };
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
                Point pointStartPosition = PointToScreen(new Point(e.X, e.Y));
                offset = new Point
                {
                    X = Location.X - pointStartPosition.X,
                    Y = Location.Y - pointStartPosition.Y
                };
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2) isTopPanelDragged = false;
        }

        // Titlebar mouse down event 
        private void TitleBar_MouseUp(object sender, MouseEventArgs e) { isTopPanelDragged = false; }

        private void ContinueBTN_Click(object sender, EventArgs e)
        {
            if (PlantNumberCB.Text == "")
            {
                MsgBoxs.MsgBox_Error("Plant number is a mandatory field, please select a plant");
                return;
            }
            Close();
        }

        private void InitialSetup_Closed(object sender, FormClosedEventArgs e)
        {
            if (PlantNumberCB.Text == "")
            {
                Environment.Exit(0);
            }
        }
    }
}
