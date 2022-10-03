using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEL;
using Servicios;

namespace AppDeposito
{
    public partial class DonacionesForm : Form,IObserverTraducible
    {
        public DonacionesForm()
        {
            InitializeComponent();
        }

        private void DonacionesForm_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                bsDonaciones.DataSource = new DonacionBLL().Listar().ConvertAll(x=>(DonacionBEL)x);
                
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
                if (bsDonaciones.Current == null) return;
                var _buscar = new BuscarActivoForm();
                _buscar.ShowDialog();

                if (_buscar.Seleccionado == null) return;

                bsActivos.Add(_buscar.Seleccionado);
                if (new DonacionBLL().Modificar((DonacionBEL)bsDonaciones.Current))
                    bsDonaciones.ResetCurrentItem();
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
                if (new EdicionDonacionForm() { Tag = new DonacionBEL() }.ShowDialog() == DialogResult.OK)
                    bsDonaciones.DataSource = new DonacionBLL().Listar();

            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EdicionDonacionForm() { Tag = bsDonaciones.Current }.ShowDialog() == DialogResult.OK)
                    bsDonaciones.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
                throw;
            }

        }

        private void QuitarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsActivos.Current == null) return;
                bsActivos.Remove(bsActivos.Current);
                new DonacionBLL().Modificar((DonacionBEL)bsDonaciones.Current);
            }
            catch (Exception ex)
            {

                Mensajes.ShowError(ex, this);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = false;
                if (bsDonaciones.Current == null) return;
                if (MessageBox.Show($"Eliminar {bsDonaciones.Current.ToString()}?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    result = new DonacionBLL().Eliminar((BEL.DonacionBEL)bsDonaciones.Current);

                Mensajes.MensajeResultado(result, this);

                if (result)
                    bsDonaciones.Remove(bsDonaciones.Current);
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
