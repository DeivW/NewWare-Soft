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

namespace NewWare_Soft.Forms.Reportes
{
    public partial class ListadoDeFacturas : Form
    {
        public ListadoDeFacturas()
        {
            InitializeComponent();
        }
        private void ListadoDeFacturas_Load(object sender, EventArgs e)
        {
            this.listadoFacturas.RefreshReport();
        }

        private void listadoFacturas_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_Facturas.obtenerListadoProductos();
            ReportDataSource ds = new ReportDataSource("DatosFacturas", tabla);
            listadoFacturas.LocalReport.DataSources.Clear();
            listadoFacturas.LocalReport.DataSources.Add(ds);
            listadoFacturas.LocalReport.Refresh();
        }
    }
}
