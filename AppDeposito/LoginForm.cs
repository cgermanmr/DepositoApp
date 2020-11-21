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
using Servicios;


namespace AppDeposito
{
    public partial class LoginForm : Form, IObserverTraducible
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Completar datos de login", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Login();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var usuario = new UsuarioBEL
                {
                    Nombre = txtNombre.Text,
                    Clave = txtClave.Text
                };

                var resultado = Sesion.SesionActual().Iniciar(usuario);

                switch (resultado)
                {
                    case ResultadoAutenticacion.UsuarioValido:
                        DialogResult = DialogResult.OK;
                        break;
                    case ResultadoAutenticacion.UsuarioInvalido:
                        DialogResult = DialogResult.No;
                        MessageBox.Show("Usuario o clave incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ResultadoAutenticacion.UsuarioBloqueado:
                        DialogResult = DialogResult.No;
                        MessageBox.Show("Usuario bloqueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("Se ha producido un error "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
        }
    }
}
