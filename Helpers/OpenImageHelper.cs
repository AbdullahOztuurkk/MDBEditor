using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Helpers
{
    public static class OpenImageHelper
    {
        public static void OpenImage(this PictureBox pictureBox, Form form)
        {
            string original_file_name = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "PNG Dosyası |*.png| JPG Dosyası|*.jpg| BMP Dosyası|*.bmp";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    original_file_name = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.LastIndexOf('.'));
                    if (pictureBox.IsNullOrEmpty())
                    {
                        pictureBox.Image = new Bitmap(openFileDialog.FileName);
                        original_file_name = "MDBEditor - " + original_file_name;
                    }
                    else
                    {
                        if (DialogResult.Yes ==
                            MessageBox.Show("There are unsaved changes. Do you still want to open this file?",
                            "Unsaved changes",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            pictureBox.Image = new Bitmap(openFileDialog.FileName);
                            original_file_name = "MDBEditor - " + original_file_name;
                        }
                    }
                }
            }
            form.Text = original_file_name;
        }

        public static void NewImage(this PictureBox pictureBox, Form form)
        {
            if (pictureBox.IsNullOrEmpty())
            {
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height); ;
                form.Text = "MDBEditor - " + "Untitled";
            }
            else
            {
                if (DialogResult.Yes ==
                    MessageBox.Show("There are unsaved changes. Do you still want to open this file?",
                    "Unsaved changes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height); ;
                    form.Text = "MDBEditor - " + "Untitled";
                }
            }
        }
    }
}
