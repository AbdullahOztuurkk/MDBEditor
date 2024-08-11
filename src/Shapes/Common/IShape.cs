using System;
using System.Drawing;

namespace MDBEditor.Shapes.Interfaces;

public interface IShape
{
    public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen);
    public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush);

}
