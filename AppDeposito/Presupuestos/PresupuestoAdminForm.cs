using System;
using System.Linq;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class PresupuestoAdminForm : Form, IObserverTraducible
    {
        private readonly ReparacionBEL Reparacion;
        public PresupuestoAdminForm(ReparacionBEL reparacion)
        {
            InitializeComponent();
            Reparacion = reparacion;

        }

        private void ObtenerDatos()
        {
            bsPresupuestos.DataSource = null;
            
            bsPresupuestos.DataSource = Reparacion.Presupuestos;
            grilla.DataSource = bsPresupuestos;
        }
        private void PresupuestoAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                Text = $"Presupuestos de reparación {Reparacion.Activo}";
                grilla.AutoGenerateColumns = false;              

                ObtenerDatos();
                
            }
            catch (Exception ex)
            {                
                Mensajes.MensajeExcepcion(ex, this);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                new PresupuestoEditForm(new PresupuestoBEL() { Reparacion = Reparacion }) 
                .ShowDialog();

                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Desea eliminar el presupuesto de {bsPresupuestos.Current}", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Mensajes.MensajeResultado(new Presupuesto().Eliminar((PresupuestoBEL)bsPresupuestos.Current), this);
                
                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
             
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                new PresupuestoEditForm(bsPresupuestos.Current as PresupuestoBEL)
                .ShowDialog();
                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
