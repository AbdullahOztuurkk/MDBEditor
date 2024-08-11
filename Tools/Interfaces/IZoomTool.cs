﻿using MDBEditor.Tools.Interfaces.General;

namespace MDBEditor.Tools.Interfaces;

public interface IZoomTool : ITool
{
    public void ZoomToNormal();
    public void ZoomIn();
    public void ZoomOut();
}
