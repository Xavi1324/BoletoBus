namespace BoletoBus.Reserva.Persistence.Models
{
    public class ReservaUpdateModel : ReservaBaseModel
    {
        public int IdReserva { get; set; }
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
