using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoBus.Reserva.Domain.Entities
{
    public class ReservaDetalle : AuditEntity<int>
    {
        [Column("IdReservaDetalle")]
        public override int id { get; set; }
        [Key]
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        
    }
}
