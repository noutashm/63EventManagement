using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace EventManagement {

    // New Component made specifically for this assignment ~ inherits a button but has special stats
    class RoundButton : Button {

        // default custom properties
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        // export custom properties shown for easier access to them when categorised together
        [Category("Custom Round Button")]
        public int BorderSize {
            get => borderSize; set {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Custom Round Button")]
        public int BorderRadius {
            get => borderRadius; set {
                if (value <= Height)
                    borderRadius = value;
                else borderRadius = Height;
                Invalidate();
            }
        }

        [Category("Custom Round Button")]
        public Color BorderColor {
            get => borderColor; set {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom Round Button")]
        public Color TextColor { get => ForeColor; set => ForeColor = value; }

        // constructor with default properties
        public RoundButton() {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.DeepSkyBlue;
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei", 11);
            Resize += new EventHandler(Button_Resize);
        }

        // return graphicsPath for radius calculation
        private GraphicsPath GetFigurePath(Rectangle rect, float radius) {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // start the new figure/drawing
            path.StartFigure();
            // curve the four corners
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            base.OnPaint(pevent);

            // get required measurements for drawin
            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            // drawing rounded button
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize)) {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // button surface
                    Region = new Region(pathSurface);

                    // draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // button border                    
                    if (borderSize >= 1)
                        // draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            } else // normal button
              {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                // button surface
                Region = new Region(rectSurface);

                // button border
                if (borderSize >= 1) {
                    using (Pen penBorder = new Pen(borderColor, borderSize)) {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e) {
            Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e) {
            if (borderRadius > Height)
                borderRadius = Height;
        }
    }
}
