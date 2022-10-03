using BEL;
using System.Collections.Generic;
using Comun;
using System;
using Interfaces;
using DAL;

namespace Servicios
{
    public class Sesion : IObservableIdioma
    {
        public event EventHandler CierreSesionEvent; 
       
        public ResultadoAutenticacion Iniciar(UsuarioBEL usuario)
        {
            ResultadoAutenticacion valido = ResultadoAutenticacion.UsuarioInvalido;
            if (!(usuario == null))
            {
                // *************** Restauracion de Base ************
                if (usuario.Nombre.Equals("admin") && usuario.Clave.Equals("admin"))
                {
                    usuario.Perfil.Add(new PermisoSimple() { Nombre = "Integridad_Consultar"});
                    usuario.Perfil.Add(new PermisoSimple() { Nombre = "Backup_Consultar"});
                    usuario.Perfil.Add(new PermisoSimple() { Nombre = "Usuario_Consultar" });
                    
                    EstablecerUsuarioActual(usuario);
                    return ResultadoAutenticacion.UsuarioValido;
                }                                                        

                // buscar el usuario por su nombre
                UsuarioBEL usuarioEncontrado = new Usuario().ObtenerUno(usuario);
                if (!(usuarioEncontrado == null))
                {
                    // verificar que el usuario no este bloqueado
                    if (!usuarioEncontrado.Bloqueado)
                    {
                        // encriptar la clave ingresada por el usuario
                        string claveEncriptada = Criptografia.Get.GetHashMD5(usuario.Clave);
                        // verificar que las contraseñas encriptadas coinciden
                        if (usuarioEncontrado.Clave.Equals(claveEncriptada))
                        {
                            valido = ResultadoAutenticacion.UsuarioValido;
                            // blanquear intentos incorrectos
                            usuarioEncontrado.IntentosIncorrectos = 0;
                            // establecer el usuario logueado actualmente en sesion
                            EstablecerUsuarioActual(usuarioEncontrado);
                            Bitacora.RegistrarEnBitacora("Inicio sesión del usuario: " + usuarioEncontrado.Nombre,TipoEvento.Auditoria);
                        }
                        else
                        {
                            // contraseñas invalidas, incrementar el contado de intentos fallidos
                            usuarioEncontrado.IntentosIncorrectos += 1;
                            Bitacora.RegistrarEnBitacora("Contraseña inválida usuario: " + usuarioEncontrado.Nombre + " Intentos incorrectos: " + usuarioEncontrado.IntentosIncorrectos,TipoEvento.Seguridad);
                            // verificar si los intentos fallidos es mayor o igual a 3
                            if (usuarioEncontrado.IntentosIncorrectos >= 3)
                            {
                                usuarioEncontrado.Bloqueado = true;
                                valido = ResultadoAutenticacion.UsuarioBloqueado;
                                Bitacora.RegistrarEnBitacora("Se bloqueó el usuario: " + usuarioEncontrado.Nombre + " por Intentos incorrectos: " + usuarioEncontrado.IntentosIncorrectos, TipoEvento.Seguridad);
                            }
                        }
                        // guardar los cambios del usuario
                        new Usuario().Modificar(usuarioEncontrado);
                    }
                    else
                    {
                        valido = ResultadoAutenticacion.UsuarioBloqueado;
                        Bitacora.RegistrarEnBitacora("El usuario " + usuarioEncontrado.Nombre + " se encuentra bloqueado", TipoEvento.Seguridad);
                    }
                }
                else
                    Logger.WriteLog("No existe el usuario: " + usuario.Nombre);
                    
            }
            return valido;
        }
        public void Cerrar()
        {
            if(_usuario!=null)
                Bitacora.RegistrarEnBitacora("Cierre sesión del usuario: " + _usuario.Nombre, TipoEvento.Auditoria);
            EstablecerUsuarioActual(null);
            CierreSesionEvent("Cierre Sesión", null);
        }
        public bool TienePermiso(Permisos p)
        {
            string nombrePermiso = p.ToString();
            bool tienePermiso = false;

            var usuario = ObtenerUsuarioActual;
            if (usuario == null) return false;
            
            if (usuario.Perfil.Count > 0)
                foreach (PermisoBase item in usuario.Perfil)
                {
                    tienePermiso |= item.EsValido(nombrePermiso);
                    if (tienePermiso) break;
                }

            return tienePermiso;
        }

        // Implementacion del singleton, solo una instancia en memoria
        private static readonly Sesion _instancia = new Sesion();
        public static Sesion SesionActual() => _instancia;
        private Sesion()
        {           
        }
        public bool Integridad => IntegridadDatos.Verificar();

        private static UsuarioBEL _usuario;
        /// <summary>
        /// Se establece el usuario de la sesión
        /// </summary>
        /// <param name="usuario"></param>
        protected void EstablecerUsuarioActual(UsuarioBEL usuario) => _usuario = usuario;
       
        public UsuarioBEL ObtenerUsuarioActual => _usuario;

        #region Patron Observer Idioma

        private IdiomaBEL _idiomaDefault = new Idioma().ObtenerUno(new IdiomaBEL() { Nombre = "Predeterminado" });
        public IdiomaBEL IdiomaActual
        {
            get
            {
                if (_usuario == null)
                    return _idiomaDefault;
                else
                    return _usuario.Idioma ?? _idiomaDefault;
            }
            set
            {
                _usuario.Idioma = value;
                new Usuario().Modificar(_usuario);

                Notificar();
            }
        }

        private List<IObserverTraducible> _observers = new List<IObserverTraducible>();

        public void Suscribir(IObserverTraducible observer)
        {
            Traductor.RegistrarLeyendas(observer);

            RefreshIdiomaDefault();

            Traductor.Traducir(observer);
            _observers.Add(observer);
        }

        private void RefreshIdiomaDefault()
        {
            _idiomaDefault = new Idioma().ObtenerUno(new IdiomaBEL() { Nombre = "Predeterminado" });
        }

        public void Desuscribir(IObserverTraducible observer)
        {
            _observers.Remove(observer);
        }

        public void Notificar()
        {
            foreach (var item in _observers)
            {
                item.Traducir();
            }
        }

        #endregion
    }
}
