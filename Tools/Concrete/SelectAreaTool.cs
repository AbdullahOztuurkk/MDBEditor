using MDBEditor.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Tools.Concrete
{
    public class SelectAreaTool : ISelectAreaTool
    {
        public Rectangle SelectedRect => new Rectangle(Location, Size);
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Pen Pen { get; }

        public SelectAreaTool()
        {
            Pen = new Pen(Color.Black, 1.5f);
            Pen.DashStyle = DashStyle.DashDot;
        }
    }
}
