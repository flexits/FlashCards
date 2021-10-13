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
                sti.BackColorSelected = CustomColors.OrangePeel;
                sti.BackColorDefault = CustomColors.TiffanyBlue;
                sti.BackColor = CustomColors.TiffanyBlue;
                sti.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                flowLayoutPanel1.Controls.Add(sti);
            }
        }
    }
}
