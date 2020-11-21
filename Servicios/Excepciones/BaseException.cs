using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Servicios
{
    public class BaseException : Exception
    {
        public BaseException()
        {
            Logger.WriteLogExeption(this);
        }

        public BaseException(string message) : base(message)
        {
            Logger.WriteLogExeption(this);
        }

        public BaseException(string message, Exception innerException) : base(message, innerException)
        {
            Logger.WriteLogExeption(this);
        }
       
    }
}
