using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        internal void ExportarXML(List<OrdenPagoBEL> seleccionadas, string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<OrdenPagoBEL>));

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"//OrdenesPagoExport_{DateTime.Now:yyyyMMddHHmmss}.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, seleccionadas);
            file.Close();
        }
    }
}
