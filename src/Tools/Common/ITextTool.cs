using System;
using System.Drawing;

namespace MDBEditor.Tools.Common;

public interface ITextTool : ITool
{
    public Point Location { get; set; }
    public Font Font { get; set; }
    public string Text { get; set; }
    public float FontSize { get; }
    public FontStyle FontStyle { get; }
    public Color ForeColor { get; set; }
    public Color SideColor { get; set; }
}
