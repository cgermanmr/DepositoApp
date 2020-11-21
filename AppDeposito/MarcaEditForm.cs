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
    public partial class MarcaEditForm : Form, IObserverTraducible
    {
        public MarcaEditForm()
        {
            InitializeComponent();
        }

        private bool _esAlta=false;
        private void MarcaEditForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            if (((BEL.MarcaBEL)bsEditado.Current).Id == 0)
                _esAlta = true;
        }
     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormConfig.ValidarCamposCompletos(this, errorProvider);
            if (_esAlta)
                Mensajes.MensajeResultado(new BLL.MarcaBLL().Agregar((BEL.MarcaBEL)bsEditado.Current),this);
            else
                Mensajes.MensajeResultado(new BLL.MarcaBLL().Modificar((BEL.MarcaBEL)bsEditado.Current), this);

            Close();
        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
