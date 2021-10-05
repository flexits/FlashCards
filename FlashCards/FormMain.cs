using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //translate controls' text
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
                CustomLocales.TranslateControlsTextProp(panelNavi.Controls);
            }
            //set parent panel for all forms
            MDIFormControls.PanelParent = panelContainer;
        }

        private void buttonStacks_Click(object sender, EventArgs e)
        {
            MenuVisualSelections.BtnSelect(sender as Button, panelNavi);
            MDIFormControls.OpenFormInPanel(new FormStacksBrowser());
        }

        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            MenuVisualSelections.BtnSelect(sender as Button, panelNavi);
            MDIFormControls.OpenFormInPanel(new FormSettings());
        }

        private void buttonQiuz_Click(object sender, EventArgs e)
        {
            MenuVisualSelections.BtnSelect(sender as Button, panelNavi);
            MDIFormControls.OpenFormInPanel(null);
        }
    }
}
