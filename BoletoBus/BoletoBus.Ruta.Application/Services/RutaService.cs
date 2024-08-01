

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
            var rutas = rutaRepository.GetAll();
            var rutaDtos = rutas.Select(r => new RutaDto
            {
                IdRuta = r.id,
                Origen = r.Origen,
                Destino = r.Destino,
                FechaCreacion = r.FechaCreacion,
            }).ToList();
            return new ServiceResult
            {
                Success = true,
                Message = "Rutas obtenidas exitosamente",
                Data = rutaDtos
            };
        }

        public ServiceResult GetRutas(int id)
        {
            var rutas=rutaRepository.GetEntityBy(id);
            if (rutas == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Ruta no encontrada",
                };
            }
            var rutaDto = new RutaDto
            {
                IdRuta = rutas.id,
                Origen = rutas.Origen,
                Destino = rutas.Destino,
                FechaCreacion = rutas.FechaCreacion
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Ruta obtenidas exitosamente",
                Data= rutaDto
            };
        }

        public ServiceResult SaveRuta(RutaSaveModel rutaSaveModel)
        {
            var saveRuta = new Domain.Entities.Ruta
            {

                Origen = rutaSaveModel.Origen,
                Destino = rutaSaveModel.Destino,
                FechaCreacion = rutaSaveModel.FechaCreacion
            };
            rutaRepository.Save(saveRuta);
            return new ServiceResult
            {
                Success = true,
                Message = "Ruta guardada exitosamente"
            };
        }

        public ServiceResult UpDateRutas(RutaUpdateModel rutaUpdateModel)
        {
            var updarteRuta = rutaRepository.GetEntityBy(rutaUpdateModel.IdRuta);
            if (updarteRuta == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Ruta no encontrada"
                };
            }
            updarteRuta.Origen = rutaUpdateModel.Origen ?? updarteRuta.Origen;
            updarteRuta.Destino = rutaUpdateModel.Destino ?? updarteRuta.Destino;
            updarteRuta.FechaCreacion = rutaUpdateModel.FechaCreacion ?? updarteRuta.FechaCreacion;
            rutaRepository.Updater(updarteRuta);
            return new ServiceResult
            {
                Success = true,
                Message = "Ruta actualizada exitosamente"
            };
        }

        public ServiceResult DeleteRuta(RutaDeleteModel rutaDeleteModel)
        {
            var deleteRuta = rutaRepository.GetEntityBy(rutaDeleteModel.IdRuta);
            if (deleteRuta == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Ruta no encontrada"
                };
            }
            rutaRepository.Delete(deleteRuta);
            return new ServiceResult
            {
                Success = true,
                Message = "Ruta eliminida exitosamente"
            };
        }
    }
}
