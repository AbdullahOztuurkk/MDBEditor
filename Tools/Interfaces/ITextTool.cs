using MDBEditor.Tools.Interfaces.General;
using System;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces
{
    public interface ITextTool:ITool
    {
        public Point Loc { get; set; }
        public Font Font { get; set; }
        public String Text { get; set; }
        public float Size { get; }
        public FontStyle FontStyle { get; }
        public Color ForeColor { get; set; }
        public Color SideColor { get; set; }
    }
}
