using System.Data;
using System.Linq;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class ReparacionDAL:Repository
    {
        protected override string ProcedimientoAlmacenado => "SP_REPARACION";

        public override EntidadBase GetNew => new ReparacionBEL();

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            ReparacionBEL _valor=(ReparacionBEL)valor;

            if (_valor == null) _valor = new ReparacionBEL();
            hdatos.Add("@codRep", _valor.Id);
            hdatos.Add("@codAct", _valor.Activo.Id);
            hdatos.Add("@des", _valor.Descripcion);
            hdatos.Add("@obs", _valor.Observaciones);
            hdatos.Add("@estado", _valor.Estado);
            hdatos.Add("@fecha_solicitud", _valor.FechaSolicitud);
            hdatos.Add("@fecha_finalizacion", _valor.FechaFinalizacion);
            hdatos.Add("@usuario", _valor.Solicitante.Id);
            hdatos.Add("@ticket", _valor.TicketSoporte);

            return hdatos;
        }
        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            ReparacionBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new ReparacionBEL();
                x.Id = (int)dr[0];
                x.Activo = (ActivoBEL)new ActivoDAL().ObtenerUno(new ActivoBEL() { Id = (int)dr[1] });
                x.Descripcion = Convert.IsDBNull(dr[2]) ? string.Empty : dr[2].ToString();
                x.Observaciones = Convert.IsDBNull(dr[3]) ? string.Empty : dr[3].ToString();
                x.Estado = (bool)dr[4];
                x.FechaSolicitud = Convert.ToDateTime(dr[5]).ToShortDateString();
                x.FechaFinalizacion = dr[6].ToString();
                x.TicketSoporte = Convert.IsDBNull(dr[7]) ? 0 : (int)dr[7];
                x.Solicitante = Convert.IsDBNull(dr[8]) ? new ClienteBEL() : (ClienteBEL)new ClienteDAL().ObtenerUno(new ClienteBEL() { Id=Convert.ToInt32(dr[8])}); ;
                x.Presupuestos= new PresupuestoDAL().Listar().FindAll(_ => ((PresupuestoBEL)_).Reparacion.Id==x.Id).ConvertAll(_=>(PresupuestoBEL)_);
                x.Presupuestos.ForEach(_ => _.Reparacion = x);
                _lista.Add(x);
            }

            return _lista;
        }
        
    }
}
