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
        public String Text { get; set; }
        public float Size { get; }
        public FontStyle FontStyle { get; }
        public Color ForeColor { get; set; }
        public Color SideColor { get; set; }
    }
}
