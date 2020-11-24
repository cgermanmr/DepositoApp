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
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class EdicionDonacionForm : Form, IObserverTraducible
    {
        public EdicionDonacionForm()
        {
            InitializeComponent();
        }

        private void FecharDonacion(bool autorizada)
        {
            if (autorizada)
            {
                fechaDateTimePicker.Format = DateTimePickerFormat.Short;
                fechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
                string _fecha = ((DonacionBEL)Tag).Fecha;
                if (_fecha == "") ((DonacionBEL)Tag).Fecha = DateTime.Now.ToString("dd/MM/yyyy");
                else fechaDateTimePicker.Value = DateTime.Parse(_fecha);
            }
            else
            {
                fechaDateTimePicker.Format = DateTimePickerFormat.Custom;
                fechaDateTimePicker.CustomFormat = " ";
                ((DonacionBEL)Tag).Fecha = "";
            }
        }
        private void estadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FecharDonacion(estadoCheckBox.Checked);
        }
        DonacionBEL _donacion;
        private void EdicionDonacionForm_Load(object sender, EventArgs e)
        {
            try
            {

                bsDonacion.DataSource = (DonacionBEL)Tag;
                _donacion = (DonacionBEL)Tag;
                auditorComboBox.DataSource = new ClienteBLL().Listar();
                autorizadorComboBox.DataSource = new ClienteBLL().Listar();
                organizacionComboBox.DataSource = new EmpresaBLL().Listar();

                if (_donacion.Id==0)
                {
                    auditorComboBox.SelectedIndex = -1;
                    autorizadorComboBox.SelectedIndex = -1;
                    organizacionComboBox.SelectedIndex = -1;
                }
                else
                {
                    auditorComboBox.SelectedIndex = auditorComboBox.FindString(_donacion.Auditor.Descripcion);
                    autorizadorComboBox.SelectedIndex = autorizadorComboBox.FindString(_donacion.Autorizador.Descripcion);
                    organizacionComboBox.SelectedIndex = organizacionComboBox.FindString(_donacion.Organizacion.Descripcion);
                }
                FecharDonacion(_donacion.Estado);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfig.ValidarCamposCompletos(this, errorProvider);
                FecharDonacion(_donacion.Estado);
                _donacion.Autorizador = (ClienteBEL)autorizadorComboBox.SelectedItem;
                _donacion.Auditor = (ClienteBEL)auditorComboBox.SelectedItem;
                _donacion.Organizacion = (EmpresaBEL)organizacionComboBox.SelectedItem;

                bool result=false;
                if (_donacion.Id == 0)
                    result = new DonacionBLL().Agregar(_donacion);
                else
                    result = new DonacionBLL().Modificar(_donacion);

                Mensajes.MensajeResultado(result, this);

                if (result)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {

                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }
    }
}
