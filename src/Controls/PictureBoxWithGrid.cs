using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MDBEditor.Constants.Global;

namespace MDBEditor.Controls;

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
        Pen p = new Pen(GridSettings.PenForeColor);

        Parallel.For(0, GridSettings.CellLimit, cell =>
        {
            g.DrawLine(p, 0, cell * GridSettings.CellSize, GridSettings.CellLimit * GridSettings.CellSize, cell * GridSettings.CellSize);
        });

        Parallel.For(0, GridSettings.CellLimit, cell =>
        {
            g.DrawLine(p, cell * GridSettings.CellSize, 0, cell * GridSettings.CellSize, GridSettings.CellLimit * GridSettings.CellSize);
        });
    }
}
