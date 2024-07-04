namespace BoletoBus.Ruta.Application.Dtos
{
    public class RutaDtoAccess : RutaBaseDto
    {
        public int IdRuta { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}