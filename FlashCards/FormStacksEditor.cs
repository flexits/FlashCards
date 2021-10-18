using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlashCards
{
    public partial class FormStacksEditor : Form
    {
        private VocabStack currentStack;
        public FormStacksEditor(VocabStack stack)
        {
            InitializeComponent();
            string title;
            if (stack == null)
            {
                title = "Adding stack";
                currentStack = null;
            }
            else
            {
                title = "Editing stack";
                textBoxTitle.Text = stack.Name;
                textBoxNative.Text = stack.NativeLang;
                textBoxForeign.Text = stack.ForeignLang;
                textBoxComment.Text = stack.Comment;
                pictureBox1.Image = stack.Picture;
                currentStack = stack;
            }
            //translate controls' text
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
                openFileDialog1.Title = CustomLocales.GetTranslation(openFileDialog1.Title);
                title = CustomLocales.GetTranslation(title);
            }

            //Text = title + " \"" + stack.Name + "\"";
            
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormStacksBrowser());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (Control tb in Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    tb.Text = tb.Text.Trim();
                }
            }
            if (currentStack == null)
            {
                //add
                DbOperations.AddStack(textBoxTitle.Text, textBoxNative.Text, textBoxForeign.Text, pictureBox1.Image, textBoxComment.Text);
            }
            else
            {
                //update object
                currentStack.Name = textBoxTitle.Text;
                currentStack.NativeLang = textBoxNative.Text;
                currentStack.ForeignLang = textBoxForeign.Text;
                currentStack.Comment = textBoxComment.Text;
                currentStack.Picture = pictureBox1.Image;
                DbOperations.UpdateStack(currentStack);
            }
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormStacksBrowser());

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = ImageConversion.ImgFromFile(openFileDialog1.FileName);
        }

        private void buttonCards_Click(object sender, EventArgs e)
        {
            MDIFormControls.OpenFormInPanel(new FormCardsBrowser(currentStack));
        }

        private void buttonImgRemove_Click(object sender, EventArgs e)
        {
            string text = "You're going to delete picture. This action can't be undone. Continue anyway?";
            string caption = "Delete file";
            if (CustomLocales.TranslationNeeded)
            {
                text = CustomLocales.GetTranslation(text);
                caption = CustomLocales.GetTranslation(caption);
            }
            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pictureBox1.Image = null;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string text = "You're going to delete stack with all cards in it. This action can't be undone. Continue anyway?";
            string caption = "Delete file";
            if (CustomLocales.TranslationNeeded)
            {
                text = CustomLocales.GetTranslation(text);
                caption = CustomLocales.GetTranslation(caption);
            }
            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                text = CustomLocales.GetTranslation("Records removed:") + " ";
                text += DbOperations.RemoveStack(currentStack.Id).ToString();
                _ = MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonCancel.PerformClick();
            }
        }
    }
}
