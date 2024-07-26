using BoletoBus.Viaje.Application.Dtos;
using BoletoBus.Vieaje.Application.Base;

namespace BoletoBus.Viaje.Application.Interfaces
{
    public interface IViajeService
    {
        ServiceResult GetViaje();
        ServiceResult GetViaje(int id);
        ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel);
        ServiceResult DeleteViaje(ViajeDeleteModel viajeDeleteModel);
        ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel);
    }
}
