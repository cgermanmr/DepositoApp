using System.Data;
using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class MarcaDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_ACTIVO_MARCA";

        public override EntidadBase GetNew => new MarcaBEL();

    }
}
