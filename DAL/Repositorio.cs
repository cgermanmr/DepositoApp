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
    public abstract class Repositorio: ICRUD<EntidadBase>
    {
        /***************** Modificar nombre procedimiento y tipos *******************************************/
        protected readonly Datos _datos = new Datos();
        protected abstract string ProcedimientoAlmacenado { get; }
        public abstract EntidadBase GetNew { get; }
        protected virtual Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();

            if (valor == null) valor = GetNew;
            hdatos.Add("@cod", valor.Id);
            hdatos.Add("@des", valor.Descripcion);
            
            return hdatos;
        }
        protected virtual List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            EntidadBase x;
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
        public virtual bool Agregar(EntidadBase valor)
        {
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", (int)TipoOperacion.Alta);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual bool Eliminar(EntidadBase valor)
        {
            bool resultado;

            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", (int)TipoOperacion.Baja);
            parametros.Add("@id", valor.Id);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
      
        public virtual bool Modificar(EntidadBase valor)
        {
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", TipoOperacion.Modificación);

            resultado = _datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual List<EntidadBase> Listar()
        {
            Hashtable parametros = new Hashtable();//ObtenerParametros(null);
            parametros.Add("@operacion", (int)TipoOperacion.Consulta);

            DataSet ds = _datos.Leer(ProcedimientoAlmacenado, parametros);

            return ObtenerLista(ds);
        }

        public virtual List<EntidadBase> Listar(string filtro) => Listar();
        public virtual List<EntidadBase> Listar(EntidadBase filtro) => Listar();

        public virtual EntidadBase ObtenerUno(EntidadBase valor)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", (int)TipoOperacion.Consulta);
            parametros.Add("@id", valor.Id);

            DataSet ds = _datos.Leer(ProcedimientoAlmacenado, parametros);

            var _lista = ObtenerLista(ds);

            if (_lista.Count > 0) return _lista.FirstOrDefault();
            
            return null;
        }

    }
}
