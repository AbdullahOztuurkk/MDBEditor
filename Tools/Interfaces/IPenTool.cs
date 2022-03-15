using MDBEditor.Constants;
using MDBEditor.Tools.Interfaces.General;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces
{
    public interface IPenTool : ITool
    {
        public Point Loc { get; set; }
        public Point LastPoint { get; set; }
        public Color BackColor { get; set; }
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
