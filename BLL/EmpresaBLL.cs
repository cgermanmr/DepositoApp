using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class EmpresaBLL : ICRUD<EmpresaBEL>
    {
        public bool Agregar(EmpresaBEL valor)
        {
            return new EmpresaDAL().Agregar(valor);
        }

        public bool Eliminar(EmpresaBEL valor)
        {
            return new EmpresaDAL().Eliminar(valor);
        }

        public List<EmpresaBEL> Listar()
        {
            return new EmpresaDAL().Listar().ConvertAll(_=>(EmpresaBEL)_);
        }
        
        public bool Modificar(EmpresaBEL valor)
        {
            return new EmpresaDAL().Modificar(valor);
        }

        public EmpresaBEL ObtenerUno(EmpresaBEL filtro)
        {
            return (EmpresaBEL)new EmpresaDAL().ObtenerUno(filtro);
        }

        public List<EmpresaBEL> Listar(EmpresaBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
