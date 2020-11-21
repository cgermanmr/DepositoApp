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
    public partial class AdminUsuariosForm : Form,IObserverTraducible
    {
        private BindingSource bsUsuarios = new BindingSource();
        public AdminUsuariosForm()
        {
            InitializeComponent();
        }

        public void ObtenerDatos()
        {
            bsUsuarios.DataSource = new Usuario().Listar(); 
        }
        private void MensajeResultado(bool resultado)
        {
            if (resultado)
                MessageBox.Show("La operación a concluído exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido realizar la operación", "Operación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void EditarUsuario(Form FormularioEdicion)
        {
            try
            {
                var resultado = FormularioEdicion.ShowDialog();

                if (resultado == DialogResult.OK)
                    MensajeResultado(true);
                if (resultado == DialogResult.No)
                    MensajeResultado(false);

                ObtenerDatos();
            }
            catch (Exception ex)
            {
                Logger.WriteLogExeption(ex);
                MessageBox.Show("La operación falló. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {   
            EditarUsuario(new EdicionUsuarioForm());        
        }

        private void EnlazarControles()
        {
            GrillaUsuarios.AutoGenerateColumns = false;
            GrillaUsuarios.DataSource = bsUsuarios;
            txtNombre.DataBindings.Add("Text", bsUsuarios, "Nombre");
            txtEmail.DataBindings.Add("Text", bsUsuarios, "Email");
            txtIdioma.DataBindings.Add("Text", bsUsuarios, "Idioma");      
        }

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {
            Sesion.SesionActual().Suscribir(this);
            bsUsuarios.CurrentItemChanged += BsUsuarios_CurrentItemChanged;
            ObtenerDatos();
            EnlazarControles();                 
        }

        private void BsUsuarios_CurrentItemChanged(object sender, EventArgs e)
        {
            ActualizarArbol();
        }

        private void ActualizarArbol()
        {
            PerfilTreeView.Nodes.Clear();

            if (((UsuarioBEL)bsUsuarios.Current).Perfil.Count == 0)
                return;
                    
            foreach (var item in ((UsuarioBEL)bsUsuarios.Current).Perfil)
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

        private void btnModificarPermisos_Click(object sender, EventArgs e)
        {
            new EdicionPermisosUsuarioForm() { Editado=(UsuarioBEL)bsUsuarios.Current }.ShowDialog();
            ActualizarArbol();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ((UsuarioBEL)bsUsuarios.Current).Id = 1; // utilizo como flag el campo id
            EditarUsuario(new EdicionUsuarioForm(){UsuarioEditado=(UsuarioBEL)bsUsuarios.Current });
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se eliminará el usuario " + ((UsuarioBEL)bsUsuarios.Current).Nombre, "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MensajeResultado(new Usuario().Eliminar((UsuarioBEL)bsUsuarios.Current));
                ObtenerDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClaveButton_Click(object sender, EventArgs e)
        {
            bool resultado = (new CambioClaveForm() {Editado=(UsuarioBEL)bsUsuarios.Current }.ShowDialog() == DialogResult.OK);

            MensajeResultado(resultado);                   
           
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
