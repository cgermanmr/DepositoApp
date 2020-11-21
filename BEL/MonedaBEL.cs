using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MonedaBEL:EntidadBase
    {       

        public override string ToString()
        {
            return $"{Descripcion}";
        }
    }
}
