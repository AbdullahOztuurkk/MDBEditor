using MDBEditor.Tools.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Concrete
{
    public class TextTool : ITextTool
    {
        public readonly Graphics graphics;

        public TextTool(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Point Loc { get; set; }
        public Font Font { get; set; }
        public short Size { get; set; }
        public Color ForeColor { get; set; }
        public Color SideColor { get; set; }

        public void Handle()
        {
            throw new NotImplementedException();
        }
    }
}
