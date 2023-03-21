using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject
{
    /// <summary>
    /// Calculates the area of the transmitted shape
    /// may throw an ArgumentException if the shape with the specified parameters does not exist
    /// </summary>
    public interface IAreaCalculator
    {
        double Calculate(Shape shape);
    }
}
