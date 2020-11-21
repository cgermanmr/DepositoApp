using System;

namespace Servicios
{
    public class UsuarioBloqueadoExcepcion : Exception
    {
        public UsuarioBloqueadoExcepcion() : base("Usuario Bloqueado")
        {
        }
    }
}
