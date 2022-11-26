using System;
using System.Linq;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class ActivoEditForm : Form, IObserverTraducible
    {
        public ActivoBEL Editado { get => bsEditado.Current as ActivoBEL; set => bsEditado.DataSource = value; }

        public ActivoEditForm()
        {
            InitializeComponent();
        }

        private void EnlazarControles()
        {
            NumeroInventarioTextBox.DataBindings.Add("Text", Editado, "Inventario");
            DescripcionTextBox.DataBindings.Add("Text", Editado, "Descripcion");
            NumeroSerieTextBox.DataBindings.Add("Text", Editado, "Serie");
            ValorCompraTextBox.DataBindings.Add("Text", Editado, "ValorCompra");
            PeriodoGarantiaTextBox.DataBindings.Add("Text", Editado, "MesesGarantia");
            VolumenTextBox.DataBindings.Add("Text", Editado, "Volumen");
            ObservacionesTextBox.DataBindings.Add("Text", Editado, "Observaciones");
            fechaAltaDateTimePicker.Value = Editado.FechaAlta == DateTime.MinValue ? DateTime.Now : Editado.FechaAlta;
            fechaCompraDateTimePicker.Value = Editado.FechaCompra == DateTime.MinValue ? DateTime.Now : Editado.FechaCompra; ;

            monedaComboBox.SelectedIndex = monedaComboBox.FindString(Editado.Moneda.Descripcion);

            EstadoComboBox.DataBindings.Add("SelectedItem", Editado, "EstadoActivo");
            EstadoComboBox.SelectedIndex = EstadoComboBox.FindString(Editado.EstadoActivo.Descripcion);

            MarcaComboBox.DataBindings.Add("SelectedItem", Editado, "Marca");
            MarcaComboBox.SelectedIndex = MarcaComboBox.FindString(Editado.Marca.Descripcion);
            
            OrganizacionComboBox.DataBindings.Add("SelectedItem", Editado, "Organizacion");
            OrganizacionComboBox.SelectedIndex = OrganizacionComboBox.FindString(Editado.Organizacion.Descripcion);

            SectorComboBox.DataBindings.Add("SelectedItem", Editado, "Sector");
            SectorComboBox.SelectedIndex = SectorComboBox.FindString(Editado.Sector.Descripcion);
            
            TipoComboBox.DataBindings.Add("SelectedItem", Editado, "TipoActivo");
            TipoComboBox.SelectedIndex = TipoComboBox.FindString(Editado.TipoActivo.Descripcion);

            UbicacionComboBox.DataBindings.Add("SelectedItem", Editado, "Ubicacion");
            UbicacionComboBox.SelectedIndex = UbicacionComboBox.FindString(Editado.Ubicacion.Descripcion);

            DireccionTextBox.DataBindings.Add("Text", Editado, "Ubicacion.Direccion");

        }
        public void ObtenerDatos()
        {
            EstadoComboBox.DataSource = new EstadoBLL().Listar();
            MarcaComboBox.DataSource = new MarcaBLL().Listar();
            OrganizacionComboBox.DataSource = new EmpresaBLL().Listar();
            SectorComboBox.DataSource = new SectorBLL().Listar();
            TipoComboBox.DataSource = new TipoActivoBLL().Listar();
            UbicacionComboBox.DataSource = new UbicacionBLL().Listar();
            monedaComboBox.DataSource = new MonedaBLL().Listar();
        }

        private void ActivoABMForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            ObtenerDatos();
            EnlazarControles();            

            if (Editado.Id == 0) FormConfig.LimpiarCombos(this);           

        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {

                Editado.FechaAlta = fechaAltaDateTimePicker.Value;
                Editado.FechaCompra = fechaCompraDateTimePicker.Value;

                if (Editado.Id == 0)
                    Mensajes.MensajeResultado(new ActivoBLL().Agregar(Editado), this);
                else
                    Mensajes.MensajeResultado(new ActivoBLL().Modificar(Editado), this);
                Close();

            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex,this);
            }
            
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void monedaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
