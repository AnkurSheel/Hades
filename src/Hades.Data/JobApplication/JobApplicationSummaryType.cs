using GraphQL.Types;

namespace Hades.Core.JobApplication
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
