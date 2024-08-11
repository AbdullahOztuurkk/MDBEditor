using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Hexagon)]
public class Hexagon : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        int size = rect.Width > rect.Height ? rect.Height : rect.Width;
        return new Point[]
        {
            new Point(rect.Left + (size / 2 ), rect.Top) ,
            new Point(rect.Left, (int)( rect.Top + (size * 0.25) )) ,
            new Point(rect.Left, (int)( rect.Top + (size * 0.75) )) ,
            new Point(rect.Left +(size / 2 ), rect.Top + size) ,
            new Point(rect.Left + size, (int)( rect.Top +(size * 0.75) )) ,
            new Point(rect.Left + size, (int)( rect.Top +(size * 0.25) )) ,
        };
    }
}
