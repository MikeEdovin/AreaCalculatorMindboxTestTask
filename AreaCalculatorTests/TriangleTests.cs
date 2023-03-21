using AreaCalculatorProject.Shapes;
using System.Reflection;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [Fact]
        public void IsExistShouldReturnExpectedValue()
        {
            Shape rectangularTriangle = new Triangle(10, 5, 11.18);
            Shape wrongTriangle = new Triangle(2, 2, 4);
            MethodInfo isExistMethodInfo = typeof(Triangle).GetMethod("IsExist", BindingFlags.Instance | BindingFlags.NonPublic);
            object[] args = {};

            //Assert
            Assert.Equal(true, isExistMethodInfo.Invoke(rectangularTriangle, args));
            Assert.Equal(false, isExistMethodInfo.Invoke(wrongTriangle,args));
        }
        public void IsRectangularShouldReturnExpectedValue()
        {
            Shape rectangularTriangle = new Triangle(10, 5, 11.18);
            Shape notRectangularTriangle = new Triangle(2.2, 2.2, 2);

            MethodInfo isRectangularMethodInfo = typeof(Triangle).GetMethod("IsRectangular", BindingFlags.Instance | BindingFlags.NonPublic);
            object[] args = { };

            //Assert
            Assert.Equal(true, isRectangularMethodInfo.Invoke(rectangularTriangle, args));
            Assert.Equal(true, isRectangularMethodInfo.Invoke(notRectangularTriangle, args));
        }
        [Fact]
        public void CalulateAreaShouldThrowArgumentException()
        {
            Shape wrongTriangle = new Triangle(2, 2, 4);
            Assert.Throws<ArgumentException>(() => wrongTriangle.CalculateArea());
        }

    }
}