using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class StackItem : UserControl
    {
        /*
         * Custom UI item to represent a stack
         */

        //need to design margins
        //background with rounded corners

        VocabStack currentStack;
        bool isSelected;

        public StackItem(VocabStack stack)
        {
            InitializeComponent();
            isSelected = false;
            panel1.BackColor = ColorScheme.Default.Brown3;
            labelTitle.ForeColor = ColorScheme.Default.DarkGreen1;
            labelCounter.ForeColor = ColorScheme.Default.LightBrown2;
            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelCounter.Text = currentStack.StackLength.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //invoke stack view/edit form
            MDIFormControls.openFormInPanel(new FormSettings());
        }

        private void StackItem_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (panel1.ClientRectangle.Contains(PointToClient(e.Location))){
                //not working because item is in backround
            }*/
            if (isSelected)
            {
                //de-select
                isSelected = false;
                panel1.BackColor = ColorScheme.Default.Brown3;
            }
            else
            {
                //select
                isSelected = true;
                panel1.BackColor = ColorScheme.Default.Brown1;
            }
            //make this item selected
            //change color
            //deselect others!
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //invoke stack view/edit form
            MDIFormControls.openFormInPanel(new FormSettings());
        }
    }
}
