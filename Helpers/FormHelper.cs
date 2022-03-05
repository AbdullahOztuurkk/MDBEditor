using MDBEditor.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Helpers
{
    public static class FormHelper
    {
        /// <summary>
        /// Get all system colors as pictureboxes to control.
        /// </summary>
        /// <param name="control">Any FlowLayoutPanel</param>
        public static void Get_Colors(this FlowLayoutPanel control)
        {
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor knowColor in colors)
            {
                Color color = Color.FromKnownColor(knowColor);
                PictureBox pb = new PictureBox()
                {
                    Size = new Size(AppSettings.BOX_SIZE, AppSettings.BOX_SIZE),
                    BackColor = color,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                pb.MouseClick += new MouseEventHandler(Set_Color);
                control.Controls.Add(pb);
            }
        }

        private static void Set_Color(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            MasterForm.secondaryColor = MasterForm.primaryColor;
            MasterForm.primaryColor = pictureBox.BackColor;
        }

        /// <summary>
        /// Availability of given picturebox before open new file
        /// </summary>
        /// <param name="pb">Any picturebox</param>
        /// <returns>Availability of given picturebox</returns>
        public static bool IsNullOrEmpty(this PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        /// <summary>
        /// Set image of specified picturebox
        /// </summary>
        /// <param name="pictureBox">Any PictureBox Control</param>
        /// <param name="img">Any Image Object</param>
        public static void SetImage(this PictureBox pictureBox, Image img)
        {
            //pictureBox.Image.Dispose();
            pictureBox.Image = img;
            pictureBox.Invalidate();
        }
    }
}
