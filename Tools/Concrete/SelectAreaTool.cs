using MDBEditor.Tools.Interfaces;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MDBEditor.Tools.Concrete;

public class SelectAreaTool : ISelectAreaTool
{
    public Rectangle SelectedArea { get; set; }
    public Pen Pen { get; }
    public void Clear() => SelectedArea = Rectangle.Empty;

    public SelectAreaTool()
    {
        Pen = new Pen(Color.Black, 1.5f);
        Pen.DashStyle = DashStyle.DashDot;
    }
}
