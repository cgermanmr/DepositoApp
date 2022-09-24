using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MonedaBEL:Entidad
    {       

        public override string ToString()
        {
            return $"{Descripcion}";
        }
    }
}
