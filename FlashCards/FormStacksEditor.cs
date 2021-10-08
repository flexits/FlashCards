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
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormStacksBrowser());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //update object
            //check if changed
            currentStack.Name = textBoxTitle.Text;
            currentStack.NativeLang = textBoxNative.Text;
            currentStack.ForeignLang = textBoxForeign.Text;
            currentStack.Comment = textBoxComment.Text;
            //picture
            if (pictureBox1.Image != null)
            {
                if (currentStack.Picture == null || !currentStack.Picture.Equals(pictureBox1.Image))
                {
                    currentStack.Picture = pictureBox1.Image;
                }
            }
            //update db
            DbOperations.UpdateStack(currentStack);
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormStacksBrowser());

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image image;
            try
            {
                //byte[] imgarr = File.ReadAllBytes(openFileDialog1.FileName);
                //image = ImageConversion.ByteToImg(imgarr);
                image = Image.FromFile(openFileDialog1.FileName);
                //FOrmats?!
            }
            catch
            {
                return;
            }
            pictureBox1.Image = image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
