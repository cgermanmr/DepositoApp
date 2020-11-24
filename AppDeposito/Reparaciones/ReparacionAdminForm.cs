using System;
using System.Windows.Forms;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class ReparacionAdminForm : Form, IObserverTraducible
    {
        public ReparacionAdminForm()
        {
            InitializeComponent();
        }

        private void EnlazarControles()
        {
            GrillaReparaciones.DataSource = bsReparaciones;
        }
        
        private void ObtenerDatos()
        {
            bsReparaciones.DataSource = new ReparacionBLL().Listar().ConvertAll(x=>(BEL.ReparacionBEL)x);
        }


        private void ReparacionesForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            GrillaReparaciones.AutoGenerateColumns = false;
            FormConfig.TextBoxToReadOnly(this);
            ObtenerDatos();
            EnlazarControles();
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsReparaciones.Current == null) return;

                new PresupuestoAdminForm() { Reparacion = (BEL.ReparacionBEL)bsReparaciones.Current }.ShowDialog();
                bsReparaciones.ResetBindings(false);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            new ReparacionEditForm() { Tag=new BEL.ReparacionBEL()}.ShowDialog();
            ObtenerDatos();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            new ReparacionEditForm() { Tag = bsReparaciones.Current }.ShowDialog();
            bsReparaciones.ResetCurrentItem();
            //ObtenerDatos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                    $"Confirmar eliminar reparación: {Environment.NewLine}{bsReparaciones.Current.ToString()}",
                    "Eliminar reparación", 
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Mensajes.MensajeResultado(new ReparacionBLL().Eliminar((BEL.ReparacionBEL)bsReparaciones.Current), this);
                    bsReparaciones.RemoveCurrent();
                }

            }
            catch (Exception ex)
            {               

                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void estadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bsReparaciones.Current == null)
            {
                estadoCheckBox.Checked = false;
                return;
            }
            estadoCheckBox.Checked = ((BEL.ReparacionBEL)bsReparaciones.Current).Estado;
        }

        private void enGarantiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bsReparaciones.Current == null)
            {
                enGarantiaCheckBox.Checked = false;
                return;
            }
            enGarantiaCheckBox.Checked = ((BEL.ReparacionBEL)bsReparaciones.Current).Activo.EnGarantia;

        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
