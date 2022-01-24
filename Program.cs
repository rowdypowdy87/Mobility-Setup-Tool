using System;
using System.Linq;
using System.Windows.Forms;
using static Mobility_Setup_Tool.MsgBoxs;

namespace Mobility_Setup_Tool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Check for another instance
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) {
                MsgBox_Error("Another instance of this application is already running!");
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        } 
    }
}
