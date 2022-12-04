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
    public partial class AsignarEquipoReemplazoForm : Form, IObserverTraducible
    {
        private readonly ReparacionBEL _reparacion;

        public ReemplazoTemporalBEL Seleccionado => bsReemplazos.Current as ReemplazoTemporalBEL;
        public List<ReemplazoTemporalBEL> Grilla { get => bsReemplazos.DataSource as List<ReemplazoTemporalBEL>; set => bsReemplazos.DataSource = value; }
        public AsignarEquipoReemplazoForm(ReparacionBEL reparacion)
        {
            InitializeComponent();
            _reparacion = reparacion;
            txtReparacion.Text = reparacion.ToString();
            bsReemplazos.DataSource = new List<ReemplazoTemporalBEL>();
            Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _busqueda = new BuscarActivoForm();
            _busqueda.ShowDialog();
            AddNewReemplazo(_busqueda.Seleccionado);          

            _busqueda.Close();
        }

        private void AddNewReemplazo(ActivoBEL seleccionado)
        {
            if(seleccionado == null) return; 

            var newReemplazo = new ReemplazoTemporalBEL() {
                Activo = seleccionado.Id,
                Descripcion = seleccionado.Descripcion,
                Reparacion = _reparacion.Id,
                Inicio = DateTime.Now.Date,
                Fin = DateTime.Now.AddDays(10).Date,
                Definitivo = false
            
            };

            new ReparacionBLL().AgregarReemplazo(newReemplazo);

            Grilla.Add(newReemplazo);
            bsReemplazos.ResetBindings(true);

        }

        private void AsignarEquipoReemplazoForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            Grilla = new ReparacionBLL().ListarReemplazos(_reparacion.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Grilla.Count == 0 || Seleccionado == null) return;
            
            new ReparacionBLL().EliminarReemplazo(Seleccionado);

            Grilla.Remove(Seleccionado);
            bsReemplazos.ResetBindings(true);
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
