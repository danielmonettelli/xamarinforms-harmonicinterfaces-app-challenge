using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XF_HarmonicInterfaces.Themes;

namespace XF_HarmonicInterfaces.Helpers
{
    public static class ThemeHelper
    {
        public static void ChangeTheme(ThemeType themeType)
        {
            if (Application.Current.Resources != null)
                Application.Current.Resources.Clear();


            switch (themeType)
            {
                case ThemeType.Light:
                    Application.Current.Resources = new LightTheme();
                    break;
                case ThemeType.Dark:
                    Application.Current.Resources = new DarkTheme();
                    break;
            }
        }
    }
}
