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
                new Point(rect.X,rect.Height),
                new Point((int)Math.Abs(rect.Width * 0.75),rect.Height),
                new Point(rect.Width,rect.Y),
                new Point((int)Math.Abs(rect.Width * 0.25),rect.Y),
            };
        }
    }
}
