using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.Image = Properties.Resources.minimize_yellow;
        }

        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.Image = Properties.Resources.minimize_light;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.Image = Properties.Resources.close_yellow;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.Image = Properties.Resources.close_light;
        }
    }
}
