using BoletoBus.Entities.Persistence.Repositories;
using BoletoBus.ReservaDetalle.Application.Interfaces;
using BoletoBus.ReservaDetalle.Application.Services;
using BoletoBus.ReservaDetalle.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.ReservaDetalle.IOC.Dependencies
{
    public static class ReservaDetalleDependency
    {
        public static void addResevaDetalleDependecy(this IServiceCollection sevice)
        {
            sevice.AddScoped<IReservaDetalleRepository, ReservaDetalleRepository>();

            sevice.AddTransient<IReservaDetalleService, ReservaDetalleService>();
        }
    }
}
