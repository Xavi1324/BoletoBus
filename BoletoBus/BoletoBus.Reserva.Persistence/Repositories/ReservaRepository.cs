using BoletoBus.Reserva.Domain.Entities;
using BoletoBus.Reserva.Domain.Interfaces;
using BoletoBus.Reserva.Persistence.Context;
using BoletoBus.Reserva.Persistence.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletoBus.Reserva.Persistence.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly BoletosBusContext context;
        public ReservaRepository(BoletosBusContext context)
        {
            this.context = context;
        }
        
        public bool Exists(Expression<Func<Domain.Entities.Reserva, bool>> filter)
        {
            return this.context.Reserva.Any(filter);
        }

        public List<Domain.Entities.Reserva> GetAll()
        {
            return this.context.Reserva.Select(r => new Domain.Entities.Reserva()
            {
                IdReserva = r.IdReserva,
                IdViaje = r.IdViaje,
                IdPasajero = r.IdPasajero,
                AsientosReservados = r.AsientosReservados,
                MontoTotal = r.MontoTotal,
                FechaCreacion = r.FechaCreacion

            }).ToList();
        }

        public Domain.Entities.Reserva GetEntityBy(int Id)
        {
            var Reserva = this.context.Reserva.Find(Id);
            if (Reserva == null)
            {
                throw new ReservaDbException($"No se encontro reserva");
            }
            Domain.Entities.Reserva reserva = new Domain.Entities.Reserva()
            {
                IdReserva = Reserva.IdReserva,
                IdViaje = Reserva.IdViaje,
                IdPasajero = Reserva.IdPasajero,
                AsientosReservados = Reserva.AsientosReservados,
                MontoTotal = Reserva.MontoTotal,
                FechaCreacion = Reserva.FechaCreacion

            };
            return reserva;
        }

        public List<Domain.Entities.Reserva> GetReservasByIdReserva(int IdReserva)
        {
            return this.context.Reserva.Where(r => r.IdReserva == IdReserva).ToList();
        }

        public void Save(Domain.Entities.Reserva entity)
        {
            
            try
            {
                Domain.Entities.Reserva reserva = new Domain.Entities.Reserva()
                {
                    IdViaje = entity.IdViaje,
                    IdPasajero = entity.IdPasajero,
                    AsientosReservados = entity.AsientosReservados,
                    MontoTotal = entity.MontoTotal,
                    FechaCreacion = entity.FechaCreacion ?? DateTime.Now
                };
                this.context.Reserva.Add(reserva);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the error or throw
                throw new Exception("Error saving reservation", ex);
            }
        }

        public void Updater(Domain.Entities.Reserva entity)
        {
            var reserva = this.context.Reserva.Find(entity.IdReserva);
            reserva.IdViaje = entity.IdViaje;
            reserva.IdPasajero = entity.IdPasajero;
            reserva.MontoTotal = entity.MontoTotal;
            reserva.AsientosReservados = entity.AsientosReservados;
            reserva.FechaCreacion = entity.FechaCreacion ?? reserva.FechaCreacion;

            this.context.Reserva.Update(reserva);
            this.context.SaveChanges();
        }
        public void Delete(Domain.Entities.Reserva entity)
        {
            this.context.Reserva.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
