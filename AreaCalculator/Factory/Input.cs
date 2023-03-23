using System.Text.Encodings.Web;
using System.Text.Json;

namespace AreaCalculatorProject.Factory
{
    public class Input
    {
        public string Type { get; set; }
        public string Args { get; set; }
        public string GetJsonInput()
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping

            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
