


using BoletoBus.Common.Data.Repository;

namespace BoletoBus.Ruta.Domain.Interfaces
{
    public interface IRutaRepository : IBaseRepository<Domain.Entities.Ruta,int>
    {
        List<Domain.Entities.Ruta> GetRutasByIdRuta(int IdRuta);
    }
}