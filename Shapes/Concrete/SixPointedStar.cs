using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class SixPointedStar : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[]
            {
                new Point(rect.Left +(size / 2), rect.Top), // Top point
                new Point((int)( rect.Left +(size * 0.25) ),(int)( rect.Top +(size * 0.25) )),
                new Point(rect.Left,(int)( rect.Top + (size * 0.25) )), // Second Point
                new Point((int)( rect.Left + (size * 0.2) ),rect.Top +(size / 2)),
                new Point(rect.Left, (int)( rect.Top + (size * 0.75) )), // Third Point
                new Point((int)( rect.Left + (size * 0.25) ), (int)( rect.Top + (size * 0.75) )),
                new Point(rect.Left + (size / 2 ), rect.Top + size), //Bottom Point
                new Point((int)( rect.Left + (size* 0.75) ) , (int)( rect.Top + (size * 0.75) )),
                new Point(rect.Left + size, (int)( rect.Top +(size * 0.75) )), // Fifth Point
                new Point((int)( rect.Left + (size * 0.8) ), rect.Top + (size / 2)),
                new Point(rect.Left + size, (int)( rect.Top +(size * 0.25) )), //Sixth Point
                new Point((int)( rect.Left + (size *0.75) ), (int)( rect.Top +(size * 0.25) )),
            };
        }
    }
}
