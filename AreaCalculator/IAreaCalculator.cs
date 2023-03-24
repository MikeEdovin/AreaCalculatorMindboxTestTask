using AreaCalculatorProject.MappingObjects;

namespace AreaCalculatorProject
{
    /// <summary>
    /// Calculates the area of the transmitted shape
    /// throw an ArgumentException if the shape with the specified parameters does not exist
    /// uses metric number system
    /// rounds result to the second digit after the dot
    /// Input - object Input(ShapesEnum Type, List<double>args)
    /// Output  - object Output(double Area)
    /// </summary>
    public interface IAreaCalculator
    {
        Output Calculate(Input input);
    }
}
