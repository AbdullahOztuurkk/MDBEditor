using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Controls
{
    /// <summary>
    /// Drawing board control
    /// </summary>
    public class ResizablePictureBox:PictureBox
    {
        public ResizablePictureBox()
        {
            this.ResizeRedraw = true;
        }

        /// <summary>
        /// Resize form operation  
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var rc = new Rectangle(this.ClientSize.Width - grab, this.ClientSize.Height - grab, grab, grab);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        /// <summary>
        /// Draw triangle at bottom right of control 
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                var pos = this.PointToClient(new Point(m.LParam.ToInt32()));
                if (pos.X >= this.ClientSize.Width - grab && pos.Y >= this.ClientSize.Height - grab)
                    m.Result = new IntPtr(17);  // HT_BOTTOMRIGHT
            }
        }
        private const int grab = 16;
    }
}
