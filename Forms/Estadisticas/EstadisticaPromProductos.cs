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

namespace NewWare_Soft
{
    public partial class EstadisticaPromProductos : Form
    {
        public EstadisticaPromProductos()
        {
            InitializeComponent();
        }

        private void EstadisticaPromProductos_Load(object sender, EventArgs e)
        {
            this.reportProm.RefreshReport();
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Productos.GetEstadisticaPreciosProduc();
                ReportDataSource ds = new ReportDataSource("DatosPreciosProd", tabla);
                reportProm.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaPromProd.rdlc";

                reportProm.LocalReport.DataSources.Clear();
                reportProm.LocalReport.DataSources.Add(ds);
                reportProm.RefreshReport();
                lblPromedio.Visible = true;
                txtPromedio.Visible = true;
                int prom = AD_Productos.GetPromedio();
                txtPromedio.Text = prom.ToString();
                reportProm.Visible = true;
            }
            else
            {
                DataTable tabla = new DataTable();
                tabla = AD_Productos.GetEstadisticaPromPrecios();
                ReportDataSource ds = new ReportDataSource("DatosPromProdMes", tabla);
                reportProm.LocalReport.ReportEmbeddedResource = "NewWare_Soft.EstadisticaPromProdMes.rdlc";

                reportProm.LocalReport.DataSources.Clear();
                reportProm.LocalReport.DataSources.Add(ds);
                reportProm.RefreshReport();
                lblPromedio.Visible = false;
                txtPromedio.Visible = false;
                txtPromedio.Clear();
                reportProm.Visible = true;
            }
        }
    }
}
