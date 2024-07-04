

using BoletoBus.Common.Data.Repository;
using BoletoBus.Reserva.Domain.Entities;

namespace BoletoBus.Reserva.Domain.Interfaces
{
    public interface IReservaDetalleRepository : IBaseRepository<Domain.Entities.ReservaDetalle,int>
    {
        List<Domain.Entities.ReservaDetalle> GetReservaDetallesByIdReservaDetalle (int IdReservaDetalle);
    }
}
