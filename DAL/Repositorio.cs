using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using System.Collections;
using Interfaces;

namespace DAL
{
    public abstract class Repositorio: ICRUD<Entidad>
    {
        /***************** Modificar nombre procedimiento y tipos *******************************************/
        protected readonly Datos _datos = new Datos();
        protected abstract string ProcedimientoAlmacenado { get; }
        public abstract Entidad GetNew { get; }
        protected virtual Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();

            if (valor == null) valor = GetNew;
            hdatos.Add("@cod", valor.Id);
            hdatos.Add("@des", valor.Descripcion);
            
            return hdatos;
        }
        protected virtual List<Entidad> ObtenerLista(DataSet ds)
        {
            List<Entidad> _lista = new List<Entidad>();
            Entidad x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = GetNew;
                x.Id = Convert.ToInt32(dr[0]);
                x.Descripcion = dr[1].ToString().Trim();
                _lista.Add(x);
            }

            return _lista;
        }
        /***********************************************************************/
        public virtual bool Agregar(Entidad valor)
        {
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", (int)TipoOperacion.Alta);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual bool Eliminar(Entidad valor)
        {
            bool resultado;

            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", (int)TipoOperacion.Baja);
            parametros.Add("@id", valor.Id);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
      
        public virtual bool Modificar(Entidad valor)
        {
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", TipoOperacion.Modificación);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual List<Entidad> Listar()
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", (int)TipoOperacion.Consulta);

            DataSet ds = _datos.Leer(ProcedimientoAlmacenado, parametros);

            return ObtenerLista(ds);
        }

        public virtual List<Entidad> Listar(string filtro) => Listar();
        public virtual List<Entidad> Listar(Entidad filtro) => Listar();
        public virtual Entidad ObtenerUno(Entidad valor)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", (int)TipoOperacion.Consulta);
            parametros.Add("@id", valor.Id);

            DataSet ds = _datos.Leer(ProcedimientoAlmacenado, parametros);

            var _lista = ObtenerLista(ds);

            if (_lista.Count > 0) 
                return _lista.FirstOrDefault();
            
            return null;
        }

        public Entidad GetById(object id)
        {

            var obj = GetNew;

            if (!long.TryParse(id.ToString(), out long _id))
                return null;

            obj.Id = _id;

            return ObtenerUno(obj);
        }

    }
}
