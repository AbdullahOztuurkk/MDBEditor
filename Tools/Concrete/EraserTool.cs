using MDBEditor.Tools.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Concrete
{
    public class EraserTool : IEraserTool
    {
        public EraserTool(Graphics grph)
        {
            graphics = grph;
        }
        private readonly Graphics graphics;

        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public int Size { get; set; }

        public void Handle()
        {
            Pen eraser = new Pen(Color.White, Size);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            eraser.StartCap = LineCap.Square;
            eraser.EndCap = LineCap.Square;

            graphics.DrawLine(eraser, LastPoint, new Point(Loc.X,Loc.Y));

            LastPoint = new Point(Loc.X, Loc.Y);
        }
    }
}
