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
using BEL;

namespace AppDeposito.Administracion.Integridad
{
    public partial class RestauracionForm : Form,IObserverTraducible
    {
        public BackupBEL BackupSeleccionado => bsBackups.Current as BackupBEL;

        public List<BackupBEL> Grilla { get => bsBackups.DataSource as List<BackupBEL>; set => bsBackups.DataSource = value; }

        public RestauracionForm()
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

            Grilla = new BackupRestore().Listar();
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

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = "";

            if (File.Exists(BackupSeleccionado?.Ubicacion))
                path = BackupSeleccionado.Ubicacion;
            else
            {
                var dlg = new OpenFileDialog
                {
                    DefaultExt = ".bak", //Default file extension
                    CheckPathExists = true,
                    InitialDirectory = "c:\\", //txRutaBackup.Text
                    Filter = "Archivos Backup (.bak)|*.bak" //Filter files by extension
                };
                //Show save file dialog box
                var result = dlg.ShowDialog();
                //Process save file dialog box results
                if (result == DialogResult.Cancel)
                    return;

                path = dlg.FileName;

            }


            if (!Mensajes.ShowDecision($"Desea restaurar la base de datos con {path}"))
                return;

            Cursor = Cursors.WaitCursor;
            new BackupRestore().RealizarRestore(path);
            var msj = $"Se ha realizado la restauración correctamente con el archivo {path}";

            Mensajes.ShowExitoso(msj);

            Cursor = Cursors.Default;

            Close();
        }
    }
}
