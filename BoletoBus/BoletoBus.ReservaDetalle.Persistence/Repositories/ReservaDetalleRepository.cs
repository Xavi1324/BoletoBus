using BoletoBus.ReservaDetalle.Domain.Interfaces;
using BoletoBus.ReservaDetalle.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace BoletoBus.Entities.Persistence.Repositories
{
    public class ReservaDetalleRepository : IReservaDetalleRepository
    {
        private readonly BoletosBusContext context;
        private readonly ILogger<ReservaDetalleRepository> logger;

        public ReservaDetalleRepository(BoletosBusContext context, ILogger<ReservaDetalleRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(Expression<Func<ReservaDetalle.Domain.Entities.ReservaDetalle, bool>> filter)
        {
            return context.ReservaDetalle.Any(filter);
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetAll()
        {
            return context.ReservaDetalle.ToList();
            
        }

        public ReservaDetalle.Domain.Entities.ReservaDetalle GetEntityBy(int Id)
        {
             return context.ReservaDetalle.Find(Id);
            
        }

        public List<ReservaDetalle.Domain.Entities.ReservaDetalle> GetReservaDetallesByIdReservaDetalle(int Id)
        {
            return this.context.ReservaDetalle.Where(rd => rd.id == Id).ToList();
        }

        public void Save(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            try
            {
                this.context.ReservaDetalle.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving details", ex);
            }
        }

        public void Updater(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            try
            {
                this.context.ReservaDetalle.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception ("Error updating details", ex);
            }
        }

        public void Delete(ReservaDetalle.Domain.Entities.ReservaDetalle entity)
        {
            this.context.ReservaDetalle.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
