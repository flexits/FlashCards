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
        }
    }
}
