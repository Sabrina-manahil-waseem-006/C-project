using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CustomRoundButton
{
    public class RoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 10;
        private Color borderColor = Color.Transparent;
        public Color TextColor = Color.White;
        public Color DisabledTextColor { get; set; } = Color.Gray;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.FromArgb(50, 48, 48);
            ForeColor = TextColor;
            FlatAppearance.BorderSize = 0;
            Margin = new Padding(0);
            Size = new Size(77, 50);
            TabStop = true;
            TextAlign = ContentAlignment.MiddleCenter;
            if (borderRadius > this.Height)
                borderRadius = this.Height;

            // Handle mouse events
            this.MouseDown += (s, e) => { this.BackColor = Color.FromArgb(70, 68, 68); };
            this.MouseUp += (s, e) => { this.BackColor = Color.FromArgb(50, 48, 48); };
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2f;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0) smoothSize = borderSize;

            if (borderRadius > 2) // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Draw background
                    using (SolidBrush brush = new SolidBrush(this.BackColor))
                    {
                        pevent.Graphics.FillPath(brush, pathSurface);
                    }

                    // Button surface
                    this.Region = new Region(pathSurface);

                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Button border                    
                    if (borderSize >= 1)
                        // Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            // Text Rendering
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            if (!Enabled)
            {
                using (SolidBrush brush = new SolidBrush(DisabledTextColor))
                {
                    pevent.Graphics.DrawString(Text, Font, brush, ClientRectangle, format);
                }
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(TextColor))
                {
                    pevent.Graphics.DrawString(Text, Font, brush, ClientRectangle, format);
                }
            }
        }
    }
}
