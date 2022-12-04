using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class ConfigDbBEL
    {
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string NombreBase { get; set; }
        public string Mensaje { get; set; }
        public bool UsarAutenticacionIntegrada { get; set; }

    }
}
