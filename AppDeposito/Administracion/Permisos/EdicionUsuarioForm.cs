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

namespace AppDeposito.Administracion.Permisos
{
    public partial class EdicionUsuarioForm : Form,IObserverTraducible
    {     
        
        public EdicionUsuarioForm()
        {
            InitializeComponent();
        }

        public UsuarioBEL UsuarioEditado { get; set; }

        private void EdicionUsuarioForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);

            txtNombre.ReadOnly = !(UsuarioEditado == null);
            txtClave.ReadOnly = !(UsuarioEditado == null);
            txtClaveRepetir.ReadOnly = !(UsuarioEditado == null);

            if (UsuarioEditado == null)
            {
                UsuarioEditado = new UsuarioBEL();
                txtClave.DataBindings.Add("Text", UsuarioEditado, "Clave");
            }                                                       

            txtNombre.DataBindings.Add("Text", UsuarioEditado, "Nombre");
            txtEmail.DataBindings.Add("Text", UsuarioEditado, "Email");
            chkBloqueado.DataBindings.Add("Checked", UsuarioEditado, "Bloqueado");
            cboIdioma.DataSource = new Servicios.Idioma().Listar();
            cboIdioma.DataBindings.Add("SelectedItem", UsuarioEditado, "Idioma");   
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {      
                foreach (Control c in this.Controls)
                {
                    if (errorProvider.GetError(c).Length > 0)
                    {
                        throw new Exception(errorProvider.GetError(c));
                    }
                }

                bool validado = false;
                var p = new Usuario();

                if (UsuarioEditado.Idioma == null)
                    UsuarioEditado.Idioma = (IdiomaBEL)cboIdioma.SelectedItem;

                validado = (UsuarioEditado.Id != 0) ? p.Modificar(UsuarioEditado) : p.Agregar(UsuarioEditado);

                DialogResult = (validado) ? DialogResult.OK : DialogResult.No;
                Close();                           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }  
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                errorProvider.SetError(txtNombre, "Se ha ingresado un nombre inválido.");
            else
                errorProvider.SetError(txtNombre, "");
        }

        private void txtClave_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text))
                errorProvider.SetError(txtClave, "Ingrese una clave.");
            else
                errorProvider.SetError(txtClave, "");
        }
        private void txtClaveRepetir_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveRepetir.Text))
                errorProvider.SetError(txtClaveRepetir, "Ingrese una clave.");
            else
                errorProvider.SetError(txtClaveRepetir, "");

            if (!txtClaveRepetir.Text.Equals(txtClave.Text))
                errorProvider.SetError(txtClaveRepetir, "Las claves no coinciden");
            else
                errorProvider.SetError(txtClaveRepetir, "");
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                errorProvider.SetError(txtEmail, "Ingrese una dirección de correo.");
            else
                errorProvider.SetError(txtEmail, "");
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
