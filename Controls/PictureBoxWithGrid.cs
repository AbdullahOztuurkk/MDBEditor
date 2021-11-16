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
        short CELL_OF_SIZE = 12;
        short NUM_OF_CELLS = 500;
        
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
            short numOfCells = NUM_OF_CELLS;
            short cellSize = CELL_OF_SIZE;
            Pen p = new Pen(Color.LightGray);

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
