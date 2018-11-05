using System.Threading.Tasks;

using Hades.Data.GraphQl;

using Microsoft.AspNetCore.Mvc;

namespace Hades.Web.GraphQl
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
            var json = await _graphQlService.GetData(request);
            return Ok(json);
        }
    }
}
