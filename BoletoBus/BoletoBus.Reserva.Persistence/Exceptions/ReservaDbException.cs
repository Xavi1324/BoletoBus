namespace BoletoBus.Reserva.Persistence.Exceptions
{
    public class ReservaDbException : Exception
    {
        public ReservaDbException()
        {
        }

        public ReservaDbException(string message) : base(message) 
        {
            
        }
    }
}
