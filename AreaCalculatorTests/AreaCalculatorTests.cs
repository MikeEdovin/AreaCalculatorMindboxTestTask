using AreaCalculatorProject;
using AreaCalculatorProject.MappingObjects;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject.Tests
{
    public class AreaCalculatorTests
    {
        public static IEnumerable<object[]> CalculateData()
        {
            yield return new object[] { new Input() { Type = ShapesEnum.Circle, Args = new List<double>() { 10 } }, 314.16 };
            yield return new object[] { new Input() { Type = ShapesEnum.Triangle, Args = new List<double>() { 10,5,11.18 } }, 25 };
        }

        [Theory]
        [MemberData(nameof(CalculateData))]
        public void CalculateShouldReturnExpectedValue(Input input, double expected)
        {
            IAreaCalculator calculator= new AreaCalculator();
            Output output = calculator.Calculate(input);
            Assert.Equal(expected, output.Area);
        }
    }
    
}
