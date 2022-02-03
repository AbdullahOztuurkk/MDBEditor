using MDBEditor.Tools.Abstract.General;
using System.Drawing;

namespace MDBEditor.Tools.Abstract
{
    public interface IPenTool : ITool
    {
        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public Color BackColor { get; set; }
        public int Size { get; set; }

    }
}
