using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt =>
            {
               opt.UseNpgsql(configuration.GetSection("Database:DefaultConnection").Value, cfg =>
               {
                   cfg.MigrationsAssembly("Infrastructure");
               });
            });

            return services;
        }
    }
}
