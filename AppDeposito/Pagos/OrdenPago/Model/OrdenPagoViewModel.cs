using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Pagos.OrdenPago.Model
{
    public class OrdenPagoViewModel : OrdenPagoBEL
    {
        public string RazonSocial { get; set; }
        public bool Seleccionada { get; set; }
    }
}
