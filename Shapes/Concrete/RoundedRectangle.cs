using System.Drawing;
using System.Drawing.Drawing2D;

namespace MDBEditor.Shapes.Concrete
{
    public class RoundedRectangle:IShape
    {
        public static GraphicsPath RoundedRect(System.Drawing.Rectangle bounds, int radius = 45)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            System.Drawing.Rectangle arc = new System.Drawing.Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            graphics.DrawPath(pen, RoundedRect(rect));
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillPath(brush, RoundedRect(rect));
        }
    }
}
