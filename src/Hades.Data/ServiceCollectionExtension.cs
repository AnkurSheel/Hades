using GraphQL;
using GraphQL.Http;

using Hades.Core.Data;
using Hades.Core.GraphQl;
using Hades.Core.JobApplication;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hades.Core
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddHadesDataDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();

            services.AddScoped<IGraphQlService, GraphQlService>();
            services.AddScoped<IJobApplicationDbContext, JobApplicationDbContext>();
            services.AddScoped<IJobApplicationSummaryDataSource, JobApplicationSummaryDataSource>();
            services.AddScoped<ApplicationSummaryQuery, ApplicationSummaryQuery>();

            services.AddDbContext<JobApplicationDbContext>(options =>
                options.UseLoggerFactory(JobApplicationDbContext.MyConsoleLoggerFactory)
                       .UseSqlServer(configuration.GetConnectionString("HadesConnection"))
                       .EnableSensitiveDataLogging());

            return services;
        }
    }
}
