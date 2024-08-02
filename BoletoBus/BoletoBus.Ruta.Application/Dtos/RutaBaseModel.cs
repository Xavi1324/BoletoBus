namespace BoletoBus.Ruta.Application.Dtos
{
    public abstract class RutaBaseModel
    {
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
