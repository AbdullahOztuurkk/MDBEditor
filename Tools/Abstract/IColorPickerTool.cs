﻿using MDBEditor.Tools.Abstract.General;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MDBEditor.Tools.Abstract
{
    public interface IColorPickerTool:ITool
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public Point Loc { get; set; }
    }
}
