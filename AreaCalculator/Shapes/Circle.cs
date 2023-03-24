namespace AreaCalculatorProject.Shapes
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle(List<double> args)
        {
            if (ValidateArgs(args)) Radius = args[0];
            else throw new ArgumentException(GetExceptionMessage(args));
        }
        public override double CalculateArea(){ return Math.Round(Math.PI*Radius*Radius,2); }
        internal static bool ValidateArgs(List<double> args)
        {
            if (args.Count == 1 && args[0] >= 0) return true;
            return false;
        }
        internal static string GetExceptionMessage(List<double> args)
        {
            string message = "";
            if (args.Count == 0) message = "Invalid input. You didn't pass any arguments.";
            else if (args.Count > 1) message = "Invalid input. You passed more than 1 argument.";
            else message = "Invalid input. There is no circle with radius " + args[0] + " .";
            return message;
        }

    }
}
