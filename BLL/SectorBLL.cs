using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;


namespace BLL
{
    public class SectorBLL : Negocio
    {
        public override Repositorio Repositorio() => new SectorDAL();
    }
}
