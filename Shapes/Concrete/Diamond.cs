using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Diamond : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.Left + (rect.Width / 2), rect.Top),//Top center
                new Point(rect.Left, rect.Top +  (rect.Height / 2)), //Left center
                new Point(rect.Left + (rect.Width / 2), rect.Bottom), //Bottom center
                new Point(rect.Right, rect.Top + (rect.Height / 2)),//Right center
            };
        }
    }
}
