using GraphQL;
using GraphQL.Http;

using Hades.Data.GraphQl;

using Microsoft.Extensions.DependencyInjection;

namespace Hades.Data
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddHadesDataDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();

            services.AddScoped<IGraphQlService, GraphQlService>();

            return services;
        }
    }
}
