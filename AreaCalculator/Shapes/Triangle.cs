using System.Text;

namespace AreaCalculatorProject.Shapes
{
    public class Triangle : Shape
    {
        private List<double> sides;
        public Triangle(List<double>args)
        {
            if (ValidateArgs(args))
            {
                sides = args;
                sides.Sort();
            }
            else
            {
                throw new ArgumentException(GetExceptionMessage(args));
            }
        }

        public override double CalculateArea()
        {
            if (IsRectangular())
            {
                return Math.Round((sides[0] * sides[1]) / 2, 2);
            }
            else
            {
                double halfPerimeter = sides.Sum() / 2;
                return Math.Round(
                    Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0])
                    * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2])), 2);
            }
        }

        internal static bool ValidateArgs(List<double>args)
        {
            if (args.Count != 3) return false;
            foreach(double item in args)
            {
                if(item<=0) return false;
            }
            return args[0] + args[1] > args[2] 
                && args[0] + args[2] > args[1] 
                && args[1] + args[2] > args[0];
        }

        internal static string GetExceptionMessage(List<double> args)
        {
            string message = "Invalid input. There is no triangle with such a set of side sizes ";
            foreach (double item in args)
            {
                message += item + " ";
            }
            message += ".";
            return message;
        }
        internal bool IsRectangular()
        {
            return Math.Round(sides[2] * sides[2], 1) == Math.Round(sides[0] * sides[0] + sides[1] * sides[1],1) ;
        }

    }
}
