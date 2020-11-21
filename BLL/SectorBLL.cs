using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;


namespace BLL
{
    public class SectorBLL : ICRUD<SectorBEL>
    {
        public bool Agregar(SectorBEL valor)
        {
            return new SectorDAL().Agregar(valor);
        }

        public bool Eliminar(SectorBEL valor)
        {
            return new SectorDAL().Eliminar(valor);
        }

        public List<SectorBEL> Listar()
        {
            return new SectorDAL().Listar().ConvertAll(_=>(SectorBEL)_);
        }

        public bool Modificar(SectorBEL valor)
        {
            return new SectorDAL().Modificar(valor);
        }

        public SectorBEL ObtenerUno(SectorBEL filtro)
        {
            return (SectorBEL)new SectorDAL().ObtenerUno(filtro);
        }

        public List<SectorBEL> Listar(SectorBEL filtro)
        {
            return new SectorDAL().Listar(filtro).ConvertAll(_=>(SectorBEL)_);
        }
    }
}
