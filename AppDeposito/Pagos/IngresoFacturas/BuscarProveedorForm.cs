using BEL;
using BLL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito.Pagos.IngresoFacturas
{
    public partial class BuscarProveedorForm : Form, IObserverTraducible
    {
        private readonly bool conOtPendientes;

        public ProveedorBEL Seleccionado { get => bsProveedor.Current as ProveedorBEL; }
        
        
        public BuscarProveedorForm(bool conOtPendientes = false)
        {
            InitializeComponent();
            this.conOtPendientes = conOtPendientes;
        }

        private void BuscarProveedorForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);

            CargarGrilla();

        }

        private void CargarGrilla()
        {
            if(conOtPendientes)
                bsProveedor.DataSource = new ProveedorBLL().ListarConOTPendientes();
            else
                bsProveedor.DataSource = new ProveedorBLL().Listar().Select(x => x as ProveedorBEL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filtro = textBox1.Text.ToUpper().Trim();

            if (filtro.Length == 0)
                CargarGrilla();

            if(filtro.Length > 3)
                bsProveedor.DataSource = new ProveedorBLL().Listar().Select(x => x as ProveedorBEL)
                    .Where( p => p.RazonSocial.ToUpper().Contains(filtro) |
                                 p.CUIT.ToString().Contains(filtro) |
                                 p.Telefono.Contains(filtro) |
                                 p.Email.ToUpper().Contains(filtro)).ToList();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
