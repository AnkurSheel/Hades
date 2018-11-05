using System.Threading.Tasks;

using GraphQL;
using GraphQL.Http;
using GraphQL.Types;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

namespace Hades.Web.GraphQl
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GraphQlController : Controller
    {
        private readonly IDocumentExecuter _executer;

        private readonly IDocumentWriter _writer;

        public GraphQlController(IDocumentExecuter executer, IDocumentWriter writer)
        {
            _executer = executer;
            _writer = writer;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] GraphQlRequest request)
        {
            var schema = new Schema { Query = new ApplicationSummaryQuery() };
            var configure = new ExecutionOptions { Schema = schema, Query = request.Query };

            var result = await _executer.ExecuteAsync(doc =>
                                                      {
                                                          doc.Schema = schema;
                                                          doc.Query = request.Query;
                                                      })
                                        .ConfigureAwait(false);

            var str = await _writer.WriteToStringAsync(result);
            var json = JObject.Parse(str);
            return Ok(json);
        }
    }
}
