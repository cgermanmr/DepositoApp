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
        public IdiomaBEL IdiomaEditado { 
            get => bsIdiomas.DataSource as IdiomaBEL;
            set { 
                bsIdiomas.DataSource = value;
                bsLeyendas.DataSource = value.Leyendas.OrderBy(x => x.Valor);
            } 
        }
        public EdicionIdiomaForm(IdiomaBEL idioma)
        {
            InitializeComponent();

            IdiomaEditado = idioma;
            
        }
      
               
        private void EdicionIdiomaForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);


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
           
            foreach (Control c in Controls)
            {
                if (errorProvider.GetError(c).Length > 0)
                {
                    throw new Exception(errorProvider.GetError(c));
                }
            }

            bool resultado;
            if (new Servicios.Idioma().Listar().Find(x => x.Nombre == IdiomaEditado.Nombre) == null)
                resultado = new Servicios.Idioma().Agregar(IdiomaEditado);
            else
                resultado = new Servicios.Idioma().Modificar(IdiomaEditado);

            if (Sesion.SesionActual().IdiomaActual.Equals(IdiomaEditado))
                Sesion.SesionActual().IdiomaActual = IdiomaEditado;

            MensajeResultado(resultado);

            Close();                                
             
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
            Traductor.Traducir(this);
        }
    }
}
