using AreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public interface ICalculator
    {
        double Calculate(Shape shape);
    }
}
