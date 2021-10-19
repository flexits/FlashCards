using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormBrowserStacks : FormBrowserParent
    {
        public FormBrowserStacks()
        {
            InitializeComponent();
            //get all stacks from db and create a control for each
            List<VocabStack> stacks = DbOperations.GetAllStacks();
            foreach (VocabStack vst in stacks)
            {
                ControlStackItem sti = new ControlStackItem(vst);
                sti.BackColorSelected = CustomColors.OrangePeel;
                sti.BackColorDefault = CustomColors.TiffanyBlue;
                sti.BackColor = CustomColors.TiffanyBlue;
                sti.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                flowLayoutPanel1.Controls.Add(sti);
            }
            //create and add the button to add new stack
            Button btnAddItem = CustomBtnAdd.Generate(new Padding(45, 5, 5, 45));
            btnAddItem.MouseClick += new MouseEventHandler(btnAddItemMouseClick);
            flowLayoutPanel1.Controls.Add(btnAddItem);
            //empty panel - workaround for a better look
            Panel footer = new Panel
            {
                Height = 10,
                Width = 300,
            };
            flowLayoutPanel1.Controls.Add(footer);
        }

        private void btnAddItemMouseClick(object sender, MouseEventArgs e)
        {
            MDIFormControls.OpenFormInPanel(new FormStacksEditor(null));
        }
    }
}
