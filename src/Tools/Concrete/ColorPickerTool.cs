using MDBEditor.Tools.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor.Tools.Concrete;

public class ColorPickerTool : IColorPickerTool
{
    public ColorPickerTool(PictureBox pictureBox)
    {
        PictureBox = pictureBox;
    }

    public readonly PictureBox PictureBox;

    public Point Location { get; set; }
    public Color DetectedColor { private set; get; }

    private Color GetColorAt(int x, int y)
    {
        Bitmap bmp = new Bitmap(1, 1);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.CopyFromScreen(PictureBox.PointToScreen(Location), new Point(0, 0), bmp.Size);
        }
        return bmp.GetPixel(0, 0);
    }

    public void Handle()
    {
        DetectedColor = GetColorAt(Location.X, Location.Y);
    }

}
