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

namespace AppDeposito.Administracion.Backup
{
    public partial class BackupRestoreForm : Form,IObserverTraducible
    {
        public BackupRestoreForm()
        {
            InitializeComponent();
        }   
        private void BtnRealizarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                //Configure save file dialog box
                var dlg = new SaveFileDialog
                {
                    FileName = string.Format("Backup_Full_{0}", DateTime.Now.ToString("yyy-MM-dd_HHmmss")), // Default file name
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

                Cursor = Cursors.WaitCursor;

                new BackupRestore().RealizarBackup(dlg.FileName);
                MessageBox.Show("Se ha realizado el backup correctamente", "Backup Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló el backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }    
        private void BtnRealizarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                //Configure save file dialog box
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

                Cursor = Cursors.WaitCursor;

                new BackupRestore().RealizarBackup(dlg.FileName);
                MessageBox.Show("Se ha realizado la restauración", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sesion.SesionActual().Cerrar();
                Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("Falló la restauración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }    
        private void BackupRestoreForm_Load(object sender, EventArgs e)
        {

        }   
        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
