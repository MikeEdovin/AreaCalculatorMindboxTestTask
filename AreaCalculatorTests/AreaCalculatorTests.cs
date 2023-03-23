using AreaCalculatorProject.Factory;
using AreaCalculatorProject.Shapes;
using AreaCalculatorProject;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Theory]
        [InlineData("{\"Type\":\"Circle\",\"Args\":\"{\\\"Radius\\\":10.0}\"}", 314.16)]
        [InlineData("{\"Type\":\"Triangle\",\"Args\":\"{\\\"Side1\\\":2.2,\\\"Side2\\\":2.2,\\\"Side3\\\":2}\"}", 1.96)]
        [InlineData("{\"Type\":\"Triangle\",\"Args\":\"{\\\"Side1\\\":10,\\\"Side2\\\":5,\\\"Side3\\\":11.18}\"}", 25)]
        public void CalculateAreaShouldReturnExpectedValue(string shapeString, double expected)
        {
            IAreaCalculator calculator= new AreaCalculator();
            double area = calculator.Calculate(shapeString);
            Assert.Equal(expected, area);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("{\"Type\":\"Circle\",\"Args\":\"{\"Radius\":10.0}\"}")]
        [InlineData("{\"Type\":\"Triangle\",\"Args\":\"{\\\"Side1\\\":2.2,\\\"Side2\\\":2.2,\\\"Side3\\\":4}\"}")]
        public void CalculateAreaShouldThrowException(string shapeString)
        {
            IAreaCalculator calculator= new AreaCalculator();
            Assert.Throws<ArgumentException>(()=>calculator.Calculate(shapeString));
        }
    }
    
}
