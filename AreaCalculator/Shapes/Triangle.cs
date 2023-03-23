namespace AreaCalculatorProject.Shapes
{
    public class Triangle : Shape
    {
        private List<double> sides;
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1,double side2,double side3 )
        {if (ValidateTriangle(side1,side2,side3))
            {
                Side1= side1;
                Side2= side2;
                Side3= side3;
                sides = new List<double>() { side1,side2,side3 };   
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
            return side1 +side2 > side3 
                && side1 + side3 > side2 
                && side2 + side3 > side1;
        }

        internal bool IsRectangular()
        {
            return Math.Round(sides[2] * sides[2], 1) == Math.Round(sides[0] * sides[0] + sides[1] * sides[1],1) ;
        }
    }
}
