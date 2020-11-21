using System;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class OrganizacionAdminForm : Form, IObserverTraducible
    {
        public OrganizacionAdminForm()
        {
            InitializeComponent();
        }

        private void ObtenerDatos(string filtro = "")
        {
            filtro = filtro.ToUpper();

            if(string.IsNullOrEmpty(filtro))
                bsOrganizaciones.DataSource = new EmpresaBLL().Listar().FindAll(_=>!_.EsCliente);
            else
                bsOrganizaciones.DataSource = new EmpresaBLL().Listar()
                    .FindAll(_=>
                    _.RazonSocial.ToUpper().Contains(filtro) |
                    _.Telefono.ToUpper().Contains(filtro) |
                    _.Email.ToUpper().Contains(filtro) |
                    _.Direccion.ToUpper().Contains(filtro) |
                    _.CUIT.ToString().Contains(filtro) |
                    _.Direccion.ToUpper().Contains(filtro) |
                    _.CodigoPostal.ToUpper().Contains(filtro) |
                    _.Ciudad.ToUpper().Contains(filtro) |
                    _.Observaciones.ToUpper().Contains(filtro)).FindAll(_=>!_.EsCliente);

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
                Mensajes.MensajeExcepcion(ex, this);
               
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            try
            {
                new OrganizacionEditForm() { Editado = new EmpresaBEL() }.ShowDialog();
                ObtenerDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                new OrganizacionEditForm() { Editado = (EmpresaBEL)bsOrganizaciones.Current }.ShowDialog();
                ObtenerDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex,this);
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
                if (MessageBox.Show($"Se eliminará {bsOrganizaciones.Current.ToString()}", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Mensajes.MensajeResultado(new EmpresaBLL().Modificar((EmpresaBEL)bsOrganizaciones.Current), this);
                    ObtenerDatos(txtFiltro.Text);
                }
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);

            }
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
