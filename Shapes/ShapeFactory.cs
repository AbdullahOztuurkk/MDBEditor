using MDBEditor.Constants.Enums;
using MDBEditor.Shapes.Concrete;

namespace MDBEditor.Shapes
{
    public static class ShapeFactory
    {
        private static Shape desiredShape;
        public static Shape GetShapeBase(GeometricalShape shape)
        {
            switch (shape)
            {
                case GeometricalShape.Left_Arrow:
                    desiredShape = new LeftArrow();
                    break;
                case GeometricalShape.Right_Arrow:
                    desiredShape = new RightArrow();
                    break;
                case GeometricalShape.Triangle:
                    desiredShape = new Triangle();
                    break;
                case GeometricalShape.Pentagon:
                    desiredShape = new Pentagon();
                    break;
                case GeometricalShape.Hexagon:
                    desiredShape = new Hexagon();
                    break;
                case GeometricalShape.Star:
                    desiredShape = new Star();
                    break;
                case GeometricalShape.Six_Pointed_Star:
                    desiredShape = new SixPointedStar();
                    break;
                case GeometricalShape.Rounded_Rectangle:
                    desiredShape = new RoundedRectangle();
                    break;
            }
            return desiredShape;
        }
    }
}
