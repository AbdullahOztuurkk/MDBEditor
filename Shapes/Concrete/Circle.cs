using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Circle)]
public class Circle : IShape
{
    public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
    {
        graphics.DrawEllipse(pen, rect);
    }

    public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
    {
        graphics.FillEllipse(brush, rect);
    }
}
