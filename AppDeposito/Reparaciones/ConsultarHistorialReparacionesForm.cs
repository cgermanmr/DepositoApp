using BEL;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito.Reparaciones
{
    public partial class ConsultarHistorialReparacionesForm : Form,IObserverTraducible
    {
        public List<ReparacionBEL> Grilla { get => bsGrilla.DataSource as List<ReparacionBEL>; set => bsGrilla.DataSource = value; }
        public ConsultarHistorialReparacionesForm()
        {
            InitializeComponent();
        }

        private ActivoBEL _equipo;

        private void button1_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarActivoForm();
            _busqueda.ShowDialog();
            _equipo = _busqueda.Seleccionado;
            _busqueda.Close();

            CalcularEstadisticaReparacion();
        }

        private void CalcularEstadisticaReparacion()
        {
            if (_equipo == null) return;

            lblActivo.Text = _equipo?.ToString();
            double costoTotal = 0;
            double tiempoDemora = 0;

            Grilla = new ReparacionBLL().Listar()
                .Where( x => (x as ReparacionBEL).Activo.Id == _equipo.Id)
                .Select( r => r as ReparacionBEL).ToList();

            Grilla.ForEach( x => {
                var pre = x.Presupuestos.FirstOrDefault(p => p.Autorizado);
                
                if (pre != null)
                    costoTotal += pre.Cotizacion;

                tiempoDemora += x.DemoraReparacion;

            });

            lblTotalReparaciones.Text = Grilla.Count.ToString();
            lblTotalDias.Text = Math.Round(tiempoDemora,0).ToString();
            lblCosto.Text = costoTotal.ToString("C0");


        }

        private void ConsultarHistorialReparacionesForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
