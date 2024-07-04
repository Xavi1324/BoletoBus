namespace BoletoBus.ReservaDetalle.Application.Dtos
{
    public abstract class ReservaDetalleBaseDto
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
