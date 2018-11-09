using Hades.Core.JobApplication;

namespace Hades.Core.Data
{
    public class JobApplicationStatus
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public int JobApplicationId { get; set; }
    }
}