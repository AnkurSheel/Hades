using System.Collections.Generic;

namespace Hades.Core.Data
{
    public class JobApplication
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Date { get; set; }

        public List<JobApplicationStatus> StatusHistory { get; set; }

        public string Description { get; set; }
    }
}