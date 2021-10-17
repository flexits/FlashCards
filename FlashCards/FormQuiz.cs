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

            comboBoxLang.Items.Add(stack.ForeignLang);
            comboBoxLang.Items.Add(stack.NativeLang);
            comboBoxLang.SelectedItem = comboBoxLang.Items[Properties.Settings.Default.CardFaceLang];

            quiz = stack.Quiz();
            DisplayNextCard();

            MDIFormControls.CenterElementInPanel(labelTitle, Width);
            MDIFormControls.CenterElementInPanel(panelCard, Width);
        }

        private void DisplayCardWord(VocabCard vcard, bool reversecard)
        {
            int selectionindex = comboBoxLang.SelectedIndex;
            if (reversecard)
            {
                selectionindex = 1 - selectionindex;
            }
            CardFaceLanguages facelang = (CardFaceLanguages)selectionindex;
            if (facelang == CardFaceLanguages.Foreign)
            {
                labelWord.Text = vcard.WordForeign;
            }
            else
            {
                labelWord.Text = vcard.WordNative;
            }
            MDIFormControls.CenterElementInPanel(labelWord, panelCard.Width);
            //if image not null, make padding
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
                return;
            }
            pictureBox1.Image = currentcrd.Picture;
            DisplayCardWord(currentcrd, false);
        }

        private void labelWord_MouseClick(object sender, MouseEventArgs e)
        {
            //turn card over
            DisplayCardWord(currentcrd, true);
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
