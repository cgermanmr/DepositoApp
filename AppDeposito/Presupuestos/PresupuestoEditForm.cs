using System;
using System.Windows.Forms;
using BEL;
using Servicios;

namespace AppDeposito
{
    public partial class PresupuestoEditForm : Form, IObserverTraducible
    {
        private bool _isLoading;
        private PresupuestoBEL Presupuesto { get => bsPresupuesto.DataSource as PresupuestoBEL; set => bsPresupuesto.DataSource = value; }
        public PresupuestoEditForm(PresupuestoBEL presupuesto)
        {
            InitializeComponent();
            Presupuesto = presupuesto;
        }
               
        private void EdicionPresupuestoForm_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            FormConfig.Config(this);
            bsProveedores.DataSource = new BLL.ProveedorBLL().Listar();
            cmbMoneda.BindEnumToComboBox(TipoMoneda.Pesos);
            cotizacionTextBox.SoloNumerosConDecimales();
            tiempoEstimadoTextBox.SoloNumeros();

            if (Presupuesto.Id == 0)
            {
                proveedorComboBox.SelectedIndex = -1;
            }
            else
            {
                proveedorComboBox.SelectedIndex = proveedorComboBox.FindStringExact(Presupuesto.Proveedor.ToString());
                cmbMoneda.SelectedValue = Presupuesto.Moneda;
            }

            _isLoading = false;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this, errorProvider);

                bool result;
                if (Presupuesto.Id == 0)
                   result = new BLL.PresupuestoBLL().Agregar(Presupuesto);
                else
                    result = new BLL.PresupuestoBLL().Modificar(Presupuesto);
                                
                Mensajes.MensajeResultado(result, this);

                if (result)
                    Close();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);                
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }

        private void razonSocialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presupuesto.Proveedor = proveedorComboBox.SelectedValue as ProveedorBEL;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            Presupuesto.Moneda = cmbMoneda.SelectedValue.ToString().ToEnum<TipoMoneda>();
        }
    }
}
