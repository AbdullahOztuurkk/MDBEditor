using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Shapes.Concrete
{
    public class Circle : Shape
    {
        public void Draw(Graphics graphics, System.Drawing.Rectangle rect, Pen pen)
        {
            graphics.DrawEllipse(pen, rect);
        }

        public void Fill(Graphics graphics, System.Drawing.Rectangle rect, Brush brush)
        {
            graphics.FillEllipse(brush, rect);
        }
    }
}
