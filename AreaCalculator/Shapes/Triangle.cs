namespace AreaCalculatorProject.Shapes
{
    internal class Triangle : Shape
    {
        private readonly List<double> sides;

        public Triangle(double side1, double side2, double side3)
        {if (ValidateTriangle(side1, side2, side3))
            {
                sides = new List<double>() { side1, side2, side3 };
                sides.Sort();
            }
            else
            {
                throw new ArgumentException("Invalid input. There is no triangle with such a set of side sizes ");
            }
        }

        public override double CalculateArea()
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
        
    

        internal static bool ValidateTriangle(double side1, double side2, double side3)
        {
            return side1+side2 > side3 && side1+side3 > side2 && side2+side3 > side1;
        }

        internal bool IsRectangular()
        {
            return Math.Round(sides[2] * sides[2], 1) == Math.Round(sides[0] * sides[0] + sides[1] * sides[1],1) ;
        }

        internal List<double> ShowArray()
        {
            return sides;
        }
    }
}
