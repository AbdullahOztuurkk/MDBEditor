using MDBEditor.Constants;
using MDBEditor.Tools.Abstract.General;
using MDBEditor.Tools.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Abstract
{
    public interface IEraserTool: ITool
    {
        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public int Size
        {
            get
            {
                if (Size != null)
                    return Size;
                else
                    return AppSettings.DEFAULT_TOOL_SIZE;
            }
            set
            {
                Size = value;
            }
        }
        public void IncreaseSize();
        public void DescreaseSize();
    }
}
