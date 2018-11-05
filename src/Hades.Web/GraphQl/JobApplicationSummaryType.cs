using GraphQL.Types;

using Hades.Web.Features.JobApplication;

namespace Hades.Web.GraphQl
{
    public class JobApplicationSummaryType : ObjectGraphType<JobApplicationSummary>
    {
        public JobApplicationSummaryType()
        {
            Field(i => i.Id);
            Field(i => i.CompanyName);
            Field(i => i.Date);
            Field(i => i.Description);
            Field(i => i.Status);
        }
    }
}
