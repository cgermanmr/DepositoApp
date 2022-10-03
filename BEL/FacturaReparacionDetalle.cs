using Comun;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class FacturaReparacionDetalle : Entidad, IAuditable
    {
        public long NroFactura { get; set; }
        public string OtReparacion { get; set; }
        public string Descripcion { get; set; }
        //public double Importe { get; set; }

        private double _Importe;

        public event Action<double> CambioImporteEvent;
        public double Importe
        {
            get { return _Importe; }
            set { 
                _Importe = value;
                CambioImporteEvent?.Invoke(value);
            }
        }
        public string UsuarioModificador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaModificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TipoOperacion TipoModificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDVH()
        {
            var sb = new StringBuilder();
            sb.Append(NroFactura);
            sb.Append(OtReparacion);
            sb.Append(Descripcion);
            sb.Append(Importe);

            return Criptografia.Get.GetHashMD5(sb.ToString());

        }
    }
}
