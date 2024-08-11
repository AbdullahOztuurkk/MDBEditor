using System.Drawing.Imaging;
using System.Text;

namespace MDBEditor.Helpers;

public static class SaveImageHelper
{
    public static void SaveImage(this PictureBox pictureBox)
    {
        Bitmap bmp = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);

        using SaveFileDialog sfd = new SaveFileDialog();
        sfd.Title = MessageProvider.SaveFileDialogTitle;
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        sfd.Filter = GetFilter();

        if (sfd.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        var extension = Path.GetExtension(sfd.FileName).ToLower();

        var imageFormat = extension switch
        {
            ".bmp" => ImageFormat.Bmp,
            ".gif" => ImageFormat.Gif,
            ".jpeg" => ImageFormat.Jpeg,
            ".png" => ImageFormat.Png,
            ".tiff" => ImageFormat.Tiff,
            ".wmf" => ImageFormat.Wmf,
            ".ico" => ImageFormat.Icon,
            _ => null
        };

        bmp.Save(sfd.FileName, imageFormat);
    }

    public static void SaveImage(this PictureBox pictureBox, ImageFormat format)
    {
        Bitmap bmp = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);

        using SaveFileDialog sfd = new SaveFileDialog();
        sfd.Title = MessageProvider.SaveFileDialogTitle;
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        sfd.Filter = FileSettings.FileFilterDictionary[format];

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            bmp.Save(sfd.FileName, format);
        }
    }

    private static string GetFilter()
    {
        var builder = new StringBuilder();
        foreach (var item in FileSettings.FileFilterDictionary)
        {
            builder.Append(item.Value);
        }
        var filter = builder.ToString();
        return filter;
    }
}
