using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalForm());
            //Application.Run(new DonacionesForm());


            //Application.Run(new Administracion.Permisos.AdminPermisosForm());
            //Application.Run(new Administracion.Permisos.AdminUsuariosForm());
            //Application.Run(new Administracion.Idioma.EdicionIdiomaForm());
            //Application.Run(new Administracion.Idioma.MultiIdiomaForm());
            //Application.Run(new Administracion.Backup.BackupRestoreForm());
            //Application.Run(new Administracion.Logs.UsuarioControlCambiosForm());
            //Application.Run(new Administracion.Integridad.IntegridadForm());
            //Application.Run(new ActivoAdminForm());
            //Application.Run(new ReparacionAdminForm());
            //Application.Run(new ClienteAdminForm());
            //Application.Run(new DepositoAdminForm());

            //Application.Run(new Activos.ProveedoresForm());
            //Application.Run(new OrganizacionAdminForm());
            //Application.Run(new SectorAdminForm());
            //Application.Run(new UbicacionAdminForm());
            //Application.Run(new MarcaAdminForm());
            //Application.Run(new EstadoAdminForm());


        }
    }
}
