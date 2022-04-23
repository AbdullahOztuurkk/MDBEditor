using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class SixPointedStar : RegularShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[]
            {
                new Point((int)Math.Abs(size * 0.25),size),
                new Point(Math.Abs(size / 2), (int)Math.Abs(size*0.75)),
                new Point((int)Math.Abs(size * 0.75),size),
                new Point((int)Math.Abs(size * 0.75),(int)Math.Abs(size * 0.75)),
                new Point(size,Math.Abs(size / 2)),
                new Point((int)Math.Abs(size * 0.75),(int)Math.Abs(size * 0.25)),
                new Point((int)Math.Abs(size * 0.75), rect.Y),
                new Point(Math.Abs(size / 2),(int)Math.Abs(size * 0.25)),
                new Point((int)Math.Abs(size * 0.25),rect.Y),
                new Point((int)( size * 0.25 ),(int)Math.Abs(size * 0.25)),
                new Point(rect.X,Math.Abs(size / 2)),
                new Point((int)Math.Abs(size * 0.25),(int)Math.Abs(size * 0.75)),
            };
            //titreşimi engelleme amaçlı araştırma yap
        }
    }
}
