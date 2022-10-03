using System;
using System.Collections.Generic;
using System.Text;
using Comun;
using Interfaces;

namespace BEL
{

    public class UsuarioBEL : Entidad, Interfaces.IAuditable
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public int IntentosIncorrectos { get; set; }
        public bool Bloqueado { get; set; }

        public List<PermisoBase> Perfil { get; set; } = new List<PermisoBase>();

        public IdiomaBEL Idioma { get; set; }
        public string UsuarioModificador { get; set; }
        public DateTime FechaModificacion { get; set; }
        public TipoOperacion TipoModificacion { get; set; }
    
        public string GetDVH()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Nombre);
            sb.Append(Clave);
            sb.Append(Email);
            sb.Append(IntentosIncorrectos);
            sb.Append(Bloqueado);
            sb.Append(Idioma.Nombre);
            sb.Append(Estado);

            return Criptografia.Get.GetHashMD5(sb.ToString());
        }
        public override bool Equals(object obj)
        {
            if (!(obj == null) && obj is UsuarioBEL)
                return Nombre.Equals(((UsuarioBEL)obj).Nombre);
            else
                return false;
        }        
        public override string ToString()
        {
            return Nombre;
        }
    }
}
