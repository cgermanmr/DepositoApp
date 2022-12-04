using AppDeposito.Pagos.IngresoFacturas;
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
    public partial class IngresoFacturasForm : Form, IObserverTraducible
    {
        private readonly IngresoFacturaPresenter Presenter;
        public IngresoFacturasForm()
        {
            InitializeComponent();
            Presenter = new IngresoFacturaPresenter(this);
        }

        
        public FacturaReparacionDetalle ConceptoActual { get => bsConceptos.Current as FacturaReparacionDetalle; }

        public FacturaReparacionBEL Factura { get => bsFacturas.DataSource as FacturaReparacionBEL; set => bsFacturas.DataSource = value; }

        public List<FacturaReparacionDetalle> Conceptos { get => bsConceptos.DataSource as List<FacturaReparacionDetalle>; set => bsConceptos.DataSource = value; }

        private void cuitProveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (cuitProveedorTextBox.Text.Trim().Length != 11)
            {
                errorProvider1.SetError(sender as Control, "Cuit es de 11 digitos");
                return;
            }

            var prov = new ProveedorBLL().GetByCuit(cuitProveedorTextBox.Text.SafeToLong());

            if (prov == null)
            {
                errorProvider1.SetError(sender as Control, "No se encuentra el CUIT");
                return;
            }
            else
                txtRazonSocial.Text = prov.ToString();

            errorProvider1.SetError(sender as Control, "");

        }

        private void IngresoFacturasForm_Load(object sender, EventArgs e)
        {

            FormConfig.Config(this);

            Factura = new FacturaReparacionBEL();
            Conceptos = Factura.Conceptos;

            cuitProveedorTextBox.SoloNumeros();
            importeTextBox.SoloNumerosConDecimales();

            nroFacturaTextBox.SoloNumeros();
            nroFacturaTextBox.ValidarCampoCompleto(errorProvider1);

            codigoTextBox.SoloNumeros();
            codigoTextBox.ValidarCampoCompleto(errorProvider1);

            letraTextBox.ValidarCampoCompleto(errorProvider1);

        }
              

        private void button3_Click(object sender, EventArgs e)
        {

            if (Conceptos.Any(x => !x.IsOk))
                return;

            var d = new FacturaReparacionDetalle() { NroFactura = Factura.NroFactura };
            d.CambioImporteEvent += (valor) =>
            {
                Factura.Importe = 0;
                Conceptos.ForEach(x => Factura.Importe += x.Importe);
                bsFacturas.ResetBindings(false);

            };
            Conceptos.Add(d);
            bsConceptos.ResetBindings(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bsConceptos.Current != null)
            {
                Conceptos.Remove((FacturaReparacionDetalle)bsConceptos.Current);
                bsConceptos.ResetBindings(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConfig.Validar(errorProvider1, this);

            if (!Factura.IsOk)
                throw new InvalidOperationException("Varifique los datos ingresados");

            var p = new FacturaReparacionBLL();

            if (p.Agregar(Factura))
            { 
                Mensajes.ShowExitoso();
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool cancelIt = false;

        private void conceptosDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var valor = e.FormattedValue.ToString();


            if (valor.Length == 0) return;

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0: //OT
                        Presenter.ValidarOt(valor);
                        break;
                    case 2: //Importe
                        Presenter.ValidarImporte(valor.SafeToDouble());
                        break;
                }
            }
            catch (Exception ex)
            {
                if (cancelIt)
                {
                    Mensajes.ShowError(ex);
                    e.Cancel = true;
                    bsConceptos.EndEdit();
                    cancelIt = false;
                }
            }
        }

        private void conceptosDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cancelIt = true;
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var buscarProv = new BuscarProveedorForm(conOtPendientes: true);
            if (buscarProv.ShowDialog() != DialogResult.OK)
                return;

            txtRazonSocial.Text = buscarProv.Seleccionado.RazonSocial;
            cuitProveedorTextBox.Text = buscarProv.Seleccionado.CUIT.ToString();

            buscarProv.Close();

        }
    }
}
