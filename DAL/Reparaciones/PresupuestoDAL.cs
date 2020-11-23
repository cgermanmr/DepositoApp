using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BEL;
using Interfaces;
using System.Collections;

namespace DAL
{
    public class PresupuestoDAL :Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_Presupuesto";

        public override EntidadBase GetNew => new PresupuestoBEL();

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            var _valor = (PresupuestoBEL)valor;
            if (_valor == null) _valor = new PresupuestoBEL();
            hdatos.Add("@codigoPresupuesto", _valor.Id);
            hdatos.Add("@codigoReparacion", _valor.Reparacion.Id);
            hdatos.Add("@codigoProveedor", _valor.Proveedor.Id);
            hdatos.Add("@fecha",Convert.ToDateTime(_valor.Fecha).ToShortDateString());
            hdatos.Add("@fechaValidez", Convert.ToDateTime(_valor.FechaValidez).ToShortDateString());
            hdatos.Add("@tiempoReparacion", _valor.TiempoEstimado);
            hdatos.Add("@cotizacion", _valor.Cotizacion);
            hdatos.Add("@estado", _valor.Estado);
            hdatos.Add("@moneda", _valor.Moneda.Id);

            return hdatos;
        }
        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            PresupuestoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new PresupuestoBEL();
                x.Id = (int)dr[0];
                x.Proveedor= (EmpresaBEL)new EmpresaDAL().ObtenerUno(new EmpresaBEL() { Id = Convert.ToInt32(dr[1]) });
                x.Fecha = Convert.ToDateTime(dr[2]).ToShortDateString();
                x.FechaValidez = Convert.ToDateTime(dr[3]).ToShortDateString();
                x.TiempoEstimado = Convert.ToInt32(dr[4]);
                x.Cotizacion = Convert.ToDouble(dr[5]);
                x.Moneda = (MonedaBEL)new MonedaDAL().ObtenerUno(new MonedaBEL() { Id=Convert.ToInt32(dr[6])});
                x.Estado = Convert.ToBoolean(dr[7]);
                x.Reparacion = new ReparacionBEL() { Id = Convert.ToInt32(dr[8])};
                _lista.Add(x);
            }

            return _lista;
        }    

       
    }
}
