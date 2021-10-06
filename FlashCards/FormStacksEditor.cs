using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormStacksEditor : Form
    {
        private readonly VocabStack currentStack;
        public FormStacksEditor(VocabStack stack)
        {
            if (stack == null)
            {
                Close();
            }
            InitializeComponent();
            //translate controls' text
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
            }

            textBoxTitle.Text = stack.Name;
            textBoxNative.Text = stack.NativeLang;
            textBoxForeign.Text = stack.ForeignLang;
            textBoxComment.Text = stack.Comment;
            pictureBox1.Image = stack.Picture;
            currentStack = stack;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
