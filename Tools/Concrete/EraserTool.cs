using MDBEditor.Constants;
using MDBEditor.Tools.Interfaces;
using System.Drawing;
using System.Drawing.Drawing2D;

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
