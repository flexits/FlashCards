using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            string foreign = "Foreign";
            string native = "Native";
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
                foreign = CustomLocales.GetTranslation(foreign);
                native = CustomLocales.GetTranslation(native);
            }
            comboBoxCardFace.Items.Add(foreign);
            comboBoxCardFace.Items.Add(native);
            LoadSettings();
        }

        private void LoadSettings()
        {
            comboBoxLang.SelectedIndex = comboBoxLang.Items.IndexOf(Properties.Settings.Default.UseLocale);
            comboBoxCardFace.SelectedIndex = Properties.Settings.Default.CardFaceLang;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.UseLocale = comboBoxLang.SelectedItem.ToString();
            Properties.Settings.Default.CardFaceLang = comboBoxCardFace.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLang.SelectedItem.ToString().Equals(Properties.Settings.Default.UseLocale))
            {
                labelRestartWarning.Visible = false;
            }
            else
            {
                labelRestartWarning.Visible = true;
            }
        }
    }
}
