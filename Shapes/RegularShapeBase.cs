using MDBEditor.Shapes.Concrete;
using System.Drawing;

namespace MDBEditor.Shapes
{
    public abstract class RegularShapeBase: Shape
    {
        public abstract Point[] GetCoordinates(Rectangle rect);
        public override void Draw(Graphics graphics, Rectangle rect, Pen pen)
        {
            graphics.DrawPolygon(pen, GetCoordinates(rect));
        }
        public override void Fill(Graphics graphics, Rectangle rect, Brush brush) 
        {
            graphics.FillPolygon(brush, GetCoordinates(rect));
        }
    }
}
