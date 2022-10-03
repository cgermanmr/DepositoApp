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
    public partial class EstadoAdminForm : Form, IObserverTraducible
    {
        public EstadoAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos(string txt="")
        {
            txt = txt.ToUpper();
            if(txt=="")
                bsEstados.DataSource = new BLL.EstadoBLL().Listar();
            else
                bsEstados.DataSource = new BLL.EstadoBLL()
                    .Listar()
                    .FindAll(_ => _.Descripcion.ToUpper().Contains(txt));

        }

        private void EstadoAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                dgvGrilla.AutoGenerateColumns = false;
                ObtenerDatos();
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
