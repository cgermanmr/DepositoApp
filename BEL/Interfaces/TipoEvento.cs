using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum TipoEvento : int
    {
        Informacion = 1,
        Auditoria = 2,
        Error = 3,
        Seguridad = 4

    }

    public enum Criticidad : int
    {
        Baja = 1,
        Media = 2,
        Alta = 3,

    }

}
