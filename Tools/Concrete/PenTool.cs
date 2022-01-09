using MDBEditor.Tools.Abstract;
using MDBEditor.Tools.Abstract.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Concrete
{
    public class PenTool : IPenTool
    {
        public PenTool(Graphics grph)
        {
            graphics = grph;
        }
        private readonly Graphics graphics;
        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public Color BackColor { get; set; }
        public int Size { get; set; }

        public void Handle()
        {
            Pen p = new Pen(BackColor, Size);

            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphics.DrawLine(p, LastPoint, new Point(Loc.X, Loc.Y));
            LastPoint = new Point(Loc.X, Loc.Y);
        }
    }
}
