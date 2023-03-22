using AreaCalculatorProject;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Theory]
        [InlineData(2.2, 2.2, 2,1.96)]
        [InlineData(10, 5, 11.18,25)]
        public void TriangleCalculateAreaShouldReturnExpectedValue(double side1, double side2, double side3, double expected)
        {
            IAreaCalculator calculator= new AreaCalculator();
            double area = calculator.Calculate(new Triangle(side1,side2,side3));
            Assert.Equal(expected, area);
        }
        [Theory]
        [InlineData(10,314.16)]
        public void CircleCalculateAreaShouldReturnExpectedValue(double radius,double expected)
        {
            IAreaCalculator calculator = new AreaCalculator();
            double area = calculator.Calculate(new Circle(radius));
            Assert.Equal(expected, area);
        }
        
    }
}
