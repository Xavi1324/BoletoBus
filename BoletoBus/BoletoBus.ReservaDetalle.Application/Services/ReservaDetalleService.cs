

using BoletoBus.ReservaDetalle.Application.Base;
using BoletoBus.ReservaDetalle.Application.Dtos;
using BoletoBus.ReservaDetalle.Application.Interfaces;
using BoletoBus.ReservaDetalle.Domain.Entities;
using BoletoBus.ReservaDetalle.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoletoBus.ReservaDetalle.Application.Services
{
    public class ReservaDetalleService : IReservaDetalleService
    {
        private readonly IReservaDetalleRepository reservaDetalleRepository;
        private readonly ILogger<ReservaDetalleService> logger;

        public ReservaDetalleService(IReservaDetalleRepository reservaDetalleRepository, ILogger<ReservaDetalleService> logger)
        {
            this.reservaDetalleRepository = reservaDetalleRepository;
            this.logger = logger;
        }
        
        public ServiceResult GetReservaDetalles()
        {
            var reservasDetalles = reservaDetalleRepository.GetAll();
            var reservaDetalleDtos = reservasDetalles.Select(d => new ReservaDetalleDto
            {
                IdReservaDetalle = d.id,
                IdReserva = d.IdReserva,
                IdAsiento = d.IdAsiento,
                FechaCreacion = d.FechaCreacion,
            }).ToList();
            return new ServiceResult
            {
                Success = true,
                Message = "Detalles obtenidos exitosamente",
                Data = reservaDetalleDtos
            };
        }

        public ServiceResult GetReservaDetalles(int id)
        {
            var reservaDetalle = reservaDetalleRepository.GetEntityBy(id);
            if (reservaDetalle == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Detalles de reserva no encontrado"
                };
            }
            var reservaDetalleDto = new ReservaDetalleDto
            {
                IdReservaDetalle = reservaDetalle.id,
                IdReserva = reservaDetalle.IdReserva,
                IdAsiento = reservaDetalle.IdAsiento,
                FechaCreacion = reservaDetalle.FechaCreacion
            };
            return new ServiceResult
            {
                Success = true,
                Message = "Detalles de la reserva obtenida exitosamente",
                Data = reservaDetalleDto
            };
        }

        public ServiceResult SaveReservaDetalles(ReservaDetalleSave reservaDetalleSaveModel)
        {
            var reservaDetalle = new Domain.Entities.ReservaDetalle
            {
                IdReserva = reservaDetalleSaveModel.IdReserva.Value,
                IdAsiento = reservaDetalleSaveModel.IdAsiento.Value,
                FechaCreacion = reservaDetalleSaveModel.FechaCreacion.Value
            };
            reservaDetalleRepository.Save(reservaDetalle);
            return new ServiceResult
            {
                Success = true,
                Message = "Detalles guardados exitosamente"
            };
        }

        public ServiceResult UpdateReservaDetalles(ReservaDetalleUpdate reservaDetalleUpdateModel)
        {
            var UptadereservaDetalle = reservaDetalleRepository.GetEntityBy(reservaDetalleUpdateModel.IdReservaDetalle);
            if(UptadereservaDetalle == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Detalles no encontrados"
                };
            }
            UptadereservaDetalle.IdReserva = reservaDetalleUpdateModel.IdReserva ?? UptadereservaDetalle.IdReserva;
            UptadereservaDetalle.IdAsiento = reservaDetalleUpdateModel.IdAsiento ?? UptadereservaDetalle.IdAsiento;
            UptadereservaDetalle.FechaCreacion = reservaDetalleUpdateModel.FechaCreacion ?? UptadereservaDetalle.FechaCreacion;
            reservaDetalleRepository.Updater(UptadereservaDetalle);
            return new ServiceResult
            {
                Success = true,
                Message = "Detalles actualizados exitosamente"
            };
        }

        public ServiceResult DeleteReservaDetalles(ReservaDetalleDelete reservaDetalleDeleteModel)
        {
            var deleteReservaDertalle = reservaDetalleRepository.GetEntityBy(reservaDetalleDeleteModel.IdReservaDetalle);
            if (deleteReservaDertalle == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Detalles no encontrados"
                };

            }
            reservaDetalleRepository.Delete(deleteReservaDertalle);
            return new ServiceResult
            {
                Success = true,
                Message = "Detalles eliminados exitosamente"
            };
        }
    }
}