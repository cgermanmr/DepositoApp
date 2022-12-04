using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito.ConfigurarDB
{
    public partial class ConfigDbForm : Form
    {
        public ConfigDbBEL ConfigDbDatos { get=>bsDatos.DataSource as ConfigDbBEL; set => bsDatos.DataSource = value; }
        public ConfigDbForm()
        {
            InitializeComponent();
            ConfigDbDatos = new ConfigDbBEL()
            {
                NombreBase = "depodb",
                Password = "Desarrollo**009",
                Servidor = ".",
                Usuario = "sa"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = new ConfigDbBLL().TestCnx(ConfigDbDatos);

            button2.Enabled = result;

            if (result)
                Mensajes.ShowExitoso("Conexion OK!!!");
            else
                Mensajes.ShowError(ConfigDbDatos.Mensaje);
        }

        private void ConfigDbForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = new ConfigDbBLL().CrearBase(ConfigDbDatos);

            if (result)
                Mensajes.ShowExitoso("Base de datos creada correctamente!!!");
            else
                Mensajes.ShowError(ConfigDbDatos.Mensaje);
        }
    }
}
