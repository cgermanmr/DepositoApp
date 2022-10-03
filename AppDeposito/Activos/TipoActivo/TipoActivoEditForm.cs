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
    public partial class TipoActivoEditForm : Form, IObserverTraducible
    {
        public TipoActivoEditForm()
        {
            InitializeComponent();
        }

        private bool _esAlta=false;
        private void UbicacionEditForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            if (((BEL.UbicacionBEL)bsEditado.Current).Id == 0)
                _esAlta = true;
        }
     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this, errorProvider);
                
                if (_esAlta)
                    Mensajes.MensajeResultado(new BLL.UbicacionBLL().Agregar((BEL.UbicacionBEL)bsEditado.Current), this);
                else
                    Mensajes.MensajeResultado(new BLL.UbicacionBLL().Modificar((BEL.UbicacionBEL)bsEditado.Current), this);

                Close();

            }
            catch (Exception ex)
            {

                Mensajes.ShowError(ex, this);
            }

        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
