using AreaCalculatorProject.MappingObjects;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject.Factory
{
    public class ShapeFactory
    {
        public static Shape CreateShape(Input input)
        {
                ShapesEnum type = input.Type;
                List<double> args = input.Args;
            return type switch
            {
                (ShapesEnum.Circle) => new Circle(args),
                (ShapesEnum.Triangle) => new Triangle(args),
                _ => null,
            };
        }
    }
}
