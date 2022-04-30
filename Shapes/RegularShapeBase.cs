using MDBEditor.Shapes.Concrete;
using MDBEditor.Shapes.Interfaces;
using System.Drawing;

namespace MDBEditor.Shapes
{
    public abstract class RegularShapeBase: IShape
    {
        public abstract Point[] GetCoordinates(System.Drawing.Rectangle rect);
        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            graphics.DrawPolygon(pen, GetCoordinates(rect));
        }
        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillPolygon(brush, GetCoordinates(rect));
        }
    }
}
