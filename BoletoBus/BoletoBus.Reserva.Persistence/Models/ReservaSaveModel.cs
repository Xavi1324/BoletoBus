namespace BoletoBus.Reserva.Persistence.Models
{
    public class ReservaSaveModel : ReservaBaseModel
    {
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
