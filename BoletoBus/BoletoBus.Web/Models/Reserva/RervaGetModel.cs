namespace BoletoBus.Web.Models.Reserva
{
    public class RervaGetModel
    {
        public int idReserva { get; set; }
        public int idViaje { get; set; }
        public int idPasajero { get; set; }
        public int asientosReservados { get; set; }
        public int montoTotal { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
