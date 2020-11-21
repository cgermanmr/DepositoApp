using System;
using System.Windows.Forms;
using Interfaces;
using Servicios;
using BEL;

namespace AppDeposito
{
    public partial class PrincipalForm : Form,IObserverTraducible
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void ArmarMenu()
        {
            UsuariosToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Usuario_Consultar.ToString());
            PermisosToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Permiso_Consultar.ToString());
            BitacoraToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Logs_Consultar.ToString());
            BackupToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Backup_Consultar.ToString());
            IdiomaToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Idioma_Consultar.ToString());
            IntegridadToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Integridad_Consultar.ToString());

            foreach (ToolStripMenuItem item in AdministrarToolStripMenuItem.DropDownItems)
            {
                AdministrarToolStripMenuItem.Available = false | item.Available;
                if (AdministrarToolStripMenuItem.Available) break;
            }

            GestionarActivosToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Activos.ToString());
            GestionarToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Propiedades_Activos.ToString());
            GestionarPCsToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_PCs.ToString());
            GestionarUbicacionesToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Ubicaciones.ToString());
            categoriasPCsToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Categorias_PCs.ToString());
            PropuestaDeReemplazoPCsToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Propuesta_Reemplazo.ToString());
            UsuarioDelActivoToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Usuario_de_Activos.ToString());

            foreach (ToolStripMenuItem item in ActivosToolStripMenuItem.DropDownItems)
            {
                ActivosToolStripMenuItem.Available = false | item.Available;
                if (ActivosToolStripMenuItem.Available) break;
            }

            administrarDepositosToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Depositos.ToString());
            AdministrarDonacionesToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Donacion.ToString());
            PropuestaDeDonaciónToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Propuesta_Donacion.ToString());

            foreach (ToolStripMenuItem item in DepositosToolStripMenuItem.DropDownItems)
            {
                DepositosToolStripMenuItem.Available = false | item.Available;
                if (DepositosToolStripMenuItem.Available) break;
            }

            GestionarReparacionesToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Reparacion.ToString());
            GestionarProveedoresToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Proveedores.ToString());
            ReparacionesRecurrentesToolStripMenuItem.Available = Sesion.SesionActual().TienePermisoPara(Permisos.Gestionar_Recurrentes.ToString());

            foreach (ToolStripMenuItem item in ReparacionesToolStripMenuItem.DropDownItems)
            {
                ReparacionesToolStripMenuItem.Available = false | item.Available;
                if (ReparacionesToolStripMenuItem.Available) break;
            }
        }
        private void IniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!Sesion.SesionActual().Integridad)
            {
                MessageBox.Show("Se ha producido un error al verificar la integridad de los datos, informar al administrador", "Falla Integridad de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                ArmarMenu(); 
                CerrarSesionToolStripMenuItem.Enabled = true;
                IniciarSesionToolStripMenuItem.Enabled = false;
            }

            Sesion.SesionActual().Suscribir(this);
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            Sesion.SesionActual().CierreSesionEvent += PrincipalForm_CierreSesionEvent;
        }

        private void PrincipalForm_CierreSesionEvent(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {                      
            var adminUsuarios = new Administracion.Permisos.AdminUsuariosForm
            {
                MdiParent = this,
            };
            
            adminUsuarios.Show();             
        }

        private void QuitarMenu()
        {
            ArmarMenu();
        }
        private void CerrarSesion()
        {
            if(Sesion.SesionActual().ObtenerUsuarioActual!=null)
                Sesion.SesionActual().Cerrar();

            IniciarSesionToolStripMenuItem.Enabled = true;
            CerrarSesionToolStripMenuItem.Enabled = false;

            QuitarMenu();

            foreach (var item in MdiChildren)
            {
                item.Close();
            }           
        }
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void PermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {             
            var adminPermisos = new Administracion.Permisos.AdminPermisosForm
            {
                MdiParent = this,
            };
          
            adminPermisos.Show();
        }

        
        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var adminBackup = new Administracion.Backup.BackupRestoreForm
            {
                MdiParent = this,
            };
            
            adminBackup.Show();            
        }

        private void IdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {                 
            var adminIdioma = new Administracion.Idioma.MultiIdiomaForm
            {
                MdiParent = this,
            };
            
            adminIdioma.Show();
        }

        private void IntegridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var adminIntegridad = new Administracion.Integridad.IntegridadForm
            {
                MdiParent = this,
            };
            
            adminIntegridad.Show();
        }

        private void MenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PropuestaDeReemplazoPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GestionarActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminActivos = new ActivoAdminForm()
            {
                MdiParent = this               
            };

            adminActivos.Show();

        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminLogs = new Administracion.Logs.BitacoraForm
            {
                MdiParent = this,
            };

            adminLogs.Show();
        }

        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controlCambios = new Administracion.Logs.UsuarioControlCambiosForm()
            {
                MdiParent = this,
            };

            controlCambios.Show();
        }
             

        private void UsuarioDelActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionarClientes = new ClienteAdminForm()
            {
                MdiParent = this,
            };

            gestionarClientes.Show();
        }

        private void CategoriasPCsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GestionarUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ubicacionAdmin = new UbicacionAdminForm()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            ubicacionAdmin.Show();
        }

        private void EstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estadoAdmin = new EstadoAdminForm()
            {
                MdiParent = this,
            };

            estadoAdmin.Show();
        }

        private void TiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tipoAdmin = new TipoActivoAdminForm()
            {
                MdiParent = this,
            };

            tipoAdmin.Show();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marcaAdmin = new MarcaAdminForm()
            {
                MdiParent = this,
            };

            marcaAdmin.Show();

        }

        private void SectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sectoresAdmin = new SectorAdminForm()
            {
                MdiParent = this,
            };

            sectoresAdmin.Show();
        }

        private void OrganizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empresaAdmin = new OrganizacionAdminForm
            {
                MdiParent = this,
            };

            empresaAdmin.Show();
        }

        private void administrarDepositosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var depositoAdmin = new DepositoAdminForm()
            {
                MdiParent = this,
            };

            depositoAdmin.Show();
        }

        private void AdministrarDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var donacionAdmin = new DonacionesForm()
            {
                MdiParent = this,
            };

            donacionAdmin.Show();
        }

        private void GestionarReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reparacionAdmin = new ReparacionAdminForm()
            {
                MdiParent = this,
            };

            reparacionAdmin.Show();
        }

        private void GestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empresaAdmin = new OrganizacionAdminForm()
            {
                MdiParent = this,
            };

            empresaAdmin.Show();
        }

        private void ReparacionesRecurrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
