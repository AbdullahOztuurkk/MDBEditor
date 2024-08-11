using MDBEditor.Tools.Interfaces.General;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces;

public interface IEraserTool : ITool
{
    public Point Location { get; set; }
    public Point LastPoint { get; set; }
    public int Size { get; set; }
    public void IncreaseSize();
    public void DescreaseSize();
}
