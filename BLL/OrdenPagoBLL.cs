using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace BLL
{
    public class OrdenPagoBLL : Negocio
    {
        public List<OrdenPagoReportBEL> GetDatosOrdenPagoReporte(long nroOrdenPago)
        {
            return new OrdenPagoDAL().GetDatosOrdenPagoReporte(nroOrdenPago);
        }

        public override Repositorio Repositorio()
        {
            return new OrdenPagoDAL();
        }
    }
}
