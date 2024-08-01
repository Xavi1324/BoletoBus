﻿

using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoBus.Reserva.Domain.Entities
{
    public class Reserva : AuditEntity<int>
    {
        [Column("IdReserva")]
        public override int id { get ; set ; }                      
        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        public int? AsientosReservados { get; set; }
        public decimal? MontoTotal { get; set; }
        
    }
}

