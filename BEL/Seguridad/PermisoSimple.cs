using System;

namespace BEL
{
    [Serializable()]
    public class PermisoSimple : PermisoBase
    {
        public override bool EsValido(string nombrePermiso)
        {
            return Nombre.Equals(nombrePermiso);
        }

        public override bool TieneHijos()
        {
            return false;
        }

        public override bool AgregarHijo(PermisoBase permiso)
        {
            return false;
        }

        public override System.Collections.Generic.List<PermisoBase> ObtenerHijos()
        {
            return null;
        }

        public override bool QuitarHijo(PermisoBase permiso)
        {
            return false;
        }

        public override void LimpiarHijos()
        {
        }
    }
}
