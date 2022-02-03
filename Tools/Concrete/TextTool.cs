using MDBEditor.Tools.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Concrete
{
    public class TextTool : ITextTool
    {
        public readonly Graphics graphics;

        public TextTool(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Point Loc { get; set; }
        public Font Font { get; set; }
        public String Text { get; set; }
        public float Size => (float)Font.Size;

        public FontStyle FontStyle => Font.Style;
        public Color ForeColor { get; set; }
        public Color SideColor { get; set; }

        public void Handle()
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath(FillMode.Alternate);

            using (FontFamily fontFamily = new FontFamily(Font.Name))
            {
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    path.AddString(this.Text, fontFamily,
                        (int)this.FontStyle, this.Size,
                        this.Loc, sf);
                }
            }

            graphics.FillPath(new SolidBrush(ForeColor), path);
            using (Pen pen = new Pen(SideColor))
            {
                graphics.DrawPath(pen, path);
            }
        }
    }
}
