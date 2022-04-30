using MDBEditor.Constants.Enums;
using MDBEditor.Shapes.Concrete;
using MDBEditor.Shapes.Interfaces;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace MDBEditor.Shapes
{
    public static class ShapeFactory
    {
        public static IShape Create(GeometricalShape shape)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == shape.ToString());

            return (IShape)Activator.CreateInstance(type);
        }
    }
}
