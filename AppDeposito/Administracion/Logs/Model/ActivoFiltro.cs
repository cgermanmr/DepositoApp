using BEL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Administracion.Logs.Model
{
    public class ActivoFiltro
    {
        public long Tipo { get; set; }
        public string UsuarioModificador { get; set; } = "";
        public DateTime FechaD { get; set; } = DateTime.Now.AddDays(-20).Date;
        public DateTime FechaH { get; set; } = DateTime.Now.Date;
        public TipoOperacion TipoModificacion { get; set; }

        public string NroInventario { get; set; } = "";
        public string Descripcion { get; set; } = "";

    }
}
