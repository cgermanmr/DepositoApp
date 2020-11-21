using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PresupuestoBEL:EntidadBase
    {
        public ReparacionBEL Reparacion { get; set; } = new ReparacionBEL();
        public EmpresaBEL Proveedor { get; set; } = new EmpresaBEL();
        public string Fecha { get; set; } = DateTime.Now.ToShortDateString();
        public string FechaValidez { get; set; } = DateTime.Now.ToShortDateString();
        public int TiempoEstimado { get; set; }
        public double Cotizacion { get; set; } 
        public MonedaBEL Moneda { get; set; } = new MonedaBEL() { Id=1};

        public override string ToString()
        {
            return $"Cotizacón de {Proveedor.Descripcion} por {Cotizacion.ToString()}";
        }

    }
}
