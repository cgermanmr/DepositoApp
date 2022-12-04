using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrdenPagoReportBEL
    {
        public long CuitProveedor { get; set; } // bigint, not null
        public DateTime FechaPago { get; set; } // date, not null
        public DateTime FechaEmision { get; set; } // date, not null
        public DateTime FechaEmisionFactura { get; set; } // date, not null
        public DateTime FechaVtoFactura { get; set; } // date, not null
        public decimal ImporteTotal { get; set; } // decimal(18,2), not null
        public bool Pagado { get; set; } // bit, not null
        public bool Anulado { get; set; } // bit, null
        public long NroOrdenPago { get; set; } // bigint, not null
        public long NroFactura { get; set; } // bigint, not null
        public string Descripcion { get; set; } // varchar(50), null
        public decimal Importe { get; set; } // decimal(18,2), not null
        public string RAZON_SOCIAL { get; set; } // nvarchar(50), null
        public string DIRECCION { get; set; } // nvarchar(50), null
        public string TELEFONO { get; set; } // nvarchar(20), null
        public string EMAIL { get; set; } // varchar(50), null

        public string PagadoAnulado => Anulado
                                        ? "ANULADO"
                                        :Pagado
                                        ? "PAGADO"
                                        :"";
    }
}
