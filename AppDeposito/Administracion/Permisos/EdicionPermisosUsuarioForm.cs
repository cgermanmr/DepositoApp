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

namespace AppDeposito.Administracion.Permisos
{
    public partial class EdicionPermisosUsuarioForm : Form
    {
        public EdicionPermisosUsuarioForm()
        {
            InitializeComponent();
        }     
        public UsuarioBEL Editado { get; set; }

        BindingSource bsPermisosLista;
        private void EdicionPermisosUsuarioForm_Load(object sender, EventArgs e)
        {
            bsPermisosLista = new BindingSource();
            PermisoCompuesto perfil = new PermisoCompuesto();
            perfil.ObtenerHijos().AddRange(Editado.Perfil);           
            bsPermisosLista.DataSource = new Permiso().Listar().Where(x => !perfil.EsValido(x.Nombre) && !Editado.Perfil.Contains(x)).ToList().OrderByDescending(x => x.TieneHijos()).ToList();
            ListaPermisos.DataSource = bsPermisosLista;

            ActualizarArbol();
        }

        private void ActualizarArbol()
        {
            PerfilTreeView.Nodes.Clear();
            foreach (var item in (Editado).Perfil)
            {
                var raiz = new TreeNode
                {
                    Text = item.Nombre,
                    Tag = item
                };
                CargarArbol(raiz);
                PerfilTreeView.Nodes.Add(raiz);
                PerfilTreeView.Nodes[0].ExpandAll();
            }
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

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AsignarButton_Click(object sender, EventArgs e)
        {
            Editado.Perfil.Add((PermisoBase)bsPermisosLista.Current);
            bsPermisosLista.Remove(bsPermisosLista.Current);
            ActualizarArbol();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            Editado.Perfil.Remove((PermisoBase)PerfilTreeView.SelectedNode.Tag);
            bsPermisosLista.Add((PermisoBase)PerfilTreeView.SelectedNode.Tag);
            ActualizarArbol();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {    
            try
            {
                var validado = new Usuario().Modificar(Editado);

                DialogResult = (validado) ? DialogResult.OK : DialogResult.No;
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("Se ha producido un error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
