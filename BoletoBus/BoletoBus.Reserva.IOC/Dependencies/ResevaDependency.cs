

using BoletoBus.Reserva.Application.Interfaces;
using BoletoBus.Reserva.Application.Services;
using BoletoBus.Reserva.Domain.Interfaces;
using BoletoBus.Reserva.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Reserva.IOC.Dependencies
{
    public static class ResevaDependency
    {
        public static void addResevaDependecy(this IServiceCollection sevice)
        {
            sevice.AddScoped<IReservaRepository, ReservaRepository>();

            sevice.AddTransient<IReservaService, ReservaService>();
        }
    }
}
