using System.Drawing;

namespace MDBEditor.Tools.Interfaces;

public interface ISelectAreaTool
{
    public Rectangle SelectedArea { get; set; }
    public Pen Pen { get; }
}
