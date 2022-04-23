using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Diamond : RegularShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            return new Point[]
            {
                new Point(Math.Abs(rect.Width / 2), rect.X),//Top center
                new Point(rect.X, Math.Abs(rect.Height / 2)), //Left center
                new Point(Math.Abs(rect.Width / 2), rect.Height), //Bottom center
                new Point(rect.Width, Math.Abs(rect.Height / 2)),//Right center
            };
        }
    }
}
