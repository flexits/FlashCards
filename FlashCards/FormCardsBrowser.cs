using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class FormCardsBrowser : Form
    {
        public FormCardsBrowser()
        {
            InitializeComponent();
            //get all cards from db relevant to stack_id and create a control for each
        }
    }
}
