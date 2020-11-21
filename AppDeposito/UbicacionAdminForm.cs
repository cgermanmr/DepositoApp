using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace AppDeposito
{
    public partial class UbicacionAdminForm : Form, IObserverTraducible
    {
        public UbicacionAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos(string txt="")
        {
            if(txt=="")
                bsUbicaciones.DataSource = new BLL.UbicacionBLL().Listar();
            else
            {
                bsUbicaciones.DataSource = new BLL.UbicacionBLL().Listar().FindAll(_ =>
                _.Direccion.ToUpper().Contains(txt) |
                _.Descripcion.ToUpper().Contains(txt));
            }
        }

        private void UbicacionAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                dgvGrilla.AutoGenerateColumns = false;
                ObtenerDatos();
            }
            catch (Exception ex)
            {

                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = txtFiltro.Text.ToUpper();
                ObtenerDatos(txt);
                
            }
            catch (Exception ex)
            {

                Mensajes.MensajeExcepcion(ex,this);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ubicacionEdit = new UbicacionEditForm();
            ubicacionEdit.bsEditado.DataSource = new BEL.UbicacionBEL();
            ubicacionEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var ubicacionEdit = new UbicacionEditForm();
            ubicacionEdit.bsEditado.DataSource = bsUbicaciones.Current;
            ubicacionEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, $"Eliminar {bsUbicaciones.Current.ToString()} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mensajes.MensajeResultado(new BLL.UbicacionBLL().Eliminar((BEL.UbicacionBEL)bsUbicaciones.Current),this);
                    ObtenerDatos(txtFiltro.Text.ToUpper());
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
