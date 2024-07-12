using BoletoBus.ReservaDetalle.Application.Base;
using BoletoBus.ReservaDetalle.Persistence.Models;

namespace BoletoBus.ReservaDetalle.Application.Interfaces
{
    public interface IReservaDetalleService
    {
        ServiceResult GetReservaDetalles();
        ServiceResult GetReservaDetalles(int id);
        ServiceResult UpdateReservaDetalles(ReservaDetalleUpdateModel reservaDetalleUpdateModel);
        ServiceResult DeleteReservaDetalles(ReservaDetalleDeleteModel reservaDetalleDeleteModel);
        ServiceResult SaveReservaDetalles(ReservaDetalleSaveModel reservaDetalleSaveModel);
    }
}
