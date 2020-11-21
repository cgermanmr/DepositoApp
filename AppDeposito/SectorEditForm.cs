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
    public partial class SectorEditForm : Form, IObserverTraducible
    {
        public SectorEditForm()
        {
            InitializeComponent();
        }

        private bool _esAlta=false;
        private void SectorEditForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            if (((BEL.SectorBEL)bsEditado.Current).Id == 0)
                _esAlta = true;
        }
     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormConfig.ValidarCamposCompletos(this, errorProvider);

            if (_esAlta)
                Mensajes.MensajeResultado(new BLL.SectorBLL().Agregar((BEL.SectorBEL)bsEditado.Current),this);
            else
                Mensajes.MensajeResultado(new BLL.SectorBLL().Modificar((BEL.SectorBEL)bsEditado.Current), this);

            Close();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
