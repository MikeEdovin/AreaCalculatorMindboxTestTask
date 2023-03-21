using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Shapes
{
   public class Circle:Shape
    {
        private readonly double radius;    
        public Circle(double radius) { this.radius= radius; }

        public override double CalculateArea()
        {
            return Math.PI*Math.Pow(radius, 2);
        }
    }
}
