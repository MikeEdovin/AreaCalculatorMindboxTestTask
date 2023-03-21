using AreaCalculator.Shapes;
namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateAreaShouldReturnExpectedValue()
        {
            Shape triangle = new Triangle(10,5,11.18);
            Shape triangle2 = new Triangle(2.2, 2, 2.2);
            Shape circle = new Circle(10);

            //Act
            double area = triangle.CalculateArea();
            double area2 = triangle2.CalculateArea();
            double area3=circle.CalculateArea();

            //Assert

            Assert.Equal(25, area);
            Assert.Equal(1.96, area2);
            Assert.Equal(314.16,area3);
        }
        [Fact]
        public void CalculateAreaShouldThrowArgumentException()
        {
            Shape triangle = new Triangle(2, 2, 4);
            //Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }
    }
}