using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Star)]
public class Star : RegularShape
{
    public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        Point[] points = new Point[5];
        int cx = rect.Width / 2;
        int cy = rect.Height / 2;
        double theta = -Math.PI / 2;
        double dtheta = Math.PI * 0.8;
        for (int i = 0; i <= 4; i++)
        {
            points[i].X = rect.Left + (int)(cx + cx * Math.Cos(theta));
            points[i].Y = rect.Top + (int)(cy + cy * Math.Sin(theta));
            theta += dtheta;
        }
        return points;
    }
}
