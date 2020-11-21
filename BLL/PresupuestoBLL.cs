using System;
using BEL;
using DAL;

namespace BLL
{
    public class PresupuestoBLL : Negocio
    {
        public override Repository Repositorio() => new PresupuestoDAL();

        public override void Validar(EntidadBase valor)
        {
            if (valor.Estado)
                if (Listar(valor).FindAll(_ => _.Id != valor.Id & _.Estado).Count > 0)
                    throw new InvalidOperationException("Existe otro presupuesto aprobado");
        }
    }
}
