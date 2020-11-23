using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAuditable
    {
        string UsuarioModificador { get; set; }
        DateTime FechaModificacion { get; set; }
        TipoOperacion TipoModificacion { get; set; }
        TipoEvento TipoEvento { get; set; }

    }
}
