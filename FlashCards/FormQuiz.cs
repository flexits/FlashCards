using System.Drawing;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormQuiz : Form
    {
        /*
         * See description of VocabQuiz class on how quiz works
         */

        private VocabQuiz quiz;
        private VocabCard currentcard;
        private CardFaceLanguages currentcardfacelang;
        private int counter;

        public FormQuiz(VocabStack stack)
        {
            if (stack == null)
            {
                Close();
            }
            InitializeComponent();
            if (CustomLocales.TranslationNeeded)
            {
                CustomLocales.TranslateControlsTextProp(Controls);
            }

            counter = stack.StackLength;
            labelTitle.Text = stack.Name;
            labelCounter.Text = counter.ToString();
            comboBoxLang.Items.Add(stack.ForeignLang);
            comboBoxLang.Items.Add(stack.NativeLang);
            comboBoxLang.SelectedItem = comboBoxLang.Items[Properties.Settings.Default.CardFaceLang];
            quiz = new VocabQuiz(stack.Id);
            DisplayNextCard();
            //MDIFormControls.CenterElementInPanel(labelTitle, Width);
            //MDIFormControls.CenterElementInPanel(panelCard, Width);
        }

        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            //turn card over = change language of the word shown
            ReverseCardWord();
        }

        private void buttonKnown_MouseClick(object sender, MouseEventArgs e)
        {
            //pop next card
            DisplayNextCard();
            if (counter > 0)
            {
                labelCounter.Text = (--counter).ToString();
            }
        }

        private void buttonUnknown_MouseClick(object sender, MouseEventArgs e)
        {
            //push card back
            quiz.PushCardBack(currentcard);
            DisplayNextCard();
        }

        private void DisplayNextCard()
        {
            currentcard = quiz.PopRandomCard();
            if (currentcard == null)
            {
                //quiz ended
                pictureBox1.Image = Properties.Resources.approval_green;
                labelWord.Text = CustomLocales.GetTranslation("Finished!");
                //TODO insert text in labelWord (stats? counters?)
                buttonKnown.Enabled = false;
                buttonUnknown.Enabled = false;
                comboBoxLang.Enabled = false;
                return;
            }
            pictureBox1.Image = ImageConversion.ByteToImg(currentcard.Picture);

            //display card word in the selected language
            currentcardfacelang = (CardFaceLanguages)comboBoxLang.SelectedIndex;
            if (currentcardfacelang == CardFaceLanguages.Foreign)
            {
                labelWord.Text = currentcard.WordForeign;
            }
            else
            {
                labelWord.Text = currentcard.WordNative;
            }

            DisplayComment();

            //center label
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
        }

        private void DisplayComment()
        {
            //if card is up the corresponding side, display its comment
            if (!string.IsNullOrWhiteSpace(currentcard.Comment) && ((int)currentcardfacelang == Properties.Settings.Default.CommentSide))
            {
                labelComment.Visible = true;
                labelWord.Location = new Point(labelWord.Location.X, 18);
                labelComment.Text = currentcard.Comment;
                MDIFormControls.CenterElementInPanel(labelComment, panelCard.Width);
            }
            else
            {
                labelComment.Visible = false;
                labelWord.Location = new Point(labelWord.Location.X, 36);
            }
        }

        private void comboBoxLang_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ReverseCardWord();
        }

        private void ReverseCardWord()
        {
            //display card word in another language (turn card over)
            if (currentcard == null)
            {
                return;
            }
            if (currentcardfacelang == CardFaceLanguages.Foreign)
            {
                labelWord.Text = currentcard.WordNative;
                currentcardfacelang = CardFaceLanguages.Native;
            }
            else
            {
                labelWord.Text = currentcard.WordForeign;
                currentcardfacelang = CardFaceLanguages.Foreign;
            }

            DisplayComment();

            //center label
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
        }
    }
}
