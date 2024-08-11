using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.EightPointedStar)]
public class EightPointedStar : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        return new Point[]
        {
            new Point((int)( rect.Left + (rect.Width * 0.25) ), rect.Top),//Top Left corner
            new Point(rect.Left + (rect.Width / 2 ), (int)( rect.Top +(rect.Height *0.25) )),
            new Point((int)( rect.Left + (rect.Width * 0.75) ), rect.Top),//Top Right corner
            new Point((int)( rect.Left + (rect.Width * 0.75 ) ), (int)( rect.Top + (rect.Height *0.25) )),
            new Point(rect.Right, (int)( rect.Top + (rect.Height *0.25))),//Right Top corner
            new Point((int)( rect.Left + (rect.Width * 0.75 ) ), rect.Top +(rect.Height / 2)),
            new Point(rect.Right, (int)( rect.Top + (rect.Height *0.75))),//Right Bottom corner
            new Point((int)( rect.Left + (rect.Width * 0.75 ) ), (int)( rect.Top +(rect.Height * 0.75) )),
            new Point((int)( rect.Left + (rect.Width * 0.75 ) ), rect.Bottom),//Bottom Right Corner
            new Point(rect.Left + (rect.Width / 2  ), (int)( rect.Top +(rect.Height * 0.75) )),
            new Point((int)( rect.Left + (rect.Width * 0.25 ) ), rect.Bottom),//Bottom Left Corner
            new Point((int)( rect.Left + (rect.Width * 0.25  ) ), (int)( rect.Top +(rect.Height * 0.75) )),
            new Point(rect.Left, (int)( rect.Top + (rect.Height * 0.75 ) )), //Left Bottom Corner
            new Point((int)( rect.Left + (rect.Width * 0.25) ), rect.Top + (rect.Height / 2 )),
            new Point(rect.Left, (int)( rect.Top + (rect.Height * 0.25) )), //Left Top Corner
            new Point((int)( rect.Left + (rect.Width  * 0.25) ), (int)( rect.Top + (rect.Height * 0.25) ))
        };
    }
}
