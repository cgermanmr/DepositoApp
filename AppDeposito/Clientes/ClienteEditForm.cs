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
using Servicios;

namespace AppDeposito
{
    public partial class ClienteEditForm : Form, IObserverTraducible
    {

        private EmpresaBEL EmpresaSeleccionada { get => bsEmpresas.Current as EmpresaBEL; }
        public ClienteBEL Cliente { 
            get => bsCliente.DataSource as ClienteBEL; 
            set => bsCliente.DataSource = value; }
        public ClienteEditForm()
        {
            InitializeComponent();
            Cliente = new ClienteBEL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                bool result = Cliente.Id == 0
                    ? new ClienteBLL().Agregar(Cliente)
                    : new ClienteBLL().Modificar(Cliente);
                
                Mensajes.MensajeResultado(result, this);

                if (result) 
                    Close();

            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex, 1199);
                Mensajes.MensajeExcepcion(ex, this);             
         
            }

        }
        BindingSource bsEmpresas = new BindingSource();
        private void ClienteEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);

                telefonoTextBox.SoloCaracteresHabilitados(new char[] {'1','2','3','4','5','6','7','8','9','0','-' });

                bsEmpresas.DataSource = new EmpresaBLL().Listar();
                bsEmpresas.CurrentChanged += BsEmpresas_CurrentChanged;
                razonSocialComboBox.DataSource = bsEmpresas;

                if (Cliente.Id == 0) 
                    razonSocialComboBox.SelectedIndex = -1;
                else 
                    razonSocialComboBox.SelectedIndex = razonSocialComboBox.FindString(Cliente.Empresa?.RazonSocial);

            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex, 2233);
                Mensajes.MensajeExcepcion(ex, this);
            }
            
        }

        private void BsEmpresas_CurrentChanged(object sender, EventArgs e)
        {
            if (bsEmpresas.Current != null)
                Cliente.Empresa = EmpresaSeleccionada;
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
