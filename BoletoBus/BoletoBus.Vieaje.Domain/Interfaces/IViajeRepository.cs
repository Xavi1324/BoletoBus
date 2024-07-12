


using BoletoBus.Common.Data.Repository;

namespace BoletoBus.Viaje.Domain.Interfaces
{
    public interface IViajeRepository : IBaseRepository<Domain.Entities.Viaje,int>
    {
        List<Domain.Entities.Viaje> GetViajesByIdViaje(int IdViaje);    
    }
}