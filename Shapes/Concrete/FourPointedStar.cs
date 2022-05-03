using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class FourPointedStar : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {   
                new Point(rect.Left + (rect.Width / 2), rect.Top ), // Top Point
                new Point((int)( rect.Left + (rect.Width * 0.375) ),(int)( rect.Top + (rect.Height * 0.375) )),
                new Point(rect.Left, rect.Top + (rect.Height / 2)), // Left Point
                new Point((int)( rect.Left + (rect.Width * 0.375) ), (int)( rect.Top + (rect.Height * 0.625) ) ),
                new Point(rect.Left + (rect.Width / 2), rect.Bottom ), // Bottom Point
                new Point((int)( rect.Left + (rect.Width * 0.625) ),(int)( rect.Top + (rect.Height * 0.625) )),
                new Point(rect.Right, rect.Top + (rect.Height / 2)), // Right Point
                new Point((int)( rect.Left + (rect.Width * 0.625) ), (int)( rect.Top + (rect.Height * 0.375) ) ),
            };
        }
    }
}
