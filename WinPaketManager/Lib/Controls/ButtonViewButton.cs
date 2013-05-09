using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPaketManager.Lib.Controls
{
    /// <summary>
    /// A class containing a button for the ButtonView UserControl
    /// </summary>
    public class ButtonViewButton
    {
        public ButtonViewButton(string caption)
        {
            BorderBrush = Brushes.Black;
            Font = new Font(FontFamily.GenericMonospace, 10.0f);
            TextBrush = Brushes.Black;
            this.Caption = caption;
            this.Style = ButtonViewButtonStyle.RectangleImageOnly;
        }

        /// <summary>
        /// Gets or sets the caption of the button
        /// </summary>
        public string Caption
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the location of the button
        /// </summary>
        public Point Location
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the button
        /// </summary>
        public Size Size
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the hitbox of he button
        /// </summary>
        public Rectangle HitBox
        {
            get
            {
                return new Rectangle(Location, Size);
            }
        }

        public int BorderWidth
        {
            get;
            set;
        }

        public Pen Pen
        {
            get
            {
                return new Pen(BorderBrush, BorderWidth);
            }
        }

        public Brush BorderBrush
        {
            get;
            set;
        }

        public Brush TextBrush
        {
            get;
            set;
        }

        public Font Font
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the button
        /// </summary>
        public void Draw(Graphics g)
        {
            
            switch (Style)
            {
                case (ButtonViewButtonStyle.RectangleTextOnly):
                    {
                        g.DrawRectangle(Pen, HitBox);
                        SizeF stringSize = g.MeasureString(Caption, Font);
                        float distanceToBorderHorizontal = (HitBox.Width - stringSize.Width) / 2;
                        float distanceToBorderVertical = (HitBox.Height - stringSize.Height) / 2;
                        if (distanceToBorderHorizontal < 0)
                            distanceToBorderHorizontal = 0;
                        if (distanceToBorderVertical < 0)
                            distanceToBorderVertical = 0;
                        g.DrawString(Caption, Font, TextBrush, new PointF(this.Location.X + distanceToBorderHorizontal, this.Location.Y + distanceToBorderVertical));
                    }
                    break;
                case (ButtonViewButtonStyle.EllipseTextOnly):
                    {
                        g.DrawEllipse(Pen, HitBox);
                        SizeF stringSize = g.MeasureString(Caption, Font);
                        float distanceToBorderHorizontal = (HitBox.Width - stringSize.Width) / 2;
                        float distanceToBorderVertical = (HitBox.Height - stringSize.Height) / 2;
                        if (distanceToBorderHorizontal < 0)
                            distanceToBorderHorizontal = 0;
                        if (distanceToBorderVertical < 0)
                            distanceToBorderVertical = 0;
                        g.DrawString(Caption, Font, TextBrush, new PointF(this.Location.X + distanceToBorderHorizontal, this.Location.Y + distanceToBorderVertical));
                    }
                    break;
                case (ButtonViewButtonStyle.EllipseImageOnly):
                    {
                         g.DrawEllipse(Pen, HitBox);
                         if (this.Image != null)
                         {
                             g.DrawImage(this.Image, new Rectangle((int)(HitBox.X + (0.2 * HitBox.Width)), (int)(HitBox.Y + (0.2 * HitBox.Height)), (int)(HitBox.Width - (0.4 * HitBox.Width)), (int)(HitBox.Height - (0.4 * HitBox.Height))));
                         }
                    }
                    break;
                case (ButtonViewButtonStyle.EllipseImageWithText):
                    {
                         g.DrawEllipse(Pen, HitBox);
                         float stringHeight = g.MeasureString(Caption, Font).Height;
                         if (this.Image != null)
                         {
                             g.DrawImage(this.Image, new Rectangle((int)(HitBox.X + (0.2 * HitBox.Width)), (int)(HitBox.Y + (0.2 * HitBox.Height)), (int)(HitBox.Width - (0.4 * HitBox.Width)), (int)(HitBox.Height - (0.4 * HitBox.Height))));
                         }
                    }
                    break;
                case (ButtonViewButtonStyle.RectangleImageOnly):
                    {
                        g.DrawRectangle(Pen, HitBox);
                        if (this.Image != null)
                        {
                            g.DrawImage(this.Image, new Rectangle((int)(HitBox.X + (0.2 * HitBox.Width)), (int)(HitBox.Y + (0.2 * HitBox.Height)), (int)(HitBox.Width - (0.4 * HitBox.Width)), (int)(HitBox.Height - (0.4 * HitBox.Height))));
                        }
                    }
                    break;
                case (ButtonViewButtonStyle.RectangleImageWithText):
                    {
                        g.DrawRectangle(Pen, HitBox);
                        if (this.Image != null)
                        {
                            g.DrawImage(this.Image, new Rectangle((int)(HitBox.X + (0.2 * HitBox.Width)), (int)(HitBox.Y + (0.2 * HitBox.Height)), (int)(HitBox.Width - (0.4 * HitBox.Width)), (int)(HitBox.Height - (0.4 * HitBox.Height))));
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Gets or sets the image of the button
        /// </summary>
        public Image Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the buttonstyle of the button
        /// </summary>
        public ButtonViewButtonStyle Style
        {
            get;
            set;
        }
    }
}
