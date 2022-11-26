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
using Interfaces;
using BLL;
using AppDeposito.Administracion.Logs.Model;

namespace AppDeposito.Administracion.Logs
{
    public partial class ActivoControlCambiosForm : Form,IObserverTraducible
    {
        public ActivoControlCambiosForm()
        {
            InitializeComponent();
        }

        public ActivoFiltro Filtro => bsFiltro.DataSource as ActivoFiltro;

        public ActivoBEL Seleccionado => bsGrilla.Current as ActivoBEL;

        public void ObtenerDatosFiltro()
        {
            List<ActivoBEL> _lista = new ActivoBLL().ListarHistorico();

            _lista = _lista.FindAll(x => x.FechaModificacion.Date >= Filtro.FechaD.Date & x.FechaModificacion.Date <= Filtro.FechaH.Date);

            if (!string.IsNullOrEmpty(txtFiltroUsuario.Text))
                _lista = _lista.FindAll(x=> x.UsuarioModificador.Contains(txtFiltroUsuario.Text));

            if (cmbEvento.SelectedIndex!=-1)
                _lista = _lista.FindAll(x => x.TipoModificacion == (TipoOperacion)cmbEvento.SelectedIndex+1);

            if (Filtro.NroInventario.Length > 0)
                _lista = _lista.FindAll(x => x.Inventario.Contains(Filtro.NroInventario));

            if (Filtro.Descripcion.Length > 0)
                _lista = _lista.FindAll(x => x.Descripcion.Contains(Filtro.NroInventario));


            bsGrilla.DataSource = _lista;       
        }
       
          
       

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {

            Sesion.SesionActual().Suscribir(this);

            bsFiltro.DataSource = new ActivoFiltro();

            bsGrilla.DataSource = new ActivoBLL().ListarHistorico();

        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Traducir()
        {
            Traductor.Traducir(this);
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ObtenerDatosFiltro();
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            bsGrilla.DataSource = new ActivoBLL().ListarHistorico();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Seleccionado.TipoModificacion == TipoOperacion.Baja)
                return;

            var activoBll = new ActivoBLL();

            if(activoBll.Listar().Any( x => x.Id == Seleccionado.Id))
                activoBll.Modificar(Seleccionado);
            else
                activoBll.Agregar(Seleccionado);
            
        }
    }
}
