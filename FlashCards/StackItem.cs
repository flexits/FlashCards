using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class StackItem : ItemControl
    /*
     * Custom UI item to represent a stack
     */
    {
        public StackItem(VocabStack stack)
        {
            InitializeComponent();

            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelCounter.Text = currentStack.StackLength.ToString();
            pictureBox1.Image = currentStack.Picture;
        }

        private VocabStack currentStack;

        private void OnItemSelection(object sender, MouseEventArgs e)
        {
            IsSelected = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(currentStack));
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(currentStack));
            //TODO change behaviour in settings: is it needed to edit by dblclick
        }
    }
}
