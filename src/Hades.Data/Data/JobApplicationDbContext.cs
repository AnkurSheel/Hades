using Hades.Core.JobApplication;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace Hades.Core.Data
{
    public interface IJobApplicationDbContext
    {
        DbSet<JobApplication> JobApplications { get; set; }
    }

    public class JobApplicationDbContext : DbContext, IJobApplicationDbContext
    {
        public static readonly LoggerFactory MyConsoleLoggerFactory = new LoggerFactory(new[]
        {
            new DebugLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
        });

        public JobApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<JobApplication> JobApplications { get; set; }

        public DbSet<JobApplicationStatus> JobApplicationStatusHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JobApplication>()
                        .HasData(new JobApplication
                                 {
                                     Id = 1,
                                     CompanyName = "Company 1",
                                     Date = "20/09/2018 Thursday",
                                     Description =
                                         "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                                 },
                                 new JobApplication
                                 {
                                     Id = 2,
                                     CompanyName = "Company 2",
                                     Date = "20/09/2018 Thursday",
                                     Description =
                                         "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                                 },
                                 new JobApplication
                                 {
                                     Id = 3,
                                     CompanyName = "Company 3",
                                     Date = "20/09/2018 Thursday",
                                     Description =
                                         "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                                 },
                                 new JobApplication
                                 {
                                     Id = 4,
                                     CompanyName = "Company 4",
                                     Date = "20/09/2018 Thursday",
                                     Description =
                                         "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum."
                                 });

            modelBuilder.Entity<JobApplicationStatus>()
                        .HasData(new JobApplicationStatus { Id = 1, Status = Status.Applied, JobApplicationId = 1 },
                                 new JobApplicationStatus { Id = 5, Status = Status.Interview, JobApplicationId = 1 },
                                 new JobApplicationStatus { Id = 2, Status = Status.Interview, JobApplicationId = 2 },
                                 new JobApplicationStatus { Id = 3, Status = Status.Offer, JobApplicationId = 3 },
                                 new JobApplicationStatus { Id = 4, Status = Status.Reject, JobApplicationId = 4 });
        }
    }
}
