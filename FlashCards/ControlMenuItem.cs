using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class ControlMenuItem : ControlCustomItemParent
    /*
     * Custom UI item to represent a menu item
     * - in addition to inherited logic, contains switchable image 
     * that changes with BackColor upon selection state change;
     * - additional BackColor and image change upon 
     * mouse enter and leave in deselected state (hover);
     * - invokes event ItemClickPerformed on mouse click.
     */
    {
        public ControlMenuItem()
        {
            InitializeComponent();
        }

        // invoked on mouse click
        public event EventHandler ItemClickPerformed;

        private Image imgDefault;
        [Description("Item's image in deselected state"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Image ImageDefault
        {
            get { return imgDefault; }
            set
            {
                imgDefault = value;
                pictureBox1.Image = imgDefault;
            }
        }

        private Image imgSelected;
        [Description("Item's image in selected state"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Image ImageSelected
        {
            get { return imgSelected; }
            set { imgSelected = value; }
        }

        // item's caption
        private string itemText;

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return itemText; }
            set
            {
                itemText = value;
                label1.Text = itemText;
            }
        }

        [Description("BackColor when mouse is within item"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Color BackColorHover { get; set; }

        private Image imgHover;
        [Description("Item's image when mouse is within item"), Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Image ImageHover
        {
            get { return imgHover; }
            set { imgHover = value; }
        }

        private void OnItemMouseClick(object sender, MouseEventArgs e)
        {
            IsSelected = true;
            ItemClickPerformed?.Invoke(this, EventArgs.Empty);
        }

        protected override void ItemSelected()
        {
            // change image when item gets selected
            pictureBox1.Image = imgSelected;
        }

        protected override void ItemDeselected()
        {
            // change image when item loses selection
            pictureBox1.Image = imgDefault;
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (!IsSelected)
            {
                BackColor = BackColorHover;
                pictureBox1.Image = imgHover;
            }
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (IsSelected)
            {
                BackColor = BackColorSelected;
                pictureBox1.Image = imgSelected;
            }
            else
            {
                BackColor = BackColorDefault;
                pictureBox1.Image = imgDefault;
            }
        }

        public void PerformClick()
        {
            OnItemMouseClick(this, null);
        }
    }
}
