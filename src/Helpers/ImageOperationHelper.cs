﻿using System.Drawing.Imaging;

namespace MDBEditor.Helpers;

public static class ImageOperationHelper
{
    public static readonly ColorMatrix GrayscaleColorMatrix = new ColorMatrix(
            new float[][]
            {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
            });

    public static Bitmap MakeGrayscale(this Bitmap original)
    {
        //create a blank bitmap the same size as original
        Bitmap newBitmap = new Bitmap(original.Width, original.Height);

        //get a graphics object from the new image
        Graphics g = Graphics.FromImage(newBitmap);

        //create some image attributes
        ImageAttributes attributes = new ImageAttributes();

        //set the color matrix attribute
        attributes.SetColorMatrix(GrayscaleColorMatrix);

        //draw the original image on the new image
        //using the grayscale color matrix
        g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
        return newBitmap;
    }
}
