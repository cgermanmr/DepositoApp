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
        private ReparacionBEL _reparacion;
        private readonly ReparacionBLL _reparacionBLL;
        public PresupuestoAdminForm(ReparacionBEL reparacion)
        {
            InitializeComponent();
            _reparacion = reparacion;



        }

        private void ObtenerDatos()
        {
            _reparacion = new ReparacionBLL().GetById(_reparacion.Id) as ReparacionBEL;
            
            bsPresupuestos.DataSource = _reparacion.Presupuestos;
            grilla.DataSource = bsPresupuestos;
        }
        private void PresupuestoAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                Text = $"Presupuestos de reparación {_reparacion.Activo}";
                grilla.AutoGenerateColumns = false;              

                ObtenerDatos();
                
            }
            catch (Exception ex)
            {                
                Mensajes.ShowError(ex, this);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                new PresupuestoEditForm(new PresupuestoBEL() { Reparacion = _reparacion }) 
                .ShowDialog();

                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Desea eliminar el presupuesto de {bsPresupuestos.Current}", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Mensajes.MensajeResultado(new PresupuestoBLL().Eliminar((PresupuestoBEL)bsPresupuestos.Current), this);
                
                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
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
                Mensajes.ShowError(ex, this);
            }
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
