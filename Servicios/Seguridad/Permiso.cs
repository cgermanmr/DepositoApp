using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;


namespace Servicios
{
    public class Permiso : ICRUD<PermisoBase>
    {
        private PermisoDAL _mapeador;

        public Permiso()
        {
            _mapeador = new PermisoDAL();
        }


        public bool Agregar(PermisoBase permiso)
        {
            try
            {
                return _mapeador.Agregar(permiso);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error en agregar permiso");
            }
        }

        public bool Eliminar(PermisoBase permiso)
        {
            try
            {
              return _mapeador.Eliminar(permiso);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error en eliminar permiso");
            }
        }

        public List<PermisoBase> Listar()
        {
            try
            {
                List<PermisoBase> _lista = new List<PermisoBase>();

                foreach (PermisoBase i in _mapeador.Listar())
                    _lista.Add(i);

                return _lista;
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error al listar permisos");
            }
        }

        public List<PermisoBase> Listar(PermisoBase filtro)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(PermisoBase permiso)
        {
            try
            {
                return _mapeador.Modificar(permiso);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error en modificar permiso");
            }
        }

        public PermisoBase ObtenerUno(PermisoBase filtro)
        {
            return _mapeador.ObtenerUno(filtro);
        }
    }
}
