using AreaCalculatorProject.Shapes;
using System.Text.Json;

namespace AreaCalculatorProject.Factory
{
    public class ShapeFactory
    {
        public static Shape CreateShapeFromJson(string shapeString)
        {
            try
            {
                Input? input = JsonSerializer.Deserialize<Input>(shapeString);
                string? type = input.Type;
                string? args = input.Args;
                switch (type)
                {
                    case ("Cirlce"):
                        return JsonSerializer.Deserialize<Circle>(args);
                    case ("Triangle"):
                        return JsonSerializer.Deserialize<Triangle>(args);
                    default:
                        return null;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Invalid input. " + e.Message);
            }
        }



    }
}
