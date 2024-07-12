using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBus.Viaje.Domain.Entities
{
    public class Viaje : AuditEntity<int>
    {
        [Column("IdViaje")]
        public override int id { get; set ; }

        [Key]
        public int IdViaje { get; set; }
             public int? IdBus { get; set; }
        public int? IdRuta { get; set; }
        public DateTime? FechaSalida { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public TimeSpan? HoraLlegada { get; set; }
        public decimal? Precio { get; set; }
        public int? TotalAsientos { get; set; }
        public int? AsientosReservados { get; set; }
        public int AsientoDisponibles => (TotalAsientos ?? 0) - (AsientosReservados ?? 0);
        public bool Completo => AsientoDisponibles < 1;

    }
}
