

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
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = reservaDetalleRepository.GetAll();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los detalles de las reservas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetReservaDetalles(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaDetalleRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los detalles de las reservas.";
                this.logger.LogError(result.Message, ex.ToString());


            }
            return result;
        }

        public ServiceResult SaveReservaDetalles(ReservaDetalleSave reservaDetalleSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.ReservaDetalle reservaDetalle = new Domain.Entities.ReservaDetalle();
                this.reservaDetalleRepository.Save(reservaDetalle);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }

        public ServiceResult UpdateReservaDetalles(ReservaDetalleUpdate reservaDetalleUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.ReservaDetalle UpdatereservaDetalle = new Domain.Entities.ReservaDetalle();
                this.reservaDetalleRepository.Updater(UpdatereservaDetalle);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error atualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }

        public ServiceResult DeleteReservaDetalles(ReservaDetalleDelete reservaDetalleDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.ReservaDetalle DeletereservaDetalle = new Domain.Entities.ReservaDetalle();
                this.reservaDetalleRepository.Delete(DeletereservaDetalle);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error eliminando los detalles de esta reserva.";
                this.logger.LogError(result.Message, ex.ToString());

            }
            return result;
        }
    }
}