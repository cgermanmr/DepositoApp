using System;
using System.Linq;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AppDeposito
{
    public partial class ReparacionAdminForm : Form, IObserverTraducible
    {
        public ReparacionAdminForm()
        {
            InitializeComponent();
        }

        public ReparacionBEL ReparacionSeleccionada { get => bsReparaciones.Current as ReparacionBEL; }
        private void ObtenerDatos()
        {
            var reparaciones = new ReparacionBLL()
                .Listar().ConvertAll( x => (ReparacionBEL)x )
                .OrderByDescending(x => x.FechaSolicitud).ToList();

            bsReparaciones.DataSource = chkSoloPendientes.Checked
                ? reparaciones.Where(r => !r.Realizada).ToList()
                : reparaciones;
        }


        private void ReparacionesForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            FormConfig.TextBoxToReadOnly(this);
            ObtenerDatos();
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReparacionSeleccionada == null) return;

                new PresupuestoAdminForm(ReparacionSeleccionada).ShowDialog();
                bsReparaciones.ResetBindings(false);
                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            new ReparacionEditForm().ShowDialog();
            ObtenerDatos();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            new ReparacionEditForm() { Reparacion = ReparacionSeleccionada }.ShowDialog();
            bsReparaciones.ResetCurrentItem();
            ObtenerDatos();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mensajes.ShowDecision($"Confirmar eliminar reparación: \n{ReparacionSeleccionada}"))
                {
                    Mensajes.MensajeResultado(new ReparacionBLL().Eliminar(ReparacionSeleccionada), this);
                    bsReparaciones.RemoveCurrent();
                }

            }
            catch (Exception ex)
            {               

                Mensajes.ShowError(ex, this);
            }
        }

        

        private void enGarantiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bsReparaciones.Current == null)
            {
                enGarantiaCheckBox.Checked = false;
                return;
            }
            enGarantiaCheckBox.Checked = ReparacionSeleccionada.Activo.EnGarantia;

        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

       

        private void chkSoloPendientes_CheckedChanged(object sender, EventArgs e)
        {
            ObtenerDatos();

        }
    }
}
