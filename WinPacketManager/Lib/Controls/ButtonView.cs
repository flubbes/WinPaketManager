using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPacketManager.Lib.Controls
{
    /// <summary>
    /// A view to show some buttons in the form
    /// </summary>
    public partial class ButtonView : UserControl
    {
        public delegate void ButtonViewClickEventHandler(ButtonViewClickEventArgs e);
        public event ButtonViewClickEventHandler ButtonClick;

        public ButtonView()
        {
            Items = new List<ButtonViewButton>();
            InitializeComponent();
            this.DoubleBuffered = true;
            ShowBorder = false;
            MinimumButtonHeight = 100;
            MinimumButtonWidth = 100;
            this.Refresh();
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
        }

        /// <summary>
        /// All button from this ButtonView
        /// </summary>
        public List<ButtonViewButton> Items
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the if the border should show up
        /// </summary>
        public bool ShowBorder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the width of the border
        /// </summary>
        public int BorderWith
        {
            get;
            set;
        }

        private void OnButtonClick(ButtonViewClickEventArgs e)
        {
            if (ButtonClick != null)
            {
                ButtonClick(e);
            }
        }

        public int MinimumButtonHeight
        {
            get;
            set;
        }

        public int MinimumButtonWidth
        {
            get;
            set;
        }

        private void ArrangeButtons(Graphics g)
        {
            int availableHeight = this.Size.Height;
            int availableWidth = this.Size.Width;
            int curWidth = MinimumButtonWidth;
            float minWidth = MinimumButtonWidth;


            foreach (ButtonViewButton bvb in Items)
            {
                float width = g.MeasureString(bvb.Caption, bvb.Font).Width;
                if (width > minWidth)
                {
                    minWidth = width;
                }
            }

            

            double itemCountHorizonzalDouble = availableWidth / minWidth;
            int itemCountHorizonzal = Convert.ToInt32(itemCountHorizonzalDouble);
            if (itemCountHorizonzal < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            //int expectedWidth = (int)minWidth * itemCountHorizonzal;
            //int restWidth = availableWidth - expectedWidth;
            //int betweener = restWidth / itemCountHorizonzal;

            int curX = 0;
            int curY = 0;
            int itemCounter = 0;
            for (int i = 0; itemCounter < Items.Count; i++)
            {
                for (int p = 0; p < itemCountHorizonzal && itemCounter < Items.Count; p++)
                {
                    if (curX + minWidth < availableWidth)
                    {
                        Items[itemCounter].Location = new Point(curX, curY);
                        Items[itemCounter].Size = new System.Drawing.Size(Convert.ToInt32(minWidth), Convert.ToInt32(minWidth));
                        curX += Convert.ToInt32(minWidth);
                        itemCounter++;
                    }
                }
                curX = 0;
                curY += Convert.ToInt32(minWidth);
            }
        }

        private void ButtonView_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ButtonViewButton bvb in Items)
            {
                if (bvb.HitBox.Contains(e.Location))
                {
                    OnButtonClick(new ButtonViewClickEventArgs(bvb));
                }
            }
        }

        private void ButtonView_Paint(object sender, PaintEventArgs e)
        {
            ArrangeButtons(e.Graphics);
            foreach (ButtonViewButton bvb in Items)
            {
                bvb.Draw(e.Graphics);
            }
        }

        private void ButtonView_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
