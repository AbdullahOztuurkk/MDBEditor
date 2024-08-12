namespace MDBEditor.Tools.Common;

public interface ISelectAreaTool
{
    public Rectangle SelectedArea { get; set; }
    public Pen Pen { get; }
}
