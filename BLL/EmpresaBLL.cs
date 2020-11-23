using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class EmpresaBLL : Negocio
    {
        public override Repositorio Repositorio() => new EmpresaDAL();
    }
}
