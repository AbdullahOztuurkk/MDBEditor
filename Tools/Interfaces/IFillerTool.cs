using MDBEditor.Tools.Interfaces.General;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces
{
    public interface IFillerTool:ITool
    {
        public Color BackColor { get; set; }
        public Point Loc { get; set; }

    }
}
