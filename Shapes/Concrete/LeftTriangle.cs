using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class LeftTriangle : RegularShapeBase
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
}
