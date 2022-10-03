using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class FacturaReparacionBLL : Negocio
    {
        private FacturaReparacionDAL _repo = new FacturaReparacionDAL();
        public override Repositorio Repositorio() => _repo;

        public FacturaReparacionDetalle GetDetalleById(string ot,long cuit) => _repo.GetDetalleById(ot,cuit);

        public bool ExiteOTPresupuestada(string ot, long cuit) => _repo.ExisteOTPresupuestada(ot, cuit);

        public bool OtEstaFinalizada(string ot, long cuit) => _repo.OtEstaFinalizada(ot, cuit);
    }
}
