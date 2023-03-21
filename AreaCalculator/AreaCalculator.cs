using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject
{
    public class AreaCalculator : IAreaCalculator
    {
        public double Calculate(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}