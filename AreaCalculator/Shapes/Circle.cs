namespace AreaCalculatorProject.Shapes
{
    public class Circle:Shape
    {
        private readonly double radius;    
        public Circle(double radius) { this.radius= radius; }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI*Math.Pow(radius, 2),2);
           
        }
    }
}
