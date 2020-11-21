using System.Collections.Generic;
using System;
using DAL;
using BEL;
using Interfaces;      
                
namespace Servicios
{
    public class Idioma : ICRUD<IdiomaBEL>
    {
        private IdiomaDAL _mapeadorIdioma = new IdiomaDAL();

        public bool RegistrarLeyenda(LeyendaBEL valor)
        {
            try
            {
                return new IdiomaDAL().RegistrarLeyenda(valor);              
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                throw ex;
            }
        }

        public bool Agregar(IdiomaBEL valor)
        {
            try
            {
                return _mapeadorIdioma.Agregar(valor);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error al agregar Idioma");
            }
        }
                
        public bool Eliminar(IdiomaBEL valor)
        {
            try
            {
                return _mapeadorIdioma.Eliminar(valor);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception personalizada
                throw new Exception("Error al eliminar Idioma");
            }
        }



        public List<IdiomaBEL> Listar()
        {
            try
            {
                return _mapeadorIdioma.Listar();
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error al listar Idioma");
            }
        }

        public IdiomaBEL ObtenerUno(IdiomaBEL filtro)
        {
            try
            {
                return _mapeadorIdioma.ObtenerUno(filtro);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error al obtener un Idioma");
            }
        }

        public bool Modificar(IdiomaBEL valor)
        {
            try
            {
                return _mapeadorIdioma.Modificar(valor);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                // Lanzar Exception  personalizada
                throw new Exception("Error al modificar Idioma");
            }
        }

        public List<IdiomaBEL> Listar(IdiomaBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
