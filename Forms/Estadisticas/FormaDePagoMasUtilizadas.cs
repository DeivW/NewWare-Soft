using Microsoft.Reporting.WinForms;
using NewWare_Soft.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Estadisticas
{
    public partial class FormaDePagoMasUtilizadas : Form
    {
        public FormaDePagoMasUtilizadas()
        {
            InitializeComponent();
        }

        private void FormaDePagoMasUtilizadas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_FPago.obtenerEstadisticaFormaDePago();
            ReportDataSource ds = new ReportDataSource("FormaDePagoMasUtilizada", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }
    }
}
