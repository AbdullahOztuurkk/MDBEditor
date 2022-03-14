using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Helpers
{
    public static class SaveImageHelper
    {
        private static string FileFilter = String.Empty;
        public static void SaveImage(this PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Select Save Location";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = GetFilter();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch (Path.GetExtension(sfd.FileName).ToLower())
                    {
                        case ".bmp":
                            bmp.Save(sfd.FileName, ImageFormat.Bmp);
                            break;
                        case ".gif":
                            bmp.Save(sfd.FileName, ImageFormat.Gif);
                            break;
                        case ".jpeg":
                            bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                            break;
                        case ".png":
                            bmp.Save(sfd.FileName, ImageFormat.Png);
                            break;
                        case ".tiff":
                            bmp.Save(sfd.FileName, ImageFormat.Tiff);
                            break;
                        case ".wmf":
                            bmp.Save(sfd.FileName, ImageFormat.Wmf);
                            break;
                        case ".ico":
                            bmp.Save(sfd.FileName, ImageFormat.Icon);
                            break;
                    }
                }
            }
        }

        public static void SaveImage(this PictureBox pictureBox,ImageFormat format)
        {
            Bitmap bmp = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);

            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Select Save Location";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = GetFilter(format);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(sfd.FileName, format);
                }
            }            
        }

        private static string GetFilter()
        {
            FileFilter = "Bitmap Image (.bmp)|*.bmp|"
                         + "Gif Image (.gif)|*.gif|"
                         + "JPEG Image (.jpeg)|*.jpeg|"
                         + "Png Image (.png)|*.png|"
                         + "Tiff Image (.tiff)|*.tiff|"
                         + "Icon (.ico)|*.ico|"
                         + "Wmf Image (.wmf)|*.wmf";
            return FileFilter;
        }
        private static string GetFilter(ImageFormat imageFormat)
        {
            switch (imageFormat.ToString())
            {
                case "Png":
                    FileFilter = "Png Image (.png)|*.png";
                    break;
                case "Bmp":
                    FileFilter = "Bitmap Image (.bmp)|*.bmp";
                    break;
                case "Gif":
                    FileFilter = "Gif Image (.gif)|*.gif";
                    break;
                case "Jpeg":
                    FileFilter = "JPEG Image (.jpeg)|*.jpeg";
                    break;
                case "Tiff":
                    FileFilter = "Tiff Image (.tiff)|*.tiff";
                    break;
                case "Wmf":
                    FileFilter = "Wmf Image (.wmf)|*.wmf";
                    break;
                case "Icon":
                    FileFilter = "Icon (.ico)|*.ico";
                    break;
                }

            return FileFilter;
        }

    }
}
