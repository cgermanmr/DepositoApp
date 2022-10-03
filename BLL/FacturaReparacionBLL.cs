using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;
using Servicios;
using System.Linq;

namespace BLL
{
    public class FacturaReparacionBLL : ICRUD<FacturaReparacionBEL>
    {
        private FacturaReparacionDAL _repo = new FacturaReparacionDAL();

        public FacturaReparacionDetalle GetDetalleById(string ot,long cuit) => _repo.GetDetalleById(ot,cuit);

        public bool ExiteOTPresupuestada(string ot, long cuit) => _repo.ExisteOTPresupuestada(ot, cuit);

        public bool OtEstaFinalizada(string ot, long cuit) => _repo.OtEstaFinalizada(ot, cuit);

        public bool Agregar(FacturaReparacionBEL valor)
        {
            var result = _repo.Agregar(valor);
            IntegridadDatos.RegenerarDV();
            return result;
        }

        public bool Modificar(FacturaReparacionBEL valor)
        {
            var result = _repo.Modificar(valor);
            IntegridadDatos.RegenerarDV();
            return result;

        }

        public bool Eliminar(FacturaReparacionBEL valor)
        {
            var result = _repo.Eliminar(valor);
            IntegridadDatos.RegenerarDV();
            return result;
        }

        public List<FacturaReparacionBEL> Listar()
        {
            return _repo.Listar().Select(x => (FacturaReparacionBEL)x ).ToList();
        }

        public List<FacturaReparacionBEL> Listar(string filtro)
        {
            return _repo.Listar(filtro).Select(x => (FacturaReparacionBEL)x).ToList();
        }

        public List<FacturaReparacionBEL> Listar(FacturaReparacionBEL filtro)
        {
            return _repo.Listar(filtro).Select(x => (FacturaReparacionBEL)x).ToList();
        }

        public FacturaReparacionBEL ObtenerUno(FacturaReparacionBEL filtro)
        {
            return _repo.ObtenerUno(filtro) as FacturaReparacionBEL;
        }
    }
}
