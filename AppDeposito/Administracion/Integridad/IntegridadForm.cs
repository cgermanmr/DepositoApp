using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Servicios;

namespace AppDeposito.Administracion.Integridad
{
    public partial class IntegridadForm : Form,IObserverTraducible
    {
        public IntegridadForm()
        {
            InitializeComponent();
        }

        private void VerificarButton_Click(object sender, EventArgs e)
        {
            StringWriter salida = new StringWriter();
            Console.SetOut(salida);

            if (Sesion.SesionActual().Integridad)
            {
                MessageBox.Show(this,"Integridad de datos OK", "Datos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this,"Falló verificación de integridad de datos", "Falla de integridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtSalida.Text = salida.ToString();
            salida.Close();
        }

        private void IntegridadForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);

        }

        private void RegenerarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IntegridadDatos.RegenerarDV())
                    MessageBox.Show("Códigos verificadores regenerados OK", "Códigos regenerados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Falló la regeneracion de códigos", "Falló regeneracion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("Se a producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
