using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System;
using System.Collections.Generic;
using Comun;
using System.Transactions;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace DAL
{
    public class FacturaReparacionDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_FACTURA";

        public override Entidad GetNew => new FacturaReparacionBEL();

        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<FacturaReparacionBEL> _lista = new List<FacturaReparacionBEL>();
            FacturaReparacionBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new FacturaReparacionBEL();
                x.Id = dr[7].SafeToLong();
                x.NroFactura = dr[0].SafeToLong();
                x.Codigo = dr[1].SafeToLong();
                x.Letra = dr[2].ToString();
                x.CuitProveedor = dr[3].SafeToLong();
                x.FechaVto = dr[4].SafeToDateTime();
                x.FechaEmision = dr[5].SafeToDateTime();
                x.Importe = dr[6].SafeToDouble();
                x.Estado = Convert.ToBoolean(dr[8]);

                _lista.Add(x);
            }

            return _lista.ConvertAll(_=>(Entidad)_);
        }

        public override bool Agregar(Entidad valor)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                var result = base.Agregar(valor);
                var f = valor as FacturaReparacionBEL;

                if (result)
                    foreach (FacturaReparacionDetalle d in f.Conceptos)
                        result = result && AgregarDetalle(f, d);
                
                scope.Complete();

                return result;
            }            
        }


        public bool AgregarDetalle(FacturaReparacionBEL factura, FacturaReparacionDetalle detalle)
        {
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@NroFactura", factura.NroFactura);
            hdatos.Add("@OtReparacion", detalle.OtReparacion);
            hdatos.Add("@Descripcion", detalle.Descripcion);
            hdatos.Add("@Importe", detalle.Importe);
            hdatos.Add("@dvh", detalle.GetDVH());

            resultado = _datos.Escribir("SP_factura_detalle", hdatos);

            return resultado;
        }

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            FacturaReparacionBEL x = (FacturaReparacionBEL)valor;

            if (x == null) x = new FacturaReparacionBEL();
            hdatos.Add("@id", x.Id);
            hdatos.Add("@NroFactura", x.NroFactura);
            hdatos.Add("@Codigo", x.Codigo);
            hdatos.Add("@Letra", x.Letra);
            hdatos.Add("@CuitProveedor", x.CuitProveedor);
            hdatos.Add("@FechaVto", x.FechaVto.Date);
            hdatos.Add("@FechaEmision", x.FechaEmision.Date);
            hdatos.Add("@Importe", x.Importe);
            hdatos.Add("@estado", x.Estado);
            hdatos.Add("@dvh", x.GetDVH());

            return hdatos;
        }

        public FacturaReparacionDetalle GetDetalleById(string ot,long cuit)
        {
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@OTReparacion", ot);
            hdatos.Add("@Cuit", cuit);
            hdatos.Add("@operacion", 5);

            var ds = _datos.Leer("[SP_FACTURA_DETALLE_VALIDACION]", hdatos);

            return ObtenerListaDetalle(ds).FirstOrDefault();
        }

        public bool ExisteOTPresupuestada(string ot, long cuit)
        {
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@OTReparacion", ot);
            hdatos.Add("@Cuit", cuit);
            hdatos.Add("@operacion", 6);

            var ds = _datos.Leer("[SP_FACTURA_DETALLE_VALIDACION]", hdatos);

            return ds.Tables[0].Rows.Count > 0;
        }

        private List<FacturaReparacionDetalle> ObtenerListaDetalle(DataSet ds)
        {
            List<FacturaReparacionDetalle> _lista = new List<FacturaReparacionDetalle>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var x = new FacturaReparacionDetalle();
                x.NroFactura = dr[0].SafeToLong();
                x.OtReparacion = dr[1].ToString();
                x.Descripcion = dr[2].ToString();
                x.Importe = dr[3].SafeToLong();

                _lista.Add(x);
            }

            return _lista;
        }

        public bool OtEstaFinalizada(string ot, long cuit)
        {
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@OTReparacion", ot);
            hdatos.Add("@Cuit", cuit);
            hdatos.Add("@operacion", 7);

            var ds = _datos.Leer("[SP_FACTURA_DETALLE_VALIDACION]", hdatos);

            return ds.Tables[0].Rows.Count > 0;
        }
    }
}
