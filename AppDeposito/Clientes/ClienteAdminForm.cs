using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class ClienteAdminForm : Form,IObserverTraducible
    {
        public ClienteAdminForm()
        {
            InitializeComponent();
            
        }

        public ClienteBEL ClienteSeleccionado { get => bsClientes.Current as ClienteBEL; }
        public ActivoBEL ActivoSeleccionado { get => bsActivosAsignados.Current as ActivoBEL; }

        private readonly ClienteBLL _clienteBll = new ClienteBLL();

        List<ClienteBEL> _listaClientes;
        private void ClienteAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                FormConfig.TextBoxToReadOnly(this);
                txtFiltro.ReadOnly = false;
                _listaClientes = _clienteBll.Listar().ConvertAll(x => (ClienteBEL)x);
                bsClientes.DataSource = _listaClientes;
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _edit = new ClienteEditForm();
            _edit.Cliente = ClienteSeleccionado;
            _edit.ShowDialog();
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _edit = new ClienteEditForm();
            _edit.ShowDialog();
            bsClientes.ResetCurrentItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool result=false;
                if (MessageBox.Show($"Eliminar {bsClientes.Current}", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    result = _clienteBll.Eliminar((Entidad)bsClientes.Current);

                if (result)
                {
                    Mensajes.MensajeResultado(result, this);
                    bsClientes.Remove(bsClientes.Current);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex, 4455);
                Mensajes.ShowError(ex, this);
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = txtFiltro.Text.ToUpper();
                bsClientes.DataSource = _listaClientes
                    .FindAll(x=>
                            x.Nombre.ToUpper().Contains(txt) |
                            x.Apellido.ToUpper().Contains(txt) |
                            x.Telefono.ToUpper().Contains(txt) |
                            x.Email.ToUpper().Contains(txt) |
                            x.Empresa.RazonSocial.ToUpper().Contains(txt));
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex, 3344);
                Mensajes.ShowError(ex, this);
            }
        }

        private void AsignarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _buscar = new BuscarActivoForm();
                _buscar.ShowDialog();

                if (_buscar.Seleccionado == null) return;
                ClienteSeleccionado.ActivosAsignados.Add(_buscar.Seleccionado);
                _buscar.Close();

                _clienteBll.Modificar(ClienteSeleccionado);

                RefrescarDatos();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);               
            }
            
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActivoSeleccionado == null) return;

                if (ClienteSeleccionado == null) return;

                ClienteSeleccionado.ActivosAsignados.Remove(ActivoSeleccionado);

                _clienteBll.Modificar(ClienteSeleccionado);

                RefrescarDatos();

            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex,this);
               
            }
        }

        private void RefrescarDatos()
        {
            bsActivosAsignados.ResetBindings(true);
            bsClientes.ResetBindings(true);
        }
        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
