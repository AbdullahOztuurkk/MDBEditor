using MDBEditor.Constants;
using MDBEditor.Tools.Interfaces;
using MDBEditor.Tools.Interfaces.General;
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
        public int Size = AppSettings.DEFAULT_TOOL_SIZE;

        public void Handle()
        {
            Pen p = new Pen(BackColor, Size);

            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphics.DrawLine(p, LastPoint, new Point(Loc.X, Loc.Y));
            LastPoint = new Point(Loc.X, Loc.Y);
        }

        public void IncreaseSize()
        {
            if (Size < AppSettings.MAXIMUM_TOOL_SIZE)
                Size++;
        }
        public void DescreaseSize()
        {
            if (Size > AppSettings.MINIMUM_TOOL_SIZE)
                Size--;
        }
    }
}
