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

namespace AppDeposito
{
    public partial class MovimientosActivoForm : Form, IObserverTraducible
    {
        public MovimientosActivoForm()
        {
            InitializeComponent();
        }

        public void Traducir()
        {
            throw new NotImplementedException();
        }

        private void MovimientosActivoForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            //TODO: cargar los movimientos del activo
        }
    }
}
