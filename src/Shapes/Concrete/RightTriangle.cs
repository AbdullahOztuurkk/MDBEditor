using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.RightTriangle)]
public class RightTriangle : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point(rect.Left, rect.Top),
            new Point(rect.Left, rect.Bottom),
            new Point(rect.Right, rect.Top + (rect.Height / 2)),
        };
    }
}
