using System.Threading.Tasks;

using GraphQL;
using GraphQL.Http;
using GraphQL.Types;

using Hades.Data.JobApplication;

using Newtonsoft.Json.Linq;

namespace Hades.Data.GraphQl
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

        public async Task<JObject> GetData(GraphQlRequest request)
        {
            var schema = new Schema { Query = new ApplicationSummaryQuery() };

            var result = await _executer.ExecuteAsync(doc =>
                                                      {
                                                          doc.Schema = schema;
                                                          doc.Query = request.Query;

                                                          doc.Inputs = request.Variables.ToInputs();
                                                      })
                                        .ConfigureAwait(false);

            var str = await _writer.WriteToStringAsync(result);
            var json = JObject.Parse(str);
            return json;
        }
    }
}
