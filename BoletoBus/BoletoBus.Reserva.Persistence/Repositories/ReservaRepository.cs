using BoletoBus.Reserva.Domain.Interfaces;
using BoletoBus.Reserva.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace BoletoBus.Reserva.Persistence.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly BoletosBusContext context;
        private readonly ILogger<ReservaRepository> logger;
        public ReservaRepository(BoletosBusContext context, ILogger<ReservaRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(Expression<Func<Domain.Entities.Reserva, bool>> filter)
        {
            return context.Reserva.Any(filter);
        }

        public List<Domain.Entities.Reserva> GetAll()
        {
           return context.Reserva.ToList();
        }

        public Domain.Entities.Reserva GetEntityBy(int Id)
        {
            return context.Reserva.Find(Id);
        }

        public List<Domain.Entities.Reserva> GetReservasByIdReserva(int Id)
        {
            return context.Reserva.Where(r => r.id == Id).ToList();
        }

        public void Save(Domain.Entities.Reserva entity)
        {
            try
            {
                this.context.Reserva.Add(entity);
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
            try
            {
                this.context.Reserva.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error updating reservation", ex);
            }
            
        }
        public void Delete(Domain.Entities.Reserva entity)
        {
            this.context.Reserva.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
