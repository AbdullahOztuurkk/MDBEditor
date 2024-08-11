using MDBEditor.Tools.Interfaces.General;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces;

public interface IPenTool : ITool
{
    public Point Location { get; set; }
    public Point LastPoint { get; set; }
    public Color BackColor { get; set; }
    public void IncreaseSize();
    public void DescreaseSize();
}
