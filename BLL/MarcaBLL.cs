using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class MarcaBLL : Negocio
    {
        public override Repositorio Repositorio() => new MarcaDAL();
    }
}
