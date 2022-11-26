using AppDeposito.Administracion.Backup;
using AppDeposito.Administracion.Logs;
using AppDeposito.Pagos;
using AppDeposito.Reparaciones;
using AppDeposito.Test;
using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);


            //Application.Run(new LoginForm());
            
            //Application.Run(new PrincipalForm());
            //Application.Run(new PruebaAyudaForm());
            //Application.Run(new ConsultarHistorialReparacionesForm());
            //Application.Run(new FacturasControlCambiosForm());
            //Application.Run(new ActivoControlCambiosForm());


            //Application.Run(new BitacoraForm());

            //Application.Run(new DonacionesForm());

            //Application.Run(new Administracion.Permisos.AdminPermisosForm());
            //Application.Run(new Administracion.Permisos.AdminUsuariosForm());
            //Application.Run(new Administracion.Idioma.EdicionIdiomaForm());
            //Application.Run(new Administracion.Idioma.MultiIdiomaForm());

            Application.Run(new BackupRestoreForm());

            //Application.Run(new Administracion.Logs.UsuarioControlCambiosForm());
            //Application.Run(new Administracion.Integridad.IntegridadForm());
            //Application.Run(new ActivoAdminForm());
            //Application.Run(new ReparacionAdminForm());
            //Application.Run(new ClienteAdminForm());
            //Application.Run(new DepositoAdminForm());

            //Application.Run(new EmpresaAdminForm());
            //Application.Run(new SectorAdminForm());
            //Application.Run(new UbicacionAdminForm());
            //Application.Run(new MarcaAdminForm());
            //Application.Run(new EstadoAdminForm());
            //Application.Run(new IngresoFacturasForm());
            //Application.Run(new OrdenPagoAdminForm());


        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;

            Logger.WriteLogExeption(ex);

            switch (ex)
            {
                case InvalidOperationException invalidOperationException:
                    MessageBox.Show(invalidOperationException.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Bitacora.RegistrarEnBitacora($"{ex.Message}", TipoEvento.Error,Criticidad.Media);
                    break;
                
                default:
                    MessageBox.Show($"Se ha producido un error: \n\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bitacora.RegistrarEnBitacora($"{ex.Message}", TipoEvento.Error,Criticidad.Alta);
                    break;
            }
        }


    }
}
