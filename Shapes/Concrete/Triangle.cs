using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Triangle : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.X,rect.Height), //Left bottom
                new Point(Math.Abs(rect.Width / 2),rect.Y),//Top center
                new Point(rect.Width,rect.Height),//Right bottom
            };
        }
    }
}
