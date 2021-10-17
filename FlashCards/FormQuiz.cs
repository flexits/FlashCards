using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormQuiz : Form
    {
        public FormQuiz(VocabStack stack)
        {
            if (stack == null)
            {
                Close();
            }
            InitializeComponent();
            labelTitle.Text = stack.Name;

            MDIFormControls.CenterElementInPanel(labelTitle, Width);
            MDIFormControls.CenterElementInPanel(panelCard, Width);
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
            //in image not null, make offset
        }

        private void labelWord_MouseClick(object sender, MouseEventArgs e)
        {
            //turn card over
        }
    }
}
