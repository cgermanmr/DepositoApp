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
using Interfaces;

namespace AppDeposito.Administracion.Logs
{
    public partial class BitacoraForm : Form,IObserverTraducible
    {
        public BitacoraForm()
        {
            InitializeComponent();
        }

        BindingSource bsBitacora = new BindingSource();
        private void BitacoraForm_Load(object sender, EventArgs e)
        {
            Sesion.SesionActual().Suscribir(this);
            bsBitacora.DataSource = Bitacora.Listar();
            GrillaBitacora.DataSource = bsBitacora;
            cmbEvento.DataSource = new TipoEvento[] { TipoEvento.Auditoria,TipoEvento.Error,TipoEvento.Informacion,TipoEvento.Seguridad};
             
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            bsBitacora.DataSource = Bitacora.Listar().FindAll(x => x.Fecha.Date>=FechaDesde.Value.Date & x.Fecha.Date <=FechaHasta.Value.Date & 
            x.Evento == (TipoEvento)cmbEvento.SelectedItem & x.Usuario.Contains(UsuarioTextBox.Text) & x.Descripcion.Contains(DescripcionTextBox.Text));
        }

        private void QuitarFiltroButton_Click(object sender, EventArgs e)
        {
            bsBitacora.DataSource = Bitacora.Listar();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
