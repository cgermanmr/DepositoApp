using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace BLL
{
    public class ReparacionBLL : Negocio
    {
        public void AgregarReemplazo(ReemplazoTemporalBEL reemplazo)
        {
            new ReparacionDAL().AgregarReemplazo(reemplazo);
        }

        public void EliminarReemplazo(ReemplazoTemporalBEL reemplazo)
        {
            new ReparacionDAL().EliminarReemplazo(reemplazo);
        }

        public List<ReemplazoTemporalBEL> ListarReemplazos(long reparacion)
        {
            return new ReparacionDAL().ListarReemplazos(reparacion);
        }

        public override Repositorio Repositorio() => new ReparacionDAL();
    }
}
