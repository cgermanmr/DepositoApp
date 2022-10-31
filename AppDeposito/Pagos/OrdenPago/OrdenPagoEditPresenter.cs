using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeposito.Pagos.OrdenPago
{
    public class OrdenPagoEditPresenter
    {
        private readonly OrdenPagoEditForm _view;

        public OrdenPagoEditPresenter(OrdenPagoEditForm view)
        {
            _view = view;
        }

        public void Grabar()
        {
            var opBll = new OrdenPagoBLL();

            if (_view.OrdenPago.NroOrdenPago == 0)
                opBll.Agregar(_view.OrdenPago);
            else
                opBll.Modificar(_view.OrdenPago);

        }
    }
}
