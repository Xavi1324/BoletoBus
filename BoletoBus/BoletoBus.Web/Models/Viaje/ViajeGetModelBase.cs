namespace BoletoBus.Web.Models.Viaje
{
    public class ViajeGetModelBase
    {
        public int idViaje { get; set; }
        public int idBus { get; set; }
        public int idRuta { get; set; }
        public DateTime fechaSalida { get; set; }
        public string horaSalida { get; set; }
        public DateTime fechaLlegada { get; set; }
        public string horaLlegada { get; set; }
        public int precio { get; set; }
        public int totalAsientos { get; set; }
        public int asientosReservados { get; set; }
        public int asientoDisponibles { get; set; }
        public bool completo { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
