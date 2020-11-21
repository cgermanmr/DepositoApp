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
    public partial class SectorAdminForm : Form, IObserverTraducible
    {
        public SectorAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos(string txt="")
        {
            txt = txt.ToUpper();
            if(txt=="")
                bsSectores.DataSource = new BLL.SectorBLL().Listar();
            else
                bsSectores.DataSource = new BLL.SectorBLL()
                    .Listar()
                    .FindAll(_ => _.CentroCosto.ToUpper().Contains(txt) |
                                  _.Descripcion.ToUpper().Contains(txt));

        }

        private void SectorAdminForm_Load(object sender, EventArgs e)
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
            var sectorEdit = new SectorEditForm();
            sectorEdit.bsEditado.DataSource = new BEL.SectorBEL();
            sectorEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var sectorEdit = new SectorEditForm();
            sectorEdit.bsEditado.DataSource = bsSectores.Current;
            sectorEdit.ShowDialog();
            ObtenerDatos(txtFiltro.Text.ToUpper());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, $"Eliminar {bsSectores.Current.ToString()} ?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mensajes.MensajeResultado(new BLL.SectorBLL().Eliminar((BEL.SectorBEL)bsSectores.Current),this);
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
