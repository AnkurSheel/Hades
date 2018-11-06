using GraphQL;
using GraphQL.Http;

using Hades.Core.GraphQl;

using Microsoft.Extensions.DependencyInjection;

namespace Hades.Core
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
