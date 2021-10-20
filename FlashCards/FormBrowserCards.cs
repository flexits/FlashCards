using System;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormBrowserCards : FormBrowserParent
    {
        private readonly VocabStack currentstack;

        public FormBrowserCards(VocabStack stack) 
        {
            InitializeComponent();
            currentstack = stack;
            //get all cards from db relevant to stack_id and create a control for each
            foreach (VocabCard card in currentstack)
            {
                ControlCardItem crd = new ControlCardItem(card);
                crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                crd.ItemDeleted += new EventHandler(ChildItemDeleted);
                flowLayoutPanel1.Controls.Add(crd);
            }
            //align button for adding item 
            Padding pad;
            if (stack.StackLength > 0)
            {
                pad = new Padding(420, 3, 3, 20);
            }
            else
            {
                pad = new Padding(30, 25, 3, 20);
            }
            //generate and add button
            Button btnAddItem = CustomBtnAdd.Generate(pad);
            btnAddItem.MouseClick += new MouseEventHandler(btnAddItemMouseClick);
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }

        private void ChildItemDeleted(object sender, EventArgs e)
        {
            //remove the card that doesn't already exist from panel
            foreach(Control cl in flowLayoutPanel1.Controls)
            {
                if (cl is ControlCardItem)
                {
                    if ((cl as ControlCardItem).CardId == (sender as ControlCardItem).CardId)
                    {
                        flowLayoutPanel1.Controls.Remove(cl);
                        break;
                    }
                }
            }
        }

        private void btnAddItemMouseClick(object sender, MouseEventArgs e)
        {
            //generate new control with an empty card belonging to the current stack
            ControlCardItem crd = new ControlCardItem(new VocabCard(currentstack.Id));
            crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
            //add new control to the panel and move the btnAddItem to the bottom
            //(btnAddItem is always the last item)
            int lastcontrolindex = flowLayoutPanel1.Controls.Count - 1;
            if (lastcontrolindex >= 0)
            {
                Control btnAdd = flowLayoutPanel1.Controls[lastcontrolindex];
                flowLayoutPanel1.Controls.RemoveAt(lastcontrolindex);
                flowLayoutPanel1.Controls.Add(crd);
                flowLayoutPanel1.Controls.Add(btnAdd);
            }
            //move focus to the newly added item 
            crd.IsSelected = true;
        }
    }
}
