using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class UbicacionBLL : ICRUD<UbicacionBEL>
    {
        public bool Agregar(UbicacionBEL valor)
        {
            try
            {
               
                return new UbicacionDAL().Agregar(valor);
                            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex);
                throw new InvalidOperationException("Error al agregar");
            }
        }

        public bool Eliminar(UbicacionBEL valor)
        {
            try
            {
                return new UbicacionDAL().Eliminar(valor);

            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex);
                throw new InvalidOperationException("Se ha pruducido un error al eliminar ");
               
            }
        }

        public List<UbicacionBEL> Listar()
        {
            try
            {
                return new UbicacionDAL().Listar().ConvertAll(_=>(UbicacionBEL)_);

            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex);
                throw new InvalidOperationException("Error al listar");
            }
        }

        public bool Modificar(UbicacionBEL valor)
        {
            return new UbicacionDAL().Modificar(valor);
        }

        public UbicacionBEL ObtenerUno(UbicacionBEL filtro)
        {
            return (UbicacionBEL)new UbicacionDAL().ObtenerUno(filtro);
        }

        public List<UbicacionBEL> Listar(UbicacionBEL filtro)
        {
            return new UbicacionDAL().Listar(filtro).ConvertAll(_=>(UbicacionBEL)_);
        }
    }
}
