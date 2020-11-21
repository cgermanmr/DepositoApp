using System.Collections.Generic;
using System;
using DAL;
using BEL;
using Interfaces;
using Servicios;

namespace BLL
{
    public class ActivoBLL : Negocio
    {
        public override Repository Repositorio() => new ActivoDAL();

        public override bool Agregar(EntidadBase valor)
        {
            ActivoBEL _activo = (ActivoBEL)valor;
            var _lista = new ActivoDAL().Listar().ConvertAll(x=>(ActivoBEL)x);
            if (_lista.Find(x=>x.Inventario==_activo.Inventario || x.Serie==_activo.Serie)!= null)
                throw new InvalidOperationException("Existe un elemento con el mismo Nro de Inventario o Nro de Serie");

            return base.Agregar(valor);
        }
    }
}
