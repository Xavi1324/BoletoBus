namespace BoletoBus.Reserva.Persistence.Models.Reserva
{
    public abstract class ReservaBaseModel
    {
        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        public int? MontoTotal { get; set; }
        
    }
}
