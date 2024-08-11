using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;

namespace MDBEditor.Constants;

/// <summary>
/// Customizable all options in program
/// </summary>
public static class Global
{
    public static readonly string ApplicationName = Assembly.GetExecutingAssembly().GetName().Name;

    public static class MenuSettings
    {
        public const short BOX_SIZE = 20;
        public static readonly Color DefaultToolColor = SystemColors.Control;
        public static readonly Color CurrentToolColor = SystemColors.ControlLight;
    }

    public static class GridSettings
    {
        public const short CellSize = 12;
        public const short CellLimit = 500;
        public static readonly Color PenForeColor = Color.LightGray;
    }

    public static class BrushSettings
    {
        public const short MinimumToolSize = 2;
        public const short DefaultToolSize = 4;
        public const short MaximumToolSize = 15;
    }

    public static class BuiltInCoordinates
    {
        public static readonly Point OldDrawingBoardCoordinate = new Point(12, 9);
        public static readonly Point NewDrawingBoardCoordinate = new Point(32, 28);
        public static readonly Size RulerClosedCoordinate = new Size(1098, 772);
        public static readonly Size RulerOpenedCoordinate = new Size(1116, 791);
    }

    public static class ImageResizeSettings
    {
        public const short MaximumResizePercentageLimit = 1000;
        public const short MaximumResizePixelLimit = 5000;
        public const short DefaultHorizontalPixel = 1152;
        public const short DefaultVerticalPixel = 648;
    }

    public static class ZoomSettings
    {
        public const double MaximumZoomSize = 2;
        public const double DefaultZoomSize = 1;
        public const double MinimumZoomSize = 0.5;
    }

    public static class FileSettings
    {
        public const string OpenFileFilter = "PNG File |*.png| JPG File |*.jpg| BMP File |*.bmp";
        private static Dictionary<ImageFormat,string> _fileFilter = new Dictionary<ImageFormat,string>
        {
            { ImageFormat.Png, "Png Image (.png)|*.png" },
            { ImageFormat.Bmp, "Bitmap Image (.bmp)|*.bmp" },
            { ImageFormat.Gif , "Gif Image (.gif)|*.gif" },
            { ImageFormat.Jpeg, "JPEG Image (.jpeg)|*.jpeg" },
            { ImageFormat.Tiff, "Tiff Image (.tiff)|*.tiff" },
            { ImageFormat.Icon, "Icon (.ico)|*.ico" },
            { ImageFormat.Wmf , "Wmf Image (.wmf)|*.wmf"}
        };
        public static readonly ReadOnlyDictionary<ImageFormat,string> FileFilterDictionary = new ReadOnlyDictionary<ImageFormat, string>(_fileFilter);
    }
}
