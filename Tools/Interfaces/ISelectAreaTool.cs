using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Interfaces
{
    public interface ISelectAreaTool
    {
        public Rectangle SelectedRect => new Rectangle(Location, Size);
        public bool IsSelected { get { return Location != null && Size != null; } }
        public Pen Pen { get; }
        public Point Location { get; set; }
        public Size Size { get; set; }
    }
}
