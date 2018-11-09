using System.Collections.Generic;

namespace Hades.Core.JobApplication
{
    public interface IJobApplicationSummaryDataSource
    {
        IList<JobApplicationSummary> JobApplicationSummaries();

        JobApplicationSummary GetSummaryById(int id);
    }
}