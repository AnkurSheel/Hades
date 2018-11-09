using System.Threading.Tasks;

using GraphQL;
using GraphQL.Http;
using GraphQL.Types;

using Hades.Core.JobApplication;

using Newtonsoft.Json;

namespace Hades.Core.GraphQl
{
    public class GraphQlService : IGraphQlService
    {
        private readonly IDocumentExecuter _executer;

        private readonly IDocumentWriter _writer;

        private readonly ApplicationSummaryQuery _applicationSummaryQuery;

        public GraphQlService(IDocumentExecuter executer, IDocumentWriter writer, ApplicationSummaryQuery applicationSummaryQuery)
        {
            _executer = executer;
            _writer = writer;
            _applicationSummaryQuery = applicationSummaryQuery;
        }

        public async Task<T> ExecuteQuery<T>(GraphQlRequest request)
        {
            var schema = new Schema { Query = _applicationSummaryQuery };

            var queryResult = await _executer.ExecuteAsync(doc =>
                                                           {
                                                               doc.Schema = schema;
                                                               doc.Query = request.Query;

                                                               doc.Inputs = request.Variables.ToInputs();
                                                           })
                                             .ConfigureAwait(false);

            var str = await _writer.WriteToStringAsync(queryResult);
            var result = JsonConvert.DeserializeObject<T>(str);
            return result;
        }
    }
}
