using MDBEditor.Constants;
using MDBEditor.Tools.Interfaces.General;
using System.Drawing;

namespace MDBEditor.Tools.Interfaces
{
    public interface IZoomTool:ITool
    {
        public void ZoomToNormal();
        public void ZoomIn();
        public void ZoomOut();
    }
}
