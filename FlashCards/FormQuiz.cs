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

            labelTitle.Text = stack.Name;
            //TODO add counters
            comboBoxLang.Items.Add(stack.ForeignLang);
            comboBoxLang.Items.Add(stack.NativeLang);
            comboBoxLang.SelectedItem = comboBoxLang.Items[Properties.Settings.Default.CardFaceLang];
            quiz = stack.Quiz();
            DisplayNextCard();
            //MDIFormControls.CenterElementInPanel(labelTitle, Width);
            //MDIFormControls.CenterElementInPanel(panelCard, Width);
        }

        private void labelWord_MouseClick(object sender, MouseEventArgs e)
        {
            //turn card over = change language of the word shown
            ReverseCardWord();
        }

        private void buttonKnown_MouseClick(object sender, MouseEventArgs e)
        {
            //pop next card
            DisplayNextCard();
        }

        private void buttonUnknown_MouseClick(object sender, MouseEventArgs e)
        {
            //push card back
            quiz.PushCardBack(currentcard);
            DisplayNextCard();
        }

        private void DisplayCardWord()
        {
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
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
            
        }

        private void ReverseCardWord()
        {
            //display card word in another language (turn card over)
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
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
            //TODO if image not null, pad label left
        }

        private void DisplayNextCard()
        {
            currentcard = quiz.PopRandomCard();
            if (currentcard == null)
            {
                //quiz ended
                pictureBox1.Image = Properties.Resources.approval_green;
                //TODO insert text in labelWord (stats? counters?)
                buttonKnown.Enabled = false;
                buttonUnknown.Enabled = false;
                comboBoxLang.Enabled = false;
                return;
            }
            pictureBox1.Image = currentcard.Picture;
            DisplayCardWord();
        }
    }
}
