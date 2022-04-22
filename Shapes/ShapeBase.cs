using System.Drawing;

namespace MDBEditor.Extensions
{
    public abstract class ShapeBase
    {
        public abstract Point[] GetCoordinates(Rectangle rect);

        public virtual void Draw(Graphics graphics, Rectangle rect, Pen pen) => graphics.DrawPolygon(pen, GetCoordinates(rect));
        public virtual void Fill(Graphics graphics, Rectangle rect, Brush brush) => graphics.FillPolygon(brush, GetCoordinates(rect));
    }
}
