using System;
using System.Linq;
using BEL;
using DAL;

namespace BLL
{
    public class PresupuestoBLL : Negocio
    {
        public override Repositorio Repositorio() => new PresupuestoDAL();

        public override bool EsValido(Entidad valor)
        {
            var v = valor as PresupuestoBEL;
            if (v.Autorizado)
                if (Listar(v).Any(_ => _.Id != v.Id && ((PresupuestoBEL)_).Autorizado))
                    throw new InvalidOperationException("Existe otro presupuesto aprobado");

            return true;
        }

        public PresupuestoBEL GetByOtProveedor(string ot, long cuit)
            => new PresupuestoDAL().GetByOtProveedor(ot, cuit);
    }
}
