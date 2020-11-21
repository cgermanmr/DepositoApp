using System.Data;
using Interfaces;
using System.Collections.Generic;
using System;
using BEL;
using System.Collections;
using System.Transactions;

namespace DAL
{
    public class PermisoDAL : ICRUD<PermisoBase>
    {
        private int ObtenerProximoID()
        {
            var datos = new Datos();
            DataSet ds;
            
            ds = datos.Leer("SP_PERMISO_PROXIMO_ID", null);

            return (int)ds.Tables[0].Rows[0][0];
        }
        public bool Agregar(PermisoBase valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            valor.Id = ObtenerProximoID();
            hdatos.Add("@codigoPermiso", valor.Id);
            hdatos.Add("@nombre", valor.Nombre);
            hdatos.Add("@descripcion", valor.Descripcion);

            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_PERMISO_AGREGAR", hdatos);

                if (resultado)
                {
                    foreach (PermisoBase hijo in valor.ObtenerHijos())
                        resultado = resultado && AgregarHijo(valor, hijo);
                }
                scope.Complete();
            }

            return resultado;
           
        }

        public PermisoBase ObtenerUno(int CodigoPermiso)
        {
            return ObtenerUno(new PermisoCompuesto { Id = CodigoPermiso });
        }
        public PermisoBase ObtenerUno(PermisoBase filtro)
        {
           return Listar().Find(x => x.Id == filtro.Id | x.Nombre == filtro.Nombre);
        }
       
        public bool Eliminar(PermisoBase valor)
        {                  
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoPermiso", valor.Id);
              
            resultado = datos.Escribir("SP_PERMISO_ELIMINAR", hdatos);

            return resultado;            
        }

        public List<PermisoBase> Listar()
        {
            if (CacheDatos.Permisos != null) return CacheDatos.Permisos;

            var datos = new Datos();
            var hdatos = new Hashtable();
            DataSet ds = datos.Leer("SP_PERMISO_LISTAR", null);
            List<PermisoBase> permisos = new List<PermisoBase>();
            PermisoBase p;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                p = (bool)dr["ES_ACCION"] == true? (PermisoBase)new PermisoSimple(): new PermisoCompuesto();
                p.Id = (int)dr["COD_PERMISO"];
                p.Nombre = dr["NOMBRE"].ToString();
                p.Descripcion = dr["DESCRIPCION"].ToString();
                if (p.TieneHijos())
                    p.ObtenerHijos().AddRange(ListarHijos(p));
                permisos.Add(p);
            }

            CacheDatos.Permisos = permisos;

            return permisos;                   
        }

        public bool Modificar(PermisoBase valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoPermiso", valor.Id);
            hdatos.Add("@nombre", valor.Nombre);
            hdatos.Add("@descripcion", valor.Descripcion);

            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_PERMISO_MODIFICAR", hdatos);

                if (resultado)
                {
                    QuitarTodosHijos(valor);
                    foreach (PermisoBase hijo in valor.ObtenerHijos())
                        resultado = resultado && AgregarHijo(valor, hijo);
                }
                scope.Complete();
            }

            return resultado;  
        }

        public bool AgregarHijo(PermisoBase padre, PermisoBase hijo)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoPadre", padre.Id);
            hdatos.Add("@codigoHijo", hijo.Id);

            resultado = datos.Escribir("SP_PERMISO_AGREGAR_HIJO", hdatos);

            return resultado;             
        }

        public List<PermisoBase> ListarHijos(PermisoBase valor)
        {
            
            var datos = new Datos();
            var hdatos = new Hashtable();
            hdatos.Add("@codigoPadre", valor.Id);
            DataSet ds = datos.Leer("SP_PERMISO_LISTAR_HIJOS", hdatos);

            List<PermisoBase> permisos = new List<PermisoBase>();
            PermisoBase p;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                p = (bool)dr["ES_ACCION"] == true ? (PermisoBase)new PermisoSimple() : new PermisoCompuesto();
                p.Id = (int)dr["COD_PERMISO"];
                p.Nombre = dr["NOMBRE"].ToString();
                p.Descripcion = dr["DESCRIPCION"].ToString();
                if (p.TieneHijos())
                    p.ObtenerHijos().AddRange(ListarHijos(p));
                permisos.Add(p);
            }               
            return permisos;
           
        }

        public bool QuitarHijo(PermisoBase padre, PermisoBase hijo)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoPadre", padre.Id);
            hdatos.Add("@codigoHijo", hijo.Id);
                
            resultado = datos.Escribir("SP_PERMISO_ELIMINAR_HIJO", hdatos);

            return resultado;             
        }

        public bool QuitarTodosHijos(PermisoBase padre)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoPadre", padre.Id);

            resultado = datos.Escribir("SP_PERMISO_ELIMINAR_HIJOS", hdatos);

            return resultado;
        }

        public List<PermisoBase> Listar(PermisoBase filtro)
        {
            throw new NotImplementedException();
        }
    }
}
