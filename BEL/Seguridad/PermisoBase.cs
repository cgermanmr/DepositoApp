using System.Collections.Generic;

namespace BEL
{
    public abstract class PermisoBase : Entidad
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public abstract bool EsValido(string nombrePermiso);

        public abstract bool TieneHijos();

        public abstract void LimpiarHijos();

        public abstract bool AgregarHijo(PermisoBase permiso);

        public abstract bool QuitarHijo(PermisoBase permiso);

        public abstract List<PermisoBase> ObtenerHijos();

        public override string ToString()
        {
            return Nombre;
        }

        public override bool Equals(object obj)
        {
            if (!(obj == null))
            {
                if (obj is PermisoBase)
                    // comparacion contra un objeto PermisoBase
                    return Nombre.Equals(((PermisoBase)obj).Nombre);
                else if (obj is string)
                    // comparacion contra un String
                    return Nombre.Equals(obj);
                else
                    return false;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
