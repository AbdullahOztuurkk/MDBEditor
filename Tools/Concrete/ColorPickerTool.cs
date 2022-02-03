using MDBEditor.Tools.Abstract;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor.Tools.Concrete
{
    public class ColorPickerTool:IColorPickerTool
    {
        public ColorPickerTool(PictureBox pictureBox)
        {
            //Graphics = pictureBox.CreateGraphics();
            PictureBox = pictureBox;
        }
        //public readonly Graphics Graphics;
        public readonly PictureBox PictureBox;

        public Point Loc { get; set; }
        public Color DetectedColor { private set; get; }

        private Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(PictureBox.PointToScreen(Loc), new Point(0, 0), bmp.Size);
            }
            return bmp.GetPixel(0, 0);    
        }

        public void Handle()
        {
            DetectedColor = GetColorAt(Loc.X, Loc.Y);
        }

    }
}
