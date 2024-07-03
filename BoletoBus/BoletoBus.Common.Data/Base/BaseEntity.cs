using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Common.Data.Base
{
    public abstract class BaseEntity<TType>
    {
        public abstract TType id {get; set;}
    }
}
