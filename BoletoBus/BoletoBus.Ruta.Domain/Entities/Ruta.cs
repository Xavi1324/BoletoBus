using BoletoBus.Common.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BoletoBus.Ruta.Domain.Entities
{
    public class Ruta : AuditEntity<int>
    {
        [Column("IdRuta")]
        public override int id { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        
    }
}
