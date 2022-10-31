using AppDeposito.Pagos.IngresoFacturas;
using AppDeposito.Pagos.OrdenPago;
using AppDeposito.Pagos.OrdenPago.Model;
using BEL;
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

namespace AppDeposito.Pagos
{
    public partial class OrdenPagoAdminForm : Form, IObserverTraducible
    {
        private readonly OrdenPagoAdminPresenter Presenter;
        public OrdenPagoAdminForm()
        {
            InitializeComponent();
            Presenter = new OrdenPagoAdminPresenter(this);
        }

        public List<OrdenPagoBEL> Grilla { 
            get => bsOrdenPago.DataSource as List<OrdenPagoBEL>; 
            set => bsOrdenPago.DataSource = value; 
        }

        private void OrdenPagoAdminForm_Load(object sender, EventArgs e)
        {
            Grilla = new List<OrdenPagoBEL>();
            Presenter.CargarOrdenesPago();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaOp = new OrdenPagoEditForm();

            if (nuevaOp.ShowDialog() != DialogResult.OK)
                return;

            Presenter.CargarOrdenesPago();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevaOp = new OrdenPagoEditForm();
            nuevaOp.OrdenPago = bsOrdenPago.Current as OrdenPagoBEL;

            if (nuevaOp.ShowDialog() != DialogResult.OK)
                return;

            Refresh();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
