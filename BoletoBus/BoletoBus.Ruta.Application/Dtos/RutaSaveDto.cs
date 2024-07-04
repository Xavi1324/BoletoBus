
namespace BoletoBus.Ruta.Application.Dtos
{
    public class RutaSaveDto : RutaBaseDto
    {
        public string? Origen {  get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
