using System.Drawing.Drawing2D;

namespace MDBEditor.Tools.Concrete;

public class ZoomTool : IZoomTool
{
    public PictureBox pictureBox { get; set; }
    public Bitmap OriginalImage { get; private set; }
    public Bitmap ZoomedImage { get; private set; }

    public double Size = ZoomSettings.DefaultZoomSize;
    public ZoomTool(PictureBox pictureBox)
    {
        this.pictureBox = pictureBox;
        OriginalImage = (Bitmap)pictureBox.Image;
    }
    public void Handle()
    {
        ZoomedImage = new Bitmap(OriginalImage,
            width: Convert.ToInt32(OriginalImage.Width * Size),
            height: Convert.ToInt32(OriginalImage.Height * Size));
        Graphics grap = Graphics.FromImage(ZoomedImage);
        grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
    }

    public void ZoomIn()
    {
        if (Size < ZoomSettings.MaximumZoomSize)
            Size += 0.25;
    }

    public void ZoomOut()
    {
        if (Size > ZoomSettings.MinimumZoomSize)
            Size -= 0.25;
    }

    public void ZoomToNormal()
    {
        pictureBox.Size = new Size(OriginalImage.Width, OriginalImage.Height);
        ZoomedImage = OriginalImage;
    }
}
