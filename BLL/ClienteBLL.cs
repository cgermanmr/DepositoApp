using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class ClienteBLL : Negocio
    {
      
        public override Repository Repositorio() => new ClienteDAL();

        public override bool Eliminar(EntidadBase valor)
        {
            if (((ClienteBEL)valor).ActivosAsignados.Count > 0)
                throw new InvalidOperationException("El cliente tiene activos asignados");
            return base.Eliminar(valor);
        }
    }
}
