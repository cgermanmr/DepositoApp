using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Pagos
{
    public class IngresoFacturaPresenter
    {
        private readonly IngresoFacturasForm _view;
        public IngresoFacturaPresenter(IngresoFacturasForm view)
        {
            _view = view;            
        }

        internal void ValidarImporte(double importe)
        {
            var presupuestosBll = new PresupuestoBLL();

            var presupuesto = presupuestosBll.GetByOtProveedor(_view.ConceptoActual.OtReparacion, _view.Factura.CuitProveedor);

            if (importe > presupuesto.Cotizacion)
                throw new InvalidOperationException($"No coincide el valor ingresado {importe:N2} con el presupuesto del proveedor {presupuesto.Cotizacion:N2} ");
        }

        internal void ValidarOt(string valor)
        {
            var fr = new FacturaReparacionBLL();

            var sb = new StringBuilder();

            if (!fr.ExiteOTPresupuestada(valor,_view.Factura.CuitProveedor))
                sb.AppendLine($"La OT No se encuentra asociada a ningun presupuesto del Proveedor");

            var otFacturada = fr.GetDetalleById(valor,_view.Factura.CuitProveedor);
            if (otFacturada != null)
                sb.AppendLine($"La OT {valor} ya esta facturada. Corresponde a la factura {otFacturada.NroFactura}");

            if(!fr.OtEstaFinalizada(valor, _view.Factura.CuitProveedor))
                sb.AppendLine($"La OT {valor} no esta finalizada o el presupuesto no esta autorizado");

            if (sb.Length > 0)
                throw new InvalidOperationException(sb.ToString());

            _view.ConceptoActual.Descripcion = $"Servicio de reparación";

        }
    }
}
