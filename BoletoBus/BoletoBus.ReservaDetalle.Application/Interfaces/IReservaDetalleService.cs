using BoletoBus.ReservaDetalle.Application.Base;
using BoletoBus.ReservaDetalle.Application.Dtos;

namespace BoletoBus.ReservaDetalle.Application.Interfaces
{
    public interface IReservaDetalleService
    {
        ServiceResult GetReservaDetalles();
        ServiceResult GetReservaDetalles(int id);
        ServiceResult UpdateReservaDetalles(ReservaDetalleUpdate reservaDetalleUpdateModel);
        ServiceResult DeleteReservaDetalles(ReservaDetalleDelete reservaDetalleDeleteModel);
        ServiceResult SaveReservaDetalles(ReservaDetalleSave reservaDetalleSaveModel);
    }
}
