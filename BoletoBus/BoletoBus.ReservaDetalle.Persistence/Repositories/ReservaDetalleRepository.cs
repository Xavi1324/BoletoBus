using BoletoBus.ReservaDetalle.Domain.Interfaces;
using BoletoBus.ReservaDetalle.Persistence.Context;
using BusMonoliticApp.Web.Data.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ReservaDetalleRepository : IReservaDetalleRepository
    {
        private readonly BoletosBusContext context;

        public ReservaDetalleRepository(BoletosBusContext context)
        {
            this.context = context;
        }

        public bool Exists(Expression<Func<ReservaDetalle.Domain.Entities.ReservaDetalle, bool>> filter)
        {
            return this.context.ReservaDetalle.Any(filter);
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetAll()
        {
            return this.context.ReservaDetalle.Select(rd => new ReservaDetalle.Domain.Entities.ReservaDetalle()
            {
                IdReservaDetalle = rd.IdReservaDetalle,
                IdReserva = rd.IdReserva,
                IdAsiento = rd.IdAsiento,
                FechaCreacion = rd.FechaCreacion,
            }).ToList();
        }

        public ReservaDetalle.Domain.Entities.ReservaDetalle GetEntityBy(int Id)
        {
            var ReservaDetalle = this.context.ReservaDetalle.Find(Id);
            ReservaDetalle.Domain.Entities.ReservaDetalle reservaDetalle = new ReservaDetalle.Domain.Entities.ReservaDetalle()
            {
                IdReservaDetalle = ReservaDetalle.IdReservaDetalle,
                IdReserva = ReservaDetalle.IdReserva,
                IdAsiento = ReservaDetalle.IdAsiento,
                FechaCreacion = ReservaDetalle.FechaCreacion
            };
            return reservaDetalle;
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetReservaDetallesByIdReservaDetalle(int IdReservaDetalle)
        {
            return this.context.ReservaDetalle.Where(r => r.IdReservaDetalle == IdReservaDetalle).ToList();
        }

        public void Save(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            ReservaDetalle.Domain.Entities.ReservaDetalle reservaDetalle = new ReservaDetalle.Domain.Entities.ReservaDetalle()
            {
                IdReserva = entity.IdReserva,
                IdAsiento = entity.IdAsiento,
                FechaCreacion = entity.FechaCreacion,
            };
            this.context.ReservaDetalle.Add(reservaDetalle);
            this.context.SaveChanges();
            
            
            
        }

        public void Updater(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            ReservaDetalle.Domain.Entities.ReservaDetalle reservaDetalleUpdate = this.context.ReservaDetalle.Find(entity.IdReservaDetalle);
            reservaDetalleUpdate.IdReservaDetalle = entity.IdReservaDetalle;
            reservaDetalleUpdate.IdReserva = entity.IdReserva;
            reservaDetalleUpdate.IdAsiento = entity.IdAsiento;
            reservaDetalleUpdate.FechaCreacion = entity.FechaCreacion;
            this.context.ReservaDetalle.Update(reservaDetalleUpdate);
            this.context.SaveChanges();
        }

        public void Delete(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            this.context.ReservaDetalle.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
