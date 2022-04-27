using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Shapes.Concrete
{
    public class Trapezoid : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[] { 
                new Point((int)Math.Abs(rect.Width *0.125), rect.Y),
                new Point((int)Math.Abs(rect.Width *0.875), rect.Y),
                new Point(rect.Width, rect.Height),
                new Point(rect.X, rect.Height),
            };
        }
    }
}
