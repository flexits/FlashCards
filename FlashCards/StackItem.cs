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
    {
        /*
         * Custom UI item to represent a stack
         */

        // object represented by this control
        private VocabStack currentStack;

        public StackItem(VocabStack stack)
        {
            InitializeComponent();

            IsSelected = false;
            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelCounter.Text = currentStack.StackLength.ToString();
            pictureBox1.Image = stack.Picture;

            panel1.MouseClick += OnClick;
            labelTitle.MouseClick += OnClick;
            labelCounter.MouseClick += OnClick;
            pictureBox1.MouseClick += OnClick;
            MouseClick += OnClick;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(currentStack));
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //open stack view/edit form
            //MDIFormControls.OpenFormInPanel(new FormSettings());
        }
    }
}
