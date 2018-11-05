﻿using System.Collections.Generic;
using System.Linq;

namespace Hades.Data.JobApplication
{
    public class JobApplicationSummaryDataSource
    {
        public JobApplicationSummaryDataSource()
        {
            JobApplicationSummaries = new List<JobApplicationSummary>
            {
                new JobApplicationSummary
                {
                    Id = 1,
                    CompanyName = "Company 1",
                    Date = "20/09/2018 Thursday",
                    Status = "Applied",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                },
                new JobApplicationSummary
                {
                    Id = 2,
                    CompanyName = "Company 2",
                    Date = "20/09/2018 Thursday",
                    Status = "Applied",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                },
                new JobApplicationSummary
                {
                    Id = 3,
                    CompanyName = "Company 3",
                    Date = "20/09/2018 Thursday",
                    Status = "Applied",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                },
                new JobApplicationSummary
                {
                    Id = 4,
                    CompanyName = "Company 4",
                    Date = "20/09/2018 Thursday",
                    Status = "Applied",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                }
            };
        }

        public IList<JobApplicationSummary> JobApplicationSummaries { get; set; }

        public JobApplicationSummary GetSummaryById(int id)
        {
            return JobApplicationSummaries.First(i => i.Id == id);
        }
    }
}