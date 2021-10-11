using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormCardsBrowser : CustomBrowserForm
    {
        public FormCardsBrowser(VocabStack stack) 
        {
            InitializeComponent();
            //get all cards from db relevant to stack_id and create a control for each
            foreach (VocabCard card in stack)
            {
                Label lbl = new Label();
                lbl.Text = card.WordForeign;
                flowLayoutPanel1.Controls.Add(lbl);
            }
            /*
            foreach (VocabStack vst in stacks)
            {
                StackItem sti = new StackItem(vst);
                sti.SelectionChanged += new EventHandler(StackItemSelectChanged);
                flowLayoutPanel1.Controls.Add(sti);
            }
             */
        }
    }
}
