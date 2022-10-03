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
using Servicios;

namespace AppDeposito.Administracion.Permisos
{
    public partial class EdicionPermisoForm : Form, IObserverTraducible
    {
        public PermisoCompuesto Editado { get; set; }

        public EdicionPermisoForm()
        {
            InitializeComponent();
        }
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {                      
                foreach (Control c in this.Controls)
                {
                    if (errorProvider.GetError(c).Length > 0)
                    {
                        throw new Exception(errorProvider.GetError(c));
                    } 
                }                     
                
                var p = new Permiso();

                if(Editado.Id!=0)
                    Mensajes.MensajeResultado(p.Modificar(Editado), this);
                else
                    Mensajes.MensajeResultado(p.Agregar(Editado),this);

                Close();                    
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("Se ha producido un error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                    errorProvider.SetError(txtNombre,"Se ha ingresado un nombre inválido.");
                else
                    errorProvider.SetError(txtNombre, "");   
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtNombre, ex.Message);
            }

        }
        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                    errorProvider.SetError(txtDescripcion, "Se ha ingresado una descripción inválida");
                else
                    errorProvider.SetError(txtDescripcion, "");
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtDescripcion, ex.Message);
            }
        }

        BindingSource bsPermisosLista;
        private void NuevoGrupoPermisoForm_Load(object sender, EventArgs e)
        {
            bsPermisosLista = new BindingSource();

            if (Editado == null)
                Editado = new PermisoCompuesto();
          
            txtNombre.DataBindings.Add("Text", Editado, "Nombre");
            txtDescripcion.DataBindings.Add("Text", Editado, "Descripcion");

            bsPermisosLista.DataSource = new Permiso().Listar().Where(x => !Editado.EsValido(x.Nombre) && !(x.Nombre.Equals(Editado.Nombre))).ToList().OrderByDescending(x => x.TieneHijos()).ToList();
            ListaPermisos.DataSource = bsPermisosLista;
            ActualizarControles();

            Sesion.SesionActual().Suscribir(this);


        }
        private void ActualizarControles()
        {
            //Actualiza Arbol
            var raiz = new TreeNode
            {
                Text = Editado.Nombre,
                Tag = Editado
            };
            CargarArbol(raiz);
            PermisosTreeView.Nodes.Clear();
            PermisosTreeView.Nodes.Add(raiz);
            PermisosTreeView.Nodes[0].ExpandAll();
        }

        public void CargarArbol(TreeNode raiz)
        {
            if (((PermisoBase)raiz.Tag).ObtenerHijos() == null) return;
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
        private void AsignarButton_Click(object sender, EventArgs e)
        {
            Editado.AgregarHijo((PermisoBase)bsPermisosLista.Current);
            bsPermisosLista.Remove(bsPermisosLista.Current);
            ActualizarControles();
        }

        private void DesasignarButton_Click(object sender, EventArgs e)
        {
            Editado.QuitarHijo((PermisoBase)PermisosTreeView.SelectedNode.Tag);
            bsPermisosLista.Add((PermisoBase)PermisosTreeView.SelectedNode.Tag);
            ActualizarControles();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
