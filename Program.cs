using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    static class Program
    {
        // Global variables
        public static bool DeveloperMode = false;
        public static bool HighPerformanceMode = false;

        /// <summary>
        /// Main entry point of the application
        /// </summary>
        /// <param name="args">
        ///     -r - Application Restarting
        ///     -a - Start in Developer mode
        /// </param>
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            // Variables
            bool IsRestarting = false;

            // Check startup arguments
            foreach (string arg in args)
            {
                switch (arg)
                {
                    case "-r":
                        IsRestarting = true;
                        break;

                    case "-a":
                        DeveloperMode = true;
                        break;

                    case "-h":
                        HighPerformanceMode = true;
                        break;
                }
            }

            // Check for another instance if not restarting the app
            if (Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1 && !IsRestarting)
            {
                MessageBox.Show("Another instance of the Mobilty Setup Tool is already running, you cannot start another instance.", "Instance already exists", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Application entry settings
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run main loop
            Application.Run(new MainForm());
        }
    }
}
