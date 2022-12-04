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

namespace AppDeposito
{
    public partial class ProveedorEditForm : Form, IObserverTraducible
    {
        public ProveedorEditForm()
        {
            InitializeComponent();
        }
        public ProveedorBEL Editado { get; set; }

        private void EdicionOrganizacion_Load(object sender, EventArgs e)
        {
            try
            {
                FormConfig.Config(this);
                bsOrganizacion.DataSource = Editado;
                
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);
            }           
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(Editado.Id == 0)
                    Mensajes.MensajeResultado(new ProveedorBLL().Agregar(Editado), this);
                else
                    Mensajes.MensajeResultado(new ProveedorBLL().Modificar(Editado), this);
                Close();
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
                if (MessageBox.Show($"Se eliminará {Editado.RazonSocial}","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    Mensajes.MensajeResultado(new EmpresaBLL().Modificar(Editado), this);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Mensajes.ShowError(ex, this);

            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
