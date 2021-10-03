using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace FlashCards
{
    /*
     * Application UI-related classes
     */
    static class TestClass
    {
        static int dummy = 0;
        public static int Dummy { get; set; }

        jkljk;ljk;kllk

    }

    static class MDIFormControls
    {
        static Form activeForm = null;
        static Panel panelParent = null;

        public static Panel PanelParent
        //set parent panel for all app's forms 
        {
            get { return panelParent; }
            set { panelParent = value; }
        }

        public static void openFormInPanel(Form formChild)
        //open new form in a panel (only one form at a time)
        //previously opened form is automatically closed
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (formChild == null || panelParent == null)
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
        static string currentLocale;
        static bool translationNeeded;
        static customLocales()
        {
            //get needed language from the app settings
            switch (Properties.Settings.Default.UseLocale)
            {
                case "Русский":
                    currentLocale = "ru";
                    translationNeeded = true;
                    break;
                case "Английский":
                default:
                    currentLocale = "en";
                    translationNeeded = false;
                    break;
            }
        }

        public static void TranslateControlsTextProp(Control.ControlCollection controls)
        //iterate over controls and translate their .Text property if .Tag contains "TextTranslatable"
        {
            foreach (Control cl in controls)
            {
                if (cl.Tag != null && cl.Tag.ToString().Contains("TextTranslatable"))
                {
                    cl.Text = GetTranslation(cl.Text);
                }
            }
        }

        public static string GetTranslation(string str)
        //return the translation of str from FlashCards.lang.lang_* corresponding to the app language setting
        //or echo str back if any error
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

        public static string CurrentLocale
        {
            get
            {
                return currentLocale;
            }
        }

        public static bool TranslationNeeded
        {
            get
            {
                return translationNeeded;
            }
        }

    }
}
