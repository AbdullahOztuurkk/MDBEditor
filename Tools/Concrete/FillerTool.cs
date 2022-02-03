using MDBEditor.Tools.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Tools.Concrete
{
    public class FillerTool : IFillerTool
    {
        public FillerTool(Bitmap imageCanvas)
        {
            ImageCanvas = imageCanvas;
        }
        private readonly Bitmap ImageCanvas;

        public Color BackColor { get; set; }
        public Point Loc { get; set; }

	    public void Handle()
        {
            //Needs efficiently Flood Fill Algorithm
		}
    }
}
