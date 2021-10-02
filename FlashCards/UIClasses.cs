using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace FlashCards
{
    static class MDIFormControls
    {
        static Form activeForm = null;

        public static void openFormInPanel(Panel panelParent, Form formChild)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (formChild == null)
            {
                return;
            }
            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelParent.Controls.Add(formChild);
            formChild.BringToFront();
            formChild.Show();
        }
    }

    static class customLocales
    {
        static CultureInfo currentCultureInfo;
        static string currentLocale;
        static bool usingDefaultLang;
        static customLocales()
        {
            switch (Properties.Settings.Default.UseLocale)
            {
                case "Русский":
                    currentLocale = "ru";
                    usingDefaultLang = false;
                    break;
                case "Английский":
                default:
                    currentLocale = "en";
                    usingDefaultLang = true;
                    break;
            }
            currentCultureInfo = CultureInfo.GetCultureInfo(currentLocale);
        }

        public static string GetTranslation(string str)
        {
            string translation;
            try
            {
                ResourceManager rmgr = new ResourceManager("FlashCards.lang.lang_" + currentLocale, Assembly.GetExecutingAssembly());
                translation = rmgr.GetString(str);
            }
            catch
            {
                return str;
            }
            if (translation == null)
            {
                return str;
            }
            return translation;
        }

        public static CultureInfo CurrentCultureInfo
        {
            get
            {
                return currentCultureInfo;
            }
        }

        public static string CurrentLocale
        {
            get
            {
                return currentLocale;
            }
        }

        public static bool UseDefaulLang
        {
            get
            {
                return usingDefaultLang;
            }
        }

    }
}
