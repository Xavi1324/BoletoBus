using BoletoBus.Ruta.Domain.Interfaces;
using BoletoBus.Ruta.Application.Interfaces;
using BoletoBus.Ruta.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using BoletoBus.Entities.Persistence.Repositories;

namespace BoletoBus.Ruta.IOC.Dependecies
{
    public static class RutaDependency
    {
        public static void addRutaDependency(this IServiceCollection sevice)
        {
            sevice.AddScoped<IRutaRepository, RutaRepository>();

            sevice.AddTransient<IRutaService, RutaService>();
        }
    }
}
