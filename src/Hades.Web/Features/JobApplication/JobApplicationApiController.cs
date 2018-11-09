using System.Collections.Generic;
using System.Threading.Tasks;

using Hades.Core.GraphQl;
using Hades.Core.JobApplication;
using Hades.Web.Features.GraphQl;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

namespace Hades.Web.Features.JobApplication
{
    [Route("api/[controller]")]
    public class JobApplicationApiController : Controller
    {
        private readonly IGraphQlService _graphQlService;

        public JobApplicationApiController(IGraphQlService graphQlService)
        {
            _graphQlService = graphQlService;
        }

        [Route("list")]
        public async Task<IActionResult> ApplicationListAsync()
        {
            const string QueryName = "applicationSummaries";
            var request = new GraphQlRequest
            {
                Query = $@"
query {{
  {QueryName} {{
    id
    companyName
    status
    date
    description
  }}
}}
"
            };
            GraphQlResponse<JObject> result = await _graphQlService.ExecuteQuery<GraphQlResponse<JObject>>(request);
            var jobApplicationSummaries = result.Data[QueryName]
                                                .ToObject<List<JobApplicationSummary>>();

            return Ok(jobApplicationSummaries);
        }
    }
}
