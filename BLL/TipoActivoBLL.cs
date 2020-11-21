using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class TipoActivoBLL : ICRUD<TipoActivoBEL>
    {
        public bool Agregar(TipoActivoBEL valor)
        {
            return new TipoActivoDAL().Agregar(valor);
        }

        public bool Eliminar(TipoActivoBEL valor)
        {
            return new TipoActivoDAL().Eliminar(valor);
        }

        public List<TipoActivoBEL> Listar()
        {
            return new TipoActivoDAL().Listar().ConvertAll(new Converter<object, TipoActivoBEL>(ObjectToTipoActivoBEL));
        }

        private TipoActivoBEL ObjectToTipoActivoBEL(object obj)
        {
            return (TipoActivoBEL)obj;
        }
        public bool Modificar(TipoActivoBEL valor)
        {
            return new TipoActivoDAL().Modificar(valor);
        }


        public TipoActivoBEL ObtenerUno(TipoActivoBEL filtro)
        {
            return ObjectToTipoActivoBEL(new TipoActivoDAL().ObtenerUno(filtro));
        }

        public List<TipoActivoBEL> Listar(TipoActivoBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
