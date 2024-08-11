using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDBEditor.Controls;

/// <summary>
/// Drawing board control
/// </summary>
public class ResizablePictureBox : PictureBox
{
    public ResizablePictureBox()
    {
        ResizeRedraw = true;
    }

    private int grab = 10;

    /// <summary>
    /// Resize form operation
    /// </summary>
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var rc = new Rectangle(ClientSize.Width - grab, ClientSize.Height - grab, grab, grab);
        ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
    }

    /// <summary>
    /// Draw triangle at bottom right of control
    /// </summary>
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == 0x84)
        {  // Trap WM_NCHITTEST
            var pos = PointToClient(new Point(m.LParam.ToInt32()));
            if (pos.X >= ClientSize.Width - grab && pos.Y >= ClientSize.Height - grab)
                m.Result = new IntPtr(17);  // HT_BOTTOMRIGHT
        }
    }
}