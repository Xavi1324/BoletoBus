namespace BoletoBus.Web.Models.Ruta
{
    public class ViajeGetModelBase
    {
        public int idRuta { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
