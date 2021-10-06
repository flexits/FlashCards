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
        private readonly VocabStack currentStack;

        // true if this control is selected by user
        public bool IsSelected { get; private set; }
        // controls are selected by a first click and deselected by the second one
        // upon each click the event is invoked to deselect other controls
        public event EventHandler SelectionChanged;

        public void DeselectItem()
        {
            IsSelected = false;
            BackColor = CustomColors.TiffanyBlue;
        }

        public void SelectItem()
        {
            IsSelected = true;
            BackColor = CustomColors.OrangePeel;
        }

        public void ToggleSelection()
        {
            if (IsSelected)
            {
                DeselectItem();
            }
            else
            {
                SelectItem();
            }
        }

        public StackItem(VocabStack stack)
        {
            InitializeComponent();

            IsSelected = false;
            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelCounter.Text = currentStack.StackLength.ToString();
            pictureBox1.Image = stack.Picture;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(currentStack));
        }

        private void StackItem_MouseClick(object sender, MouseEventArgs e)
        {
            ToggleSelection();
            SelectionChanged?.Invoke(this, e);
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //open stack view/edit form
            //MDIFormControls.OpenFormInPanel(new FormSettings());
        }
    }
}
