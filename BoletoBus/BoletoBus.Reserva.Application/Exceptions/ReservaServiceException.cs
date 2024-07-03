using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Reserva.Application.Exceptions
{
    public class ReservaServiceException : Exception
    {
        public ReservaServiceException(string message) : base(message)
        {

        }
    }
}
