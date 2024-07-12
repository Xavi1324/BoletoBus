using BoletoBus.Vieaje.Application.Base;
using BoletoBus.Vieaje.Persistence.Models;

namespace BoletoBus.Viaje.Application.Interfaces
{
    public interface IViajeService
    {
        ServiceResult GetViaje();
        ServiceResult GetViaje(int id);
        ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel);
        ServiceResult DeleteReservas(ViajeDeleteModel viajeDeleteModel);
        ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel);
    }
}
