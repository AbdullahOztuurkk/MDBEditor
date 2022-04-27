﻿using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public interface Shape
    {
        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen);
        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush);

    }
}
