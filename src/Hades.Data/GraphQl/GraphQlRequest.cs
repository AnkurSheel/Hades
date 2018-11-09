using Newtonsoft.Json.Linq;

namespace Hades.Core.GraphQl
{
    public class GraphQlRequest
    {
        public string Query { get; set; }

        public JObject Variables { get; set; }
    }
}
