using System;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class ControlStackItem : ControlCustomItemParent
    /*
     * Custom UI item to represent a stack
     */
    {
        public ControlStackItem(VocabStack stack)
        {
            InitializeComponent();

            if (CustomLocales.TranslationNeeded)
            {
                labelCounter.Text = CustomLocales.GetTranslation(labelCounter.Text);
            }

            currentStack = stack;
            labelTitle.Text = currentStack.Name;
            labelComment.Text = currentStack.Comment;
            labelCounter.Text += " " + currentStack.StackLength.ToString();
            pictureBox1.Image = currentStack.Picture;
            labelLang.Text = CustomLocales.GetShortString(currentStack.ForeignLang, 6) + " / " + CustomLocales.GetShortString(currentStack.NativeLang, 6);
        }

        private VocabStack currentStack;

        private void OnItemSelection(object sender, MouseEventArgs e)
        {
            IsSelected = true;
            SelectStackInMainForm(currentStack);
        }

        protected override void ItemDeselected()
        {
            IsSelected = false;
            SelectStackInMainForm(null);
        }

        private void SelectStackInMainForm(VocabStack stack)
        {
            //set stack selection in the main form
            Form fm = Application.OpenForms["FormMain"];
            if (fm != null)
            {
                (fm as FormMain).SelectedStack = stack;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //open stack view/edit form
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(currentStack));
        }

        private void StackItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //open cards view/edit form
            MDIFormControls.OpenFormInPanel(new FormBrowserCards(currentStack));
        }
    }
}
