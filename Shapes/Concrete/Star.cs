using MDBEditor.Extensions;
using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Star: ShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            Point[] points = new Point[5];
            int cx = rect.Width / 2;
            int cy = rect.Height / 2;
            double theta = -Math.PI / 2;
            double dtheta = Math.PI * 0.8;
            for (int i = 0; i <= 4; i++)
            {
                points[i].X = (int)( cx + cx * Math.Cos(theta) );
                points[i].Y = (int)( cy + cy * Math.Sin(theta) );
                theta += dtheta;
            }
            return points;
        }
    }
}
