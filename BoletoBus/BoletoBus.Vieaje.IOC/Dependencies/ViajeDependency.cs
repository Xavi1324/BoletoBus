using BoletoBus.Entities.Persistence.Repositories;
using BoletoBus.Viaje.Application.Interfaces;
using BoletoBus.Viaje.Application.Services;
using BoletoBus.Viaje.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Vieaje.IOC.Dependencies
{
    public static class ViajeDependency
    {
        public static void AddViajeDependency(this IServiceCollection sevice)
        {
            sevice.AddScoped<IViajeRepository, ViajeRepository>();

            sevice.AddTransient<IViajeService, ViajeService>();
        }
    }
}
