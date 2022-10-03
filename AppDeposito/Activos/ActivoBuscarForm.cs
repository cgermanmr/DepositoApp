using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BLL;
using Interfaces;
using Servicios;

namespace AppDeposito
{
    public partial class BuscarActivoForm : Form, IObserverTraducible
    {
        private readonly ActivoBLL _activoBll = new ActivoBLL();
        public BuscarActivoForm()
        {
            InitializeComponent();
        }
        private void BusquedaForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            bsActivos.DataSource = _activoBll.Listar().ConvertAll(x => (ActivoBEL)x);
            Grilla.AutoGenerateColumns = false;
            Grilla.DataSource = bsActivos;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Seleccionado = bsActivos.Current as ActivoBEL;
            Visible = false;
        }

        public ActivoBEL Seleccionado { get; set; }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro.Text.Length < 4) return;

                string txt = txtFiltro.Text.ToUpper();
                bsActivos.DataSource = _activoBll.Listar(txt).ConvertAll(x => (ActivoBEL)x);
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
    }
}
