using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Envelope)]
public class Envelope : IShape
{
    public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
    {
        graphics.DrawRectangle(pen, rect);
        graphics.DrawLine(pen,
            new Point(rect.Left + (rect.Width / 2), (int)(rect.Top + (rect.Height * 0.375))),
            new Point(rect.Left, rect.Top));

        graphics.DrawLine(pen,
            new Point(rect.Left + (rect.Width / 2), (int)(rect.Top + (rect.Height * 0.375))),
            new Point(rect.Right, rect.Top));
    }

    public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
    {
        graphics.FillRectangle(brush, rect);
    }
}
