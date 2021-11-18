using MDBEditor.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Controls
{
    public class PictureBoxWithGrid : PictureBox
    {   
        public PictureBoxWithGrid(Size size)
        {
            this.Size = size;
            this.BackColor = Color.Transparent;
            this.Enabled = false;
            this.Dock = DockStyle.Fill;
            this.Visible = false;
        }
        /// <summary>
        /// Draw grid lines on picture box
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            short numOfCells    = AppSettings.CELL_OF_SIZE;
            short cellSize      = AppSettings.NUM_OF_CELLS;
            Pen p = new Pen(AppSettings.PEN_FORECOLOR);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }
    }
}
