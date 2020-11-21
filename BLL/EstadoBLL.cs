using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class EstadoBLL : Interfaces.ICRUD<EstadoBEL>
    {
        public bool Agregar(EstadoBEL valor)
        {
            return new EstadoDAL().Agregar(valor);
        }

        public bool Eliminar(EstadoBEL valor)
        {
            return new EstadoDAL().Eliminar(valor);
        }

        public List<EstadoBEL> Listar()
        {
            return new EstadoDAL().Listar().ConvertAll(_=>(EstadoBEL)_);
        }

        
        public bool Modificar(EstadoBEL valor)
        {
            return new EstadoDAL().Modificar(valor);
        }

        public EstadoBEL ObtenerUno(EstadoBEL filtro)
        {
            return (EstadoBEL)new EstadoDAL().ObtenerUno(filtro);
        }

        public List<EstadoBEL> Listar(EstadoBEL filtro)
        {
            return new EstadoDAL().Listar(filtro).ConvertAll(_=>(EstadoBEL)_);
        }
    }
}
