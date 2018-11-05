using GraphQL.Types;

namespace Hades.Web.GraphQl
{
    public class ApplicationSummaryQuery : ObjectGraphType
    {
        public ApplicationSummaryQuery()
        {
            Field<ListGraphType<JobApplicationSummaryType>>("applicationSummaries",
                                                            resolve: context => new JobApplicationSummaryDataSource().JobApplicationSummaries);
        }
    }
}
