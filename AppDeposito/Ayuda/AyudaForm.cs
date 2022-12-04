using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito.Test
{
    public partial class AyudaForm : Form
    {
        public AyudaForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Tag.ToString().Length==0)
                return;

            //webBrowser1.Navigate($@"file:///{treeView1.SelectedNode.Tag}#navpanes=0&toolbar=0");
            //webBrowser1.Navigate($@"file:///C:\UAI\TD\DepositoApp\AppDeposito\Ayuda\Docs\{treeView1.SelectedNode.Tag}.pdf#navpanes=0&toolbar=0");
            webBrowser1.Navigate($@"file:///{AppContext.BaseDirectory}Ayuda\Docs\{treeView1.SelectedNode.Tag}.pdf#navpanes=0&toolbar=0");
        }

        private void PruebaAyudaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
