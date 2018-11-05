using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace Hades.Data.GraphQl
{
    public interface IGraphQlService
    {
        Task<JObject> GetData(GraphQlRequest request);
    }
}