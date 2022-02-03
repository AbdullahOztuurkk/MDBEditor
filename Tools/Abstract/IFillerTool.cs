using MDBEditor.Tools.Abstract.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Abstract
{
    public interface IFillerTool:ITool
    {
        public Color BackColor { get; set; }
        public Point Loc { get; set; }

    }
}
