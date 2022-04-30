using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Parallelogram : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.Left,rect.Bottom),
                new Point((int)( rect.Left + (rect.Width * 0.75) ),rect.Bottom),
                new Point(rect.Right,rect.Top),
                new Point((int)( rect.Left + (rect.Width * 0.25) ),rect.Top),
            };
        }
    }
}
