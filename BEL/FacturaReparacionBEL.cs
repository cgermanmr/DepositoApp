using Comun;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class FacturaReparacionBEL:Entidad,IAuditable
    {
        public long NroFactura { get; set; }
        public long Codigo { get; set; }
        public string Letra { get; set; } = "";
        public long CuitProveedor { get; set; }
        public DateTime FechaVto { get; set; } = DateTime.Now;
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public double Importe { get; set; }

        public bool IsOk => NroFactura > 0 &&
                            Codigo > 0 &&
                            Letra.Length > 0 &&
                            Importe > 0 &&
                            CuitProveedor > 0 &&
                            Conceptos.Count > 0;

        public List<FacturaReparacionDetalle> Conceptos { get; set; } = new List<FacturaReparacionDetalle>();
        public string UsuarioModificador { get ; set; }
        public DateTime FechaModificacion { get; set; }
        public TipoOperacion TipoModificacion { get; set; }

        public string GetDVH()
        {
            var sb = new StringBuilder();

            sb.Append(NroFactura);
            sb.Append(Codigo);
            sb.Append(Letra);
            sb.Append(CuitProveedor);
            sb.Append(FechaVto);
            sb.Append(FechaEmision);
            sb.Append(Importe);
            sb.Append(Id);
            sb.Append(Estado);

            return Criptografia.Get.GetHashMD5(sb.ToString());

        }
    }
}
