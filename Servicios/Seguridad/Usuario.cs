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
                usuario.Clave = Criptografia.Get.GetHashMD5(usuario.Clave);
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
            catch (Exception)
            {               
                throw;
            }
        }

        public bool ModificarClave(UsuarioBEL usuario)
        {
            
            usuario.Clave = Criptografia.Get.GetHashMD5(usuario.Clave);
            usuario.UsuarioModificador = Sesion.SesionActual().ObtenerUsuarioActual.Nombre;
            var resultado = new UsuarioDAL().ModificarClave(usuario);
            IntegridadDatos.RegenerarDV();
            return resultado;
          
        }
        public bool Modificar(UsuarioBEL usuario)
        {
           
            usuario.UsuarioModificador = (Sesion.SesionActual().ObtenerUsuarioActual!=null)? Sesion.SesionActual().ObtenerUsuarioActual.Nombre:"No registrado";
            var resultado = new UsuarioDAL().Modificar(usuario);
            IntegridadDatos.RegenerarDV();
            return resultado;
           
        }
        public bool Eliminar(UsuarioBEL usuario)
        {
            usuario.UsuarioModificador = Sesion.SesionActual().ObtenerUsuarioActual.Nombre;
            var resultado= new UsuarioDAL().Eliminar(usuario);
            IntegridadDatos.RegenerarDV();
            return resultado;
        }

        public List<UsuarioBEL> Listar()
        {
           return new UsuarioDAL().Listar();
        }

        public List<UsuarioBEL> ListarHistorico()
        {
           return new UsuarioDAL().ListarHistorico();
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

        public List<UsuarioBEL> Listar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
