using AreaCalculatorProject.Shapes;

namespace AreaCalculatorProject.MappingObjects
{
    public class Input
    {
        public ShapesEnum Type { get; set; }
        public List<double> Args { get; set; }
    }
}
