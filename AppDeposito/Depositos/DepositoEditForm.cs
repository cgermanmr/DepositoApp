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
    public partial class EdicionDepositoForm : Form, IObserverTraducible
    {
        public EdicionDepositoForm()
        {
            InitializeComponent();
        }

        BEL.DepositoBEL _deposito;
        private void EdicionDepositoForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                _deposito = (BEL.DepositoBEL)Tag;
                bsDeposito.DataSource = _deposito;
                ubicacionComboBox.DataSource = new BLL.UbicacionBLL().Listar();

                if (_deposito.Id == 0)
                    ubicacionComboBox.SelectedIndex = -1;
                else
                    ubicacionComboBox.SelectedIndex = ubicacionComboBox.FindString(_deposito.Ubicacion.Descripcion);
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
            

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this, errorProvider);
                bool result;

                _deposito.Ubicacion = (BEL.UbicacionBEL)ubicacionComboBox.SelectedItem;

                if (_deposito.Id == 0)
                    result = new BLL.DepositoBLL().Agregar(_deposito);
                else
                    result = new BLL.DepositoBLL().Modificar(_deposito);

                if (result)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
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
