namespace MDBEditor.Shapes;

public static class ShapeFactory
{
    public static IShape Create(GeometricalShape shape)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var type = assembly.GetTypes()
            .FirstOrDefault(x => x.GetCustomAttribute<ShapeAttribute>()?.Shape == shape);

        return (IShape?)Activator.CreateInstance(type);
    }
}
