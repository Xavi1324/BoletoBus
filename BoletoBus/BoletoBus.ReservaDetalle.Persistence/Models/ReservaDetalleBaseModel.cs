namespace BoletoBus.ReservaDetalle.Persistence.Models
{
    public abstract class ReservaDetalleBaseModel
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
