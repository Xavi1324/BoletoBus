

using BoletoBus.Common.Data.Repository;


namespace BoletoBus.ReservaDetalle.Domain.Interfaces
{
    public interface IReservaDetalleRepository : IBaseRepository<Domain.Entities.ReservaDetalle,int>
    {
        List<Domain.Entities.ReservaDetalle> GetReservaDetallesByIdReservaDetalle (int IdReservaDetalle);
    }
}
