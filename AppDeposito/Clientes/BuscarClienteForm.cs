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
    public partial class BuscarClienteForm : Form, IObserverTraducible
    {
        public ClienteBEL Solicitante { get => bsClientes.Current as ClienteBEL; }
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        List<ClienteBEL> _listaClientes;
        private void BusquedaForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            _listaClientes = new ClienteBLL().Listar().ConvertAll(x=>(ClienteBEL)x);
            bsClientes.DataSource = _listaClientes;
            Grilla.AutoGenerateColumns = false;
            Grilla.DataSource = bsClientes;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = txtFiltro.Text.ToUpper();
                bsClientes.DataSource = _listaClientes
                    .FindAll(x =>
                            (bool)x.Nombre?.ToUpper().Contains(txt) |
                            (bool)x.Apellido?.ToUpper().Contains(txt) |
                            (bool)x.Telefono?.ToUpper().Contains(txt) |
                            (bool)x.Email?.ToUpper().Contains(txt) |
                            (bool)x.Empresa?.RazonSocial.ToUpper().Contains(txt));
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);                
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
