using System;
using System.Windows.Forms;
using Interfaces;
using Servicios;
using BEL;
using AppDeposito.Pagos;
using AppDeposito.Administracion.Backup;
using AppDeposito.Administracion.Permisos;
using AppDeposito.Administracion.Logs;
using AppDeposito.Reparaciones;

namespace AppDeposito
{
    public partial class PrincipalForm : Form,IObserverTraducible
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }
        public LoginForm LoginForm { get; set; }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void ArmarMenu()
        {
            var _sesion = Sesion.SesionActual();

            UsuariosToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Usuario_Consultar);
            PermisosToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Permiso_Consultar);
            BitacoraToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Logs_Consultar);
            BackupToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Backup_Consultar);
            IdiomaToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Idioma_Consultar);
            IntegridadToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Integridad_Consultar);

            foreach (ToolStripMenuItem item in AdministrarToolStripMenuItem.DropDownItems)
            {
                AdministrarToolStripMenuItem.Available = false | item.Available;
                if (AdministrarToolStripMenuItem.Available) break;
            }

            GestionarActivosToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Activos);
            GestionarToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Propiedades_Activos);
            GestionarUbicacionesToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Ubicaciones);
            UsuarioDelActivoToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Usuario_de_Activos);

            foreach (ToolStripMenuItem item in ActivosToolStripMenuItem.DropDownItems)
            {
                ActivosToolStripMenuItem.Available = false | item.Available;
                if (ActivosToolStripMenuItem.Available) break;
            }

            GestionarReparacionesToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Reparacion);
            GestionarProveedoresToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Proveedores);
            ingresoFacturasToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Reparacion_Ingreso_Facturas);
            ordenesDePagoToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Reparacion_Ordenes_Pago);
            nuevaReparaciónToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Reparacion);
            consultarHistorialReparacionesToolStripMenuItem.Available = _sesion.TienePermiso(Permisos.Gestionar_Reparacion);

            foreach (ToolStripMenuItem item in ReparacionesToolStripMenuItem.DropDownItems)
            {
                ReparacionesToolStripMenuItem.Available = false | item.Available;
                if (ReparacionesToolStripMenuItem.Available) break;
            }
        }

        private void Init()
        {
            //LoginForm login = new LoginForm();

            //if (!Sesion.SesionActual().Integridad)
            //{
            //    MessageBox.Show("Se ha producido un error al verificar la integridad de los datos, informar al administrador", "Falla Integridad de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Login.ModoRecuperacion = true;
            //}

            //if (Login.ShowDialog(this) == DialogResult.OK)
            //{
                ArmarMenu();
                CerrarSesionToolStripMenuItem.Enabled = true;
                IniciarSesionToolStripMenuItem.Enabled = false;
                //Visible = true;
                Sesion.SesionActual().Suscribir(this);
            //}
            //else
            //    Close();
        }

        private void IniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!Sesion.SesionActual().Integridad)
                Mensajes.ShowError("Se ha producido un error al verificar la integridad de los datos, informar al administrador");

            LoginForm login = new LoginForm();

            Sesion.SesionActual().Suscribir(login);

            if (login.ShowDialog(this) == DialogResult.OK)
            {
                ArmarMenu(); 
                CerrarSesionToolStripMenuItem.Enabled = true;
                IniciarSesionToolStripMenuItem.Enabled = false;
            }

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            Sesion.SesionActual().Suscribir(this);
            Sesion.CierreSesionEvent += PrincipalForm_CierreSesionEvent;

            Init();
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
            var adminUsuarios = new AdminUsuariosForm
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(adminUsuarios);

            adminUsuarios.Show();             
        }

        private void QuitarMenu()
        {
            ArmarMenu();
        }
        private void CerrarSesion()
        {
            if(Sesion.SesionActual().ObtenerUsuarioActual!=null)
                Sesion.Cerrar();

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
            var adminPermisos = new AdminPermisosForm
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(adminPermisos);

            adminPermisos.Show();
        }
        
        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var adminBackup = new BackupRestoreForm
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(adminBackup);

            adminBackup.Show();     
            
            if(adminBackup.FueRestaurado)
                Close();
        }

        private void IdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {                 
            var adminIdioma = new Administracion.Idioma.MultiIdiomaForm
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(adminIdioma);

            adminIdioma.Show();
        }

        private void IntegridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var adminIntegridad = new Administracion.Integridad.IntegridadForm
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(adminIntegridad);

            adminIntegridad.Show();
        }

        private void MenuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

            Sesion.SesionActual().Suscribir(adminActivos);


            adminActivos.Show();

        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitacoraForm = new BitacoraForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(bitacoraForm);

            bitacoraForm.Show();
        }

        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controlCambios = new UsuarioControlCambiosForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(controlCambios);

            controlCambios.Show();
        }
             

        private void UsuarioDelActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionarClientes = new ClienteAdminForm()
            {
                MdiParent = this,
            };
            Sesion.SesionActual().Suscribir(gestionarClientes);

            gestionarClientes.Show();
        }      

        private void GestionarUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ubicacionAdmin = new UbicacionAdminForm()
            {
                MdiParent = this,
            };
            Sesion.SesionActual().Suscribir(ubicacionAdmin);

            ubicacionAdmin.Show();
        }

        private void EstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estadoAdmin = new EstadoAdminForm()
            {
                MdiParent = this,
            };
            Sesion.SesionActual().Suscribir(estadoAdmin);
            estadoAdmin.Show();
        }

        private void TiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tipoAdmin = new TipoActivoAdminForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(tipoAdmin);

            tipoAdmin.Show();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marcaAdmin = new MarcaAdminForm()
            {
                MdiParent = this,
            };
            Sesion.SesionActual().Suscribir(marcaAdmin);
            marcaAdmin.Show();

        }

        private void SectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sectoresAdmin = new SectorAdminForm()
            {
                MdiParent = this,
            };
            Sesion.SesionActual().Suscribir(sectoresAdmin);
            sectoresAdmin.Show();
        }
                           

        private void GestionarReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reparacionAdmin = new ReparacionAdminForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(reparacionAdmin);

            reparacionAdmin.Show();
        }

        private void GestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proveedorAdm = new ProveedorAdminForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(proveedorAdm);

            proveedorAdm.Show();
        }
              

        private void ingresoFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ingresoFacturas = new IngresoFacturasForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(ingresoFacturas);

            ingresoFacturas.Show();
        }
               

        private void ordenesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ordenesPago = new OrdenPagoAdminForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(ordenesPago);

            ordenesPago.Show();
        }

        private void controlDeCambiosFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var controlFacturas = new FacturasControlCambiosForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(controlFacturas);

            controlFacturas.Show();
        }
             

        private void nuevaReparaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nuevaReparacion = new ReparacionEditForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(nuevaReparacion);

            nuevaReparacion.Show();
        }

        private void consultarHistorialReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ConsultarHistorialReparacionesForm()
            {
                MdiParent = this,
            };

            Sesion.SesionActual().Suscribir(form);

            form.Show();

        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }
    }
}
