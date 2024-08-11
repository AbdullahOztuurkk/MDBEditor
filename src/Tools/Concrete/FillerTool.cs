using MDBEditor.Tools.Interfaces;
using System.Drawing;

namespace MDBEditor.Tools.Concrete;

public class FillerTool : IFillerTool
{
    public FillerTool(Bitmap imageCanvas)
    {
        ImageCanvas = imageCanvas;
    }
    private readonly Bitmap ImageCanvas;

    public Color BackColor { get; set; }
    public Point Location { get; set; }

    public void Handle()
    {
        //Needs efficiently Flood Fill Algorithm
    }
}
