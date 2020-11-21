using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class MarcaBLL : ICRUD<MarcaBEL>
    {
        public bool Agregar(MarcaBEL valor)
        {
            return new MarcaDAL().Agregar(valor);
        }

        public bool Eliminar(MarcaBEL valor)
        {
            return new MarcaDAL().Eliminar(valor);
        }

        public List<MarcaBEL> Listar()
        {
            return new MarcaDAL().Listar().ConvertAll(new Converter<object, MarcaBEL>(ObjectToMarcaBEL));
        }

        private MarcaBEL ObjectToMarcaBEL(object obj)
        {
            return (MarcaBEL)obj;
        }
        public bool Modificar(MarcaBEL valor)
        {
            return new MarcaDAL().Modificar(valor);
        }

        public MarcaBEL ObtenerUno(MarcaBEL filtro)
        {
            return (MarcaBEL)new MarcaDAL().ObtenerUno(filtro);
        }

        public List<MarcaBEL> Listar(MarcaBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
