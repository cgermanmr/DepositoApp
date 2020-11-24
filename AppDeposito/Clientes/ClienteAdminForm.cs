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
    public partial class ClienteAdminForm : Form,IObserverTraducible
    {
        public ClienteAdminForm()
        {
            InitializeComponent();
        }

        List<ClienteBEL> _listaClientes;
        private void ClienteAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                FormConfig.TextBoxToReadOnly(this);
                txtFiltro.ReadOnly = false;
                _listaClientes = new BLL.ClienteBLL().Listar().ConvertAll(x => (BEL.ClienteBEL)x);
                bsClientes.DataSource = _listaClientes;
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _edit = new ClienteEditForm();
            _edit.Tag = bsClientes.Current;
            _edit.ShowDialog();
            bsClientes.ResetCurrentItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _edit = new ClienteEditForm();
            _edit.Tag = new BEL.ClienteBEL();
            _edit.ShowDialog();
            bsClientes.ResetCurrentItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool result=false;
                if (MessageBox.Show($"Eliminar {bsClientes.Current.ToString()}", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    result = new BLL.ClienteBLL().Eliminar((BEL.EntidadBase)bsClientes.Current);

                if (result)
                {
                    Mensajes.MensajeResultado(result, this);
                    bsClientes.Remove(bsClientes.Current);
                }
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 4455);
                Mensajes.MensajeExcepcion(ex, this);
                
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
                Servicios.Logger.WriteLogExeption(ex, 3344);
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void AsignarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _buscar = new BuscarActivoForm();
                _buscar.ShowDialog();

                if (_buscar.Seleccionado == null) return;
                ActivoBEL _seleccionado = (ActivoBEL)_buscar.Seleccionado;
                _buscar.Close();

                if (_seleccionado.EstadoActivo.Id != (int)Estados.Disponible)
                    throw new InvalidOperationException("Activo no disponible");

                ((ClienteBEL)bsClientes.Current).ActivosAsignados.Add(_seleccionado);

                if (new ClienteBLL().Modificar((ClienteBEL)bsClientes.Current))
                {
                    _seleccionado.EstadoActivo = (EstadoBEL)new EstadoBLL().Listar().Find(x=>x.Id==(int)Estados.EnUso);
                    new ActivoBLL().Modificar(_seleccionado);
                }
                                
                bsActivosAsignados.ResetBindings(false);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);               
            }
            
        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsActivosAsignados.Current == null) return;

                if (new ClienteBLL().Modificar((ClienteBEL)bsClientes.Current))
                {
                    var _nuevoEstado = new EstadoBLL().Listar().Find(x => x.Id == (int)Estados.Disponible);
                    ((ActivoBEL)bsActivosAsignados.Current).EstadoActivo = (EstadoBEL)_nuevoEstado;
                    new ActivoBLL().Modificar((ActivoBEL)bsActivosAsignados.Current);
                    bsActivosAsignados.Remove(bsActivosAsignados.Current);
                    bsActivosAsignados.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex,this);
               
            }
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
