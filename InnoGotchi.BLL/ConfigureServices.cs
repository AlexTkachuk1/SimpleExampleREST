using InnoGotchi.BLL.Interfaces;
using InnoGotchi.BLL.Services.Base;
using Microsoft.Extensions.DependencyInjection;

namespace InnoGotchi.BLL
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddBLLInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IService<,>), typeof(Service<,>));

            return services;
        }
    }
}
