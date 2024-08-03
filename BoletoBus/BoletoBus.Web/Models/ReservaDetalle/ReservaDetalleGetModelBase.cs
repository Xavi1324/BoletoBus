namespace BoletoBus.Web.Models.ReservaDetalle
{
    public class ReservaDetalleGetModelBase
    {
        public int idReservaDetalle { get; set; }
        public int idReserva { get; set; }
        public int idAsiento { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
