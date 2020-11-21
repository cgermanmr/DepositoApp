using System.Collections.Generic;
using System;

namespace BEL
{
    [Serializable()]
    public class PermisoCompuesto : PermisoBase
    {
        private List<PermisoBase> _listaHijos = new List<PermisoBase>();

        public override bool EsValido(string nombrePermiso)
        {
            bool tieneUnValido = false;
            foreach (var p in _listaHijos)
            {
                tieneUnValido = tieneUnValido | p.EsValido(nombrePermiso);
                if (tieneUnValido) break;
            }
             
            return tieneUnValido;
        }

        public override bool TieneHijos()
        {
            return true;
        }

        public override bool AgregarHijo(PermisoBase permiso)
        {
            if (!_listaHijos.Contains(permiso))
            {
                _listaHijos.Add(permiso);
                return true;
            }
            else
                return false;
        }

        public override System.Collections.Generic.List<PermisoBase> ObtenerHijos()
        {
            return _listaHijos;
        }

        public override bool QuitarHijo(PermisoBase permiso)
        {
            return _listaHijos.Remove(permiso);
        }

        public override void LimpiarHijos()
        {
            _listaHijos.Clear();
        }
    }
}
