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

        public GraphQlService(IDocumentExecuter executer, IDocumentWriter writer)
        {
            _executer = executer;
            _writer = writer;
        }

        public async Task<T> ExecuteQuery<T>(GraphQlRequest request)
        {
            var schema = new Schema { Query = new ApplicationSummaryQuery() };

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
