using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDeposito.Reparaciones;
using BEL;
using BLL;
using Comun;
using Servicios;

namespace AppDeposito
{
    public partial class ReparacionEditForm : Form, IObserverTraducible
    {
        public ReparacionBEL Reparacion { get => bsReparacion.DataSource as ReparacionBEL; set => bsReparacion.DataSource = value; }
        public ReparacionEditForm()
        {
            InitializeComponent();
            Reparacion = new ReparacionBEL();
        }

        private void EdicionReparacionForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            FinalizarReparacion(Reparacion.Realizada);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {

                if ( Reparacion.Id == 0 )
                    Mensajes.MensajeResultado(new ReparacionBLL().Agregar(Reparacion),this);
                else
                    Mensajes.MensajeResultado(new ReparacionBLL().Modificar(Reparacion), this);

                Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex, 5544);
                Mensajes.ShowError(ex, this);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalizarReparacion(bool realizada)
        {
            
            if (realizada)
            {
                Reparacion.FechaFinalizacion = DateTime.Now;
                fechaFinalizacionDateTimePicker.Format = DateTimePickerFormat.Custom;
                fechaFinalizacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                Reparacion.FechaFinalizacion = null;
                fechaFinalizacionDateTimePicker.Format = DateTimePickerFormat.Custom;
                fechaFinalizacionDateTimePicker.CustomFormat = " ";
            }

            fechaFinalizacionDateTimePicker.Enabled = realizada;
        }

            

           
        private void realizadaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FinalizarReparacion(realizadaCheckBox.Checked);
        }

        private void ActivoBuscarButton_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarActivoForm();
            _busqueda.ShowDialog();
            Reparacion.Activo = (ActivoBEL)_busqueda.Seleccionado;
            bsReparacion.ResetCurrentItem();

            _busqueda.Close();
        }

        private void ClienteBuscarButton_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarClienteForm();
            _busqueda.ShowDialog();
            Reparacion.Solicitante = _busqueda.Solicitante;
            bsReparacion.ResetCurrentItem();
            _busqueda.Close();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AsignarEquipoReemplazoForm(Reparacion).ShowDialog();
        }
    }
}
