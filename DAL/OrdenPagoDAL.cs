using BEL;
using Comun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class OrdenPagoDAL : Repositorio
    {
        public override Entidad GetNew => new OrdenPagoBEL();

        protected override string ProcedimientoAlmacenado => "SP_ORDEN_PAGO";

       
        public override bool Agregar(Entidad valor)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var result = base.Agregar(valor);
                var f = valor as OrdenPagoBEL;

                if (result)
                    foreach (OrdenPagoDetalleBEL d in f.Detalles)
                        result = result && AgregarDetalle(d);

                scope.Complete();

                return result;
            }
        }

        public override bool Modificar(Entidad valor)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var result = base.Modificar(valor);
                var f = valor as OrdenPagoBEL;

                if (result)
                {
                    result = result && EliminarDetallesOrdenPago(f.NroOrdenPago);

                    foreach (OrdenPagoDetalleBEL d in f.Detalles)
                        result = result && AgregarDetalle(d);
                }

                scope.Complete();

                return result;
            }
        }

        private bool EliminarDetallesOrdenPago(long nroOrdenPago)
        {
            var hdatos = new Hashtable();

            hdatos.Add("@operacion", 12);
            hdatos.Add("@NroOrdenPago", nroOrdenPago);

            var result = _datos.Escribir("SP_ORDEN_PAGO", hdatos);

            return result;
        }

        public bool AgregarDetalle(OrdenPagoDetalleBEL detalle)
        {
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@operacion", 10);              
            hdatos.Add("@NroOrdenPago", detalle.NroOrdenPago);
            hdatos.Add("@NroFactura", detalle.NroFactura);
            hdatos.Add("@Descripcion", detalle.Descripcion);
            hdatos.Add("@Importe", detalle.Importe);

            resultado = _datos.Escribir("SP_ORDEN_PAGO", hdatos);

            return resultado;
        }

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            OrdenPagoBEL x = (OrdenPagoBEL)valor;

            if (x == null) x = new OrdenPagoBEL();
            hdatos.Add("@id", x.NroOrdenPago);
            hdatos.Add("@NroOrdenPago", x.NroOrdenPago);
            hdatos.Add("@CuitProveedor", x.CuitProveedor);
            hdatos.Add("@FechaPAgo", x.FechaPago.Date);
            hdatos.Add("@FechaEmision", x.FechaEmision.Date);
            hdatos.Add("@Importe", x.Importe);
            hdatos.Add("@pagado", x.Pagado);
            hdatos.Add("@anulado", x.Anulado);


            return hdatos;
        }

        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<OrdenPagoBEL> _lista = new List<OrdenPagoBEL>();
            OrdenPagoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new OrdenPagoBEL();
                x.NroOrdenPago = dr[0].SafeToLong();
                x.CuitProveedor = dr[1].SafeToLong();
                x.FechaPago = dr[2].SafeToDateTime();
                x.FechaEmision = dr[3].SafeToDateTime();
                x.Importe = dr[4].SafeToDecimal();
                x.Pagado = (bool)dr[5];
                x.Anulado = (bool)dr[6];

                x.Detalles = GetDetallesOrdenPago(x.NroOrdenPago);

                _lista.Add(x);
            }

            return _lista.ConvertAll(_ => (Entidad)_);
        }

        private List<OrdenPagoDetalleBEL> GetDetallesOrdenPago(long nroOrdenPago)
        {
            var hdatos = new Hashtable();

            hdatos.Add("@operacion", 11);
            hdatos.Add("@NroOrdenPago", nroOrdenPago);

            var ds = _datos.Leer("SP_ORDEN_PAGO", hdatos);

            return ObtenerListaDetalleOrdenPago(ds);
        }

        private List<OrdenPagoDetalleBEL> ObtenerListaDetalleOrdenPago(DataSet ds)
        {
            List<OrdenPagoDetalleBEL> _lista = new List<OrdenPagoDetalleBEL>();
            OrdenPagoDetalleBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new OrdenPagoDetalleBEL();
                x.NroOrdenPago = dr[0].SafeToLong();
                x.NroFactura = dr[1].SafeToLong();
                x.Descripcion = dr[2].ToString();
                x.Importe = dr[3].SafeToDecimal();
                _lista.Add(x);
            }

            return _lista;
        }

        public List<OrdenPagoReportBEL> GetDatosOrdenPagoReporte(long nroOrdenPago)
        {
            var hdatos = new Hashtable();

            hdatos.Add("@ordpag", nroOrdenPago);

            var ds = _datos.Leer("GetDatosOrdenPagoReporte", hdatos);

            List<OrdenPagoReportBEL> _lista = new List<OrdenPagoReportBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var x = new OrdenPagoReportBEL();
                x.CuitProveedor = dr[0].SafeToLong();
                x.FechaPago = dr[1].SafeToDateTime();
                x.FechaEmision = dr[2].SafeToDateTime();
                x.ImporteTotal = dr[3].SafeToDecimal();
                x.Pagado = (bool)dr[4];
                x.Anulado = (bool)dr[5];
                x.NroOrdenPago = dr[6].SafeToLong();
                x.NroFactura = dr[7].SafeToLong();
                x.Descripcion = dr[8].ToString();
                x.Importe = dr[9].SafeToDecimal();
                x.FechaEmisionFactura = dr[10].SafeToDateTime();
                x.FechaVtoFactura = dr[11].SafeToDateTime();
                x.RAZON_SOCIAL = dr[12].ToString();
                x.DIRECCION = dr[13].ToString();
                x.TELEFONO = dr[14].ToString();
                x.EMAIL = dr[15].ToString();                

                _lista.Add(x);
            }

            return _lista;
        }
    }
}
