using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Note)]
public class Note : IShape
{
    public short distance;
    public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
    {
        distance = (short)(rect.Width < rect.Height ? (rect.Width / 4) : (rect.Height / 4));
        graphics.DrawPolygon(pen, GetCoordinates(rect));
        graphics.DrawLine(pen,
            new Point(rect.Right - distance, rect.Top),
            new Point(rect.Right - distance, rect.Top + distance));
        graphics.DrawLine(pen,
            new Point(rect.Right - distance, rect.Top + distance),
            new Point(rect.Right, rect.Top + distance));
    }

    public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
    {
        graphics.FillPolygon(brush, GetCoordinates(rect));
    }

    public Point[] GetCoordinates(System.Drawing.Rectangle rect)
    {
        distance = (short)(rect.Width < rect.Height ? (rect.Width / 4) : (rect.Height / 4));
        return new Point[]
        {
            new Point(rect.Right - distance, rect.Top),
            new Point(rect.Left, rect.Top),
            new Point(rect.Left, rect.Bottom),
            new Point(rect.Right, rect.Bottom),
            new Point(rect.Right, rect.Top + distance),
        };
    }
}
