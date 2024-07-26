﻿
namespace BoletoBus.ReservaDetalle.Application.Dtos
{
    public class ReservaDetalleUpdate : ReservaDetalleBase
    {
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}