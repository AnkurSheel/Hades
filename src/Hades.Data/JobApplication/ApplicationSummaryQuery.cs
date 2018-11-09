using GraphQL.Types;

namespace Hades.Core.JobApplication
{
  public class ApplicationSummaryQuery : ObjectGraphType
    {
        public ApplicationSummaryQuery(IJobApplicationSummaryDataSource dataSource)
        {
            Field<JobApplicationSummaryType>("applicationSummary",
                                             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                                             resolve: context =>
                                                      {
                                                          var id = context.GetArgument<int>("id");
                                                          return dataSource.GetSummaryById(id);
                                                      });

            Field<ListGraphType<JobApplicationSummaryType>>("applicationSummaries", resolve: context => dataSource.JobApplicationSummaries());
        }
    }
}
