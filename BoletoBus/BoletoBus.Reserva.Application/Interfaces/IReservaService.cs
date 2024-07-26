using BoletoBus.Reserva.Application.Base;
using BoletoBus.Reserva.Application.Dtos;

namespace BoletoBus.Reserva.Application.Interfaces
{
    public interface IReservaService
    {
        ServiceResult GetReservas();
        ServiceResult GetReservas(int id);
        ServiceResult UpdateReservas(ReservaUpdateModel reservaUpdateModel);
        ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel);
        ServiceResult SaveReserva( ReservaSaveModel reservaSaveModel);
    }
}                                   
