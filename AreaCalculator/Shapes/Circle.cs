namespace AreaCalculatorProject.Shapes
{
    internal class Circle:Shape
    {
        private readonly double radius;    
        public Circle(double radius) { this.radius= radius; }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI*radius*radius,2);
           
        }
    }
}
