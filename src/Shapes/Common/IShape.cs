using System;
using System.Drawing;

namespace MDBEditor.Shapes.Common;

public interface IShape
{
    public void Draw(Graphics graphics, Rectangle rect, Pen pen);
    public void Fill(Graphics graphics, Rectangle rect, Brush brush);

}
