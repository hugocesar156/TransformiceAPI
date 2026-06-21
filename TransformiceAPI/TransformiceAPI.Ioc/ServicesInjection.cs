using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TransformiceAPI.Application.Interfaces;
using TransformiceAPI.Application.Services;

namespace TransformiceAPI.Ioc
{
    public static class ServicesInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
