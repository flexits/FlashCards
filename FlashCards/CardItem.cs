using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class CardItem : ItemControl
    /*
     * Custom UI item to represent a card in a stack
     */
    {
        public CardItem(VocabCard card)
        {
            InitializeComponent();
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
                openFileDialog1.Title = CustomLocales.GetTranslation(openFileDialog1.Title);
            }
            currentCard = card;
            textBoxWord.Text = currentCard.WordForeign;
            textBoxTranslation.Text = currentCard.WordNative;
            textBoxComment.Text = currentCard.Comment;
            pictureBox1.Image = currentCard.Picture;
        }

        private VocabCard currentCard;

        private void OnItemSelection(object sender, MouseEventArgs e)
        {
            IsSelected = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image image;
            try
            {
                //byte[] imgarr = File.ReadAllBytes(openFileDialog1.FileName);
                //image = ImageConversion.ByteToImg(imgarr);
                image = Image.FromFile(openFileDialog1.FileName);
                //TODO FOrmats?!
                //TODO resize!!
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

        protected override void SetFocusOnSelect()
        {
            bool focus = false;
            foreach (Control cl in panel1.Controls)
            {
                if (cl.CanFocus && cl.ContainsFocus)
                {
                    focus = true;
                }
            }
            if (!focus)
            {
                panel1.Focus();
            }
        }

        protected override void SaveChangesOnDeselect()
        {
            foreach (Control tb in panel1.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    tb.Text = tb.Text.Trim();
                }
            }
            //if there were changes, update db
            if (textBoxWord.Text != currentCard.WordForeign ||
                textBoxTranslation.Text != currentCard.WordNative ||
                textBoxComment.Text != currentCard.Comment ||
                pictureBox1.Image != pictureBox1.Image)
            {
                currentCard.WordForeign = textBoxWord.Text;
                currentCard.WordNative = textBoxTranslation.Text;
                currentCard.Comment = textBoxComment.Text;
                currentCard.Picture = pictureBox1.Image;
                DbOperations.UpdateCard(currentCard);
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }
    }
}
