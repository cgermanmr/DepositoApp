using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class ProveedorBLL : Negocio
    {
        public object GetByCuit(long cuit) => new ProveedorDAL().GetByCuit(cuit);

        public override Repositorio Repositorio() => new ProveedorDAL();
    }
}
