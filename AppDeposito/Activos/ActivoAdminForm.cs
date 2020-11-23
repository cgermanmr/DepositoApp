using System;
using System.Windows.Forms;
using BLL;
using BEL;
using System.Collections.Generic;
using Servicios;

namespace AppDeposito
{
    public partial class ActivoAdminForm : Form, IObserverTraducible
    {
        public ActivoAdminForm()
        {
            InitializeComponent();
        }
        List<ActivoBEL> _listaActivos;
        public void ObtenerDatos(string filtro="")
        {
            filtro = filtro.ToUpper();

            if (filtro.Length > 3)
                _listaActivos = new ActivoBLL().Listar(filtro).ConvertAll(x => (ActivoBEL)x);
            
            if (filtro.Length == 0)
                _listaActivos = new ActivoBLL().Listar().ConvertAll(x=>(ActivoBEL)x);
                      
                bsActivos.DataSource = _listaActivos;
        }

        private void EnlazarControles()
        {
            GrillaActivos.DataSource = bsActivos;
           
            DescripcionTextBox.DataBindings.Add("Text", bsActivos, "Descripcion");
            
            VolumenTextBox.DataBindings.Add("Text", bsActivos, "Volumen");
            EstadoTextBox.DataBindings.Add("Text", bsActivos, "EstadoActivo");
            MarcaTextBox.DataBindings.Add("Text", bsActivos, "Marca");
            OrganizacionTextBox.DataBindings.Add("Text",bsActivos,"Organizacion");
            SectorTextBox.DataBindings.Add("Text", bsActivos, "Sector");
            TipoTextBox.DataBindings.Add("Text", bsActivos, "TipoActivo");
            UbicacionTextBox.DataBindings.Add("Text", bsActivos, "Ubicacion");
            DireccionTextBox.DataBindings.Add("Text", bsActivos, "Ubicacion.Direccion");

        }

        private void ActivosForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            FormConfig.TextBoxToReadOnly(this);
            FiltroTextBox.ReadOnly = false;
            GrillaActivos.AutoGenerateColumns = false;
            ObtenerDatos();
            EnlazarControles();
            
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _edit = new ActivoEditForm() { Editado = (ActivoBEL)bsActivos.Current };
                _edit.ShowDialog();
                ObtenerDatos(FiltroTextBox.Text);

            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _edit = new ActivoEditForm() { Editado = new ActivoBEL() };
                _edit.ShowDialog();
                ObtenerDatos(FiltroTextBox.Text);

            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex,this);
            }
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ObtenerDatos(FiltroTextBox.Text);
            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex,this);
            }
            
        }

        private void DatosDeCompraButton_Click(object sender, EventArgs e)
        {
            if (bsActivos.Current == null) return;

            var _info = new ActivoDatosCompraForm() { Text = bsActivos.Current.ToString()};
            _info.bsActivo.DataSource = bsActivos.Current;
            _info.ShowDialog();
        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Confirma eliminar {bsActivos.Current.ToString()}", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Mensajes.MensajeResultado(new ActivoBLL().Eliminar((ActivoBEL)bsActivos.Current), this);
                    ObtenerDatos(FiltroTextBox.Text);
                }

            }
            catch (Exception ex)
            {
                Mensajes.MensajeExcepcion(ex, this);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enGarantiaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bsActivos.Current == null)
            {
                enGarantiaCheckBox.Checked = false;
                return;
            }
            enGarantiaCheckBox.Checked = ((ActivoBEL)bsActivos.Current).EnGarantia;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
