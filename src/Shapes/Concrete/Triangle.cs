using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Triangle)]
public class Triangle : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point(rect.Left,rect.Bottom), //Left bottom
            new Point(rect.Left + (rect.Width / 2), rect.Top),//Top center
            new Point(rect.Right,rect.Bottom),//Right bottom
        };
    }
}
