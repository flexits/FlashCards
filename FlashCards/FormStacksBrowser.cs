using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormStacksBrowser : Form
    {
        public FormStacksBrowser()
        {
            InitializeComponent();

            List<VocabStack> stacks = DbOperations.GetAllStacks();
            foreach (VocabStack vst in stacks)
            {
                StackItem sti = new StackItem(vst);
                flowLayoutPanel1.Controls.Add(sti);
            }

            //upon selection change deselect others
        }
    }
}
