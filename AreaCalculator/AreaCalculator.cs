using AreaCalculator.Shapes;

namespace AreaCalculator
{
    public class AreaCalculator : ICalculator
    {
        public double Calculate(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}