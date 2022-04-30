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
        public Rectangle SelectedRect { get; set; }
        public Pen Pen { get; }
    }
}
