using AreaCalculatorProject.Shapes;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        public static IEnumerable<object[]> ValidateTriangleData()
        {
            yield return new object[] { new List<double>() { 10, 5, 11.18 }, true };
            yield return new object[] { new List<double>() { 2, 2, 4 }, false };
            yield return new object[] { new List<double>() { 1, 1 }, false };
            yield return new object[] { new List<double>() { -1, 1, 4 }, false };
        }

        [Theory]
        [MemberData(nameof(ValidateTriangleData))]
        public void ValidateTriangleShouldReturnExpectedValue(List<double> args, bool expected)
        {
            var result = Triangle.ValidateArgs(args);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> IsRectangularData()
        {
            yield return new object[] { new List<double>() { 10, 5, 11.18 }, true };
            yield return new object[] { new List<double>() { 2.2, 2, 2.2 }, false };
        }

        [Theory]
        [MemberData(nameof(IsRectangularData))]
        public void IsRectangularShouldReturnExpectedValue(List<double> sides, bool expected)
        {
            var result = new Triangle(sides).IsRectangular();
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> TriangleExceptionData()
        {
            yield return new object[] { new List<double>() { 2, 2, 4 } };
            yield return new object[] { new List<double>() { 1, 1 } };
            yield return new object[] { new List<double>() { -1, 1, 4 } };
        }
        [Theory]
        [MemberData(nameof(TriangleExceptionData))]
        public void TriangleConstructorShoudThrowArgumentException(List<double> args)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(args));
        }

        public static IEnumerable<object[]> CalculateAreaData()
        {
            yield return new object[] { new List<double>() { 10, 5, 11.18 }, 25 };
            yield return new object[] { new List<double>() { 2.2, 2.2, 2 }, 1.96 };
        }
        [Theory]
        [MemberData(nameof(CalculateAreaData))]
        public void CalculateAreaShoulReturnExpectedValue(List<double> args, double expected)
        {
            var area = new Triangle(args).CalculateArea();
            Assert.Equal(expected, area);
        }

    }
}
