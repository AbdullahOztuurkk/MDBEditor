using MDBEditor.Constants;
using MDBEditor.Helpers;
using MDBEditor.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Tools.Concrete
{
    public class ZoomTool : IZoomTool
    {
        public PictureBox pictureBox { get; set; }
        public Bitmap OriginalImage { get; private set; }
        public Bitmap ZoomedImage { get; private set; }

        public double Size = AppSettings.DEFAULT_ZOOM_SIZE;
        public ZoomTool(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            OriginalImage = (Bitmap)pictureBox.Image;
        }
        public void Handle()
        {
            ZoomedImage = new Bitmap(OriginalImage, 
                width:Convert.ToInt32(OriginalImage.Width * Size), 
                height: Convert.ToInt32(OriginalImage.Height * Size));
            Graphics grap = Graphics.FromImage(ZoomedImage);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        public void ZoomIn()
        {
            if (Size < AppSettings.MAXIMUM_ZOOM_SIZE)
                Size += 0.25;
        }

        public void ZoomOut()
        {
            if (Size > AppSettings.MINIMUM_ZOOM_SIZE)
                Size -= 0.25;
        }

        public void ZoomToNormal()
        {
            pictureBox.Size = new Size(OriginalImage.Width, OriginalImage.Height);
            ZoomedImage = OriginalImage;
        }
    }
}
