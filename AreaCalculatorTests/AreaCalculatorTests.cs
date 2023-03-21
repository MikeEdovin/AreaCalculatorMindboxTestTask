using AreaCalculatorProject;
using AreaCalculatorProject.Shapes;

namespace AreaCalculatorTests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateShouldReturnExpectedValue()
        {
            IAreaCalculator calculator= new AreaCalculator();

            //Act
            double area = calculator.Calculate(new Triangle(2.2, 2.2, 2));
            double area2 = calculator.Calculate(new Triangle(10, 5, 11.18));
            double area3 = calculator.Calculate(new Circle(10));

            //Assert
            Assert.Equal(1.96, area);
            Assert.Equal(25, area2);
            Assert.Equal(314.16, area3);

        }
        [Fact]
        public void CalculateAreaShouldThrowArgumentException()
        {
            IAreaCalculator calculator = new AreaCalculator();
 
            //Assert
            Assert.Throws<ArgumentException>(() =>calculator.Calculate(new Triangle(2, 2, 4)));
        }
    }
}
