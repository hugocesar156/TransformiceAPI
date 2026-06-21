using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TransformiceAPI.DAL.Repositories;
using TransformiceAPI.Domain.Interfaces;

namespace TransformiceAPI.Ioc
{
    public static class RepositoriesInjections
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
