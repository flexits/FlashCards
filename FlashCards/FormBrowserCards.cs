using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormBrowserCards : FormBrowserParent
    {
        private VocabStack currentstack;

        public FormBrowserCards(VocabStack stack) 
        {
            InitializeComponent();
            //get all cards from db relevant to stack_id and create a control for each
            foreach (VocabCard card in stack)
            {
                ControlCardItem crd = new ControlCardItem(card);
                crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                crd.ItemDeleted += new EventHandler(ChildItemDeleted);
                flowLayoutPanel1.Controls.Add(crd);
            }
            Padding pad;
            if (stack.StackLength > 0)
            {
                pad = new Padding(420, 3, 3, 20);
            }
            else
            {
                pad = new Padding(30, 25, 3, 20);
            }
            Button btnAddItem = CustomBtnAdd.Generate(pad);
            btnAddItem.MouseClick += new MouseEventHandler(btnAddItemMouseClick);
            flowLayoutPanel1.Controls.Add(btnAddItem);
            currentstack = stack;
        }

        private void ChildItemDeleted(object sender, EventArgs e)
        {
            //ugly. redo!
            //not reload all panel but delete needed item!!!
            flowLayoutPanel1.Controls.Clear();
            foreach (VocabCard card in currentstack)
            {
                if (card == null)
                {
                    continue;
                }
                ControlCardItem crd = new ControlCardItem(card);
                crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                crd.ItemDeleted += new EventHandler(ChildItemDeleted);
                flowLayoutPanel1.Controls.Add(crd);
            }
            //add button add
        }


        private void btnAddItemMouseClick(object sender, MouseEventArgs e)
        {
            ControlCardItem crd = new ControlCardItem(new VocabCard(currentstack.Id));
            crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
            //flowLayoutPanel1.Controls.Add(crd);
            

            int lastcontrolindex = flowLayoutPanel1.Controls.Count - 1;
            if (lastcontrolindex > 0)
            {
                Control btnAdd = flowLayoutPanel1.Controls[lastcontrolindex];
                flowLayoutPanel1.Controls.RemoveAt(lastcontrolindex);
                flowLayoutPanel1.Controls.Add(crd);
                flowLayoutPanel1.Controls.Add(btnAdd);
            }
            else
            {
                flowLayoutPanel1.Controls.Add(crd);
            }
            //Control btnAdd = flowLayoutPanel1.Controls.Find("btnAdd", false)[0];

            crd.IsSelected = true;
        }
    }
}
