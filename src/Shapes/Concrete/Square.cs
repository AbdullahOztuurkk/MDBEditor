﻿using System.Drawing;

namespace MDBEditor.Shapes.Concrete;

[Shape(GeometricalShape.Square)]
public class Square : IShape
{
    public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
    {
        int size = rect.Width > rect.Height ? rect.Height : rect.Width;
        graphics.DrawRectangle(pen, new System.Drawing.Rectangle(rect.X, rect.Y, size, size));
    }

    public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
    {
        int size = rect.Width > rect.Height ? rect.Height : rect.Width;
        graphics.FillRectangle(brush, new System.Drawing.Rectangle(rect.X, rect.Y, size, size));
    }
}
