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
    public partial class AdminPermisosForm : Form
    {
        private BindingSource bsPermisos = new BindingSource();
        public AdminPermisosForm()
        {
            InitializeComponent();
        }

        public void ObtenerDatos()
        {
            bsPermisos.DataSource = new Permiso().Listar().FindAll(x => x.TieneHijos()==true);
        }

        private void EnlazarControles()
        {                                             
            GrillaPermisos.AutoGenerateColumns = false;
            GrillaPermisos.DataSource = bsPermisos;
            DescripcionTextBox.DataBindings.Add("Text", bsPermisos, "Descripcion");
        }

        private void AdminPermisosForm_Load(object sender, EventArgs e)
        {
            bsPermisos.CurrentItemChanged += BsPermisos_CurrentItemChanged;
            ObtenerDatos();
            EnlazarControles();
        }

        private void BsPermisos_CurrentItemChanged(object sender, EventArgs e)
        {
            ActualizarArbol();              
        }
        private void ActualizarArbol()
        {
            var raiz = new TreeNode
            {
                Text = ((PermisoBase)bsPermisos.Current).Nombre,
                Tag = bsPermisos.Current
            };
            CargarArbol(raiz);
            PermisosTreeView.Nodes.Clear();
            PermisosTreeView.Nodes.Add(raiz);
            PermisosTreeView.Nodes[0].ExpandAll();
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

        private void ActualizarPermiso(Form NuevoGrupo)
        {
            try
            {
                var resultado = NuevoGrupo.ShowDialog();
                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("La operación falló. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void NuevoGrupoButton_Click(object sender, EventArgs e)
        {
            EdicionPermisoForm NuevoGrupo = new EdicionPermisoForm() { Editado = new PermisoCompuesto()};
            ActualizarPermiso(NuevoGrupo);               
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            EdicionPermisoForm NuevoGrupo = new EdicionPermisoForm() { Editado = (PermisoCompuesto)bsPermisos.Current };
            ActualizarPermiso(NuevoGrupo);
        }
             
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var p = new Permiso();
            if (MessageBox.Show("Eliminar " + ((PermisoCompuesto)bsPermisos.Current).Nombre,"Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
                p.Eliminar((PermisoCompuesto)bsPermisos.Current);
            
            ObtenerDatos();
        }
    }
}
