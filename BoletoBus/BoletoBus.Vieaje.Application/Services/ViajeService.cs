

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
            var Viajes = viajeRepository.GetAll();
            var ViajeDtos = Viajes.Select(v => new ViajeDto
            {
                IdViaje = v.id,
                IdBus = v.IdBus,
                IdRuta = v.IdRuta,
                FechaSalida = v.FechaSalida,
                HoraSalida = v.HoraSalida,
                FechaLlegada = v.FechaLlegada,
                HoraLlegada = v.HoraLlegada,
                Precio = v.Precio,
                TotalAsientos = v.TotalAsientos,
                AsientosReservados = v.AsientosReservados,
                FechaCreacion = v.FechaCreacion,
                
            }).ToList();
            return new ServiceResult
            {
                Success = true,
                Message = "Viajes obtenidos exitosamente",
                Data = ViajeDtos
            };
        }

        public ServiceResult GetViaje(int id)
        {
            var Viaje = viajeRepository.GetEntityBy(id);
            if (Viaje == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Viaje no encontrado",
                };
            }
            var ViajeDto = new ViajeDto
            {
                IdViaje = Viaje.id,
                IdBus = Viaje.IdBus,
                IdRuta = Viaje.IdRuta,
                FechaSalida = Viaje.FechaSalida,
                HoraSalida = Viaje.HoraSalida,
                FechaLlegada = Viaje.FechaLlegada,
                HoraLlegada = Viaje.HoraLlegada,
                Precio = Viaje.Precio,
                TotalAsientos = Viaje.TotalAsientos,
                AsientosReservados = Viaje.AsientosReservados,
                FechaCreacion = Viaje.FechaCreacion,
            };

            return new ServiceResult
            {
                Success = true,
                Message = "Viaje obtenido exitosamente",
                Data = ViajeDto
            };
        }

        public ServiceResult SaveViaje(ViajeSaveModel viajeSaveModel)
        {
            var saveviaje = new Domain.Entities.Viaje
            {

                
                IdBus = viajeSaveModel.IdBus,
                IdRuta = viajeSaveModel.IdRuta,
                FechaSalida = viajeSaveModel.FechaSalida,
                HoraSalida = viajeSaveModel.HoraSalida,
                FechaLlegada = viajeSaveModel.FechaLlegada,
                HoraLlegada = viajeSaveModel.HoraLlegada,
                Precio = viajeSaveModel.Precio,
                TotalAsientos = viajeSaveModel.TotalAsientos,
                AsientosReservados = viajeSaveModel.AsientosReservados,
                FechaCreacion = viajeSaveModel.FechaCreacion,
            };
            viajeRepository.Save(saveviaje);
            return new ServiceResult
            {
                Success = true,
                Message = "Viaje guardado exitosamente"
            };
        }

        public ServiceResult UpDateViaje(ViajeUpdateModel viajeUpdateModel)
        {
            var updateViaje = viajeRepository.GetEntityBy(viajeUpdateModel.IdViaje);
            if (updateViaje == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Viaje no encontrado"
                };
            }
            updateViaje.IdBus = viajeUpdateModel.IdBus ?? updateViaje.IdBus;
            updateViaje.IdRuta = viajeUpdateModel.IdRuta ?? updateViaje.IdRuta;
            updateViaje.FechaSalida = viajeUpdateModel.FechaSalida ?? updateViaje.FechaSalida;
            updateViaje.HoraSalida = viajeUpdateModel.HoraSalida ?? updateViaje.HoraSalida;
            updateViaje.FechaLlegada = viajeUpdateModel.FechaLlegada ?? updateViaje.FechaLlegada;
            updateViaje.HoraLlegada = viajeUpdateModel.HoraLlegada ?? updateViaje.HoraLlegada;
            updateViaje.Precio = viajeUpdateModel.Precio ?? updateViaje.Precio;
            updateViaje.TotalAsientos = viajeUpdateModel.TotalAsientos ?? updateViaje.TotalAsientos;
            updateViaje.AsientosReservados = viajeUpdateModel.AsientosReservados ?? updateViaje.AsientosReservados;
            updateViaje.FechaCreacion = viajeUpdateModel.FechaCreacion ?? updateViaje.FechaCreacion;
            return new ServiceResult
            {
                Success = true,
                Message = "Viaje actualizado exitosamente"
            };
        }

        public ServiceResult DeleteViaje(ViajeDeleteModel viajeDeleteModel)
        {
            var deleteVieaje = viajeRepository.GetEntityBy(viajeDeleteModel.IdViaje);
            if (deleteVieaje == null)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = "Viaje no encontrada"
                };
            }
            viajeRepository.Delete(deleteVieaje);
            return new ServiceResult
            {
                Success = true,
                Message = "Viaje eliminido exitosamente"
            };
        }
    }
}