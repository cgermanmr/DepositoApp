using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DonacionBEL:EntidadBase
    {
        public List<ActivoBEL> Activos { get; set; } = new List<ActivoBEL>();
        public ClienteBEL Autorizador { get; set; } = new ClienteBEL();
        public ClienteBEL Auditor { get; set; } = new ClienteBEL();
        public string Fecha { get; set; } = "";
        public EmpresaBEL Organizacion { get; set; } = new EmpresaBEL();

        public override bool Estado { get; set; } = false;

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
