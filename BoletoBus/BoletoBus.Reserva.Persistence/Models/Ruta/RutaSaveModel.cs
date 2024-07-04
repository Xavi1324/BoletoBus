using BusMonoliticApp.Web.Data.Models.Ruta;

namespace BusMonoliticApp.Web.Data.Models.RutaModelDB
{
    public class RutaSaveModel : RutaBaseModel
    {
        public string? Origen {  get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }
}
