using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using Servicios;

namespace AppDeposito
{
    public partial class ReparacionEditForm : Form, IObserverTraducible
    {
        public ReparacionEditForm()
        {
            InitializeComponent();
        }

        private void EdicionReparacionForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            bsReparacion.DataSource = Tag;
            FinalizarReparacion(((ReparacionBEL)Tag).Realizada);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FinalizarReparacion(realizadaCheckBox.Checked);

                FormConfig.ValidarCamposCompletos(this, errorProvider);
                
                if (((EntidadBase)Tag).Id==0)
                    Mensajes.MensajeResultado(new BLL.ReparacionBLL().Agregar((EntidadBase)Tag),this);
                else
                    Mensajes.MensajeResultado(new BLL.ReparacionBLL().Modificar((EntidadBase)Tag), this);

                Close();
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 5544);
                Mensajes.MensajeExcepcion(ex, this);
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
                fechaFinalizacionDateTimePicker.Format = DateTimePickerFormat.Short;
                fechaFinalizacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
                string _fecha = ((ReparacionBEL)Tag).FechaFinalizacion;
                if (_fecha == "") ((ReparacionBEL)Tag).FechaFinalizacion = DateTime.Now.ToString("dd/MM/yyyy");
                else fechaFinalizacionDateTimePicker.Value = DateTime.Parse(_fecha);
            }
            else
            {
                fechaFinalizacionDateTimePicker.Format = DateTimePickerFormat.Custom;
                fechaFinalizacionDateTimePicker.CustomFormat = " ";
                ((ReparacionBEL)Tag).FechaFinalizacion = "";
            }
        }
        private void realizadaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FinalizarReparacion(realizadaCheckBox.Checked);
        }

        private void ActivoBuscarButton_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarActivoForm();
            _busqueda.ShowDialog();
            ((ReparacionBEL)Tag).Activo = (ActivoBEL)_busqueda.Seleccionado;
            bsReparacion.ResetCurrentItem();

            _busqueda.Close();
        }

        private void ClienteBuscarButton_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarClienteForm() { Tag = new BLL.ClienteBLL() };
            _busqueda.ShowDialog();
            ((ReparacionBEL)Tag).Solicitante = (ClienteBEL)_busqueda.Seleccionado;
            bsReparacion.ResetCurrentItem();
            _busqueda.Close();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
