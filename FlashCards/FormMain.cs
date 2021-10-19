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

        private VocabStack selectedStack;
        public VocabStack SelectedStack
        {
            get { return selectedStack; }
            set
            {
                selectedStack = value;
                if (value == null)
                {
                    menuItemQiuz.Enabled = false;
                }
                else
                {
                    menuItemQiuz.Enabled = true;
                }
            }
        }

        private void menuItemStacks_ItemClickPerformed(object sender, EventArgs e)
        {
            //reset selection and open browser form;
            SelectedStack = null;
            MDIFormControls.OpenFormInPanel(new FormBrowserStacks());
        }

        private void menuItemQiuz_ItemClickPerformed(object sender, EventArgs e)
        {
            if (SelectedStack != null)
            {
                MDIFormControls.OpenFormInPanel(new FormQuiz(SelectedStack));
            }
        }

        private void menuItemSettings_ItemClickPerformed(object sender, EventArgs e)
        {
            MDIFormControls.OpenFormInPanel(new FormSettings());
        }

        private void MenuItemSelectChanged(object sender, EventArgs e)
        {
            // only one item can be selected at a time
            if ((sender as ControlMenuItem).IsSelected)
            {
                foreach (Control cl in panelNavi.Controls)
                {
                    if (cl.GetType() == typeof(ControlMenuItem) && cl != (sender as ControlMenuItem))
                    {
                        (cl as ControlMenuItem).IsSelected = false;
                    }
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            menuItemStacks.PerformClick();
        }

        //Make panelHeader behave as a window header
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
        //custom button to close app
        {
            Application.Exit();
            //TODO minimize to tray
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        //custom button to miminize app
        {
            WindowState = FormWindowState.Minimized;
        }

        //change buttons' images on mouse actions
        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Properties.Resources.minimize_yellow;
        }

        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Properties.Resources.minimize_light;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = Properties.Resources.close_yellow;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = Properties.Resources.close_light;
        }
    }
}
