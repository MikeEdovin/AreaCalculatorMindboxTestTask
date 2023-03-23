using AreaCalculatorProject.Shapes;
using AreaCalculatorProject.Factory;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject
{
    public class AreaCalculator : IAreaCalculator
    {
        
        public double Calculate(string shapeString)
        {
            Shape? shape= ShapeFactory.CreateShapeFromJson(shapeString);
            return shape.CalculateArea();
        }
    }
}