using GraphQL.Types;

namespace Hades.Core.JobApplication
{
    public class ApplicationSummaryQuery : ObjectGraphType
    {
        public ApplicationSummaryQuery()
        {
            Field<JobApplicationSummaryType>("applicationSummary",
                                             arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }),
                                             resolve: context =>
                                                      {
                                                          var id = context.GetArgument<int>("id");
                                                          return new JobApplicationSummaryDataSource().GetSummaryById(id);
                                                      });
            Field<ListGraphType<JobApplicationSummaryType>>("applicationSummaries",
                                                            resolve: context => new JobApplicationSummaryDataSource().JobApplicationSummaries);
        }
    }
}
