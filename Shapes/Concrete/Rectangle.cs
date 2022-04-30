﻿using MDBEditor.Shapes.Interfaces;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Rectangle : IShape
    {
        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            graphics.DrawRectangle(pen, rect);
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillRectangle(brush, rect);
        }
    }
}
