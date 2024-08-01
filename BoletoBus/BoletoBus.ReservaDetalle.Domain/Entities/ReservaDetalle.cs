
using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoBus.ReservaDetalle.Domain.Entities
{
    public class ReservaDetalle : AuditEntity<int>
    {
        [Column("IdReservaDetalle")]
        public override int id { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        
    }
}
