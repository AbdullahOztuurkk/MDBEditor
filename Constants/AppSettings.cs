using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Constants
{
    /// <summary>
    /// Customizable all options in program
    /// </summary>
    public static class AppSettings
    {
        //Color settings in Menu
        public static readonly short BOX_SIZE = 20;
        public static readonly Color DEFAULT_TOOL_COLOR = SystemColors.Control;
        public static readonly Color CURRENT_TOOL_COLOR = SystemColors.ControlLight;

        //Grid settings
        public static readonly short CELL_OF_SIZE = 12;
        public static readonly short NUM_OF_CELLS = 500;
        public static readonly Color PEN_FORECOLOR = Color.LightGray;

        //Drawing tools settings
        public static readonly short MINIMUM_TOOL_SIZE = 2;
        public static readonly short DEFAULT_TOOL_SIZE = 4; 
        public static readonly short MAXIMUM_TOOL_SIZE = 15; 

        //Resize Coordinates
        public static readonly Point OLD_DRAWING_BOARD_COORDINATE = new Point(12, 9);
        public static readonly Point NEW_DRAWING_BOARD_COORDINATE = new Point(32, 28);
        public static readonly Size RULER_CLOSED_COORDINATE = new Size(1098, 772);
        public static readonly Size RULER_OPENED_COORDINATE = new Size(1116, 791);

        //Resize Options
        public static readonly short MAXIMUM_RESIZE_PERCENTAGE = 1000;
        public static readonly short MAXIMUM_RESIZE_PIXEL = 5000;
        public static readonly short DEFAULT_HORIZONTAL_PIXEL = 1152;
        public static readonly short DEFAULT_VERTICAL_PIXEL = 648;


        //Zoom options
        public static readonly double MAXIMUM_ZOOM_SIZE = 2;
        public static readonly double DEFAULT_ZOOM_SIZE = 1;
        public static readonly double MINIMUM_ZOOM_SIZE = 0.5;
    }
}
