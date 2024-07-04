namespace BusTicketsMonolitic.Web.Data.Models.ReservaDetalle
{
    public class ReservaDetalleModelAccess : ReservaDetalleBaseModel
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}