
using BoletoBus.Viaje.Domain.Entities;
using BoletoBus.Viaje.Domain.Interfaces;
using BoletoBus.Viaje.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly BoletosBusContext context;
        public ViajeRepository(BoletosBusContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<Viaje.Domain.Entities.Viaje, bool>> filter)
        {
            return this.context.Viaje.Any(filter);
        }

        public List<Viaje.Domain.Entities.Viaje> GetAll()
        {
            return this.context.Viaje.Select(v => new Viaje.Domain.Entities.Viaje()
            {
                IdViaje = v.IdViaje,
                IdBus = v.IdBus,
                IdRuta = v.IdRuta,
                FechaSalida = v.FechaSalida,
                HoraSalida = v.HoraSalida,
                FechaLlegada = v.FechaLlegada,
                HoraLlegada = v.HoraLlegada,
                Precio = v.Precio,
                TotalAsientos = v.TotalAsientos,
                AsientosReservados = v.AsientosReservados,
                FechaCreacion = v.FechaCreacion,

            }).ToList();
        }

        public Viaje.Domain.Entities.Viaje GetEntityBy(int Id)
        {
            var Viaje = this.context.Viaje.Find(Id);
            Viaje.Domain.Entities.Viaje viaje = new Viaje.Domain.Entities.Viaje()
            {
                IdViaje = Viaje.IdViaje,
                IdBus = Viaje.IdBus,
                IdRuta = Viaje.IdRuta,
                FechaSalida = Viaje.FechaSalida,
                HoraSalida = Viaje.HoraSalida,
                FechaLlegada = Viaje.FechaLlegada,
                HoraLlegada = Viaje.HoraLlegada,
                Precio = Viaje.Precio,
                TotalAsientos = Viaje.TotalAsientos,
                AsientosReservados = Viaje.AsientosReservados,
                FechaCreacion = Viaje.FechaCreacion,
            };
            return viaje;
        }

        public List<Viaje.Domain.Entities.Viaje> GetViajesByIdViaje(int IdViaje)
        {
            return this.context.Viaje.Where(r => r.IdViaje == IdViaje).ToList();
        }

        public void Save(Viaje.Domain.Entities.Viaje entity)
        {
            Viaje.Domain.Entities.Viaje viaje = new Viaje.Domain.Entities.Viaje()
            {
                IdBus = entity.IdBus,
                IdRuta = entity.IdRuta,
                FechaSalida = entity.FechaSalida,
                HoraSalida = entity.HoraSalida,
                FechaLlegada = entity.FechaLlegada,
                HoraLlegada = entity.HoraLlegada,
                Precio = entity.Precio,
                TotalAsientos = entity.TotalAsientos,
                AsientosReservados = entity.AsientosReservados,
                FechaCreacion = entity.FechaCreacion,
            };
            this.context.Viaje.Add(viaje);
            this.context.SaveChanges();
        }

        public void Updater(Viaje.Domain.Entities.Viaje entity)
        {
            Viaje.Domain.Entities.Viaje viajeUpdate = this.context.Viaje.Find(entity.IdViaje);
            viajeUpdate.IdViaje = entity.IdViaje;
            viajeUpdate.IdBus = entity.IdBus;
            viajeUpdate.IdRuta = entity.IdRuta;
            viajeUpdate.FechaSalida = entity.FechaSalida;
            viajeUpdate.HoraSalida = entity.HoraSalida;
            viajeUpdate.FechaLlegada = entity.FechaSalida;
            viajeUpdate.HoraLlegada = entity.HoraLlegada;
            viajeUpdate.Precio = entity.Precio;
            viajeUpdate.TotalAsientos = entity.TotalAsientos;
            viajeUpdate.AsientosReservados = entity.AsientosReservados;
            viajeUpdate.FechaSalida = entity.FechaSalida;
            this.context.Viaje.Update(viajeUpdate);
            this.context.SaveChanges();
        }

        public void Delete(Viaje.Domain.Entities.Viaje entity)
        {
            context.Viaje.Remove(entity);
            context.SaveChanges();
        }
    }
}
