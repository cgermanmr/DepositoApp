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

namespace AppDeposito.Administracion.Logs
{
    public partial class FacturasControlCambiosForm : Form,IObserverTraducible
    {
        private BindingSource bsUsuarios = new BindingSource();
        public FacturasControlCambiosForm()
        {
            InitializeComponent();
        }

        public void ObtenerDatos()
        {
            bsUsuarios.DataSource = new Usuario().ListarHistorico(); 
        }

        public void ObtenerDatosFiltro()
        {
            List<UsuarioBEL> _usuarios = new Usuario().ListarHistorico();

            _usuarios = _usuarios.FindAll(x => x.FechaModificacion.Date >= dateTimeDesde.Value.Date & x.FechaModificacion.Date <= dateTimeHasta.Value.Date);

            if (!string.IsNullOrEmpty(txtFiltroUsuario.Text))
                _usuarios = _usuarios.FindAll(x=> x.Nombre.Contains(txtFiltroUsuario.Text));

            if(!string.IsNullOrEmpty(usuarioModificadorTextBox.Text))
                _usuarios = _usuarios.FindAll(x => x.UsuarioModificador.Contains(usuarioModificadorTextBox.Text));

            if (cmbEvento.SelectedIndex!=-1)
                _usuarios = _usuarios.FindAll(x => x.TipoModificacion == (TipoOperacion)cmbEvento.SelectedIndex+1);
                                             
            bsUsuarios.DataSource = _usuarios;       
        }
        private void MensajeResultado(bool resultado)
        {
            if (resultado)
                MessageBox.Show("La operación a concluído exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido realizar la operación", "Operación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
          
        private void EnlazarControles()
        {
            GrillaUsuarios.AutoGenerateColumns = false;
            GrillaUsuarios.DataSource = bsUsuarios;
        }

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {

            Sesion.SesionActual().Suscribir(this);
            
            ObtenerDatos();
            EnlazarControles();
                             
        }

        public void CargarArbol(TreeNode raiz)
        {
            if (((PermisoBase)raiz.Tag).ObtenerHijos()==null) return;
            foreach (var hijo in ((PermisoBase)raiz.Tag).ObtenerHijos())
            {
                var nodoHijo = new TreeNode()
                {
                    Text = hijo.Nombre,
                    Tag = hijo
                };
                CargarArbol(nodoHijo);
                raiz.Nodes.Add(nodoHijo);
            }
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
            ObtenerDatos();
        }
    }
}
