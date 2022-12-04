using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using BEL;
using BLL;
using AppDeposito.Administracion.Logs.Model;

namespace AppDeposito.Administracion.Logs
{
    public partial class FacturasControlCambiosForm : Form,IObserverTraducible
    {
        List<FacturaReparacionBEL> _facturas;
        public FacturasControlCambiosForm()
        {
            InitializeComponent();
        }

        public FacturaReparacionBEL Seleccionado { get => bsFacturas.Current as FacturaReparacionBEL; }

        public List<FacturaReparacionBEL> Grilla { 
            get => bsFacturas.DataSource as List<FacturaReparacionBEL>; 
            set => bsFacturas.DataSource = value; }

        public FacturaFiltro Filtro { 
            get => bsFiltro.DataSource as FacturaFiltro; 
            set => bsFiltro.DataSource = value; }

        public void ObtenerDatos()
        {
            _facturas = new FacturaReparacionBLL().ListarHistorico();
            bsFacturas.DataSource = _facturas; 
        }

        public void ObtenerDatosFiltro()
        {

            var listaFiltrada = _facturas.Where(x => 
                x.FechaVto.Date >= Filtro.FechaVtoDesde.Date && 
                x.FechaVto.Date <= Filtro.FechaVtoHasta.Date);

            listaFiltrada = listaFiltrada.Where(x =>
            x.FechaEmision.Date >= Filtro.FechaEmisionDesde.Date &&
            x.FechaEmision.Date <= Filtro.FechaEmisionHasta.Date);

            listaFiltrada = listaFiltrada.Where(x =>
            x.FechaModificacion.Date >= Filtro.FechaModificacionDesde.Date &&
            x.FechaModificacion.Date <= Filtro.FechaModificacionHasta.Date);

            if(cmbEvento.SelectedIndex != -1)
                listaFiltrada = listaFiltrada.Where( x => x.TipoModificacion == Filtro.TipoModificacion);

            if (Filtro.UsuarioModificador.Trim().Length > 0)
                listaFiltrada = listaFiltrada.Where(x => 
                x.UsuarioModificador.ToUpper().Contains(Filtro.UsuarioModificador.ToUpper()));

            Grilla = listaFiltrada.ToList();

        }
     

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {

            FormConfig.Config(this);

            Filtro = new FacturaFiltro();
            
            ObtenerDatos();                             
        }

        
        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ObtenerDatosFiltro();
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEvento.SelectedIndex < 0) return;

            Filtro.TipoModificacion = (Interfaces.TipoOperacion)cmbEvento.SelectedIndex + 1;
        }

        private void bsFacturas_CurrentChanged(object sender, EventArgs e)
        {
            if (Seleccionado == null) return;

            lblFecha.Text = Seleccionado.FechaModificacion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Mensajes.ShowDecision("¿Desea restaurar a la fecha seleccionada?"))
                return;

            new FacturaReparacionBLL().RestaurarAFecha(
                Seleccionado.FechaModificacion,
                Sesion.SesionActual().ObtenerUsuarioActual?.Nombre ?? "Usuariox");

            Mensajes.ShowExitoso();

            ObtenerDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
