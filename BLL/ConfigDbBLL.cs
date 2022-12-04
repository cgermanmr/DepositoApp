using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfigDbBLL
    {
        public bool CrearBase(ConfigDbBEL configDbDatos)
        {
            return ConfigDb.CrearBase(configDbDatos);
        }

        public bool TestCnx(ConfigDbBEL configDbDatos)
        {
            return ConfigDb.TestConexion(configDbDatos);
        }
    }
}
