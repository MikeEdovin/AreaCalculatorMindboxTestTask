using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject
{
    /// <summary>
    /// Calculates the area of the transmitted shape
    /// throw an ArgumentException if the shape with the specified parameters does not exist
    /// uses metric number system
    /// rounds result to the second digit after the dot
    /// </summary>
    public interface IAreaCalculator
    {
        double Calculate(Shape shape);
    }
}
