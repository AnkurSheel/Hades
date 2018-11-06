using System.Threading.Tasks;

using Hades.Core.GraphQl;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

namespace Hades.Web.Features.GraphQl
{
    [Route("api/[controller]")]
    public class GraphQlController : Controller
    {
        private readonly IGraphQlService _graphQlService;

        public GraphQlController(IGraphQlService graphQlService)
        {
            _graphQlService = graphQlService;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] GraphQlRequest request)
        {
            var result = await _graphQlService.ExecuteQuery<JObject>(request);
            return Ok(result);
        }
    }
}
