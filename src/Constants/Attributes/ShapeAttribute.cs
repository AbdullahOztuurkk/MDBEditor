namespace MDBEditor.Constants.Attributes;

[AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
public class ShapeAttribute : Attribute
{
    public GeometricalShape Shape => _shape;

    private readonly GeometricalShape _shape;
    public ShapeAttribute(GeometricalShape shape)
    {
        _shape = shape;
    }
}
