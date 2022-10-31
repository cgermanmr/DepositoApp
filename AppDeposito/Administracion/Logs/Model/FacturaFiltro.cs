using BEL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Administracion.Logs.Model
{
    public class FacturaFiltro
    {
        public long NroFactura { get; set; }
        public long Codigo { get; set; }
        public string Letra { get; set; }
        public long CuitProveedor { get; set; }
        public DateTime FechaVtoDesde { get; set; } = DateTime.Now.AddDays(-10).Date;
        public DateTime FechaVtoHasta { get; set; } = DateTime.Now.Date;
        public DateTime FechaEmisionDesde { get; set; } = DateTime.Now.AddDays(-10).Date;
        public DateTime FechaEmisionHasta { get; set; } = DateTime.Now.Date;
        public double Importe { get; set; }
        public string UsuarioModificador { get; set; } = "";
        public DateTime FechaModificacionDesde { get; set; } = DateTime.Now.AddDays(-10).Date;
        public DateTime FechaModificacionHasta { get; set; } = DateTime.Now.Date;
        public TipoOperacion TipoModificacion { get; set; }

    }
}
