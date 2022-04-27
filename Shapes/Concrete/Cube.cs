using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Cube : IShape
    {
        public Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            return new Point[] { };
        }

        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            throw new NotImplementedException();
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            throw new NotImplementedException();
        }
    }
}
