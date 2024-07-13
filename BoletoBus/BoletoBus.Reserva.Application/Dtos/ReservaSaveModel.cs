﻿
namespace BoletoBus.Reserva.Application.Dtos
{
    public class ReservaSaveModel : ReservaBaseModel
    {
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}