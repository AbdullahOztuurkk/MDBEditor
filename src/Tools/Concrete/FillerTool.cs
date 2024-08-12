using System.Collections.Generic;

namespace MDBEditor.Tools.Concrete;

public class FillerTool : IFillerTool
{
    private readonly Bitmap bitmap;
    private readonly PictureBox _pictureBox;
    public FillerTool(PictureBox pictureBox)
    {
        _pictureBox = pictureBox;
        this.bitmap = (Bitmap)_pictureBox.Image;
    }

    public Color ReplacementColor { get; set; }
    public Color TargetColor { get; set; }
    public Point Location { get; set; }

    public void Handle()
    {
        Color currentColor = bitmap.GetPixel(Location.X, Location.Y);
        if (currentColor.ToArgb() == TargetColor.ToArgb())
        {
            return; // No need to fill if the color is already the target color
        }

        Stack<Point> pixels = new Stack<Point>();
        pixels.Push(Location);

        while (pixels.Count > 0)
        {
            Point a = pixels.Pop();
            if (a.X < bitmap.Width && a.X > 0 && a.Y < bitmap.Height && a.Y > 0) //make sure we stay within bounds
            {
                var pixelColor = bitmap.GetPixel(a.X, a.Y);
                var pixelColorArgb = bitmap.GetPixel(a.X, a.Y).ToArgb();
                var targetColorArgb = TargetColor.ToArgb();
                if (pixelColor == TargetColor || pixelColor.A == 0)
                {
                    bitmap.SetPixel(a.X, a.Y, ReplacementColor);
                    pixels.Push(new Point(a.X - 1, a.Y));
                    pixels.Push(new Point(a.X + 1, a.Y));
                    pixels.Push(new Point(a.X, a.Y - 1));
                    pixels.Push(new Point(a.X, a.Y + 1));
                }
            }
        }
        _pictureBox.Refresh();
    }
}
