using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using Interfaces;
using Servicios;

namespace AppDeposito.Administracion.Backup
{
    public partial class BackupRestoreForm : Form,IObserverTraducible
    {
        public BackupBEL BackupSeleccionado => bsBackups.Current as BackupBEL;
        public List<BackupBEL> Grilla { get => bsBackups.DataSource as List<BackupBEL>; set => bsBackups.DataSource = value; }
        public bool FueRestaurado { get; internal set; }

        public BackupRestoreForm()
        {
            InitializeComponent();
        }   
        private void BtnRealizarBackup_Click(object sender, EventArgs e)
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
            var msj = $"Se ha realizado el backup correctamente, archivo: {dlg.FileName}";
            Bitacora.RegistrarEnBitacora(msj,TipoEvento.Auditoria,Criticidad.Media);

            Mensajes.ShowExitoso(msj);

            CargarGrilla();
            
            Cursor = Cursors.Default;
        }    
        private void BtnRealizarRestore_Click(object sender, EventArgs e)
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
            Bitacora.RegistrarEnBitacora(msj, TipoEvento.Auditoria, Criticidad.Alta);
                                    
            Cursor = Cursors.Default;

            FueRestaurado = true;
            
            Close();
            
        }    
        private void BackupRestoreForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            Grilla = new BackupRestore().Listar();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
