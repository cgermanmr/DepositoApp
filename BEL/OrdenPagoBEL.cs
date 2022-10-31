using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    
    public class OrdenPagoBEL : Entidad
    {
        public long NroOrdenPago { get; set; } // bigint, not null
        public long CuitProveedor { get; set; } // bigint, not null
        public DateTime FechaPago { get; set; } =  DateTime.Now.Date.AddDays(1); // date, not null
        public DateTime FechaEmision { get; set; } = DateTime.Now.Date; // date, not null
        public decimal Importe { get; set; } // decimal(18,2), not null
        public bool Pagado { get; set; } // bit, not null
        public bool Anulado { get; set; } // bit, not null
        public List<OrdenPagoDetalleBEL> Detalles { get; set; } = new List<OrdenPagoDetalleBEL>();
    }

   
}
