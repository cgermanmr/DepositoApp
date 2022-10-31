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

        public void AgregarReemplazo(ReemplazoTemporalBEL reemplazo)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", 10);
            parametros.Add("@activo", reemplazo.Activo);
            parametros.Add("@id", reemplazo.Reparacion);
            parametros.Add("@fecha_solicitud", reemplazo.Inicio);
            parametros.Add("@fecha_finalizacion", reemplazo.Fin);
            parametros.Add("@estado", reemplazo.Definitivo);
            parametros.Add("@descripcion", reemplazo.Descripcion);

            _datos.Escribir("[SP_REPARACION]", parametros);

        }

        public void EliminarReemplazo(ReemplazoTemporalBEL reemplazo)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", 11);
            parametros.Add("@activo", reemplazo.Activo);
            parametros.Add("@id", reemplazo.Reparacion);

            _datos.Escribir("[SP_REPARACION]", parametros);
        }

        public List<ReemplazoTemporalBEL> ListarReemplazos(long reparacion)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", 13);
            parametros.Add("@id", reparacion);

            var ds = _datos.Leer("[SP_REPARACION]", parametros);

            return ObtenerListaReemplazos(ds);
        }

        protected List<ReemplazoTemporalBEL> ObtenerListaReemplazos(DataSet ds)
        {
            var _lista = new List<ReemplazoTemporalBEL>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                var x = new ReemplazoTemporalBEL();
                x.Activo = dr[0].SafeToLong();
                x.Reparacion= dr[1].SafeToLong();
                x.Inicio = dr[2].SafeToDateTime();
                x.Fin = dr[3].SafeToDateTime();
                x.Descripcion = dr[4].ToString();
                x.Definitivo = (bool)dr[5];

                _lista.Add(x);
            }

            return _lista;
        }

       

    }
}
