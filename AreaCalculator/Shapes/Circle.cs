namespace AreaCalculatorProject.Shapes
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle(List<double> args)
        {
            if (ValidateArgs(args)) Radius = args[0];
            else throw new ArgumentException("Invalid Input. There is no circle with radius " + args[0] + " .");
        }
        public override double CalculateArea(){ return Math.Round(Math.PI*Radius*Radius,2); }
        internal static bool ValidateArgs(List<double> args)
        {
            if (args.Count == 1 && args[0] >= 0) return true;
            return false;
        }

    }
}
