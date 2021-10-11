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
    * - executing method upon selection loss
    */
    {
        public ItemControl()
        {
            InitializeComponent();
        }

        // true if this control is selected by user
        private bool SelectedState = false;
        public bool IsSelected
        {
            get { return SelectedState; }
            set
            {
                if (value != SelectedState)
                {
                    ToggleSelection();
                }
            }
        }

        private void ToggleSelection()
        //selecf if not selected, deselect otherwise
        {
            if (IsSelected)
            {
                SaveChangesOnDeselect();
                SelectedState = false;
                BackColor = CustomColors.TiffanyBlue;
            }
            else
            {
                SelectedState = true;
                BackColor = CustomColors.OrangePeel;
            }
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        // controls are selected by a first click; next clicks are ignored
        // upon each click the event is invoked to deselect other controls
        public event EventHandler SelectionChanged;

        virtual protected void SaveChangesOnDeselect() { }
        // do some work upon selection loss
    }
}
