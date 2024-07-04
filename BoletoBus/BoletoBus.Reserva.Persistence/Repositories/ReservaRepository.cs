



using BoletoBus.Reserva.Domain.Interfaces;
using System.Linq.Expressions;

namespace BoletoBus.Reserva.Persistence.Repositories
{
    internal class ReservaRepository : IReservaRepository
    {
        public void Delete(Domain.Entities.Reserva entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.Entities.Reserva, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Reserva> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.Entities.Reserva GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entities.Reserva> GetReservasByIdReserva(int IdReserva)
        {
            throw new NotImplementedException();
        }

        public void Save(Domain.Entities.Reserva entity)
        {
            throw new NotImplementedException();
        }

        public void Updater(Domain.Entities.Reserva entity)
        {
            throw new NotImplementedException();
        }
    }
}
