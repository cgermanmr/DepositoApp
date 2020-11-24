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
    public partial class ClienteEditForm : Form, IObserverTraducible
    {
        public ClienteEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this,errorProvider);

                bool result = ((BEL.EntidadBase)bsCliente.Current).Id == 0
                    ? new BLL.ClienteBLL().Agregar((BEL.EntidadBase)bsCliente.Current)
                    : new BLL.ClienteBLL().Modificar((BEL.EntidadBase)bsCliente.Current);
                Mensajes.MensajeResultado(result, this);

                if (result) Close();

            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 1199);
                Mensajes.MensajeExcepcion(ex, this);             
         
            }
            

        }
        BindingSource bsEmpresas = new BindingSource();
        BEL.ClienteBEL _cliente;
        private void ClienteEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                _cliente = ((BEL.ClienteBEL)Tag);
                bsCliente.DataSource = _cliente;
                bsEmpresas.DataSource = new BLL.EmpresaBLL().Listar();
                bsEmpresas.CurrentChanged += BsEmpresas_CurrentChanged;
                razonSocialComboBox.DataSource = bsEmpresas;

                if (_cliente.Empresa == null || _cliente.Id == 0 | _cliente.Empresa.Id == 0) razonSocialComboBox.SelectedIndex = -1;
                else razonSocialComboBox.SelectedIndex = razonSocialComboBox.FindString(((BEL.ClienteBEL)bsCliente.Current).Empresa.RazonSocial);

            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 2233);
                Mensajes.MensajeExcepcion(ex, this);
            }
            
        }

        private void BsEmpresas_CurrentChanged(object sender, EventArgs e)
        {
            if (bsEmpresas.Current != null)
                _cliente.Empresa = (BEL.EmpresaBEL)bsEmpresas.Current;
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
