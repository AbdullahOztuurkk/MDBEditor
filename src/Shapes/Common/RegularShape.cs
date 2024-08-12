namespace MDBEditor.Shapes.Common;

public abstract class RegularShape : IShape
{
    public abstract Point[] GetCoordinates(Rectangle rect);
    public void Draw(Graphics graphics, Rectangle rect, Pen pen)
    {
        graphics.DrawPolygon(pen, GetCoordinates(rect));
    }
    public void Fill(Graphics graphics, Rectangle rect, Brush brush)
    {
        graphics.FillPolygon(brush, GetCoordinates(rect));
    }
}
