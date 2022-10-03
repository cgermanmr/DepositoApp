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
    public partial class CambioClaveForm : Form,IObserverTraducible
    {
        public UsuarioBEL Editado { get; set; }
        public CambioClaveForm()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
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

                Editado.Clave = txtClave.Text;

                bool validado = false;

                validado = new Usuario().ModificarClave(Editado);

                DialogResult = (validado) ? DialogResult.OK : DialogResult.No;
                Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Close();
        }

        private void CambioClaveForm_Load(object sender, EventArgs e)
        {
            Sesion.SesionActual().Suscribir(this);

        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
