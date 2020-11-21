using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;
using Comun;
using System.Reflection;

namespace Servicios
{
    public class Usuario : ICRUD<UsuarioBEL>
    {       

        public bool Agregar(UsuarioBEL usuario)
        {
            try
            {
                usuario.Clave = Criptografia.ObtenerInstancia.GetHashMD5(usuario.Clave);
                usuario.UsuarioModificador = Sesion.SesionActual().ObtenerUsuarioActual.Nombre;
                var resultado = new UsuarioDAL().Agregar(usuario);
                IntegridadDatos.RegenerarDV();
                return resultado;
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                Logger.WriteLogExeption(sqlEx);
                if (sqlEx.Number == 2627)
                    throw new Exception($"Ya existe el usuario: {usuario.Nombre}");
                else
                {
                    Logger.WriteLogExeption(sqlEx);
                    throw new Exception($"Error en Agregar Usuario {MethodBase.GetCurrentMethod().Name} {MethodBase.GetCurrentMethod().MemberType.ToString()}");
                }                      
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception personalizada
                Logger.WriteLogExeption(ex);
                throw new Exception($"Error en Agregar Usuario {MethodBase.GetCurrentMethod().Name} {MethodBase.GetCurrentMethod().MemberType.ToString()}");
            }
        }

        public bool ModificarClave(UsuarioBEL usuario)
        {
            try
            {
                usuario.Clave = Criptografia.ObtenerInstancia.GetHashMD5(usuario.Clave);
                usuario.UsuarioModificador = Sesion.SesionActual().ObtenerUsuarioActual.Nombre;
                var resultado = new UsuarioDAL().ModificarClave(usuario);
                IntegridadDatos.RegenerarDV();
                return resultado;
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                throw new Exception("Error en Modificar Clave Usuario");
            }
        }
        public bool Modificar(UsuarioBEL usuario)
        {
            try
            {
                usuario.UsuarioModificador = (Sesion.SesionActual().ObtenerUsuarioActual!=null)? Sesion.SesionActual().ObtenerUsuarioActual.Nombre:"No registrado";
                var resultado = new UsuarioDAL().Modificar(usuario);
                IntegridadDatos.RegenerarDV();
                return resultado;
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                throw new Exception("Error en Modificar Usuario");
            }
        }
        public bool Eliminar(UsuarioBEL usuario)
        {
            try
            {
                usuario.UsuarioModificador = Sesion.SesionActual().ObtenerUsuarioActual.Nombre;
                var resultado= new UsuarioDAL().Eliminar(usuario);
                IntegridadDatos.RegenerarDV();
                return resultado;
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception personalizada
                throw new Exception("Error en Eliminar Usuario");
            }
        }

        public List<UsuarioBEL> Listar()
        {
            try
            {
                return new UsuarioDAL().Listar();
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception personalizada
                throw new Exception("Error en Listar Usuario");
            }
        }

        public List<UsuarioBEL> ListarHistorico()
        {
            try
            {
                return new UsuarioDAL().ListarHistorico();
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception personalizada
                throw new Exception("Error en Listar Usuario");
            }
        }


        private UsuarioBEL ObjectToUsuarioBEL(object obj)
        {
            return (UsuarioBEL)obj;
        }

        public UsuarioBEL ObtenerUno(UsuarioBEL filtro)
        {
            return new UsuarioDAL().ObtenerUno(filtro);
        }

        public List<UsuarioBEL> Listar(UsuarioBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
