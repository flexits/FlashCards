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

        // object represented by this control
        VocabStack currentStack;
        // selection state - true if the control was highlighted by mouse click
        bool isSelected;

        public bool SelectionState
        {
            get { return isSelected; }
        }

        public StackItem(VocabStack stack)
        {
            InitializeComponent();
            isSelected = false;
            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelCounter.Text = currentStack.StackLength.ToString();
            pictureBox1.Image = stack.Picture;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormSettings());
        }

        private void StackItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (isSelected)
            {
                //de-select
                isSelected = false;
                //change outline colour
                this.BackColor = CustomColors.TiffanyBlue;
                
            }
            else
            {
                //select
                isSelected = true;
                this.BackColor = CustomColors.OrangePeel;
            }
            //invoke SelectionChanged
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormSettings());
        }
    }
}
