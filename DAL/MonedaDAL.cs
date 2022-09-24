using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class MonedaDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_MONEDA";

        public override Entidad GetNew => new MonedaBEL();

    }
}
