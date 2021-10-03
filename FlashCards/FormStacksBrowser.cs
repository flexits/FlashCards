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
            //get stack_ids from database
            //populate panel with stackitems
            int stackcounter = 8;
            int[] stack_ids = new int[stackcounter];
            stack_ids[0] = 0;
            stack_ids[1] = 1;
            stack_ids[2] = 2;
            foreach (int stack_id in stack_ids)
            {
                StackItem sti = new StackItem(stack_id);
                flowLayoutPanel1.Controls.Add(sti);
            }
        }
    }
}
