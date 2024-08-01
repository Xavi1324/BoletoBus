namespace BoletoBus.ReservaDetalle.Application.Dtos
{
    public abstract class ReservaDetalleBase
    {
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
