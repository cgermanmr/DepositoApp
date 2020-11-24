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
using Interfaces;
using Servicios;

namespace AppDeposito
{
    public partial class BuscarActivoForm : Form, IObserverTraducible
    {
        public BuscarActivoForm()
        {
            InitializeComponent();
        }
        List<ActivoBEL> _listaActivos;        
        private void BusquedaForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            _listaActivos = new ActivoBLL().Listar().ConvertAll(x=>(ActivoBEL)x);
            bsActivos.DataSource = _listaActivos;
            Grilla.AutoGenerateColumns = false;
            Grilla.DataSource = bsActivos;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

            Seleccionado = bsActivos.Current;
            Visible = false;
        }

        public object Seleccionado { get; set; }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = txtFiltro.Text.ToUpper();
                bsActivos.DataSource = _listaActivos.FindAll(x =>
                  x.Descripcion.ToUpper().Contains(txt) |
                  x.Inventario.ToUpper().Contains(txt) |
                  x.Serie.ToUpper().Contains(txt) |
                  x.TipoActivo.Descripcion.ToUpper().Contains(txt) |
                  x.Marca.Descripcion.ToUpper().Contains(txt));
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
