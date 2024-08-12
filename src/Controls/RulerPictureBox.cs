using MDBEditor.Constants.Enums;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDBEditor.Controls;


public class RulerPictureBox : PictureBox
{
    public readonly BoxAlignment boxAlignment;

    public RulerPictureBox() : this(BoxAlignment.Horizontal)
    {

    }

    public RulerPictureBox(BoxAlignment alignment)
    {
        boxAlignment = alignment;
        Dock = alignment == BoxAlignment.Vertical ? DockStyle.Fill : DockStyle.Bottom;
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;

        int height = Height;
        int width = Width;

        if (boxAlignment == BoxAlignment.Vertical)
        {
            graphics.RotateTransform(90);
            graphics.TranslateTransform(0, -Width + 1);
            height = Width;
            width = Height;
        }

        DrawRuler(graphics, width, height);

        base.OnPaint(e);
    }

    private void DrawRuler(Graphics g, int formWidth, int formHeight)
    {
        // Ticks
        for (int i = 0; i < formWidth; i++)
        {
            if (i % 2 == 0)
            {
                int tickHeight;
                if (i % 100 == 0 || i % 50 == 0)
                {
                    tickHeight = 10;
                    DrawTickLabel(g, i.ToString(), i, formHeight, tickHeight);
                }
                else if (i % 10 == 0)
                {
                    tickHeight = 7;
                }
                else
                {
                    tickHeight = 3;
                }

                DrawTick(g, i, formHeight, tickHeight);
            }
        }
    }

    private void DrawTick(Graphics g, int xPos, int formHeight, int tickHeight)
    {
        if (boxAlignment == BoxAlignment.Vertical)
        {
            // Top
            g.DrawLine(Pens.Black, xPos, 0, xPos, tickHeight);
        }
        else if (boxAlignment == BoxAlignment.Horizontal)
        {
            // Bottom
            g.DrawLine(Pens.Black, xPos, formHeight, xPos, formHeight - tickHeight);
        }
    }

    private void DrawTickLabel(Graphics g, string text, int xPos, int formHeight, int height)
    {
        if (boxAlignment == BoxAlignment.Vertical)
        {
            // Top
            g.DrawString(text, DefaultFont, Brushes.Black, xPos, height);
        }
        else if (boxAlignment == BoxAlignment.Horizontal)
        {
            // Bottom
            g.DrawString(text, DefaultFont, Brushes.Black, xPos, formHeight - height - Font.Height);
        }
    }
}
