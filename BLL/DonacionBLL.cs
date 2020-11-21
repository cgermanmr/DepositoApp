using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class DonacionBLL : Negocio
    {
        public override Repository Repositorio() => new DonacionDAL();
    }
}
