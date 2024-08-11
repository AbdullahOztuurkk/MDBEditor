namespace MDBEditor.Pages.Modals;

public partial class FeaturesForm : Form
{
    public Bitmap sourceBitmap { get; set; }
    public PictureBox pictureBox { get; }
    private ImageColorStatus colorStatus = ImageColorStatus.Colored;
    public FeaturesForm(PictureBox pictureBox, ImageInformation imageInformation)
    {
        InitializeComponent();
        this.pictureBox = pictureBox;
        sourceBitmap = (Bitmap)pictureBox.Image;
        Lbl_Image_Name.Text = imageInformation.Name;
        Lbl_Resolution.Text = imageInformation.Resolution.ToString();
        MTxtHorizontal.Text = sourceBitmap.Width.ToString();
        MTxtVertical.Text = sourceBitmap.Height.ToString();
        Btn_Exit.Click += (sender, e) => this.Close();
    }

    private void Btn_Restore_Settings_Click(object sender, EventArgs e)
    {
        MTxtHorizontal.Text = ImageResizeSettings.DefaultHorizontalPixel.ToString();
        MTxtVertical.Text = ImageResizeSettings.DefaultVerticalPixel.ToString();
    }
    private void RB_Grayscale_Click(object sender, EventArgs e)
    {
        colorStatus = ImageColorStatus.Grayscale;
    }

    private void Btn_Apply_Click(object sender, EventArgs e)
    {
        sourceBitmap = sourceBitmap.ResizeBitmap(new Size(
            width: Convert.ToInt16(MTxtHorizontal.Text),
            height: Convert.ToInt16(MTxtVertical.Text)
        ));
        sourceBitmap = colorStatus == ImageColorStatus.Grayscale
            ? sourceBitmap.MakeGrayscale()
            : sourceBitmap;
        Close();
    }
}
