using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace AppDeposito.Reportes
{
    public partial class ReporteView : Form
    {
        public ReporteView()
        {
            InitializeComponent();
        }

        public string NombreDatosReporte { get; set; }
        public string Reporte { get; set; }
        public IEnumerable<object> DatosReporte { get; set; }

        public IEnumerable<ReportParameter> ParametrosReporte { get; set; }
        private void ReporteForm_Load(object sender, EventArgs e)
        {
            FormConfig.Config(this);
            CargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void CargarReporte()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = Reporte;
            
            ReportDataSource rds1 = new ReportDataSource(NombreDatosReporte, DatosReporte);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            if (ParametrosReporte != null && ParametrosReporte.Any())
            {
                this.reportViewer1.LocalReport.SetParameters(ParametrosReporte);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
