using BoletoBus.Reserva.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Reserva.Application.Interfaces
{
    public interface IReservaService
    {
        ServiceResult GetReservas();
        ServiceResult GetReservas(int id);
        ServiceResult UpdateReservas(ReservaUpdateModel reservaUpdateModel);
        ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel);
        ServiceResult SaveReserva(ReservaSaveModel reservaSaveModel);
    }
}
