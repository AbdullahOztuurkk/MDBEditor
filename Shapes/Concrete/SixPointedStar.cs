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
                new Point((int)( rect.Left +(size * 0.25) ),rect.Top),
                new Point((int)( rect.Left +(size * 0.25) ),(int)( rect.Top +(size * 0.25) )),
                new Point(rect.Left,rect.Top + (size / 2)),
                new Point((int)( rect.Left + (size * 0.25) ),(int)( rect.Top +(size * 0.75) )),
                new Point((int)( rect.Left + (size * 0.25) ), rect.Bottom),
                new Point(rect.Left + (size / 2),(int)( rect.Top + (size * 0.75) )),
                new Point((int)( rect.Left + (size * 0.75) ), rect.Bottom),
                new Point((int)( rect.Left + (size * 0.75) ),(int)( rect.Top +(size * 0.75) )),
                new Point(rect.Left + size,rect.Top + (rect.Height /2)),
                new Point((int)( rect.Left + (size * 0.75) ),(int)( rect.Top +(size * 0.25) )),
                new Point((int)( rect.Left + (size * 0.75) ),rect.Top),
                new Point(rect.Left + (size / 2),(int)( rect.Top +(size * 0.25) )),
                };
            //titreşimi engelleme amaçlı araştırma yap
        }
    }
}
