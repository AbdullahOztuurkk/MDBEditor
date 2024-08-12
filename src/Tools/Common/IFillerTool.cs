using System.Drawing;

namespace MDBEditor.Tools.Common;

public interface IFillerTool : ITool
{
    public Color ReplacementColor { get; set; } 
    public Color TargetColor { get; set; }
    public Point Location { get; set; }

}
