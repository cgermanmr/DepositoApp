using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class EstadoDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_ACTIVO_ESTADO";

        public override Entidad GetNew => new EstadoBEL();
    }
}
