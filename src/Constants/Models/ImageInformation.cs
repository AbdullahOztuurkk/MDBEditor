namespace MDBEditor.Constants.Models;

public class ImageInformation
{
    public string Name { get; }
    public int Resolution { get; }

    public ImageInformation(string name, int resolution)
    {
        Name = name;
        Resolution = resolution;
    }

    public ImageInformation(int resolution) : this("Unknown", resolution) { }
}
