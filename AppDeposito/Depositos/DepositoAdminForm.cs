using System;
using System.Windows.Forms;
using BEL;
using BLL;
using Servicios;

namespace AppDeposito
{
    public partial class DepositoAdminForm : Form,IObserverTraducible
    {
        public DepositoAdminForm()
        {
            InitializeComponent();
        }
        private void ObtenerDatos()
        {
            bsDepositos.DataSource = new DepositoBLL().Listar().ConvertAll(x => (DepositoBEL)x);
           
        }
        private void DepositosForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                ObtenerDatos();                
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        private void AgregarActivoButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (bsDepositos.Current == null) return;
                var _deposito = (DepositoBEL)bsDepositos.Current;
                
                var _buscar = new BuscarActivoForm();
                _buscar.ShowDialog();

                if (_buscar.Seleccionado == null) return;                
                ActivoBEL _activo = (ActivoBEL)_buscar.Seleccionado;

                if (_deposito.Activos.Contains(_activo)) return;

                _activo.Ubicacion=((DepositoBEL)bsDepositos.Current).Ubicacion;

                if (new ActivoBLL().Modificar(_activo))
                    ((DepositoBEL)bsDepositos.Current).Activos.Add(_activo);

                bsActivos.ResetBindings(false);

            }
            catch (Exception ex)
            {

                Mensajes.ShowError(ex, this);
            }
        }

        private void QuitarActivoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsDepositos.Current == null) return;
                if (bsActivos.Current == null) return;

                ActivoBEL _activo = (ActivoBEL)bsActivos.Current;
                DepositoBEL _deposito = (DepositoBEL)bsDepositos.Current;

                new ActivoEditForm() { Editado=_activo }.ShowDialog();
                var _listaActivos = _deposito.Activos;

                _deposito.Activos = _listaActivos
                    .FindAll(_ => _.Ubicacion.Equals(_deposito.Ubicacion));

                bsDepositos.ResetBindings(false);
                bsActivos.ResetBindings(false);

            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
               
            }
        }

        private void activosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsDepositos.Current == null) return;

                new EdicionDepositoForm() { Tag = bsDepositos.Current }.ShowDialog();
                bsDepositos.ResetCurrentItem();

            }
            catch (Exception ex)
            {

                Mensajes.ShowError(ex, this);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsDepositos.Current == null) return;

                if(new EdicionDepositoForm() { Tag = new DepositoBEL() }.ShowDialog()==DialogResult.OK)
                    bsDepositos.DataSource = new DepositoBLL().Listar();
            }
            catch (Exception ex)
            {

                Mensajes.ShowError(ex, this);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string txt = txtFiltro.Text.ToUpper();

                var _deposito = (DepositoBEL)bsDepositos.Current;
                activosDataGridView.DataSource = _deposito.Activos
                    .FindAll(_=>_.Descripcion.ToUpper().Contains(txt) |
                    _.Inventario.ToUpper().Contains(txt) |
                    _.Serie.ToUpper().Contains(txt));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool result=false;
                if (MessageBox.Show($"Eliminar depósito {bsDepositos.Current.ToString()}",
                    "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    result = new BLL.DepositoBLL().Eliminar((DepositoBEL)bsDepositos.Current);
                    if (result)
                    {
                        Mensajes.MensajeResultado(result, this);
                        bsDepositos.Remove(bsDepositos.Current);
                        bsDepositos.ResetBindings(false);
                    }
                }

            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
