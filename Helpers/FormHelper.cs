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
        /// <param name="control">Any control like FlowLayoutPanel</param>
        public static void Get_Colors_Into_The_Control(params Control[] controls)
        {
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (Control control in controls)
            {
                foreach (KnownColor knowColor in colors)
                {
                    Color color = Color.FromKnownColor(knowColor);
                    PictureBox pb = new PictureBox()
                    {
                        Size = new Size(20, 20),
                        BackColor = color,
                        BorderStyle = BorderStyle.FixedSingle,
                    };
                    control.Controls.Add(pb);
                }
            }
        }
    }
}
