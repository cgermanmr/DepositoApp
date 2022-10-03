using System.Data;
using System.Linq;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;
using Comun;

namespace DAL
{
    public class ReparacionDAL:Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_REPARACION";

        public override Entidad GetNew => new ReparacionBEL();

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            ReparacionBEL _valor=(ReparacionBEL)valor;

            if (_valor == null) _valor = new ReparacionBEL();
            hdatos.Add("@id", _valor.Id);
            hdatos.Add("@activo", _valor.Activo.Id);
            hdatos.Add("@descripcion", _valor.Descripcion);
            hdatos.Add("@estado", _valor.Estado);
            hdatos.Add("@fecha_solicitud", _valor.FechaSolicitud);
            hdatos.Add("@fecha_finalizacion", _valor.FechaFinalizacion);
            hdatos.Add("@usuario", _valor.Solicitante.Id);
            hdatos.Add("@ticket", _valor.TicketSoporte);

            return hdatos;
        }
        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<Entidad> _lista = new List<Entidad>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var x = new ReparacionBEL();
                x.Id = (int)dr[0];
                x.Activo = (ActivoBEL)new ActivoDAL().GetById(dr[1]);
                x.Descripcion = dr[2].BlankIfDbNull();
                x.Estado = (bool)dr[3];
                x.FechaSolicitud = dr[4].SafeToDateTime();
                x.FechaFinalizacion = dr[5].SafeToDateTime();
                x.TicketSoporte = dr[6].ZeroIfDbNull();
                x.Solicitante = new ClienteDAL().GetById(dr[7]) as ClienteBEL;
                x.Presupuestos= new PresupuestoDAL().GetByReparacion(x.Id).ToList();

                x.Presupuestos.ForEach(_ => _.Reparacion = x);

                _lista.Add(x);
            }

            return _lista;
        }
        
    }
}
