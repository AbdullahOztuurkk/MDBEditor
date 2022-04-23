using MDBEditor.Extensions;
using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Pentagon : ShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[]
            {
                new Point((int)Math.Abs(size * 0.25), size) ,
                new Point((int)Math.Abs(size * 0.75), size) ,
                new Point(size, Math.Abs(size / 2 )) ,
                new Point(size / 2, rect.Y) ,
                new Point(rect.X, Math.Abs(size / 2)) ,
            };
        }
    }
}
