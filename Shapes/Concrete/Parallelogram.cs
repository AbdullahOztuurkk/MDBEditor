using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Shapes.Concrete
{
    public class Parallelogram : RegularShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
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
