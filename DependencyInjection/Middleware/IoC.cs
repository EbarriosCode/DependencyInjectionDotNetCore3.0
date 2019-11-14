using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // Inyectar el servicio de Albumes
            services.AddTransient<IAlbumesService, AlbumesService>();            

            return services;
        }
    }
}
