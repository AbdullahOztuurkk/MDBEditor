using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Plus : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point((int)( rect.Left + (rect.Width * 0.4) ), rect.Top), //
                new Point((int)( rect.Left + (rect.Width * 0.6) ), rect.Top), // Top Point
                new Point((int)( rect.Left + (rect.Width * 0.6) ), (int)( rect.Top + (rect.Height * 0.4) )),
                new Point(rect.Right, (int)( rect.Top + (rect.Height * 0.4) )), //
                new Point(rect.Right, (int)( rect.Top + (rect.Height * 0.6) )), // Right Point
                new Point((int)( rect.Left + (rect.Width * 0.6) ), (int)( rect.Top + (rect.Height * 0.6) )),
                new Point((int)( rect.Left + (rect.Width * 0.6) ), rect.Bottom), //
                new Point((int)( rect.Left + (rect.Width * 0.4) ), rect.Bottom), // Bottom Point
                new Point((int)( rect.Left + (rect.Width * 0.4) ), (int)( rect.Top + (rect.Height * 0.6) )),
                new Point(rect.Left, (int)( rect.Top +  + (rect.Height * 0.6) )), //
                new Point(rect.Left, (int)( rect.Top +  + (rect.Height * 0.4) )), // Left Point
                new Point((int)( rect.Left + (rect.Width * 0.4) ), (int)( rect.Top + (rect.Height * 0.4) )),
            };
        }
    }
}
