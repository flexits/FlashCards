using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormBrowserParent : Form
    /*
    * Parent form for cards and stacks browsers
    * - has panel container for items
    * - implements selection of a single item only
    */
    {
        public FormBrowserParent()
        {
            InitializeComponent();
        }

        protected void ChildItemSelectChanged(object sender, EventArgs e)
        //when an item is selected, deselect all others
        {
            if ((sender as ControlCustomItemParent).IsSelected)
            {
                foreach (Control cl in flowLayoutPanel1.Controls)
                {
                    if (cl is ControlCustomItemParent && cl != (sender as ControlCustomItemParent))
                    {
                        (cl as ControlCustomItemParent).IsSelected = false;
                    }
                }
            }
        }
    }
}
