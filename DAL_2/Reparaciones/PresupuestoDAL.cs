using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BEL;
using Interfaces;
using System.Collections;
using Comun;

namespace DAL
{
    public class PresupuestoDAL:Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_Presupuesto";

        public override Entidad GetNew => new PresupuestoBEL();

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            var _valor = (PresupuestoBEL)valor;
            if (_valor == null) _valor = new PresupuestoBEL();
            hdatos.Add("@id", _valor.Id);
            hdatos.Add("@codigoReparacion", _valor.Reparacion.Id);
            hdatos.Add("@codigoProveedor", _valor.Proveedor.Id);
            hdatos.Add("@fecha",_valor.Fecha);
            hdatos.Add("@fechaValidez", _valor.FechaValidez);
            hdatos.Add("@tiempoReparacion", _valor.TiempoEstimado);
            hdatos.Add("@cotizacion", _valor.Cotizacion);
            hdatos.Add("@autorizado", _valor.Autorizado);
            hdatos.Add("@moneda", _valor.Moneda);
            hdatos.Add("@descripcion", _valor.Descripcion);
            hdatos.Add("@ot", _valor.OtProveedor);

            return hdatos;
        }
        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<Entidad> _lista = new List<Entidad>();
            PresupuestoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new PresupuestoBEL();
                x.Id = dr[0].SafeToLong();
                x.Proveedor= new ProveedorDAL().GetById(dr[1]) as ProveedorBEL;
                x.Fecha = dr[2].SafeToDateTime();
                x.FechaValidez = dr[3].SafeToDateTime();
                x.TiempoEstimado = dr[4].SafeToInt();
                x.Cotizacion = dr[5].SafeToDouble();
                x.Estado = (bool)dr[6];
                x.ReparacionId = dr[7].SafeToLong();
                x.Descripcion = dr[8].ToString();
                x.Autorizado = (bool)dr[9];
                x.Moneda = (TipoMoneda)dr[10].SafeToInt();
                x.OtProveedor = dr[11].ToString();
                _lista.Add(x);
            }

            return _lista;
        }

        internal List<PresupuestoBEL> GetByReparacion(long idReparacion)
        {
            var hdatos = new Hashtable();

            hdatos.Add("@codigoReparacion", idReparacion);
            hdatos.Add("@operacion", 5);

            var ds = _datos.Leer(ProcedimientoAlmacenado, hdatos);

            return ObtenerLista(ds).Select( x => (PresupuestoBEL)x).ToList();
        }

        public PresupuestoBEL GetByOtProveedor(string ot,long cuit)
        {
            var hdatos = new Hashtable();

            hdatos.Add("@ot", ot);
            hdatos.Add("@cuitProveedor", cuit);
            hdatos.Add("@operacion", 6);

            var ds = _datos.Leer(ProcedimientoAlmacenado, hdatos);

            return ObtenerLista(ds).Select(x => (PresupuestoBEL)x).FirstOrDefault();
        }
    }
}
