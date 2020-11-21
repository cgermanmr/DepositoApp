using System;

namespace Servicios
{
    public class NegocioException : Exception
    {
        public NegocioException() : base()
        {

        }
        public NegocioException(string message) : base(message)
        {
          
        }
        public NegocioException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
