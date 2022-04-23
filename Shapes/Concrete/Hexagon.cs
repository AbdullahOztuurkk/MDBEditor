using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Hexagon : RegularShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[]
            {
                new Point(Math.Abs(size / 2 ), size) ,
                new Point(rect.X, (int)Math.Abs(size * 0.75)) ,
                new Point(rect.X, (int)Math.Abs(size * 0.25)) ,
                new Point(Math.Abs(size / 2 ), rect.Y) ,
                new Point(size, (int)Math.Abs(size * 0.25)) ,
                new Point(size, (int)Math.Abs(size * 0.75)) ,
            };
        }
    }
}
