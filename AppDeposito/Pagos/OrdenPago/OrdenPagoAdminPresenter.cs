using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Pagos.OrdenPago
{

    public class OrdenPagoAdminPresenter
    {
        private readonly OrdenPagoAdminForm _view;

        public OrdenPagoAdminPresenter(OrdenPagoAdminForm view)
        {
            _view = view;
        }

        internal void CargarOrdenesPago()
        {
            _view.Grilla = new OrdenPagoBLL().Listar()
                .Select(o => o as OrdenPagoBEL)
                .OrderBy(x => x.FechaPago).ToList();

        }
    }
}
