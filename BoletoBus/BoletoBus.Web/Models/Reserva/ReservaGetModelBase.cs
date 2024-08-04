namespace BoletoBus.Web.Models.Reserva
{
    public  class ReservaGetModelBase
    {
        public int idReserva { get; set; }
        public int idViaje { get; set; }
        public int idPasajero { get; set; }
        public int asientosReservados { get; set; }
        public decimal montoTotal { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
