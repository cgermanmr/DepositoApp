using System;
using BEL;
using DAL;

namespace BLL
{
    public class Presupuesto : Negocio
    {
        public override Repositorio Repositorio() => new PresupuestoDAL();

        public override bool EsValido(EntidadBase valor)
        {
            if (valor.Estado)
                if (Listar(valor).FindAll(_ => _.Id != valor.Id & _.Estado).Count > 0)
                    throw new InvalidOperationException("Existe otro presupuesto aprobado");

            return true;
        }
    }
}
