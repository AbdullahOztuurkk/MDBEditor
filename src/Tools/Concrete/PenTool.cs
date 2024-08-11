namespace MDBEditor.Tools.Concrete;

public class PenTool : IPenTool
{
    public PenTool(Graphics grph)
    {
        graphics = grph;
    }
    private readonly Graphics graphics;
    private int Size = BrushSettings.DefaultToolSize;
    public Point Location { get; set; }
    public Point LastPoint { get; set; }
    public Color BackColor { get; set; }

    public void Handle()
    {
        Pen p = new Pen(BackColor, Size);

        p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        graphics.DrawLine(p, LastPoint, new Point(Location.X, Location.Y));
        LastPoint = new Point(Location.X, Location.Y);
    }

    public void IncreaseSize()
    {
        if (Size < BrushSettings.MaximumToolSize)
            Size++;
    }
    public void DescreaseSize()
    {
        if (Size > BrushSettings.MinimumToolSize)
            Size--;
    }
}
