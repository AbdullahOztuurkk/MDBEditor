using MDBEditor.Tools.Abstract.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Abstract
{
    public interface ITextTool:ITool
    {
        public Point Loc { get; set; }
        public Font Font { get; set; }
        public short Size { get; set; }
        public Color ForeColor { get; set; }
        public Color SideColor { get; set; }
    }
}
