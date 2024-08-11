using MDBEditor.Constants;
using MDBEditor.Tools.Interfaces;
using System.Drawing;
using System.Drawing.Drawing2D;
using static MDBEditor.Constants.Global;

namespace MDBEditor.Tools.Concrete;

public class EraserTool : IEraserTool
{
    public EraserTool(Graphics grph)
    {
        graphics = grph;
    }
    private readonly Graphics graphics;

    public Point Location { get; set; }
    public Point LastPoint { get; set; }
    public int Size { get; set; }

    public void Handle()
    {
        Pen eraser = new Pen(Color.White, Size);
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        eraser.StartCap = LineCap.Square;
        eraser.EndCap = LineCap.Square;

        graphics.DrawLine(eraser, LastPoint, new Point(Location.X, Location.Y));

        LastPoint = new Point(Location.X, Location.Y);
    }

    public void IncreaseSize()
    {
        if (Size < BrushSettings.MaximumToolSize)
        {
            Size++;
        }
    }
    public void DescreaseSize()
    {
        if (Size > BrushSettings.MinimumToolSize)
        {
            Size--;
        }
    }
}
