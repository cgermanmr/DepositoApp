using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class MonedaDAL : Repository
    {
        protected override string ProcedimientoAlmacenado => "SP_MONEDA";

        public override EntidadBase GetNew => new MonedaBEL();

    }
}
