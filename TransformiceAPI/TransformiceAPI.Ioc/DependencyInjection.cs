using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TransformiceAPI.Application.Contexts;
using TransformiceAPI.DAL.Context;

namespace TransformiceAPI.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserContext, UserContext>();

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection") ?? string.Empty));

            services.AddServices(configuration);
            services.AddRepositories(configuration);

            return services;
        }
    }
}
