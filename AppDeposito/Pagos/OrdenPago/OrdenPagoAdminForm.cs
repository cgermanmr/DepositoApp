using AppDeposito.Pagos.IngresoFacturas;
using AppDeposito.Pagos.OrdenPago;
using AppDeposito.Pagos.OrdenPago.Model;
using AppDeposito.Reportes;
using BEL;
using BLL;
using Microsoft.Reporting.WinForms;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito.Pagos
{
    public partial class OrdenPagoAdminForm : Form, IObserverTraducible
    {
        private readonly OrdenPagoAdminPresenter Presenter;
        public OrdenPagoAdminForm()
        {
            InitializeComponent();
            Presenter = new OrdenPagoAdminPresenter(this);
        }
        public OrdenPagoBEL OpSeleccionada => bsOrdenPago.Current as OrdenPagoBEL;
        public List<OrdenPagoBEL> Grilla { 
            get => bsOrdenPago.DataSource as List<OrdenPagoBEL>; 
            set => bsOrdenPago.DataSource = value; 
        }

        private void OrdenPagoAdminForm_Load(object sender, EventArgs e)
        {

            FormConfig.Config(this);

            Grilla = new List<OrdenPagoBEL>();
            Presenter.CargarOrdenesPago();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaOp = new OrdenPagoEditForm();

            if (nuevaOp.ShowDialog() != DialogResult.OK)
                return;

            Presenter.CargarOrdenesPago();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevaOp = new OrdenPagoEditForm();
            nuevaOp.OrdenPago = bsOrdenPago.Current as OrdenPagoBEL;

            if (nuevaOp.ShowDialog() != DialogResult.OK)
                return;

            Refresh();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            var datos = new OrdenPagoBLL().GetDatosOrdenPagoReporte(OpSeleccionada.NroOrdenPago);

            _ = new ReporteView()
            {
                Reporte = "AppDeposito.Reportes.OrdenPagoReport.rdlc",
                DatosReporte = datos,
                NombreDatosReporte = "DatosReporte",
                ParametrosReporte = new List<ReportParameter>()


            }.ShowDialog();
        }

        private void ordenPagoBELDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgOrdenesPago.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        private void ordenPagoBELDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgOrdenesPago.CurrentCell?.ColumnIndex == 6 || 
                dgOrdenesPago.CurrentCell?.ColumnIndex == 5)
            {
                new OrdenPagoBLL().Modificar(OpSeleccionada);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dgOrdenesPago.SelectedRows.Count == 0)
            {
                Mensajes.ShowAdvertencia("Debe seleccionar al menos una OP");
                return;
            }                       

            var path = GetSeleccionPath();

            if(path.Length>0)
                Presenter.ExportarXML(GetSeleccionadas(),path);
        }

        private List<OrdenPagoBEL> GetSeleccionadas() 
        {
            var seleccionadas = new List<OrdenPagoBEL>();
            DataGridViewSelectedRowCollection rows = dgOrdenesPago.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                var op = row.DataBoundItem as OrdenPagoBEL;
                seleccionadas.Add(op);
            }
            return seleccionadas;
        }

        private string GetSeleccionPath()
        {
            //Configure save file dialog box
            var dlg = new SaveFileDialog
            {
                FileName = $"OrdenesPagoExport_{DateTime.Now:yyyyMMddHHmmss}.xml", // Default file name
                DefaultExt = ".xml", //Default file extension
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), //txRutaBackup.Text
                Filter = "Archivos Backup (.xml)|*.xml" //Filter files by extension
            };
            //Show save file dialog box
            var result = dlg.ShowDialog();
            //Process save file dialog box results
            if (result == DialogResult.Cancel)
                return "";

            return dlg.FileName;
        }
    }
}
