using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class ItemControl : UserControl
    /*
    * Generic logic of custom UI items, representing stacks and cards:
    * - visual selection/deselection
    * - invoking event upon selection change
    */
    {
        public ItemControl()
        {
            InitializeComponent();
        }

        // true if this control is selected by user
        public bool IsSelected { get; set; }

        public void DeselectItem()
        {
            IsSelected = false;
            BackColor = CustomColors.TiffanyBlue;
        }

        protected void SelectItem()
        {
            IsSelected = true;
            BackColor = CustomColors.OrangePeel;
        }

        protected void ToggleSelection()
        {
            if (IsSelected)
            {
                DeselectItem();
            }
            else
            {
                SelectItem();
            }
        }

        // controls are selected by a first click and deselected by the second one
        // upon each click the event is invoked to deselect other controls
        public event EventHandler SelectionChanged;

        protected void OnClick(object sender, MouseEventArgs e)
        {
            ToggleSelection();
            SelectionChanged?.Invoke(this, e);
        }
    }
}
