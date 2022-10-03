using System.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Transactions;

namespace DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class UsuarioDAL:ICRUD<UsuarioBEL>
    {
        private UsuarioBEL DataRowToEntidad(DataRow dr)
        {
            string nombre = dr["NOMBRE"].ToString();
            string clave = dr["CLAVE"].ToString();
            string email = dr["EMAIL"].ToString();
            int intentosIncorrectos = (int)dr["INTENTOSFALLIDOS"];
            bool bloqueado = (bool)dr["BLOQUEADO"];
            IdiomaBEL idioma = new IdiomaDAL().ObtenerUno(new IdiomaBEL() { Nombre = dr["IDIOMA"].ToString() });
            List<PermisoBase> perfil = ObtenerPermisos(nombre);
            bool estado = (bool)dr["ESTADO"];

            return new UsuarioBEL() {
                Nombre = nombre,
                Clave = clave,
                Email = email,
                IntentosIncorrectos = intentosIncorrectos,
                Bloqueado = bloqueado,
                Idioma = idioma,
                Perfil = perfil,
                Estado = estado
            };
        }

        private UsuarioBEL DataRowToEntidadH(DataRow dr)
        {
            int ID = (int)dr["ID"];
            string nombre = dr["NOMBRE"].ToString();
            string clave = dr["CLAVE"].ToString();
            string email = dr["EMAIL"].ToString();
            int intentosIncorrectos = (int)dr["INTENTOSFALLIDOS"];
            bool bloqueado = (bool)dr["BLOQUEADO"];
            IdiomaBEL idioma = new IdiomaBEL() { Nombre = dr["IDIOMA"].ToString() };
            bool estado = (bool)dr["ESTADO"];
            string usuarioModificador = dr["USUARIO_MODIFICADOR"].ToString();
            DateTime fecha = (DateTime)dr["FECHA"];
            TipoOperacion tipoModificacion = (TipoOperacion)dr["TIPO_MODIFICACION"];

            return new UsuarioBEL()
            {
                Id = ID,
                Nombre = nombre,
                Clave = clave,
                Email = email,
                IntentosIncorrectos = intentosIncorrectos,
                Bloqueado = bloqueado,
                Idioma = idioma,
                Estado = estado,
                UsuarioModificador = usuarioModificador,
                FechaModificacion = fecha,
                TipoModificacion = tipoModificacion
            };
        }

        private List<PermisoBase> ObtenerPermisos(string NombreUsuario)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            hdatos.Add("@codigoUsuario", NombreUsuario);
            DataSet ds = datos.Leer("SP_USUARIO_LISTAR_PERMISOS", hdatos);
            List<PermisoBase> permisos = new List<PermisoBase>();
            PermisoDAL pd = new PermisoDAL();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                permisos.Add(pd.ObtenerUno((int)dr["COD_PERMISO"]));
            }
            return permisos;               
        }

        public bool Agregar(UsuarioBEL valor)
        {       
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@nombre", valor.Nombre);
            hdatos.Add("@clave", valor.Clave);
            hdatos.Add("@email", valor.Email);
            hdatos.Add("@intentosFallidos", valor.IntentosIncorrectos);
            hdatos.Add("@bloqueado", valor.Bloqueado);
            hdatos.Add("@idioma", valor.Idioma.Nombre);
            hdatos.Add("@estado", valor.Estado);
            hdatos.Add("@usuarioModificador", valor.UsuarioModificador);
            hdatos.Add("@dvh", valor.GetDVH());
            
            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_USUARIO_AGREGAR", hdatos);

                if (resultado && valor.Perfil!=null)
                {
                    foreach (PermisoBase permiso in valor.Perfil)
                        resultado = resultado && AgregarPermiso(valor, permiso);
                }
                scope.Complete();
            }
            return resultado;
        }
        private bool AgregarPermiso(UsuarioBEL valor, PermisoBase permiso)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codigoUsuario", valor.Nombre);
            hdatos.Add("@codigoPermiso", permiso.Id);

            resultado = datos.Escribir("SP_USUARIO_AGREGAR_PERMISO", hdatos);

            return resultado;
        }   
        private bool EliminarPermisos(UsuarioBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@nombre", valor.Nombre);

            resultado = datos.Escribir("SP_USUARIO_ELIMINAR_PERMISOS", hdatos);

            return resultado;
        }
        public bool ModificarClave(UsuarioBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@nombre", valor.Nombre);
            hdatos.Add("@clave", valor.Clave);
            hdatos.Add("@usuarioModificador", valor.UsuarioModificador);
            
            resultado = datos.Escribir("SP_USUARIO_MODIFICAR_CLAVE", hdatos);

            return resultado;
        }                
        public bool Modificar(UsuarioBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@nombre", valor.Nombre);
            hdatos.Add("@email", valor.Email);
            hdatos.Add("@intentosFallidos", valor.IntentosIncorrectos);
            hdatos.Add("@bloqueado", valor.Bloqueado);
            hdatos.Add("@idioma", valor.Idioma.Nombre);
            hdatos.Add("@estado", valor.Estado);
            hdatos.Add("@usuarioModificador", valor.UsuarioModificador);
            hdatos.Add("@dvh", valor.GetDVH());

            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_USUARIO_MODIFICAR", hdatos);

                if (resultado && valor.Perfil != null)
                {
                    EliminarPermisos(valor);
                    foreach (PermisoBase permiso in valor.Perfil)
                        resultado = resultado && AgregarPermiso(valor, permiso);
                }
                scope.Complete();
            }

            return resultado;
        }         
        public bool Eliminar(UsuarioBEL valor)
        {
            bool resultado;

            valor.Estado = false;

            resultado=Modificar(valor);

            return resultado;
        }   
        public List<UsuarioBEL> Listar()
        {
            var datos = new Datos();
            DataSet ds = datos.Leer("SP_USUARIO_LISTAR", null);
            List<UsuarioBEL> usuarios = new List<UsuarioBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                usuarios.Add(DataRowToEntidad(dr));
            }                                     
            return usuarios;
        }

        public List<UsuarioBEL> ListarHistorico()
        {
            var datos = new Datos();
            DataSet ds = datos.Leer("SP_USUARIO_LISTAR_HISTORICO", null);
            List<UsuarioBEL> usuarios = new List<UsuarioBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                usuarios.Add(DataRowToEntidadH(dr));
            }
            return usuarios;
        }
        public UsuarioBEL ObtenerUno(UsuarioBEL filtro)
        {                                                               
            return Listar().Find(x=>x.Nombre==filtro.Nombre);
        }

        public List<UsuarioBEL> Listar(UsuarioBEL filtro)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioBEL> Listar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
