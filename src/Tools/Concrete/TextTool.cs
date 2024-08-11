using MDBEditor.Tools.Interfaces;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MDBEditor.Tools.Concrete;

public class TextTool : ITextTool
{
    public readonly Graphics graphics;

    public TextTool(Graphics graphics)
    {
        this.graphics = graphics;
    }

    public Point Location { get; set; }
    public Font Font { get; set; }
    public string Text { get; set; }
    public float FontSize => (float)Font.Size;

    public FontStyle FontStyle => Font.Style;
    public Color ForeColor { get; set; }
    public Color SideColor { get; set; }

    public void Handle()
    {
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        GraphicsPath path = new GraphicsPath(FillMode.Alternate);

        using (FontFamily fontFamily = new(Font.Name))
        {
            using StringFormat sf = new();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            path.AddString(this.Text, fontFamily,(int)this.FontStyle, this.FontSize, this.Location, sf);
        }

        graphics.FillPath(new SolidBrush(ForeColor), path);
        using Pen pen = new Pen(SideColor);
        graphics.DrawPath(pen, path);
    }
}
