using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class UbicacionBLL : Negocio
    {
        public override Repositorio Repositorio() => new UbicacionDAL();
    }
}
