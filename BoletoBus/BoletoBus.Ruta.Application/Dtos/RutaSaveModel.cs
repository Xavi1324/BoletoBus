
namespace BoletoBus.Ruta.Application.Dtos
{
    public class RutaSaveModel : RutaBaseModel
    {
        public string? Origen {  get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
