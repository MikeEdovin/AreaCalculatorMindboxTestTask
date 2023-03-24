using AreaCalculatorProject.Factory;
using AreaCalculatorProject.MappingObjects;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject
{
    public class AreaCalculator : IAreaCalculator
    {
        public Output Calculate(Input input)
        {
            Shape shape= ShapeFactory.CreateShape(input);
            return new Output() { Area = shape.CalculateArea() };
        }
    }
}