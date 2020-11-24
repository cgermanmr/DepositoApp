using System;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class EmpresaAdminForm : Form, IObserverTraducible
    {
        private EmpresaBLL _emp = new EmpresaBLL();
        public EmpresaAdminForm()
        {
            InitializeComponent();
        }

        private void ObtenerDatos(string filtro = "")
        {
            filtro = filtro.ToUpper();

            if (filtro.Length > 3)
                bsOrganizaciones.DataSource = _emp.Listar(filtro).ConvertAll(_ => (EmpresaBEL)_);
            else
                bsOrganizaciones.DataSource = _emp.Listar().ConvertAll(_ => (EmpresaBEL)_);
                    
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
                new EmpresaEditForm() { Editado = new EmpresaBEL() }.ShowDialog();
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
                new EmpresaEditForm() { Editado = (EmpresaBEL)bsOrganizaciones.Current }.ShowDialog();
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
                if (MessageBox.Show($"Se eliminará {bsOrganizaciones.Current}", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Mensajes.MensajeResultado(_emp.Eliminar((EmpresaBEL)bsOrganizaciones.Current), this);
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
