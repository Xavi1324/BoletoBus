using BoletoBus.Reserva.Application.Base;
using BoletoBus.Reserva.Application.Dtos;


namespace BoletoBus.Reserva.Application.Validaciones
{
    public abstract class Validaciones
    {
        public void ValidacionNoNull(Object model, ServiceResult result)
        {
            if (model is null)
            {
                result.Success = false;
                result.Message = "El detalle de esta reserva no puede ser nulo";
                
            }
        }
        public void ValidacionMayor0<T>(T model, ServiceResult result) where T : ReservaBaseModel
        {
            if (model.MontoTotal <= 0)
            {
                result.Success = false;
                result.Message = "El campo MontoTotal debe ser mayor que cero.";
            }
        }
        /*public void ValidacionLongitud<L>(L  model, ServiceResult result) where L : RutaBaseModel
        {
            if (model.Origen.Length > 51)
            {
                result.Success = false;
                result.Message = "Este campo no puene tener mas de 50 caracteres.";
            }
            if (model.Destino.Length > 51)
            {
                result.Success = false;
                result.Message = "Este campo no puene tener mas de 50 caracteres.";
            }
        }*/
    }
}
