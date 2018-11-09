using System;
using System.Collections.Generic;
using System.Linq;

using Hades.Core.Data;

using Microsoft.EntityFrameworkCore;

namespace Hades.Core.JobApplication
{
    public class JobApplicationSummaryDataSource : IJobApplicationSummaryDataSource
    {
        private readonly IJobApplicationDbContext _jobApplicationDbContext;

        public JobApplicationSummaryDataSource(IJobApplicationDbContext jobApplicationDbContext)
        {
            _jobApplicationDbContext = jobApplicationDbContext;
        }

        public IList<JobApplicationSummary> JobApplicationSummaries()
        {
            var data = _jobApplicationDbContext.JobApplications.Include(s => s.StatusHistory).ToList();
            return data.Select(x => new JobApplicationSummary
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                Date = x.Date,
                Description = x.Description,
                Status = x.StatusHistory.First().Status.ToString()
            }).ToList();
        }

        public JobApplicationSummary GetSummaryById(int id)
        {
            var data = _jobApplicationDbContext.JobApplications.First(i => i.Id == id);
            return new JobApplicationSummary
            {
                Id = data.Id,
                CompanyName = data.CompanyName,
                Date = data.Date,
                Description = data.Description,
                Status = "Applied"
            };
        }
    }
}
