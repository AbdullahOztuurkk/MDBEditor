using System.Drawing;

namespace MDBEditor.Tools.Common;

public interface IPenTool : ITool
{
    public Point Location { get; set; }
    public Point LastPoint { get; set; }
    public Color BackColor { get; set; }
    public void IncreaseSize();
    public void DescreaseSize();
}
