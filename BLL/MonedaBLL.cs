using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class MonedaBLL : Negocio
    {
        public override Repositorio Repositorio() => new MonedaDAL();

    }
}
