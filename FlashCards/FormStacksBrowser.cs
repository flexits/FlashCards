using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormStacksBrowser : CustomBrowserForm
    {
        public FormStacksBrowser()
        {
            InitializeComponent();
            //get all stacks from db and create a control for each
            List<VocabStack> stacks = DbOperations.GetAllStacks();
            foreach (VocabStack vst in stacks)
            {
                StackItem sti = new StackItem(vst);
                sti.BackColorSelected = CustomColors.OrangePeel;
                sti.BackColorDefault = CustomColors.TiffanyBlue;
                sti.BackColor = CustomColors.TiffanyBlue;
                sti.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                flowLayoutPanel1.Controls.Add(sti);
            }
            Button btnAddItem = new Button
            {
                FlatStyle = FlatStyle.Flat,
                BackColor = CustomColors.LightCyan,
                BackgroundImage = Properties.Resources.add_green,
                BackgroundImageLayout = ImageLayout.Zoom,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Size = new Size(64, 64),
                Margin = new Padding(45, 5, 5, 45),
            };
            btnAddItem.FlatAppearance.BorderColor = CustomColors.TiffanyBlue;
            btnAddItem.FlatAppearance.MouseDownBackColor = CustomColors.OrangePeel;
            btnAddItem.FlatAppearance.MouseOverBackColor = CustomColors.MellowApricot;
            btnAddItem.MouseClick += new MouseEventHandler(btnAddItemMouseClick);
            flowLayoutPanel1.Controls.Add(btnAddItem);
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
