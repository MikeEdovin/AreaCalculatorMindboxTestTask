namespace AreaCalculatorProject.Shapes
{
    public class Circle:Shape
    {
       public double Radius { get; set; }    
        public Circle(double radius) { Radius= radius; }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI*Radius*Radius,2);
           
        }
    }
}
