using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class BottomTriangle : RegularShapeBase
    {
        public override Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.Left, rect.Top),
                new Point(rect.Right, rect.Top),
                new Point(rect.Left + (rect.Width /2 ), rect.Bottom),
            };
        }
    }
}
