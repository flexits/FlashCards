using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormStacksEditor : Form
    {
        private VocabStack currentStack;
        public FormStacksEditor(VocabStack stack)
        {
            //if stack==null we're adding a new stack
            //otherwise we're in edit mode
            InitializeComponent();
            string title;
            if (stack == null)
            {
                //title = "Adding stack";
                currentStack = null;
                buttonCards.Enabled = false;
                buttonDelete.Enabled = false;
                buttonExport.Enabled = false;
            }
            else
            {
                //title = "Editing stack";
                textBoxTitle.Text = stack.Name;
                textBoxNative.Text = stack.NativeLang;
                textBoxForeign.Text = stack.ForeignLang;
                textBoxComment.Text = stack.Comment;
                pictureBox1.Image = ImageConversion.ByteToImg(stack.Picture);
                currentStack = stack;
            }
            //translate controls' text
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
                openFileDialog1.Title = CustomLocales.GetTranslation(openFileDialog1.Title);
                openFileDialog1.Filter = CustomLocales.GetTranslation(openFileDialog1.Filter);
                openFileDialog2.Title = CustomLocales.GetTranslation(openFileDialog2.Title);
                openFileDialog2.Filter = CustomLocales.GetTranslation(openFileDialog2.Filter);
                saveFileDialog1.Title = CustomLocales.GetTranslation(saveFileDialog1.Title);
                saveFileDialog1.Filter = CustomLocales.GetTranslation(saveFileDialog1.Filter);
            }

        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormBrowserStacks());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //trim text in boxes 
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
                currentStack.Picture = ImageConversion.ImgToByte(pictureBox1.Image);
                DbOperations.UpdateStack(currentStack);
            }
            //return to stacks browser
            MDIFormControls.OpenFormInPanel(new FormBrowserStacks());

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
            if (currentStack == null)
            {
                return;
            }
            MDIFormControls.OpenFormInPanel(new FormBrowserCards(currentStack));
        }

        private void buttonImgRemove_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
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
            if (currentStack == null)
            {
                buttonCancel.PerformClick();
                return;
            }
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
                buttonCancel.PerformClick(); //close form when deleted 
            }
        }

        private void buttonExport_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentStack == null)
            {
                return;
            }
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string jsoncontents = (new StackWrapper(currentStack.Id)).Serialize();
            File.WriteAllText(saveFileDialog1.FileName, jsoncontents);
        }

        private void buttonImport_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog2.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string jsoncontents = File.ReadAllText(openFileDialog2.FileName);
            _ = StackWrapper.Deserialize(jsoncontents).FlushToDb();
            buttonCancel.PerformClick(); //close form when imported 
        }
    }
}
