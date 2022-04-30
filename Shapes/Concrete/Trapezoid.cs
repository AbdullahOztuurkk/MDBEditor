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
                new Point((int)( rect.Left + rect.Width *0.125 ), rect.Top),
                new Point((int)( rect.Left + (rect.Width *0.875) ), rect.Top),
                new Point(rect.Right, rect.Bottom),
                new Point(rect.Left, rect.Bottom),
            };
        }
    }
}
