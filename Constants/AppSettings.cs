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
    public class AppSettings
    {
        //Color settings in Menu
        public static readonly short BOX_SIZE = 20;
        public static readonly Color DEFAULT_TOOL_COLOR = SystemColors.Control;
        public static readonly Color CURRENT_TOOL_COLOR = SystemColors.ControlLight;

        //Grid settings
        public static readonly short CELL_OF_SIZE = 12;
        public static readonly short NUM_OF_CELLS = 500;
        public static readonly Color PEN_FORECOLOR = Color.LightGray;

        //Drawing board settings
        public static readonly int CORNER = 16;
    }
}
