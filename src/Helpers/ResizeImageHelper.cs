using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MDBEditor.Helpers;

public static class ResizeImageHelper
{
    /// <summary>
    /// Scale Image by percentage
    /// </summary>
    /// <param name="bmp">Any Bitmap</param>
    /// <param name="Percent">Number between 0 and 100</param>
    /// <returns></returns>
    public static Bitmap ScaleByPercent(Bitmap bmp, Size Percent)
    {
        float nPercentWidth = ((float)Percent.Width / 100);
        float nPercentHeight = ((float)Percent.Height / 100);

        int sourceWidth = bmp.Width;
        int sourceHeight = bmp.Height;
        var destWidth = (int)(sourceWidth * nPercentWidth);
        var destHeight = (int)(sourceHeight * nPercentHeight);

        var bmPhoto = new Bitmap(destWidth, destHeight,
                                 PixelFormat.Format32bppArgb);
        bmPhoto.SetResolution(bmp.HorizontalResolution,
                              bmp.VerticalResolution);

        Graphics grPhoto = Graphics.FromImage(bmPhoto);
        grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

        grPhoto.DrawImage(bmp,
                          new Rectangle(0, 0, destWidth, destHeight),
                          new Rectangle(0, 0, sourceWidth, sourceHeight),
                          GraphicsUnit.Pixel);

        grPhoto.Dispose();
        return bmPhoto;
    }

    /// <summary>
    ///  Resize Image according to specified size
    /// </summary>
    /// <param name="bmp">Any Bitmap</param>
    /// <param name="size">Desired FontSize</param>
    /// <returns></returns>
    public static Bitmap ResizeBitmap(this Bitmap bmp, Size size)
    {
        Bitmap result = new Bitmap(size.Width, size.Height);
        using (Graphics g = Graphics.FromImage(result))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(bmp, 0, 0, size.Width, size.Height);
        }
        return result;
    }
}
