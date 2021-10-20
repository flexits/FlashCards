using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            MDIFormControls.OpenFormInPanel(new FormBrowserCards(currentStack));
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
                buttonCancel.PerformClick(); //close form when deleted 
            }
        }

        private void buttonExport_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentStack == null)
            {
                return;
            }
            StackWrapper stwrp = new StackWrapper(currentStack.Id);
            string jsoncontents = JsonSerializer.Serialize<StackWrapper>(stwrp);
            string filename = "test.json";
            File.WriteAllText(filename, jsoncontents);
        }

        private void buttonImport_MouseClick(object sender, MouseEventArgs e)
        {
            string filename = "test.json";
            string jsoncontents = File.ReadAllText(filename);
            StackWrapper stwrp = JsonSerializer.Deserialize<StackWrapper>(jsoncontents);
            int id = stwrp.Stack.Id;
        }
    }
}
