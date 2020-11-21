using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class DepositoBLL : Negocio
    {
      
        public override Repository Repositorio() => new DepositoDAL();

        public override bool Eliminar(EntidadBase valor)
        {
            if (((DepositoBEL)valor).Activos.Count > 0)
                throw new InvalidOperationException("El deposito tiene activos asignados");
            return base.Eliminar(valor);
        }
    }
}
