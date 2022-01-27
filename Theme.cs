using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mobility_Setup_Tool
{
    public class Theme
    {
        private List<dynamic> Controls = new List<dynamic>();
        private List<string> Type = new List<string>();
        public static Color BorderColor, BackgroundColor;
        public string AppData = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\[UGL]Mobility Setup and Planning Tool";

        public Color ThemeBorderColor {
            get { return BorderColor; }
            set { BorderColor = value; }
        }

        public Color ThemeBackgroundColor {
            get { return BackgroundColor; }
            set { BackgroundColor = value; }
        }

        public void SetColor(dynamic control, Color val)
        {
            control.Invoke((MethodInvoker)delegate { control.BackColor = val; });
        }

        public void AddControls(dynamic AddControl, string AddType)
        {
            Controls.Add(AddControl);
            Type.Add(AddType);
        }

        public void SetThemeColor(Color NewBorderColor, Color NewBackgroundColor)
        {
            BorderColor = NewBorderColor;
            BackgroundColor = NewBackgroundColor;
        }

        public Color GetBordercolor()
        {
            return BorderColor;
        }

        public Color GetBackcolor()
        {
            return BackgroundColor;
        }

        public void SaveTheme()
        {
            using (StreamWriter ThemeFile = new StreamWriter($"{AppData}\\THEME"))
            {
                ThemeFile.WriteLine(BorderColor.ToArgb().ToString());
                ThemeFile.WriteLine(BackgroundColor.ToArgb().ToString());
                ThemeFile.Close();
            }; 
        }

        public void LoadTheme()
        {
            if (File.Exists($"{AppData}\\THEME"))
            {
                using (StreamReader ThemeFile = new StreamReader($"{AppData}\\THEME"))
                {
                    BorderColor     = Color.FromArgb(System.Convert.ToInt32(ThemeFile.ReadLine()));
                    BackgroundColor = Color.FromArgb(System.Convert.ToInt32(ThemeFile.ReadLine()));
                    ThemeFile.Close();
                };
            }
        }

        public void RefreshTheme()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Type[i] == "background")
                {
                    SetColor(Controls[i], BackgroundColor);
                }
                else
                {
                    SetColor(Controls[i], BorderColor);
                }
            }
        }

    }
}
