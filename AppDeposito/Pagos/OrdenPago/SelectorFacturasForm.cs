using AppDeposito.Pagos.OrdenPago.Model;
using BEL;
using BLL;
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

namespace AppDeposito.Pagos.OrdenPago
{
    public partial class SelectorFacturasForm : Form, IObserverTraducible
    {
        public SelectorFacturasForm(ProveedorBEL proveedor)
        {
            InitializeComponent();
            _proveedor = proveedor;
        }

        public List<FacturaViewModel> FacturasSeleccionadas
            => (bsFacturas.DataSource as List<FacturaViewModel>)
            .Where(f =>f.Seleccionada).ToList();

        private readonly ProveedorBEL _proveedor;
        private void SelectorFacturasForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);

            textBox1.Text = _proveedor.ToString();
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            if (_proveedor == null) return;

            List<FacturaViewModel> facturas = new FacturaReparacionBLL()
                .GetFacturasPendientes(_proveedor.CUIT)
                .Select( x=> new FacturaViewModel() { 
                    Importe = x.Importe,
                    NroFactura = x.NroFactura,
                    Descripcion = x.Descripcion                    
                }).ToList();
        
            bsFacturas.DataSource = facturas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Visible = false;
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
