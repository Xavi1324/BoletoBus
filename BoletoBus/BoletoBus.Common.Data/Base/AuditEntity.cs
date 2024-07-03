using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Common.Data.Base
{
    public abstract class AuditEntity<TType> : BaseEntity<TType>
    {
    
        public DateTime? FechaCreacion { get; set; }

    }
}
