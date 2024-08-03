

using BoletoBus.Reserva.Application.Base;
using BoletoBus.Reserva.Application.Dtos;
using BoletoBus.Reserva.Application.Interfaces;
using BoletoBus.Reserva.Domain.Interfaces;
using Microsoft.Extensions.Logging;


namespace BoletoBus.Reserva.Application.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository reservaRepository;
        private readonly ILogger<ReservaService> Logger;

        public ReservaService(IReservaRepository reservaRepository , ILogger<ReservaService> Logger)
        {
            this.reservaRepository = reservaRepository;
            this.Logger = Logger;
        }
        
        public ServiceResult GetReservas()
        {
            var reservas = reservaRepository.GetAll();
            var reservaDtos = reservas.Select(r => new ReservaDto
            {
                IdReserva = r.id,
                IdViaje = r.IdViaje,
                IdPasajero = r.IdPasajero,
                AsientosReservados = r.AsientosReservados,
                MontoTotal = r.MontoTotal,
                FechaCreacion = r.FechaCreacion
            }).ToList();

            return new ServiceResult
            {
                Success = true,
                Message = "Reservas obtenidas exitosamente",
                Data = reservaDtos
            };

        }

        public ServiceResult GetReservas(int id)
        {
            var reserva = reservaRepository.GetEntityBy(id);
            if (reserva == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Reserva no encontrada"
                };
            }

            var reservaDto = new ReservaDto
            {
                IdReserva = reserva.id,
                IdViaje = reserva.IdViaje,
                IdPasajero = reserva.IdPasajero,
                AsientosReservados = reserva.AsientosReservados,
                MontoTotal = reserva.MontoTotal,
                FechaCreacion = reserva.FechaCreacion
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Reserva obtenida exitosamente",
                Data = reservaDto
            };
        }

        public ServiceResult SaveReserva(ReservaSaveModel reservaSaveModel)
        {

            var reserva = new Domain.Entities.Reserva
            {
                IdViaje = reservaSaveModel.IdViaje.Value,
                IdPasajero = reservaSaveModel.IdPasajero.Value,
                AsientosReservados = reservaSaveModel.AsientosReservados.Value,
                MontoTotal = reservaSaveModel.MontoTotal.Value,
                FechaCreacion = reservaSaveModel.FechaCreacion.Value
            };

            reservaRepository.Save(reserva);
            return new ServiceResult
            {
                Success = true,
                Message = "Reserva guardada exitosamente"
            };
        }

        public ServiceResult UpdateReservas(ReservaUpdateModel reservaUpdateModel)
        {
            var reserva = reservaRepository.GetEntityBy(reservaUpdateModel.IdReserva);
            if (reserva == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Reserva no encontrada"
                };
            }
            reserva.IdViaje = reservaUpdateModel.IdViaje ?? reserva.IdViaje;
            reserva.IdPasajero = reservaUpdateModel.IdPasajero ?? reserva.IdPasajero;
            reserva.AsientosReservados = reservaUpdateModel.AsientosReservados ?? reserva.AsientosReservados;
            reserva.MontoTotal = reservaUpdateModel.MontoTotal ?? reserva.MontoTotal;
            reserva.FechaCreacion = reservaUpdateModel.FechaCreacion ?? reserva.FechaCreacion;

            reservaRepository.Updater(reserva);
            return new ServiceResult
            {
                Success = true,
                Message = "Reserva actualizada exitosamente"
            };
        }
        public ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel)
        {
            var reserva = reservaRepository.GetEntityBy(reservaDeleteModel.IdReserva);
            if (reserva == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Reserva no encontrada"
                };
            }

            reservaRepository.Delete(reserva);
            return new ServiceResult
            {
                Success = true,
                Message = "Reserva eliminada exitosamente"
            };
        }
    }
}
