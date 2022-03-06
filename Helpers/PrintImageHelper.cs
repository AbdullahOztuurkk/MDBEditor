using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Helpers
{
    public static class PrintImageHelper
    {
        public static void PrintImage(this PictureBox pictureBox)
        {
            using PrintDialog PrintDialog = new PrintDialog();
            using PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) => Print_PictureBox(sender, e, pictureBox);
            PrintDialog.Document = printDocument;
            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private static void Print_PictureBox(object sender, PrintPageEventArgs e, PictureBox pictureBox)
        {
            using Bitmap currentBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(currentBitmap, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            e.Graphics.DrawImage(currentBitmap, 0, 0);
            currentBitmap.Dispose();
        }
    }
}
