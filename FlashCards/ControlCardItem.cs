using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class ControlCardItem : ControlCustomItemParent
    /*
     * Custom UI item to represent a card in a stack
     */
    {
        private VocabCard currentCard;

        public ControlCardItem(VocabCard card)
        {
            InitializeComponent();
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(panel1.Controls);
                openFileDialog1.Title = CustomLocales.GetTranslation(openFileDialog1.Title);
            }
            currentCard = card;
            if (card.Id < 0)
            //id>=0 by definition, but we use a negative id to indicate that we're adding a new card
            {
                currentCard.WordForeign = string.Empty;
                currentCard.WordNative = string.Empty;
                currentCard.Comment = string.Empty;
                currentCard.Picture = null;
            }
             textBoxWord.Text = currentCard.WordForeign;
             textBoxTranslation.Text = currentCard.WordNative;
             textBoxComment.Text = currentCard.Comment;
             pictureBox1.Image = currentCard.Picture;
            
            //form style
            BackColor = CustomColors.TiffanyBlue;
            BackColorDefault = CustomColors.TiffanyBlue;
            BackColorSelected = CustomColors.OrangePeel;
        }

        public int CardId 
        //id of the card represented by the control
        {
            get
            {
                if (currentCard == null)
                {
                    return -1;
                }
                return currentCard.Id;
            }
        }

        private void OnItemSelection(object sender, MouseEventArgs e)
        {
            IsSelected = true;
        }

        protected override void ItemSelected()
        //if the item got selection but no one of its controls have focus, make panel1 focused.
        //without this workaround
        //a textbox in another item sometimes remains active despite of selection loss
        {
            foreach (Control cl in panel1.Controls)
            {
                if (cl.CanFocus && cl.ContainsFocus)
                {
                    return;
                }
            }
            panel1.Focus();
        }

        protected override void ItemDeselected()
        //if there were changes, update db on item deselection
        {
            foreach (Control tb in panel1.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    tb.Text = tb.Text.Trim();
                }
            }

            if (DetectAndAcceptChanges())
            {
                if (currentCard.Id == -1)
                {
                    DbOperations.AddCard(currentCard);
                }
                else
                {
                    DbOperations.UpdateCard(currentCard);
                }
            }
        }

        private bool DetectAndAcceptChanges()
        //if any textbox was modified by user (as well as picturebox)
        //write info to currentCard properties and return true
        {
            if (textBoxWord.Text != currentCard.WordForeign ||
                textBoxTranslation.Text != currentCard.WordNative ||
                textBoxComment.Text != currentCard.Comment ||
                pictureBox1.Image != currentCard.Picture)
            {
                currentCard.WordForeign = textBoxWord.Text;
                currentCard.WordNative = textBoxTranslation.Text;
                currentCard.Comment = textBoxComment.Text;
                currentCard.Picture = pictureBox1.Image;
                return true;
            }
            return false;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }

        public event EventHandler ItemDeleted;

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentCard.Id == -1)
            {
                //item doesn't yet exit in database, delete only from UI
                ItemDeleted?.Invoke(this, EventArgs.Empty);
                return;
            }
            string text = "You're going to delete card with all its contents. This action can't be undone. Continue anyway?";
            string caption = "Delete file";
            if (CustomLocales.TranslationNeeded)
            {
                text = CustomLocales.GetTranslation(text);
                caption = CustomLocales.GetTranslation(caption);
            }
            if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                text = CustomLocales.GetTranslation("Records removed:") + " ";
                text += DbOperations.RemoveCard(currentCard.Id).ToString();
                //_ = MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ItemDeleted?.Invoke(this, EventArgs.Empty);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = ImageConversion.ImgFromFile(openFileDialog1.FileName);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonImgRemove_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return; //nothing to remove
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
    }
}
