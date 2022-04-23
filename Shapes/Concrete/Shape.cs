using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics, Rectangle rect, Pen pen);
        public abstract void Fill(Graphics graphics, Rectangle rect, Brush brush);

    }
}
