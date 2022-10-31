using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdenPagoBLL : Negocio
    {
        public override Repositorio Repositorio()
        {
            return new OrdenPagoDAL();
        }
    }
}
