namespace AreaCalculatorProject.Shapes
{
    public class Triangle : Shape
    {
        private readonly List<double> sides;

        public Triangle(double side1, double side2, double side3)
        {
            sides= new List<double>() { side1,side2,side3};
            sides.Sort();
        }

        public override double CalculateArea()
        {
            if (IsExist())
            {
                if (IsRectangular())
                {
                    return Math.Round((sides[0] * sides[1]) / 2,2);
                }
                else
                {
                    double halfPerimeter = sides.Sum() / 2;
                    return Math.Round(
                        Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) 
                        * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2])),2);
                }
            }
            else
            {
                throw new ArgumentException("Invalid input. There is no triangle with such a set of side sizes ");
            }
        }
    

        private bool IsExist()
        {
            return ((sides[0] + sides[1]) > sides[2]) && ((sides[0] + sides[2]) > sides[1]) && ((sides[1] + sides[2]) > sides[0]);
        }

        private bool IsRectangular()
        {
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
