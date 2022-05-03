using MDBEditor.Shapes.Interfaces;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class TrianglePyramid : IShape
    {
        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            graphics.DrawPolygon(pen, GetCoordinates(rect));
            //Middle line
            graphics.DrawLine(pen,
                new Point(rect.Left + ( rect.Width / 2 ), rect.Top),
                new Point(rect.Left + ( rect.Width / 2 ), rect.Top + rect.Height));
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillPolygon(brush, GetCoordinates(rect));
        }

        public Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.Left + (rect.Width / 2), rect.Top), // Top point
                new Point(rect.Right,(int)( rect.Top + (rect.Height * 0.75) )), // Right point
                new Point(rect.Left + (rect.Width / 2),rect.Bottom), // Bottom point 
                new Point(rect.Left, (int)( rect.Top + (rect.Height * 0.75) )), // Left point
            };
        }
    }
}
