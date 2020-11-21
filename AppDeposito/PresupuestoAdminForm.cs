using System;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class PresupuestoAdminForm : Form, IObserverTraducible
    {
        public ReparacionBEL Reparacion { get; set; }
        public PresupuestoAdminForm()
        {
            InitializeComponent();
        }

        private void ObtenerDatos()
        {
            bsPresupuestos.DataSource = null;
            Reparacion.Presupuestos = new PresupuestoBLL().Listar().FindAll(x=>((PresupuestoBEL)x).Reparacion.Id==Reparacion.Id).ConvertAll(x=>(PresupuestoBEL)x);
            bsPresupuestos.DataSource = Reparacion.Presupuestos;
            grilla.DataSource = bsPresupuestos;
        }
        private void PresupuestoAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                Text = $"Presupuestos de reparación {Reparacion.Activo.ToString()}";
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
                new PresupuestoEditForm() { Tag = new PresupuestoBEL() { Reparacion = this.Reparacion } }
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
                if (MessageBox.Show($"Desea eliminar el presupuesto de {bsPresupuestos.Current.ToString()}", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Mensajes.MensajeResultado(new PresupuestoBLL().Eliminar((PresupuestoBEL)bsPresupuestos.Current), this);
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
                new PresupuestoEditForm() { Tag = bsPresupuestos.Current }
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
