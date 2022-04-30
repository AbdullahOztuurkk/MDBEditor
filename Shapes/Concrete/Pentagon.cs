using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Pentagon : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[]
            {
                new Point((int)( rect.Left + (size * 0.25) ), rect.Top + size) ,
                new Point((int)( rect.Left + (size * 0.75) ), rect.Top + size) ,
                new Point(rect.Left + size, rect.Top +(size / 2 )) ,
                new Point(rect.Left + (size / 2), rect.Top) ,
                new Point(rect.Left, rect.Top + (size / 2)) ,
            };
        }
    }
}
