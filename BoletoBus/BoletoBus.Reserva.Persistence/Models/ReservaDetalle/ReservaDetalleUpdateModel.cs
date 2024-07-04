using BusTicketsMonolitic.Web.Data.Models.ReservaDetalle;

namespace BusMonoliticApp.Web.Data.Models.ReservaDetalleModelDb
{
    public class ReservaDetalleUpdateModel : ReservaDetalleBaseModel
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
