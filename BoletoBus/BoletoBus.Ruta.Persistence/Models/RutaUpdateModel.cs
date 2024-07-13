﻿namespace BoletoBus.Ruta.Persistence.Models
{
    public class RutaUpdateModel : RutaBaseModel
    {

        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}