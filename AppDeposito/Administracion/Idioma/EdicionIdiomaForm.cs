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

namespace AppDeposito.Administracion.Idioma
{
    public partial class EdicionIdiomaForm : Form,IObserverTraducible
    {
        public IdiomaBEL Editado { get; set; }                                                                                

        public EdicionIdiomaForm()
        {
            InitializeComponent();
        }

        private BindingSource bsLeyendasEditado=new BindingSource();
       

        private void EnlazarControles()
        {
            bsLeyendasEditado.DataSource = Editado.Leyendas;
            txtNombre.DataBindings.Add("Text", Editado, "Nombre");
            txtDescripcion.DataBindings.Add("Text", Editado, "Descripcion");
            GrillaLeyendas.AutoGenerateColumns = false;
            GrillaLeyendas.DataSource = bsLeyendasEditado;
            txtPredeterminada.DataBindings.Add("Text", bsLeyendasEditado, "Valor");
            txtEditada.DataBindings.Add("Text", bsLeyendasEditado, "Valor");
        }
               
        private void EdicionIdiomaForm_Load(object sender, EventArgs e)
        {
            Sesion.SesionActual().Suscribir(this);
            EnlazarControles();                       
        }

        private void MensajeResultado(bool resultado)
        {
            if (resultado)
                MessageBox.Show("La operación a concluído exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido realizar la operación", "Operación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
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

                bool resultado;
                if (new Servicios.Idioma().Listar().Find(x => x.Nombre == Editado.Nombre) == null)
                    resultado = new Servicios.Idioma().Agregar(Editado);
                else
                    resultado = new Servicios.Idioma().Modificar(Editado);

                MensajeResultado(resultado);
                Close();
                                
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("La operación falló. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnTraducirDesdeInternet_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                errorProvider.SetError(txtNombre, "Se ha ingresado un nombre inválido.");
            else
                errorProvider.SetError(txtNombre, "");
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
                errorProvider.SetError(txtDescripcion, "Se ha ingresado una descripción inválida.");
            else
                errorProvider.SetError(txtDescripcion, "");
        }

        private void txtEditada_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditada.Text))
                errorProvider.SetError(txtEditada, "Se ha ingresado una traducción inválida.");
            else
                errorProvider.SetError(txtEditada, "");
        }

        public void Traducir()
        {
            Servicios.Traductor.Traducir(this);
        }
    }
}
