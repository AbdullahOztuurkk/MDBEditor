using MDBEditor.Tools.Abstract.General;
using MDBEditor.Tools.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenTool = MDBEditor.Tools.Concrete.PenTool;

namespace MDBEditor.Tools.Abstract
{
    public interface IPenTool : IToolRepository<PenTool>, ITool
    {
        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public Color BackColor { get; set; }
        public int Size { get; set; }

    }
}
