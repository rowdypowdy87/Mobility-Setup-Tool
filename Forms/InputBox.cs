using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public partial class InputBox : Form
    {
        MainForm RefForm;
        public string Result {get; set;}

        public InputBox(MainForm r)
        {
            RefForm = r;
            InitializeComponent();
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            Result = Input.Text;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Input.Text = "CANCEL";
            Close();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            TitleBar_PNL.BackColor = RefForm.ThemeController.GetBordercolor();
            BackColor = RefForm.ThemeController.GetBackcolor();
            TBInformation.BackColor = RefForm.ThemeController.GetBackcolor();
        }

        private void InputBox_Paint(object sender, PaintEventArgs e)
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
