using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.LeftTriangle)]
public class LeftTriangle : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point(rect.Right, rect.Top),
            new Point(rect.Right, rect.Bottom),
            new Point(rect.Left, rect.Top + (rect.Height / 2)),
        };
    }
}
