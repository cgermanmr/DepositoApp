using AppDeposito.Pagos.IngresoFacturas;
using AppDeposito.Pagos.OrdenPago;
using AppDeposito.Pagos.OrdenPago.Model;
using BEL;
using BLL;
using Comun;
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
    public partial class OrdenPagoEditForm : Form, IObserverTraducible
    {
        private readonly OrdenPagoEditPresenter Presenter;
        public OrdenPagoEditForm()
        {
            InitializeComponent();
            Presenter = new OrdenPagoEditPresenter(this);
            OrdenPago = new OrdenPagoBEL();
        }

        public List<OrdenPagoDetalleBEL> Detalles { 
            get => bsDetalles.DataSource as List<OrdenPagoDetalleBEL>;
            set { 
                bsDetalles.DataSource = value;
                bsDetalles.ResetBindings(true);
            } 
        }
        public ProveedorBEL Proveedor { get; set; }

        public OrdenPagoBEL OrdenPago { 
            get => bsOrdenPago.DataSource as OrdenPagoBEL;
            set { 
                bsOrdenPago.DataSource = value; 
                bsDetalles.DataSource = value.Detalles;

                if (value.CuitProveedor != 0 & RazonSocialTextBox.TextLength == 0)
                    CargarProveedor(value.CuitProveedor);
            }
        }

        private void CargarProveedor(long cuit)
        {
            Proveedor = new ProveedorBLL().GetByCuit(cuit) as ProveedorBEL;
            RazonSocialTextBox.Text = Proveedor.RazonSocial;
            CuitTextBox.Text = Proveedor.CUIT.ToString();
        }

        public List<FacturaReparacionBEL> FacturasSeleccionadas { 
            get => (bsDetalles.DataSource as List<FacturaViewModel>)
                .Where(f => f.Seleccionada)
                .Select(x => (FacturaReparacionBEL)x).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buscarProv = new BuscarProveedorForm();
            if (buscarProv.ShowDialog() != DialogResult.OK)
                return;
            Proveedor = buscarProv.Seleccionado;
            RazonSocialTextBox.Text = Proveedor.RazonSocial;
            CuitTextBox.Text = Proveedor.CUIT.ToString();

            buscarProv.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Detalles.Count == 0)
            {
                Mensajes.ShowAdvertencia("Al menos debe seleccionar una factura");
                return;
            }

            Presenter.Grabar();

            DialogResult = DialogResult.OK;
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            DialogResult = DialogResult.Cancel;
            Visible = false;

        }

        private void OrdenPagoEditForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (Proveedor == null) return;

            var selecFac = new SelectorFacturasForm(Proveedor);
            if (selecFac.ShowDialog() != DialogResult.OK)
                return;

            CargarDetallesOrdenPago(selecFac.FacturasSeleccionadas);

            selecFac.Close();
        }

        private void CargarDetallesOrdenPago( List<FacturaViewModel> facturasSeleccionadas)
        {
            if (facturasSeleccionadas.Count == 0)
                return;

            //OrdenPago.Detalles.Clear();

            facturasSeleccionadas.ForEach(f => {

                var detalle = new OrdenPagoDetalleBEL()
                {
                    NroFactura = f.NroFactura,
                    Importe = (decimal)f.Importe,
                    Descripcion = $"Fec. Vto: {f.FechaVto:dd/MM/yyyy} / Fec.Emisión: {f.FechaEmision:dd/MM/yyyy} ",
                };

                OrdenPago.Detalles.Add(detalle);

            });

            OrdenPago.Importe = OrdenPago.Detalles.Sum(x => x.Importe);

            Detalles = OrdenPago.Detalles;
            
            bsOrdenPago.ResetCurrentItem();
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (bsDetalles.Current == null) return;

            OrdenPago.Detalles.Remove(bsDetalles.Current as OrdenPagoDetalleBEL);

            OrdenPago.Importe = OrdenPago.Detalles.Sum(x => x.Importe);

            bsOrdenPago.ResetCurrentItem();

            Detalles = OrdenPago.Detalles;


        }

        private void facturaModelViewDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void CuitTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (CuitTextBox.Text.Trim().Length != 11)
            {
                errorProvider1.SetError(sender as Control, "Cuit es de 11 digitos");
                return;
            }

            Proveedor = new ProveedorBLL().GetByCuit(CuitTextBox.Text.SafeToLong());

            if (Proveedor == null)
            {
                errorProvider1.SetError(sender as Control, "No se encuentra el CUIT");
                return;
            }
            else
            {
                RazonSocialTextBox.Text = Proveedor.ToString();
            }

            errorProvider1.SetError(sender as Control, "");
        }
    }
}
