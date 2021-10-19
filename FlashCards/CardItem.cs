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
                CustomLocales.TranslateControlsTextProp(panel1.Controls);
                openFileDialog1.Title = CustomLocales.GetTranslation(openFileDialog1.Title);
            }
            if (card == null)
            {
                //add new card
                currentCard = null;
            }
            else
            {
                currentCard = card;
                textBoxWord.Text = currentCard.WordForeign;
                textBoxTranslation.Text = currentCard.WordNative;
                textBoxComment.Text = currentCard.Comment;
                pictureBox1.Image = currentCard.Picture;
            }
            BackColor = CustomColors.TiffanyBlue;
            BackColorDefault = CustomColors.TiffanyBlue;
            BackColorSelected = CustomColors.OrangePeel;
        }

        private VocabCard currentCard;

        private void OnItemSelection(object sender, MouseEventArgs e)
        {
            IsSelected = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = ImageConversion.ImgFromFile(openFileDialog1.FileName);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
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
        //TODO add item
        {
            foreach (Control tb in panel1.Controls)
            {
                if (tb.GetType() == typeof(TextBox))
                {
                    tb.Text = tb.Text.Trim();
                }
            }

            if (currentCard == null)
            {
                //add
                //DbOperations.AddCard
            }
            else
            {
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
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.Trim();
        }
    }
}
