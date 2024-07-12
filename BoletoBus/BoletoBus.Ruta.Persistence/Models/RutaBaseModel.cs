namespace BoletoBus.Ruta.Persistence.Models
{
    public abstract class RutaBaseModel
    {
        public int IdRuta { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }

    }
}
