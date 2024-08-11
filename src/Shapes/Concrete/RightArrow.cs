using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.RightArrow)]
public class RightArrow : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point(rect.Left, (int)( rect.Top + (rect.Height * 0.375) )) ,
            new Point(rect.Left, (int)( rect.Top + (rect.Height * 0.625) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.75) ), (int)( rect.Top + (rect.Height * 0.625) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.75) ), (int)( rect.Top + (rect.Height * 0.75) )) ,
            new Point(rect.Right, rect.Top + (rect.Height / 2)) ,
            new Point((int)( rect.Left + (rect.Width * 0.75) ), (int)( rect.Top + (rect.Height * 0.25) )) ,
            new Point((int)( rect.Left + (rect.Width * 0.75) ), (int)( rect.Top + (rect.Height * 0.375) )) ,
        };
    }
}
