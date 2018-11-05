using Newtonsoft.Json.Linq;

namespace Hades.Web.GraphQl
{
    public class GraphQlRequest
    {
        public string Query { get; set; }

        public JObject Variables { get; set; }
    }
}