

using BoletoBus.Ruta.Application.Base;
using BoletoBus.Ruta.Application.Dtos;
using BoletoBus.Ruta.Application.Interfaces;
using BoletoBus.Ruta.Domain.Entities;
using BoletoBus.Ruta.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace BoletoBus.Ruta.Application.Services
{
    public class RutaService : IRutaService
    {
        private readonly IRutaRepository rutaRepository;
        private readonly ILogger<RutaService> logger;
        public RutaService(IRutaRepository rutaRepository, ILogger<RutaService> logger)
        {
            this.rutaRepository = rutaRepository;
            this.logger = logger;
        }

        public ServiceResult GetRutas()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = rutaRepository.GetAll();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las rutas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetRutas(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = rutaRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las rutas.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveRuta(RutaSaveModel rutaSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Ruta ruta = new Domain.Entities.Ruta();
                this.rutaRepository.Save(ruta);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpDateRutas(RutaUpdateModel rutaUpdateModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Ruta Updateruta = new Domain.Entities.Ruta();
                this.rutaRepository.Updater(Updateruta);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error atualizando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult DeleteRuta(RutaDeleteModel rutaDeleteModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Domain.Entities.Ruta Deleteruta = new Domain.Entities.Ruta();
                this.rutaRepository.Delete(Deleteruta);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error eliminando los datos.";
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
    }
}
