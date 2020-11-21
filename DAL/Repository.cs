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
    public abstract class Repository: ICRUD<EntidadBase>
    {
        /***************** Modificar nombre procedimiento y tipos *******************************************/
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
            var datos = new Datos();
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", 1);

            resultado = datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual bool Eliminar(EntidadBase valor)
        {
            var datos = new Datos();
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", 2);

            resultado = datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
      
        public virtual bool Modificar(EntidadBase valor)
        {
            var datos = new Datos();
            bool resultado;

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", 3);

            resultado = datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }
        public virtual List<EntidadBase> Listar()
        {
            var datos = new Datos();

            Hashtable parametros = ObtenerParametros(null);
            parametros.Add("@operacion", 4);

            DataSet ds = datos.Leer(ProcedimientoAlmacenado, parametros);

            return ObtenerLista(ds);
        }

        public virtual List<EntidadBase> Listar(EntidadBase filtro)
        {
            var datos = new Datos();

            Hashtable parametros = ObtenerParametros(filtro);
            parametros.Add("@operacion", 4);

            DataSet ds = datos.Leer(ProcedimientoAlmacenado, parametros);

            return ObtenerLista(ds);
        }
        public virtual EntidadBase ObtenerUno(EntidadBase valor)
        {
            var datos = new Datos();

            Hashtable parametros = ObtenerParametros(valor);
            parametros.Add("@operacion", 5);

            DataSet ds = datos.Leer(ProcedimientoAlmacenado, parametros);

            var _lista = ObtenerLista(ds);

            if (_lista.Count > 0) return _lista.First();
            else return null;
        }

    }
}
