using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Trapezoid)]
public class Trapezoid : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[] {
            new Point((int)( rect.Left + rect.Width *0.125 ), rect.Top),
            new Point((int)( rect.Left + (rect.Width *0.875) ), rect.Top),
            new Point(rect.Right, rect.Bottom),
            new Point(rect.Left, rect.Bottom),
        };
    }
}
