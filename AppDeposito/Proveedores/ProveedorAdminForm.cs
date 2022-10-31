using System;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class ProveedorAdminForm : Form, IObserverTraducible
    {
        private ProveedorBLL _prov = new ProveedorBLL();
        public ProveedorAdminForm()
        {
            InitializeComponent();
        }

        private void ObtenerDatos(string filtro = "")
        {
            filtro = filtro.ToUpper();

            if (filtro.Length > 3)
                bsOrganizaciones.DataSource = _prov.Listar(filtro).ConvertAll(_ => (ProveedorBEL)_);
            else
                bsOrganizaciones.DataSource = _prov.Listar().ConvertAll(_ => (ProveedorBEL)_);
                    
        }
        private void OrganizacionesForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            FormConfig.TextBoxToReadOnly(this);
            txtFiltro.ReadOnly = false;
            ObtenerDatos();
        }

        private void GrillaOrganizaciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
               
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ProveedorEditForm() { Editado = new ProveedorBEL() }.ShowDialog();
                ObtenerDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                new ProveedorEditForm() { Editado = (ProveedorBEL)bsOrganizaciones.Current }.ShowDialog();
                ObtenerDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex,this);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Se eliminará {bsOrganizaciones.Current}", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Mensajes.MensajeResultado(_prov.Eliminar((ProveedorBEL)bsOrganizaciones.Current), this);
                    ObtenerDatos(txtFiltro.Text);
                }
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);

            }
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
