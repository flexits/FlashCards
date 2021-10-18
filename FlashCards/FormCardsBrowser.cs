using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormCardsBrowser : CustomBrowserForm
    {
        public FormCardsBrowser(VocabStack stack) 
        {
            InitializeComponent();
            //get all cards from db relevant to stack_id and create a control for each
            foreach (VocabCard card in stack)
            {
                CardItem crd = new CardItem(card);
                crd.BackColor = CustomColors.TiffanyBlue;
                crd.BackColorDefault = CustomColors.TiffanyBlue;
                crd.BackColorSelected = CustomColors.OrangePeel;
                crd.SelectionChanged += new EventHandler(ChildItemSelectChanged);
                flowLayoutPanel1.Controls.Add(crd);
            }
            Button btnAddItem = new Button
            {
                FlatStyle = FlatStyle.Flat,
                BackColor = CustomColors.LightCyan,
                BackgroundImage = Properties.Resources.add_green,
                BackgroundImageLayout = ImageLayout.Zoom,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Size = new Size(64, 64),
                Margin = new Padding(30, 25, 3, 20),
            };
            if (stack.StackLength > 0)
            {
                btnAddItem.Margin = new Padding(420, 3, 3, 20);
            }
            btnAddItem.FlatAppearance.BorderColor = CustomColors.TiffanyBlue;
            btnAddItem.FlatAppearance.MouseDownBackColor = CustomColors.OrangePeel;
            btnAddItem.FlatAppearance.MouseOverBackColor = CustomColors.MellowApricot;
            flowLayoutPanel1.Controls.Add(btnAddItem);
        }
    }
}
