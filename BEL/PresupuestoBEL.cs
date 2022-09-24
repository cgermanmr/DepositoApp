using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PresupuestoBEL:Entidad
    {
        public bool Autorizado { get; set; }
        public ReparacionBEL Reparacion { get; set; } = new ReparacionBEL();
        public long ReparacionId { get; set; }
        public EmpresaBEL Proveedor { get; set; } = new EmpresaBEL();
        public DateTime Fecha { get; set; } = DateTime.Now;
        public DateTime FechaValidez { get; set; } = DateTime.Now.AddDays(15);
        public int TiempoEstimado { get; set; }
        public double Cotizacion { get; set; } 
        public TipoMoneda Moneda { get; set; } //= TipoMoneda.Pesos;
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return $"Cotizacón de {Proveedor.RazonSocial} por {Cotizacion}";
        }


    }
}
