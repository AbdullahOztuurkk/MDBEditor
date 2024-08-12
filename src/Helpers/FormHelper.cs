using System.Drawing;

namespace MDBEditor.Helpers;

public static class FormHelper
{
    /// <summary>
    /// Get all system colors as pictureboxes to control.
    /// </summary>
    /// <param name="control">Any FlowLayoutPanel</param>
    public static void GetColors(this FlowLayoutPanel control)
    {
        var colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        foreach (KnownColor knowColor in colors)
        {
            Color color = Color.FromKnownColor(knowColor);
            PictureBox pb = new PictureBox()
            {
                Size = new Size(MenuSettings.BoxSize, MenuSettings.BoxSize),
                BackColor = color,
                BorderStyle = BorderStyle.FixedSingle,
            };
            pb.MouseClick += new MouseEventHandler(SetColor);
            control.Controls.Add(pb);
        }
    }

    private static void SetColor(object sender, MouseEventArgs e)
    {
        PictureBox? pictureBox = sender as PictureBox;
        MasterForm.secondaryColor = MasterForm.primaryColor;
        MasterForm.primaryColor = pictureBox.BackColor;
    }

    /// <summary>
    /// Availability of given picturebox before open new file
    /// </summary>
    /// <param name="pb">Any picturebox</param>
    /// <returns>Availability of given picturebox</returns>
    public static bool IsPictureBoxEmptyOrNull(this PictureBox pb)
    {
        return pb == null || pb.Image == null;
    }

    /// <summary>
    /// Set image of specified picturebox
    /// </summary>
    /// <param name="pictureBox">Any _pictureBox Control</param>
    /// <param name="img">Any Image Object</param>
    public static void SetImage(this PictureBox pictureBox, Image img)
    {
        //pictureBox.Image.Dispose();
        pictureBox.Image = img;
        pictureBox.Invalidate();
    }

    /// <summary>
    /// Get copy of drawing area before undo & redo
    /// </summary>
    /// <param name="pictureBox"></param>
    /// <returns></returns>
    public static Bitmap TakeSnapshot(this PictureBox pictureBox)
    {
        Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
        pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);
        return bmp;
    }
}
