using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class CardItem : ItemControl
    /*
     * Custom UI item to represent a card in a stack
     */
    {
        public CardItem(VocabCard card)
        {
            InitializeComponent();
        }
    }
}
