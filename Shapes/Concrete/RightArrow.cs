using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class RightArrow : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.X, (int)Math.Abs(rect.Height * 0.375)) ,
                new Point(rect.X, (int)Math.Abs(rect.Height * 0.625)) ,
                new Point((int)Math.Abs(rect.Width * 0.75), (int)Math.Abs(rect.Height * 0.625)) ,
                new Point((int)Math.Abs(rect.Width * 0.75), (int)Math.Abs(rect.Height * 0.75)) ,
                new Point(rect.Width, Math.Abs(rect.Height / 2)) ,
                new Point((int)Math.Abs(rect.Width * 0.75), (int)Math.Abs(rect.Height * 0.25)) ,
                new Point((int)Math.Abs(rect.Width * 0.75), (int)Math.Abs(rect.Height * 0.375)) ,
            };
        }
    }
}
