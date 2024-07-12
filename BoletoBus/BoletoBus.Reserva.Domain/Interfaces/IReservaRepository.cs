


using BoletoBus.Common.Data.Repository;

namespace BoletoBus.Reserva.Domain.Interfaces
{
    public interface IReservaRepository : IBaseRepository<Domain.Entities.Reserva,int>
    {
        List<Domain.Entities.Reserva> GetReservasByIdReserva(int IdReserva);
        
    }
}
