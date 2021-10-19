using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormQuiz : Form
    {
        private VocabQuiz quiz;
        private VocabCard currentcrd;
        private CardFaceLanguages currentfacelang;

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

        private void DisplayCardWord()
        {
            currentfacelang = (CardFaceLanguages)comboBoxLang.SelectedIndex;
            if (currentfacelang == CardFaceLanguages.Foreign)
            {
                labelWord.Text = currentcrd.WordForeign;
            }
            else
            {
                labelWord.Text = currentcrd.WordNative;
            }
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
            //if image not null, make padding
        }

        private void ReverseCardWord()
        {
            if (currentfacelang == CardFaceLanguages.Foreign)
            {
                labelWord.Text = currentcrd.WordNative;
                currentfacelang = CardFaceLanguages.Native;
            }
            else
            {
                labelWord.Text = currentcrd.WordForeign;
                currentfacelang = CardFaceLanguages.Foreign;
            }
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
        }

        private void DisplayNextCard()
        {
            currentcrd = quiz.PopRandomCard();
            if (currentcrd == null)
            {
                //quiz ended
                pictureBox1.Image = Properties.Resources.approval_green;
                //insert text in labelWord (stats?)
                buttonKnown.Enabled = false;
                buttonUnknown.Enabled = false;
                comboBoxLang.Enabled = false;
                return;
            }
            pictureBox1.Image = currentcrd.Picture;
            DisplayCardWord();
        }

        private void labelWord_MouseClick(object sender, MouseEventArgs e)
        {
            //turn card over
            ReverseCardWord();
        }

        private void buttonKnown_MouseClick(object sender, MouseEventArgs e)
        {
            //go to next card
            DisplayNextCard();
        }

        private void buttonUnknown_MouseClick(object sender, MouseEventArgs e)
        {
            //push card back
            quiz.PushCardBack(currentcrd);
            DisplayNextCard();
        }
    }
}
