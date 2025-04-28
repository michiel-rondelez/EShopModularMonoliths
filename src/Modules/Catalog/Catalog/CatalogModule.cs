using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddApplicationServices()
            //    .AddInfrastructureServices(configuration)
            //    .AddPersistenceServices(configuration)
            //    .AddApiServices(configuration);

            return services;
        }

        public static IApplicationBuilder UseCatelogModule(this IApplicationBuilder app)
        {
            //app
            //    .UseApplicationServices()
            //    .UseInfrastructureServices()
            //    .UseApiServices();
            return app;
        }
    }
}
