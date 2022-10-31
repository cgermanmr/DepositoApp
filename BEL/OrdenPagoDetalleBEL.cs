using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrdenPagoDetalleBEL : Entidad
    {
        public long NroOrdenPago { get; set; } // bigint, not null
        public long NroFactura { get; set; } // bigint, not null
        public string Descripcion { get; set; } // varchar(50), null
        public decimal Importe { get; set; } // decimal(18,2), not null
    }
}
