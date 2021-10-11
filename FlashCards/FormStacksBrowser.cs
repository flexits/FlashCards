using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormStacksBrowser : CustomBrowserForm
    {
        public FormStacksBrowser()
        {
            InitializeComponent();
            //get all stacks from db and create a control for each
            List<VocabStack> stacks = DbOperations.GetAllStacks();
            foreach (VocabStack vst in stacks)
            {
                StackItem sti = new StackItem(vst);
                sti.SelectionChanged += new EventHandler(StackItemSelectChanged);
                flowLayoutPanel1.Controls.Add(sti);
            }
        }
    }
}
