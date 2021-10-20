using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class ControlCustomItemParent : UserControl
    /*
    * Parent class holding a generic logic of custom UI items:
    * - visual selection/deselection via background color change;
    * - invoking event upon selection change;
    * - executing methods upon selection set and loss.
    * 
    * Each item has two states, default (deselected) and selected.
    * Selection state is changed by setting IsSelected property.
    * Upon selection state change event SelectionChanged is invoked. 
    * Two methods ItemSelected() and ItemDeselected() are called upon
    * selection set and loss correspondingly.
    * Once item was selected, its BackColor is changed to BackColorSelected,
    * and reverted back upon deselection.
    * 
    */
    {
        public ControlCustomItemParent()
        {
            InitializeComponent();
            BackColorDefault = BackColor;
        }

        // true if this control is selected
        private bool SelectedState = false;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Bindable(false)]
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

        [Description("BackColor in selected state"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Color BackColorSelected { get; set; }

        [Description("BackColor in deselected state"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Color BackColorDefault { get; set; }

        private void ToggleSelection()
        //select if not selected, deselect otherwise
        {
            if (IsSelected)
            {
                SelectedState = false;
                BackColor = BackColorDefault;
                ItemDeselected();
            }
            else
            {
                SelectedState = true;
                BackColor = BackColorSelected;
                ItemSelected();
            }
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        // upon each state change the event is invoked
        public event EventHandler SelectionChanged;

        virtual protected void ItemSelected() { }
        // do some work upon selection

        virtual protected void ItemDeselected() { }
        // do some work upon selection loss
    }
}
