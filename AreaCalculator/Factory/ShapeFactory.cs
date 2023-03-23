using AreaCalculatorProject.Shapes;
using AreaCalculatorProject.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AreaCalculatorProject.Factory;

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
                Console.WriteLine(type+ " "+args);  
                switch (type)
                {
                    case ("Circle"):
                        return JsonSerializer.Deserialize<Circle>(args);
                    case ("Triangle"):
                        return JsonSerializer.Deserialize<Triangle>(args);
                    default:
                        throw new ArgumentException("Invalid input. Input can't be empty. ");
                }
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentException("Invalid input. " + e.Message);
            }
            catch(JsonException e) {
                throw new ArgumentException("Invalid input. " + e.Message);
            }
            catch(NotSupportedException e)
            {
                throw new ArgumentException("Invalid input. "+e.Message);
            }
        }



    }
}
