using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class ProveedorBLL : Negocio
    {
        public List<ProveedorBEL> ListarConOTPendientes() => new ProveedorDAL().ListarConOTPendientes();
        public ProveedorBEL GetByCuit(long cuit) => new ProveedorDAL().GetByCuit(cuit);

        public override Repositorio Repositorio() => new ProveedorDAL();
    }
}
