using MDBEditor.Constants;
using MDBEditor.Constants.Enums;
using MDBEditor.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor.Pages.Modals;

public partial class ResizeForm : Form
{
    public PictureBox picturebox { get; set; }
    public Bitmap sourceBitmap { get; private set; }
    private ResizeOptions resizeOptions { get; set; }
    private int horizontalValue, verticalValue;
    public ResizeForm(PictureBox pictureBox)
    {
        InitializeComponent();
        picturebox = pictureBox;
        sourceBitmap = (Bitmap)(picturebox.Image);
        RB_Pixel.Checked = true;
        NUD_Horizontal.Value = sourceBitmap.Width;
        NUD_Vertical.Value = sourceBitmap.Height;
        Btn_Exit.Click += (sender, e) => Close();

    }

    private void Apply_Resize(object sender, EventArgs e)
    {
        switch (resizeOptions)
        {
            case ResizeOptions.Percentage:
                sourceBitmap = ResizeImageHelper.ScaleByPercent(sourceBitmap, new Size(
                   width: horizontalValue,
                   height: verticalValue));
                break;
            case ResizeOptions.Pixel:
                sourceBitmap = ResizeImageHelper.ResizeBitmap(sourceBitmap, new Size(
                   width: horizontalValue,
                   height: verticalValue));
                break;
        }
        Close();
    }

    private void RB_Percentage_CheckedChanged(object sender, EventArgs e)
    {
        resizeOptions = ResizeOptions.Percentage;
        NUD_Horizontal.Maximum = Global.ImageResizeSettings.MaximumResizePercentageLimit;
        NUD_Vertical.Maximum = Global.ImageResizeSettings.MaximumResizePercentageLimit;
        NUD_Horizontal.Value = 100;
        NUD_Vertical.Value = 100;
    }

    private void RB_Pixel_CheckedChanged(object sender, EventArgs e)
    {
        resizeOptions = ResizeOptions.Pixel;
        NUD_Horizontal.Maximum = Global.ImageResizeSettings.MaximumResizePixelLimit;
        NUD_Vertical.Maximum = Global.ImageResizeSettings.MaximumResizePixelLimit;
        NUD_Horizontal.Value = sourceBitmap.Width;
        NUD_Vertical.Value = sourceBitmap.Height;
    }

    private void Value_Changed(object sender, EventArgs e)
    {
        NumericUpDown? NUD_Sender = sender as NumericUpDown;
        if (NUD_Sender.Value > 0)
        {
            if (CB_Keep_Aspect_Ratio.Checked)
            {
                NUD_Horizontal.Value = NUD_Sender.Value;
                NUD_Vertical.Value = NUD_Sender.Value;
                horizontalValue = Convert.ToInt16(NUD_Sender.Value);
                verticalValue = Convert.ToInt16(NUD_Sender.Value);
            }
            else
            {
                switch (NUD_Sender.Name)
                {
                    case nameof(NUD_Horizontal): horizontalValue = Convert.ToInt16(NUD_Horizontal.Value); break;
                    case nameof(NUD_Vertical): verticalValue = Convert.ToInt16(NUD_Vertical.Value); break;
                }
            }
        }
    }
}
