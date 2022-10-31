using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ReemplazoTemporalBEL
    {
        public long Reparacion { get; set; }
        public long Activo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public bool Definitivo { get; set; }
        public string Descripcion { get; set; }
    }
}
