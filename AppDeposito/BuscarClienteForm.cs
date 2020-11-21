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
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        //BindingSource bsLista = new BindingSource();
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
            Seleccionado = bsClientes.Current;
            Visible = false;
        }

        public object Seleccionado { get; set; }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = txtFiltro.Text.ToUpper();
                bsClientes.DataSource = _listaClientes
                    .FindAll(x =>
                            x.Nombre.ToUpper().Contains(txt) |
                            x.Apellido.ToUpper().Contains(txt) |
                            x.Telefono.ToUpper().Contains(txt) |
                            x.Email.ToUpper().Contains(txt) |
                            x.Empresa.RazonSocial.ToUpper().Contains(txt));
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
