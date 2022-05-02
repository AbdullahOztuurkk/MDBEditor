using MDBEditor.Shapes.Interfaces;
using System;
using System.Drawing;

namespace MDBEditor.Shapes.Concrete
{
    public class Cube : IShape
    {
        public Point[] GetCoordinates(System.Drawing.Rectangle rect)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            return new Point[] 
            {
                //Same as Hexagon
                new Point(rect.Left + (size / 2 ), rect.Top) ,
                new Point(rect.Left, (int)( rect.Top + (size * 0.25) )) ,
                new Point(rect.Left, (int)( rect.Top + (size * 0.75) )) ,
                new Point(rect.Left +(size / 2 ), rect.Top + size) ,
                new Point(rect.Left + size, (int)( rect.Top +(size * 0.75) )) ,
                new Point(rect.Left + size, (int)( rect.Top +(size * 0.25) )) ,
            };
        }

        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            int size = rect.Width > rect.Height ? rect.Height : rect.Width;
            Point centerPoint = new Point(rect.Left + ( size / 2 ), rect.Top + ( size / 2 ));
            graphics.DrawPolygon(pen, GetCoordinates(rect));
            //Middle lines
            graphics.DrawLine(pen, centerPoint, new Point(rect.Left + size, (int)( rect.Top + ( size * 0.25 ) )));
            graphics.DrawLine(pen, centerPoint, new Point(rect.Left + (size /2), rect.Top + size));
            graphics.DrawLine(pen, centerPoint, new Point(rect.Left, (int)( rect.Top + (size * 0.25) )));
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillPolygon(brush, GetCoordinates(rect));
        }
    }
}
