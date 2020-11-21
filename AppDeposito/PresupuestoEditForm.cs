using System;
using System.Windows.Forms;
using Servicios;

namespace AppDeposito
{
    public partial class PresupuestoEditForm : Form, IObserverTraducible
    {
        public PresupuestoEditForm()
        {
            InitializeComponent();
        }

       
        private void EdicionPresupuestoForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            FormConfig.ValidarCamposCompletos(this, errorProvider);
            bsPresupuesto.DataSource = Tag;
            bsProveedores.DataSource = new BLL.EmpresaBLL().Listar();
            bsMoneda.DataSource = new BLL.MonedaBLL().Listar();

            if (((BEL.PresupuestoBEL)bsPresupuesto.Current).Id == 0)
            {
                razonSocialComboBox.SelectedIndex = -1;
                cmbMoneda.SelectedIndex=-1;
            }
            else
            {
                razonSocialComboBox.SelectedIndex = razonSocialComboBox.FindStringExact(((BEL.PresupuestoBEL)bsPresupuesto.Current).Proveedor.RazonSocial);
                cmbMoneda.SelectedIndex = cmbMoneda.FindString(((BEL.PresupuestoBEL)bsPresupuesto.Current).Moneda.Descripcion);
            }

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this, errorProvider);

                bool result;
                if (((BEL.PresupuestoBEL)bsPresupuesto.Current).Id == 0)
                   result = new BLL.PresupuestoBLL().Agregar((BEL.EntidadBase)bsPresupuesto.Current);
                else
                    result = new BLL.PresupuestoBLL().Modificar((BEL.EntidadBase)bsPresupuesto.Current);
                                
                Mensajes.MensajeResultado(result, this);

                if (result)
                    Close();
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);                
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
    }
}
