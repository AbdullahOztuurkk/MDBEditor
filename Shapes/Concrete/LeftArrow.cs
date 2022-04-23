﻿using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class LeftArrow: RegularShapeBase
    {
        public override Point[] GetCoordinates(Rectangle rect)
        {
            return new Point[]
            {
                new Point(rect.Width, (int)Math.Abs(rect.Height * 0.375)) ,
                new Point(rect.Width, (int)Math.Abs(rect.Height * 0.625)) ,
                new Point((int)Math.Abs(rect.Width * 0.25), (int)Math.Abs(rect.Height * 0.625)) ,
                new Point((int)Math.Abs(rect.Width * 0.25), (int)Math.Abs(rect.Height * 0.75)) ,
                new Point(rect.X, Math.Abs(rect.Height / 2)) ,
                new Point((int)Math.Abs(rect.Width * 0.25), (int)Math.Abs(rect.Height * 0.25)) ,
                new Point((int)Math.Abs(rect.Width * 0.25), (int)Math.Abs(rect.Height * 0.375)) ,
            };
        }
    }
}
