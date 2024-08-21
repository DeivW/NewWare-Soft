using Microsoft.Reporting.WinForms; //Eliminar
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWare_Soft.Forms.Reportes
{
    public partial class Listado_Productos_X_Clientes : Form
    {
        public Listado_Productos_X_Clientes()
        {
            InitializeComponent();
        }

        private void Listado_Productos_X_Clientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = AccesoADatos.AD_Cliente.Productos_x_Clientes();

            ReportDataSource ds = new ReportDataSource("DataSet1", table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
