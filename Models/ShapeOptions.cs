using MDBEditor.Constants.Enums;
using System.Collections.Generic;

namespace MDBEditor.Models
{
    public static class ShapeOptions
    {
        private static Dictionary<ShapeBorderStatus, float> StatusSize = new Dictionary<ShapeBorderStatus, float>
        {
            { ShapeBorderStatus.VerySmall, 1f },
            { ShapeBorderStatus.Smaller, 2f },
            { ShapeBorderStatus.Small, 3.5f },
            { ShapeBorderStatus.Normal, 5f },
            { ShapeBorderStatus.Big, 6.5f },
            { ShapeBorderStatus.Bigger, 8f },
            { ShapeBorderStatus.VeryBig,  9f },
        };

        public static bool IsFilled { get; set; } = false;
        public static ShapeBorderStatus BorderStatus { get; set; } = ShapeBorderStatus.Normal;
        public static float BorderSize => StatusSize[BorderStatus];
    }
}
