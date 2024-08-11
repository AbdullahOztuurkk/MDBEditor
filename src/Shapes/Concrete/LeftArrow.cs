using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.LeftArrow)]
public class LeftArrow : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point(rect.Right, (int)( rect.Top + (rect.Height * 0.375) )) ,
            new Point(rect.Right, (int)( rect.Top + (rect.Height * 0.625) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.25) ), (int)( rect.Top + (rect.Height * 0.625) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.25) ), (int)( rect.Top + (rect.Height * 0.75) )) ,
            new Point(rect.Left, rect.Top + (rect.Height / 2)) ,
            new Point((int)( rect.Left + (rect.Width * 0.25) ), (int)( rect.Top + (rect.Height * 0.25) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.25) ), (int)( rect.Top + (rect.Height * 0.375) )) ,
        };
    }
}
