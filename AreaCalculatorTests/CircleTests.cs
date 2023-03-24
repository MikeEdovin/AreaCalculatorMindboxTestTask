using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject.Tests
{
    public class CircleTests
    {
        public static IEnumerable<object[]> ValidateCircleData()
        {
            yield return new object[] { new List<double>() { 10 }, true };
            yield return new object[] { new List<double>() { -2 }, false };
            yield return new object[] { new List<double>() { 1, 1 }, false };
        }

        [Theory]
        [MemberData(nameof(ValidateCircleData))]
        public void ValidateCircleShouldReturnExpectedValue(List<double> args, bool expected)
        {
            var result = Circle.ValidateArgs(args);
            Assert.Equal(expected, result);
        }
        public static IEnumerable<object[]> CircleExceptionData()
        {
            yield return new object[] { new List<double>() { 2, 2 } };
            yield return new object[] { new List<double>() { -1 } };
        }
        [Theory]
        [MemberData(nameof(CircleExceptionData))]
        public void CircleConstructorShoudThrowArgumentException(List<double> args)
        {
            Assert.Throws<ArgumentException>(() => new Circle(args));
        }

        public static IEnumerable<object[]> CalculateAreaData()
        {
            yield return new object[] { new List<double>() { 10 }, 314.16 };
        }
        [Theory]
        [MemberData(nameof(CalculateAreaData))]
        public void CalculateAreaShoulReturnExpectedValue(List<double> args, double expected)
        {
            var area = new Circle(args).CalculateArea();
            Assert.Equal(expected, area);
        }

    }
}
