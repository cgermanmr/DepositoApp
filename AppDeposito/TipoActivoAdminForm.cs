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
    public partial class TipoActivoAdminForm : Form, IObserverTraducible
    {
        public TipoActivoAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos(string txt="")
        {
            txt = txt.ToUpper();
            if(txt=="")
                bsTipos.DataSource = new BLL.TipoActivoBLL().Listar();
            else
            {
                bsTipos.DataSource = new BLL.TipoActivoBLL().Listar().FindAll(_ =>
                _.Volumen.ToString().Contains(txt) |
                _.Descripcion.ToUpper().Contains(txt));
            }

        }

        private void TipoActivoAdminForm_Load(object sender, EventArgs e)
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
                ObtenerDatos(txtFiltro.Text);             
                
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
            ObtenerDatos(txtFiltro.Text);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var ubicacionEdit = new UbicacionEditForm();
            ubicacionEdit.bsEditado.DataSource = bsTipos.Current;
            ubicacionEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, $"Eliminar {bsTipos.Current.ToString()} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mensajes.MensajeResultado(new BLL.UbicacionBLL().Eliminar((BEL.UbicacionBEL)bsTipos.Current),this);
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
