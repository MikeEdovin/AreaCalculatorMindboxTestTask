using AreaCalculatorProject.Shapes;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit.Abstractions;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(10, 5, 11.18, true)]
        [InlineData(2, 2, 4, false)]
        public void ValidateTriangleShouldReturnExpectedValue(double side1, double side2, double side3, bool expected)
        {
            var result = Triangle.ValidateTriangle(side1, side2, side3);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 5, 11.18, true)]
        [InlineData(2.2, 2, 2.2, false)]
        public void IsRectangularShouldReturnExpectedValue(double side1, double side2, double side3, bool expected)
        {
            var result = new Triangle(side1, side2, side3).IsRectangular();
            Assert.Equal(expected,result);
        }
        [Fact]
        public void TriangleConstructorShoudThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 4));
        }

    }
}
