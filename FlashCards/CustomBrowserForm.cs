using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class CustomBrowserForm : Form
    /*
    * Parent form for cards and stacks browsers
    * - has panel container for items
    * - implements selection of a single item only
    */
    {
        public CustomBrowserForm()
        {
            InitializeComponent();
        }

        protected void ChildItemSelectChanged(object sender, EventArgs e)
        //when a stack is selected, deselect all others
        {
            if ((sender as ItemControl).IsSelected)
            {
                foreach (ItemControl sti in flowLayoutPanel1.Controls)
                {
                    if (sti != (sender as ItemControl))
                    {
                        sti.IsSelected = false;
                    }
                }
            }
        }
    }
}
