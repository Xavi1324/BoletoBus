

using BoletoBus.Viaje.Application.Dtos;
using BoletoBus.Viaje.Application.Interfaces;
using BoletoBus.Viaje.Domain.Entities;
using BoletoBus.Viaje.Domain.Interfaces;
using BoletoBus.Vieaje.Application.Base;
using Microsoft.Extensions.Logging;

namespace BoletoBus.Viaje.Application.Services
{
    public class ViajeService : IViajeService
    {
        private readonly IViajeRepository viajeRepository;
        private readonly ILogger<ViajeService> logger;
        public ViajeService(IViajeRepository viajeRepository, ILogger<ViajeService> logger)
        {
            this.viajeRepository = viajeRepository;
            this.logger = logger;
        }
        public ServiceResult GetViaje()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = viajeRepository.GetAll();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los viajes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetViaje(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = viajeRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo los viajes";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Viaje saveViaje = new Domain.Entities.Viaje();
                this.viajeRepository.Save(saveViaje);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Viaje UpdarteViaje = new Domain.Entities.Viaje();
                this.viajeRepository.Updater(UpdarteViaje);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult DeleteViaje(ViajeDeleteModel viajeDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Viaje DeleteViaje = new Domain.Entities.Viaje();
                this.viajeRepository.Updater(DeleteViaje);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}