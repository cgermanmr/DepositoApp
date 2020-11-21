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
    public partial class MarcaAdminForm : Form, IObserverTraducible
    {
        public MarcaAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos(string txt="")
        {
            txt = txt.ToUpper();
            if(txt=="")
                bsMarcas.DataSource = new BLL.MarcaBLL().Listar();
            else
                bsMarcas.DataSource = new BLL.MarcaBLL()
                    .Listar()
                    .FindAll(_ => _.Descripcion.ToUpper().Contains(txt));

        }

        private void MarcaAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                dgvGrilla.AutoGenerateColumns = false;
                ObtenerDatos(txtFiltro.Text.ToUpper());
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
                ObtenerDatos(txtFiltro.Text.ToUpper());
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex,this);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var marcaEdit = new MarcaEditForm();
            marcaEdit.bsEditado.DataSource = new BEL.MarcaBEL();
            marcaEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var marcaEdit = new MarcaEditForm();
            marcaEdit.bsEditado.DataSource = bsMarcas.Current;
            marcaEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, $"Eliminar {bsMarcas.Current.ToString()} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mensajes.MensajeResultado(new BLL.MarcaBLL()
                        .Eliminar((BEL.MarcaBEL)bsMarcas.Current),this);
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
