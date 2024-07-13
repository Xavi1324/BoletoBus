

using BoletoBus.Reserva.Application.Base;
using BoletoBus.Reserva.Application.Dtos;
using BoletoBus.Reserva.Application.Interfaces;
using BoletoBus.Reserva.Domain.Interfaces;
using Microsoft.Extensions.Logging;


namespace BoletoBus.Reserva.Application.Services
{
    public class ReservaService :  IReservaService
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
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaRepository.GetAll();
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las reservas.";
                this.Logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult GetReservas(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = reservaRepository.GetEntityBy(id);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error obteniendo las reservas.";
                this.Logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveReserva(ReservaSaveModel reservaSaveModel)
        {
            ServiceResult result = new ServiceResult();
            try
            {

                Domain.Entities.Reserva reserva = new Domain.Entities.Reserva();
                this.reservaRepository.Save(reserva);
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Ocurrio un error guardando los datos.";
                this.Logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateReservas(ReservaUpdateModel reservaUpdateModel)
        {
            throw new NotImplementedException();
        }
        public ServiceResult DeleteReservas(ReservaDeleteModel reservaDeleteModel)
        {
            throw new NotImplementedException();
        }
    }
}
